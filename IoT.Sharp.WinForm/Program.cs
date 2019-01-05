using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using IoT.Sharp.Sdk.CSharp;

namespace IoT.Sharp.WinForm
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            SdkClient.BaseURL = Properties.Settings.Default.ApiUrl;
            Application.Run(new frmMain());
        }
    }
}
