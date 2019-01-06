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
using IoT.Sharp.Sdk.CSharp;
using DevExpress.XtraGrid.Views.Grid;
using System.Threading;

namespace IoT.Sharp.WinForm
{
    public partial class frmTenantAdmin :AdminBase<Tenant>
    {
       
        public frmTenantAdmin()
        {
            InitializeComponent();
            InitializeGridView(gridView);
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
        private IoT.Sharp.Sdk.CSharp.TenantsClient Client = null;
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
            return Client.GetTenantAllAsync(token);
        }
        public override Task<Tenant> Delete(Tenant obj, CancellationToken token)
        {
            return Client.DeleteTenantAsync(obj.Id, token);
        }

    }
}