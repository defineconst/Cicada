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
using System.Threading;

namespace IoTSharp.Cicada
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

        private IoTSharp.Sdk.CustomersClient Client = null;

        public override Task<FileResponse> Put(Customer obj, CancellationToken token)
        {
            var jo = Newtonsoft.Json.Linq.JObject.FromObject(obj);
            jo.Add(nameof(CustomerDto.TenantID), Tenant.Id);
            var s = jo.ToObject<CustomerDto>();
            s.TenantID = Tenant.Id;
            return Client.PutCustomerAsync(obj.Id, s, token);
        }

        public override Task<Customer> Post(Customer obj, CancellationToken token)
        {
            var jo = Newtonsoft.Json.Linq.JObject.FromObject(obj);
            jo.Add(nameof(CustomerDto.TenantID), Tenant.Id);
            var s = jo.ToObject<CustomerDto>();
            s.TenantID = Tenant.Id;
            return Client.PostCustomerAsync(s, token);
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