using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IoT.Sharp.WinForm
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmLogin fl = new frmLogin();
            var result = fl.ShowDialog(this);
            if (result == DialogResult.OK)
            {
            }
            else if (result == DialogResult.No)
            {
                frmInstaller installer = new frmInstaller();
                if (installer.ShowDialog() == DialogResult.OK)
                {
                    btnLogin.PerformClick();
                }
            }
            else if (result == DialogResult.Cancel)
            {
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void SetMenuAndBar()
        {
        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }

        private void btnTen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowMdiChildren<frmTenantAdmin>();
        }

        private void btnDevices_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.ShowMdiChildren<frmDevices>(opt =>
            {
                var cust = Sdk.CSharp.SdkClient.Create<Sdk.CSharp.DevicesClient>();
                opt.Customer = Sdk.CSharp.SdkClient.MyInfo.Customer;
            });
        }
    }
}