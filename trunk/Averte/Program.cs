using System;
using System.Windows.Forms;

using Maple.Utilities;
using Averte.Net;

namespace Averte
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            MapleKeys.Initialize();
            MapleHandler.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }
    }
}
