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
using System.Threading;

namespace IoT.Sharp.WinForm
{
    public partial class frmCustomerAdmin : AdminBase<Customer>
    {
        public frmCustomerAdmin()
        {
            InitializeComponent();
        }

        public Tenant Tenant { get; set; }

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

        private IoT.Sharp.Sdk.CSharp.CustomersClient Client = null;

        public override Task<FileResponse> Put(Customer obj, CancellationToken token)
        {
            return Client.PutCustomerAsync(obj.Id, obj, token);
        }

        public override Task<Customer> Post(Customer obj, CancellationToken token)
        {
            return Client.PostCustomerAsync(obj, token);
        }

        public override Task<ICollection<Customer>> GetAllAsync(CancellationToken token)
        {
            return Client.GetCustomersAsync(Tenant.Id, token);
        }

        public override Task<Customer> Delete(Customer obj, CancellationToken token)
        {
            return Client.DeleteCustomerAsync(obj.Id, token);
        }

        private void frmCustomerAdmin_Load(object sender, EventArgs e)
        {
            InitializeGridView(gridView, colId);
            Client = SdkClient.Create<CustomersClient>();
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowPrintPreview();
        }

        private void btnUserAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
        }
    }
}