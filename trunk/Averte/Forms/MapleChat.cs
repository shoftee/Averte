using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using Averte.Net;
using Averte.Net.Packet;

namespace Averte
{
    public partial class MapleChat : MetroForm
    {
        public static MapleChat Instance { get; private set; }

        public static int ID { get; set; }

        public MapleChat()
        {
            MapleChat.Instance = this;

            InitializeComponent();
        }

        #region Main Events

        private void MapleChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            MapleChat.Instance = null;
        }

        #endregion

        #region Essential Methods

        public void ChatReceived(string sender, string text)
        {
            string formatted = string.Format("{0}: {1}", sender, text) + Environment.NewLine;

            OutputTextBox.AppendText(formatted);
        }

        public void SendChat(string text)
        {
            string sender = "iStories";
            string formatted = string.Format(" : {0}", text);

            MapleConnection.Instance.Send(SocialPacket.MapleChatMessage(sender, formatted));
        }

        #endregion

    }
}
