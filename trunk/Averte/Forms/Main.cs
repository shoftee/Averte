using System;
using System.Threading;
using System.Windows.Forms;

using Averte.Net;

using MetroFramework.Forms;
using Maple.Utilities;
using Averte.Net.Packet;
using MetroFramework.Controls;
using System.Drawing;
using Averte.Maple.Characters;
using System.Net;
using Averte.Maple.Fields;
using MetroFramework.Components;

namespace Averte
{
    public partial class Main : MetroForm
    {
        public static Main Instance { get; private set; }

        public Main()
        {
            Main.Instance = this;

            InitializeComponent();
        }

        #region Main Events

        private void Main_Load(object sender, EventArgs e)
        {
            new MapleConnection(Constants.LoginAddress, Constants.LoginPort);
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(Connect)).Start();
        }

        #endregion

        #region Essential Methods

        public void Connect()
        {
            try
            {
                MapleConnection.Instance.Connect();
            }
            catch
            {
                Notify("Unable to connect to Maple Global.");
            }
        }

        public DialogResult Notify(string message, string caption = "Notification", int time = 0, bool cancel = false, bool YesNo = false)
        {
            using (MetroMessageBox _msgBox = new MetroMessageBox())
            {
                _msgBox.Text = caption;
                _msgBox.ShadowType = ShadowType;
                _msgBox.MinimizeBox = false;
                _msgBox.MaximizeBox = false;
                if (!cancel)
                    _msgBox.ControlBox = false;
                _msgBox.TopMost = TopMost;
                _msgBox.Resizable = Resizable;
                _msgBox.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
                using (MetroStyleManager _styleManager = new MetroStyleManager())
                {
                    _styleManager.Owner = _msgBox;
                    _styleManager.Style = Style;
                    _styleManager.Theme = Theme;
                }
                if (message.Length == 0)
                    return DialogResult.None;

                int highestCount = -1;

                string[] lines = message.Split('\n');
                foreach (string line in message.Split('\n'))
                {
                    if (line.Length > highestCount)
                    {
                        highestCount = line.Length;
                    }
                }

                if (highestCount == -1)
                    highestCount = message.Length;

                _msgBox.Size = new Size(highestCount * 8, message.Split('\n').Length * 12 + 120);
                if (_msgBox.Width < caption.Length * 15)
                    _msgBox.Width = caption.Length * 15;
                if (_msgBox.Width < 200)
                    _msgBox.Width = 200;
                _msgBox.MinimumSize = _msgBox.Size;
                MetroLabel _msg = new MetroLabel();
                _msg.Text = message;
                _msg.Location = new Point(25, 65);
                _msg.Size = new Size(_msgBox.Width - 35, message.Split('\n').Length * 12 + 15);
                _msgBox.Controls.Add(_msg);
                MetroButton _btnOK = new MetroButton();
                _btnOK.Text = YesNo ? "Yes" : "OK";
                _btnOK.Location = new Point(_msgBox.Width - 95, _msgBox.Height - 35);
                _btnOK.Click += (object sender, EventArgs e) =>
                {
                    _msgBox.DialogResult = YesNo ? DialogResult.Yes : DialogResult.OK;
                    _msgBox.Close();
                };
                _msgBox.Controls.Add(_btnOK);
                if (cancel || YesNo)
                {
                    MetroButton _btnCancel = new MetroButton();
                    _btnCancel.Text = YesNo ? "No" : "Cancel";
                    _btnCancel.Location = new Point(_msgBox.Width - 95 - _btnOK.Size.Width - 10, _msgBox.Height - 35);
                    _btnCancel.Click += (object sender, EventArgs e) =>
                    {
                        _msgBox.DialogResult = YesNo ? DialogResult.No : DialogResult.Cancel;
                        _msgBox.Close();
                    };
                    _msgBox.Controls.Add(_btnCancel);
                }
                if (time > 0)
                {
                    System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
                    _timer.Interval = time;
                    _timer.Tick += (object sender, EventArgs e) =>
                    {
                        _timer.Enabled = false;
                        _timer.Dispose();
                        for (double i = 1; i > 0; i -= 0.1)
                        {
                            _msgBox.Opacity = i;
                            Thread.Sleep(10);
                        }
                        _msgBox.ShadowType = MetroFormShadowType.None;
                        _msgBox.Close();
                    };
                    _timer.Enabled = true;
                }
                return _msgBox.ShowDialog();
            }
        }

        public void SetTab(Indexer index)
        {
            MainHidden.SelectedIndex = (int)index;
        }

        #endregion   

        #region Draw Methods

        public void DrawWorldTile(byte id, string name)
        {
            int originY = 150; // NOTE: The original initial position's X value.
            int originX = 3; // NOTE: The original initial position's Y value.
            int sizeX = 32; // NOTE: The size's X value.
            int sizeY = 150; // NOTE The size's Y value.

            MetroTile tile = new MetroTile();

            tile.Name = "World" + id.ToString();

            string final = "";

            foreach (char c in name.ToCharArray())
            {
                final += c + "\r\n";
            }

            tile.Text = final;
            tile.Font = new System.Drawing.Font("Courier", 14);
            tile.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            tile.Tag = id;
            tile.Size = new Size(sizeX, sizeY);
            tile.Location = new Point(originX + (id * sizeX), originY);
            tile.Click += new EventHandler(WorldTile_Click);

            WorldSelectTab.Controls.Add(tile);
        }

        public void DrawCharacterTile(Character character)
        {
            int originX = 10;
            int originY = 116;
            int sizeX = 120;
            int sizeY = 127;
            int max = 6;

            MetroTile tile = new MetroTile();

            tile.Name = "Character" + character.Index;
            tile.Text = character.Name;
            tile.TextAlign = ContentAlignment.BottomCenter;
            tile.UseTileImage = true;

            try
            {
                var request = WebRequest.Create(character.AvatarUrl);

                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                {
                    tile.TileImage = Bitmap.FromStream(stream);
                }
            }
            catch { }

            tile.TileImageAlign = ContentAlignment.TopCenter;
            tile.Size = new Size(sizeX, sizeY);

            int x = originX + (sizeX * (character.Index >= max ? character.Index - 6 : character.Index));
            int y = originY + ((character.Index / 6) * sizeY);

            tile.Location = new Point(x, y);
            tile.Tag = character.ID;
            tile.Click += new EventHandler(CharacterTile_Click);

            CharacterSelectTab.Controls.Add(tile);
        }

        public void DrawCharacterObject(Character character)
        {

        }

        public void DrawFootholdObject(Foothold foothold)
        {

        }

        public void SetField(Image field)
        {
            Bitmap fieldBitmap = ResizeBitmap(new Bitmap(field), (int)(field.Width * 1.0), (int)(field.Height * 1.0));

            FieldPictureBox.Size = fieldBitmap.Size;
            FieldPictureBox.Image = fieldBitmap;
        }

        private Bitmap ResizeBitmap(Bitmap bitmap, int width, int height)
        {
            Bitmap ret = new Bitmap(width, height);

            using (Graphics graphics = Graphics.FromImage((Image)ret))
            {
                graphics.DrawImage(bitmap, 0, 0, width, height);
            }

            return ret;
        }

        #endregion

        #region Button Events

        private void LoginTile_Click(object sender, EventArgs e)
        {
            if (UsernameTextBox.Text.Length < 4 || PasswordTextBox.Text.Length < 4)
                return;

            LoginTile.Enabled = false;
            UsernameTextBox.Enabled = false;
            PasswordTextBox.Enabled = false;

            string authenticationToken = NetworkUtil.GetAuthenticationToken(UsernameTextBox.Text, PasswordTextBox.Text);

            if (authenticationToken == null)
            {
                LoginTile.Enabled = true;
                UsernameTextBox.Enabled = true;
                PasswordTextBox.Enabled = true;

                Notify("The username or password is incorrect.");
                return;
            }

            MapleConnection.Instance.Send(LoginPacket.Login(PasswordTextBox.Text, authenticationToken));
        }

        private void WorldTile_Click(object sender, EventArgs e)
        {
            MetroTile selectedWorldTile = sender as MetroTile;

            for (int i = 0; i < 17; i++)
            {
                MetroTile worldTile = WorldSelectTab.Controls["World" + i.ToString()] as MetroTile;

                worldTile.Enabled = false;
            }

            MapleConnection.Instance.Send(LoginPacket.SelectWorld((byte)selectedWorldTile.Tag, 6));
        }

        private void CharacterTile_Click(object sender, EventArgs e)
        {
            MetroTile selectedCharacterTile = sender as MetroTile;

            // TODO: Disable all tiles.

            MapleConnection.Instance.Send(LoginPacket.SelectCharacter(Constants.Pic, (int)selectedCharacterTile.Tag));
        }

        #endregion

        #region Other Events

        private void PacketQueueTimer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            for (int i = 0; i < MapleConnection.Instance.PacketQueue.Count && i < 30; i++)
            {
                Action<DateTime> action;

                if (MapleConnection.Instance.PacketQueue.TryDequeue(out action))
                {
                    action(now);
                }
            }
        }

        #endregion

    }
}
