namespace Averte
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PacketQueueTimer = new System.Windows.Forms.Timer(this.components);
            this.MainHidden = new Averte.Controls.HiddenTabControl();
            this.ConnectionTab = new MetroFramework.Controls.MetroTabPage();
            this.ConnectionLabel = new MetroFramework.Controls.MetroLabel();
            this.ConnectionSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.FieldTab = new MetroFramework.Controls.MetroTabPage();
            this.UIPanel = new MetroFramework.Controls.MetroPanel();
            this.FieldPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginTab = new MetroFramework.Controls.MetroTabPage();
            this.AverteLogoLogin = new System.Windows.Forms.Label();
            this.LoginLogo = new MetroFramework.Controls.MetroLabel();
            this.LoginTile = new MetroFramework.Controls.MetroTile();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.UsernameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.WorldSelectTab = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.CharacterSelectTab = new MetroFramework.Controls.MetroTabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.MainHidden.SuspendLayout();
            this.ConnectionTab.SuspendLayout();
            this.FieldTab.SuspendLayout();
            this.UIPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FieldPictureBox)).BeginInit();
            this.LoginTab.SuspendLayout();
            this.WorldSelectTab.SuspendLayout();
            this.CharacterSelectTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // PacketQueueTimer
            // 
            this.PacketQueueTimer.Enabled = true;
            this.PacketQueueTimer.Interval = 1;
            this.PacketQueueTimer.Tick += new System.EventHandler(this.PacketQueueTimer_Tick);
            // 
            // MainHidden
            // 
            this.MainHidden.Controls.Add(this.ConnectionTab);
            this.MainHidden.Controls.Add(this.LoginTab);
            this.MainHidden.Controls.Add(this.WorldSelectTab);
            this.MainHidden.Controls.Add(this.CharacterSelectTab);
            this.MainHidden.Controls.Add(this.FieldTab);
            this.MainHidden.DesignerIndex = 0;
            this.MainHidden.Location = new System.Drawing.Point(26, 86);
            this.MainHidden.Name = "MainHidden";
            this.MainHidden.SelectedIndex = 0;
            this.MainHidden.Size = new System.Drawing.Size(748, 483);
            this.MainHidden.TabIndex = 0;
            // 
            // ConnectionTab
            // 
            this.ConnectionTab.Controls.Add(this.ConnectionLabel);
            this.ConnectionTab.Controls.Add(this.ConnectionSpinner);
            this.ConnectionTab.HorizontalScrollbarBarColor = true;
            this.ConnectionTab.Location = new System.Drawing.Point(4, 35);
            this.ConnectionTab.Name = "ConnectionTab";
            this.ConnectionTab.Size = new System.Drawing.Size(740, 444);
            this.ConnectionTab.TabIndex = 0;
            this.ConnectionTab.Text = "Connection";
            this.ConnectionTab.VerticalScrollbarBarColor = true;
            // 
            // ConnectionLabel
            // 
            this.ConnectionLabel.AutoSize = true;
            this.ConnectionLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ConnectionLabel.Location = new System.Drawing.Point(244, 130);
            this.ConnectionLabel.Name = "ConnectionLabel";
            this.ConnectionLabel.Size = new System.Drawing.Size(252, 25);
            this.ConnectionLabel.TabIndex = 3;
            this.ConnectionLabel.Text = "Connecting to Maple Global . . .";
            // 
            // ConnectionSpinner
            // 
            this.ConnectionSpinner.Location = new System.Drawing.Point(306, 241);
            this.ConnectionSpinner.Maximum = 100;
            this.ConnectionSpinner.Name = "ConnectionSpinner";
            this.ConnectionSpinner.Size = new System.Drawing.Size(128, 128);
            this.ConnectionSpinner.TabIndex = 2;
            this.ConnectionSpinner.Value = 30;
            // 
            // FieldTab
            // 
            this.FieldTab.AutoScroll = true;
            this.FieldTab.Controls.Add(this.UIPanel);
            this.FieldTab.HorizontalScrollbar = true;
            this.FieldTab.HorizontalScrollbarBarColor = true;
            this.FieldTab.Location = new System.Drawing.Point(4, 35);
            this.FieldTab.Name = "FieldTab";
            this.FieldTab.Size = new System.Drawing.Size(740, 444);
            this.FieldTab.TabIndex = 4;
            this.FieldTab.Text = "Field";
            this.FieldTab.VerticalScrollbar = true;
            this.FieldTab.VerticalScrollbarBarColor = true;
            // 
            // UIPanel
            // 
            this.UIPanel.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.UIPanel.Controls.Add(this.FieldPictureBox);
            this.UIPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UIPanel.HorizontalScrollbarBarColor = true;
            this.UIPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.UIPanel.HorizontalScrollbarSize = 10;
            this.UIPanel.Location = new System.Drawing.Point(0, 0);
            this.UIPanel.Name = "UIPanel";
            this.UIPanel.Size = new System.Drawing.Size(740, 444);
            this.UIPanel.TabIndex = 2;
            this.UIPanel.VerticalScrollbarBarColor = true;
            this.UIPanel.VerticalScrollbarHighlightOnWheel = false;
            this.UIPanel.VerticalScrollbarSize = 10;
            // 
            // FieldPictureBox
            // 
            this.FieldPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FieldPictureBox.Location = new System.Drawing.Point(0, 0);
            this.FieldPictureBox.Name = "FieldPictureBox";
            this.FieldPictureBox.Size = new System.Drawing.Size(740, 444);
            this.FieldPictureBox.TabIndex = 3;
            this.FieldPictureBox.TabStop = false;
            // 
            // LoginTab
            // 
            this.LoginTab.Controls.Add(this.AverteLogoLogin);
            this.LoginTab.Controls.Add(this.LoginLogo);
            this.LoginTab.Controls.Add(this.LoginTile);
            this.LoginTab.Controls.Add(this.PasswordTextBox);
            this.LoginTab.Controls.Add(this.UsernameTextBox);
            this.LoginTab.HorizontalScrollbarBarColor = true;
            this.LoginTab.Location = new System.Drawing.Point(4, 35);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Size = new System.Drawing.Size(740, 444);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "Login";
            this.LoginTab.VerticalScrollbarBarColor = true;
            // 
            // AverteLogoLogin
            // 
            this.AverteLogoLogin.AutoSize = true;
            this.AverteLogoLogin.BackColor = System.Drawing.Color.Transparent;
            this.AverteLogoLogin.Font = new System.Drawing.Font("Open Sans Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AverteLogoLogin.Location = new System.Drawing.Point(323, 37);
            this.AverteLogoLogin.Name = "AverteLogoLogin";
            this.AverteLogoLogin.Size = new System.Drawing.Size(95, 37);
            this.AverteLogoLogin.TabIndex = 7;
            this.AverteLogoLogin.Text = "Averte";
            // 
            // LoginLogo
            // 
            this.LoginLogo.AutoSize = true;
            this.LoginLogo.Location = new System.Drawing.Point(350, 74);
            this.LoginLogo.Name = "LoginLogo";
            this.LoginLogo.Size = new System.Drawing.Size(41, 19);
            this.LoginLogo.TabIndex = 8;
            this.LoginLogo.Text = "Login";
            // 
            // LoginTile
            // 
            this.LoginTile.Location = new System.Drawing.Point(422, 211);
            this.LoginTile.Name = "LoginTile";
            this.LoginTile.Size = new System.Drawing.Size(52, 52);
            this.LoginTile.TabIndex = 6;
            this.LoginTile.Text = "Login";
            this.LoginTile.Click += new System.EventHandler(this.LoginTile_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(267, 240);
            this.PasswordTextBox.MaxLength = 32;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PromptText = "Password";
            this.PasswordTextBox.Size = new System.Drawing.Size(149, 23);
            this.PasswordTextBox.TabIndex = 5;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(267, 211);
            this.UsernameTextBox.MaxLength = 30;
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.PromptText = "Username";
            this.UsernameTextBox.Size = new System.Drawing.Size(149, 23);
            this.UsernameTextBox.TabIndex = 4;
            // 
            // WorldSelectTab
            // 
            this.WorldSelectTab.Controls.Add(this.label1);
            this.WorldSelectTab.Controls.Add(this.metroLabel1);
            this.WorldSelectTab.HorizontalScrollbarBarColor = true;
            this.WorldSelectTab.Location = new System.Drawing.Point(4, 35);
            this.WorldSelectTab.Name = "WorldSelectTab";
            this.WorldSelectTab.Size = new System.Drawing.Size(740, 444);
            this.WorldSelectTab.TabIndex = 2;
            this.WorldSelectTab.Text = "World Select";
            this.WorldSelectTab.VerticalScrollbarBarColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(323, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "Averte";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(328, 74);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 19);
            this.metroLabel1.TabIndex = 10;
            this.metroLabel1.Text = "World Select";
            // 
            // CharacterSelectTab
            // 
            this.CharacterSelectTab.Controls.Add(this.label2);
            this.CharacterSelectTab.Controls.Add(this.metroLabel2);
            this.CharacterSelectTab.HorizontalScrollbarBarColor = true;
            this.CharacterSelectTab.Location = new System.Drawing.Point(4, 35);
            this.CharacterSelectTab.Name = "CharacterSelectTab";
            this.CharacterSelectTab.Size = new System.Drawing.Size(740, 444);
            this.CharacterSelectTab.TabIndex = 3;
            this.CharacterSelectTab.Text = "Character Select";
            this.CharacterSelectTab.VerticalScrollbarBarColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Open Sans Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(323, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 37);
            this.label2.TabIndex = 11;
            this.label2.Text = "Averte";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(318, 74);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 12;
            this.metroLabel2.Text = "Character Select";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.MainHidden);
            this.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(23, 83, 23, 28);
            this.Resizable = false;
            this.Text = "Averte - Custom MapleStory Client";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.MainHidden.ResumeLayout(false);
            this.ConnectionTab.ResumeLayout(false);
            this.ConnectionTab.PerformLayout();
            this.FieldTab.ResumeLayout(false);
            this.UIPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FieldPictureBox)).EndInit();
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.WorldSelectTab.ResumeLayout(false);
            this.WorldSelectTab.PerformLayout();
            this.CharacterSelectTab.ResumeLayout(false);
            this.CharacterSelectTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.HiddenTabControl MainHidden;
        private MetroFramework.Controls.MetroTabPage ConnectionTab;
        private MetroFramework.Controls.MetroProgressSpinner ConnectionSpinner;
        private MetroFramework.Controls.MetroLabel ConnectionLabel;
        private MetroFramework.Controls.MetroTabPage LoginTab;
        private MetroFramework.Controls.MetroTextBox UsernameTextBox;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTile LoginTile;
        private System.Windows.Forms.Label AverteLogoLogin;
        private MetroFramework.Controls.MetroLabel LoginLogo;
        private System.Windows.Forms.Timer PacketQueueTimer;
        private MetroFramework.Controls.MetroTabPage WorldSelectTab;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabPage CharacterSelectTab;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTabPage FieldTab;
        private MetroFramework.Controls.MetroPanel UIPanel;
        private System.Windows.Forms.PictureBox FieldPictureBox;
    }
}

