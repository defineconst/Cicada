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
    public partial class frmDevices : AdminBase<Device>
    {
        public frmDevices()
        {
            InitializeComponent();
        }

        public Customer Customer { get; set; }

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

        private IoT.Sharp.Sdk.CSharp.DevicesClient Client = null;

        public override Task<FileResponse> Put(Device obj, CancellationToken token)
        {
            obj.Customer = Customer;
            obj.Tenant = Customer.Tenant;
            return Client.PutDeviceAsync(obj.Id, obj, token);
        }

        public override Task<Device> Post(Device obj, CancellationToken token)
        {
            obj.Customer = Customer;
            obj.Tenant = Customer.Tenant;
            return Client.PostDeviceAsync(obj, token);
        }

        public override Task<ICollection<Device>> GetAllAsync(CancellationToken token)
        {
            return Client.GetDevicesAllAsync(Customer.Id, token);
        }

        public override Task<Device> Delete(Device obj, CancellationToken token)
        {
            return Client.DeleteDeviceAsync(obj.Id, token);
        }

        private void frmCustomerAdmin_Load(object sender, EventArgs e)
        {
            InitializeGridView(gridView, colId);
            Client = SdkClient.Create<DevicesClient>();
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