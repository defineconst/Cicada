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
using IoTSharp.Cicada.Models;

namespace IoTSharp.Cicada
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

        private IoTSharp.Sdk.DevicesClient Client = null;

        public override Task<FileResponse> Put(Device obj, CancellationToken token)
        {
            return Client.PutDeviceAsync(obj.Id,  new DevicePutDto(){   Id=obj.Id, Name=obj.Name }, token);
        }

        public override Task<Device> Post(Device obj, CancellationToken token)
        {
            obj.Customer = Customer;
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
            InitializeGridView(gridView1, colId);
            Client = SdkClient.Create<DevicesClient>();
            enumKeyValueBindingSource.BindingEnum<DeviceType>();
        }

        private void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowPrintPreview();
        }

        private void btnUserAdmin_ItemClick(object sender, ItemClickEventArgs e)
        {
        }

        private async void btnAttTest_ItemClick(object sender, ItemClickEventArgs e)
        {
            var dev = SdkClient.Create<DevicesClient>();
            var dis = new Dictionary<string, object>();
            dis.Add("boolvalue", true);
            dis.Add("jsonvalue", new { a = 1, b = "sss", c = false, e = DateTime.Now });
            dis.Add("longvalue", 2342343L);
            dis.Add("Doublevalue", 2332.322);
            await dev.Attributes2Async(txtToken.EditValue.ToString(), dis);
            await ReloadLatest();
        }

        private async void btnGetToken_ItemClickAsync(object sender, ItemClickEventArgs e)
        {
            try
            {
                var row = FocusedRow;
                if (row != null)
                {
                    var dev = SdkClient.Create<DevicesClient>();
                    var ids = await dev.GetIdentityAsync(row.Id);
                    txtToken.EditValue = ids.IdentityId;
                    //XtraMessageBox.Show(ids.ToJson());
                    lblInfo.Caption = "已经获取到该设备Token";
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }

        private async void deviceBindingSource_CurrentChangedAsync(object sender, EventArgs e)
        {
            btnGetToken.PerformClick();
            await ReloadLatest();
        }

        private async Task ReloadLatest()
        {
            try
            {
                var row = FocusedRow;
                if (row != null)
                {
                    var dev = SdkClient.Create<DevicesClient>();
                    var al = await dev.GetAttributeLatestAsync(row.Id);
                    var tl = await dev.GetTelemetryLatestAsync(row.Id);
                    attributeLatestBindingSource.DataSource = al;
                    telemetryLatestBindingSource.DataSource = tl;
                }
            }
            catch (Exception ex)
            {
                lblInfo.Caption = ex.Message;
            }
        }

        private async void btnTTest_ItemClickAsync(object sender, ItemClickEventArgs e)
        {
            var dev = SdkClient.Create<DevicesClient>();
            var dis = new Dictionary<string, object>();
            dis.Add("boolvalue", true);
            dis.Add("jsonvalue", new { a = 1, b = "sss", c = false, e = DateTime.Now });
            dis.Add("longvalue", 2342343L);
            dis.Add("Doublevalue", 2332.322);
            await dev.TelemetryAsync(txtToken.EditValue.ToString(), dis);
            await ReloadLatest();
        }
    }
}