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
using IoT.Sharp.Sdk.CSharp;

namespace IoT.Sharp.WinForm
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }


        private async void btnLogin_ClickAsync(object sender, EventArgs e)
        {
            var Client = new Sdk.CSharp.AccountClient(Properties.Settings.Default.ApiUrl);
            string username = txtUserName.Text;
            string password = txtPassword.Text;
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                lblInfo.Text = "密码或用户名为空";
            }
            else
            {
                try
                {
                    var result = await Client.LoginAsync(new Sdk.CSharp.LoginDto() { Email = username, Password = password });
                    if (result.StatusCode == 200)
                    {

                    }
                    else
                    {
                        lblInfo.Text = "密码错误";
                    }
                }
                catch (SwaggerException sex)
                {
                    var result = sex.ToResult();
                    lblInfo.Text = $"错误代码:{result.code},错误:{result.msg}";
                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        private bool _isMouseDown;
        private Point _formLocation; //form的location
        private Point _mouseOffset;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _isMouseDown = true;
                _formLocation = Location;
                _mouseOffset = MousePosition;
            }
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            _isMouseDown = false;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            //鼠标的按下位置
            if (_isMouseDown)
            {
                Point pt = MousePosition;
                int x = _mouseOffset.X - pt.X;
                int y = _mouseOffset.Y - pt.Y;

                Location = new Point(_formLocation.X - x, _formLocation.Y - y);
            }
        }
        private   void frmLogin_Load(object sender, EventArgs e)
        {
            lblVersion.Text = "V" + AppUtils.AssemblyVersion;
            btnLogin.Enabled = false;
            lblInfo.Text = "正在检查服务器...";
            Task.Run(async () =>
            {
                try
                {
                    var Client = new Sdk.CSharp.InstallerClient(Properties.Settings.Default.ApiUrl);
                    var fr = await Client.CheckInstallationAsync();
                    if (fr.StatusCode == 200)
                    {
                        var result = await fr.ToResultAsync<ApiResult>();
                        this.Invoke((MethodInvoker)delegate
                        {
                            if (result.code == 0 && result.data.Value<bool>("installed"))
                            {
                                btnLogin.Enabled = true;
                                lblInfo.Text = "服务器就绪";
                            }
                            else
                            {
                                lblInfo.Text = result.msg;
                            }
                        });
                    }
                }
                catch (SwaggerException se)
                {

                    lblInfo.Text = se.ToResult().ToString();
                }
                catch (Exception ex)
                {
                    lblInfo.Text = ex.Message;
                }
              
            });
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppUtils.ShowFileByExplorer("http://www.iotsharp.net/");
        }

        
    }
}