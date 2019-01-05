using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;

namespace IoT.Sharp.WinForm
{
    public partial class frmTenant : DevExpress.XtraBars.Ribbon.RibbonForm
    {

      
        public frmTenant()
        {
            InitializeComponent();
           
        }
        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            
           
           
         //   gridControl.DataSource = dataSource;
          //  bsiRecordsCount.Caption = "RECORDS : " + dataSource.Count;
        }
    }
}