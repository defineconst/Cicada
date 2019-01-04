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
            if (fl.ShowDialog(this) == DialogResult.OK)
            {
                
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }
        void SetMenuAndBar()
        {

        }

        private void btnExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Application.Exit();
        }
    }
}
