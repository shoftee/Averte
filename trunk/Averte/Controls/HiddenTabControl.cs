using MetroFramework.Controls;
using System;

namespace Averte.Controls
{
    class HiddenTabControl : MetroTabControl
    {
        public int DesignerIndex
        {
            get { return SelectedIndex; }
            set
            {
                if (DesignMode)
                {
                    SelectedIndex = value;
                }
            }
        }

        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            if (m.Msg == 0x1328 && !DesignMode)
                m.Result = (IntPtr)1;
            else
                base.WndProc(ref m);
        }
    }
}
