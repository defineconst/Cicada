using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoT.Sharp.WinForm
{
    partial class frmAboutBox :  XtraForm 
    {
        public frmAboutBox()
        {
            InitializeComponent();
            this.Text = String.Format("关于 {0}", AppUtils. AssemblyTitle);
            this.labelProductName.Text = AppUtils.AssemblyProduct;
            this.labelVersion.Text = String.Format("版本 {0}", AppUtils.AssemblyVersion);
            this.labelCopyright.Text = AppUtils.AssemblyCopyright;
            this.labelCompanyName.Text = AppUtils.AssemblyCompany;
            this.textBoxDescription.Text = AppUtils.AssemblyDescription;
        }

       
    }
}
