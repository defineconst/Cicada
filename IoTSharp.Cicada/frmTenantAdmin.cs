using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using IoTSharp.Sdk;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;

namespace IoTSharp.Cicada
{
    public partial class frmTenantAdmin :AdminBase<Tenant>
    {
       
        public frmTenantAdmin()
        {
            InitializeComponent();
            InitializeGridView(gridView,colId);
            Client = SdkClient.Create<TenantsClient>();
        }

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoNew();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoEdit();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoDelete();
        }

        private void bbiRefresh_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoRefresh();
        }
        private IoTSharp.Sdk.TenantsClient Client = null;
        public override Task<FileResponse> Put(Tenant obj, CancellationToken token)
        {
            return Client.PutTenantAsync(obj.Id, obj, token);
        }
        public override Task<Tenant> Post(Tenant obj, CancellationToken token)
        {
            return Client.PostTenantAsync(obj, token);
        }
    
        public override Task<ICollection<Tenant>> GetAllAsync(CancellationToken token)
        {
            return Client.GetTenantAllAsync();
        }
        public override Task<Tenant> Delete(Tenant obj, CancellationToken token)
        {
            return Client.DeleteTenantAsync(obj.Id, token);
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowPrintPreview();
        }

        private void btnCustonm_ItemClick(object sender, ItemClickEventArgs e)
        {
          var frm =   this.MdiParent.ShowMdiChildren<frmCustomerAdmin>( f=>f.Tenant=FocusedRow);
        }
    }
}