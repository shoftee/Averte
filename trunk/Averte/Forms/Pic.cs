using Averte.Net;
using Averte.Net.Packet;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Averte
{
    public partial class Pic : MetroForm
    {
        private int m_selectedCharacterID;

        public Pic(int selectedCharacterID)
        {
            m_selectedCharacterID = selectedCharacterID;

            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            MapleConnection.Instance.Send(LoginPacket.SelectCharacter(PicTextBox.Text, m_selectedCharacterID));

            Close();
        }
    }
}
