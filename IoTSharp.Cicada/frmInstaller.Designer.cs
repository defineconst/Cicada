namespace IoTSharp.Cicada
{
    partial class frmInstaller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.EmailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PasswordTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TenantNameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.TenantEMailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.CustomerEMailTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.PhoneNumberTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenantName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForTenantEMail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForCustomerEMail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForEmail = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btnInstall = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.libinfo = new DevExpress.XtraEditors.LabelControl();
            this.installDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenantNameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenantEMailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEMailTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenantName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenantEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerEMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.installDtoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.Controls.Add(this.EmailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PasswordTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TenantNameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.TenantEMailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.CustomerEMailTextEdit);
            this.dataLayoutControl1.Controls.Add(this.PhoneNumberTextEdit);
            this.dataLayoutControl1.DataSource = this.installDtoBindingSource;
            this.dataLayoutControl1.Location = new System.Drawing.Point(32, 95);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(924, 277, 911, 597);
            this.dataLayoutControl1.Root = this.Root;
            this.dataLayoutControl1.Size = new System.Drawing.Size(725, 209);
            this.dataLayoutControl1.TabIndex = 0;
            this.dataLayoutControl1.Text = "dataLayoutControl1";
            // 
            // EmailTextEdit
            // 
            this.EmailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.EmailTextEdit.Location = new System.Drawing.Point(120, 114);
            this.EmailTextEdit.Name = "EmailTextEdit";
            this.EmailTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.EmailTextEdit.Size = new System.Drawing.Size(239, 24);
            this.EmailTextEdit.StyleController = this.dataLayoutControl1;
            this.EmailTextEdit.TabIndex = 4;
            // 
            // CustomerNameTextEdit
            // 
            this.CustomerNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "CustomerName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CustomerNameTextEdit.Location = new System.Drawing.Point(120, 59);
            this.CustomerNameTextEdit.Name = "CustomerNameTextEdit";
            this.CustomerNameTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.CustomerNameTextEdit.Size = new System.Drawing.Size(238, 24);
            this.CustomerNameTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerNameTextEdit.TabIndex = 5;
            // 
            // PasswordTextEdit
            // 
            this.PasswordTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "Password", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PasswordTextEdit.Location = new System.Drawing.Point(120, 173);
            this.PasswordTextEdit.Name = "PasswordTextEdit";
            this.PasswordTextEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.PasswordTextEdit.Properties.UseSystemPasswordChar = true;
            this.PasswordTextEdit.Size = new System.Drawing.Size(593, 24);
            this.PasswordTextEdit.StyleController = this.dataLayoutControl1;
            this.PasswordTextEdit.TabIndex = 6;
            // 
            // TenantNameTextEdit
            // 
            this.TenantNameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "TenantName", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TenantNameTextEdit.Location = new System.Drawing.Point(120, 12);
            this.TenantNameTextEdit.Name = "TenantNameTextEdit";
            this.TenantNameTextEdit.Size = new System.Drawing.Size(238, 24);
            this.TenantNameTextEdit.StyleController = this.dataLayoutControl1;
            this.TenantNameTextEdit.TabIndex = 7;
            // 
            // TenantEMailTextEdit
            // 
            this.TenantEMailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "TenantEMail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TenantEMailTextEdit.Location = new System.Drawing.Point(501, 12);
            this.TenantEMailTextEdit.Name = "TenantEMailTextEdit";
            this.TenantEMailTextEdit.Size = new System.Drawing.Size(212, 24);
            this.TenantEMailTextEdit.StyleController = this.dataLayoutControl1;
            this.TenantEMailTextEdit.TabIndex = 8;
            // 
            // CustomerEMailTextEdit
            // 
            this.CustomerEMailTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "CustomerEMail", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.CustomerEMailTextEdit.Location = new System.Drawing.Point(501, 59);
            this.CustomerEMailTextEdit.Name = "CustomerEMailTextEdit";
            this.CustomerEMailTextEdit.Size = new System.Drawing.Size(212, 24);
            this.CustomerEMailTextEdit.StyleController = this.dataLayoutControl1;
            this.CustomerEMailTextEdit.TabIndex = 9;
            // 
            // PhoneNumberTextEdit
            // 
            this.PhoneNumberTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.installDtoBindingSource, "PhoneNumber", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.PhoneNumberTextEdit.Location = new System.Drawing.Point(496, 114);
            this.PhoneNumberTextEdit.Name = "PhoneNumberTextEdit";
            this.PhoneNumberTextEdit.Size = new System.Drawing.Size(217, 24);
            this.PhoneNumberTextEdit.StyleController = this.dataLayoutControl1;
            this.PhoneNumberTextEdit.TabIndex = 10;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup1});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(725, 209);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.AllowDrawBackground = false;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForPassword,
            this.ItemForTenantName,
            this.ItemForTenantEMail,
            this.ItemForCustomerName,
            this.ItemForCustomerEMail,
            this.ItemForEmail,
            this.ItemForPhoneNumber,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.emptySpaceItem6});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "autoGeneratedGroup0";
            this.layoutControlGroup1.Size = new System.Drawing.Size(705, 189);
            this.layoutControlGroup1.Spacing = new DevExpress.XtraLayout.Utils.Padding(6, 6, 6, 6);
            // 
            // ItemForPassword
            // 
            this.ItemForPassword.Control = this.PasswordTextEdit;
            this.ItemForPassword.Location = new System.Drawing.Point(0, 161);
            this.ItemForPassword.Name = "ItemForPassword";
            this.ItemForPassword.Size = new System.Drawing.Size(705, 28);
            this.ItemForPassword.Text = "密码";
            this.ItemForPassword.TextSize = new System.Drawing.Size(105, 18);
            // 
            // ItemForTenantName
            // 
            this.ItemForTenantName.Control = this.TenantNameTextEdit;
            this.ItemForTenantName.Location = new System.Drawing.Point(0, 0);
            this.ItemForTenantName.Name = "ItemForTenantName";
            this.ItemForTenantName.Size = new System.Drawing.Size(350, 28);
            this.ItemForTenantName.Text = "租户名称";
            this.ItemForTenantName.TextSize = new System.Drawing.Size(105, 18);
            // 
            // ItemForTenantEMail
            // 
            this.ItemForTenantEMail.Control = this.TenantEMailTextEdit;
            this.ItemForTenantEMail.Location = new System.Drawing.Point(381, 0);
            this.ItemForTenantEMail.Name = "ItemForTenantEMail";
            this.ItemForTenantEMail.Size = new System.Drawing.Size(324, 28);
            this.ItemForTenantEMail.Text = "租户邮箱";
            this.ItemForTenantEMail.TextSize = new System.Drawing.Size(105, 18);
            // 
            // ItemForCustomerName
            // 
            this.ItemForCustomerName.Control = this.CustomerNameTextEdit;
            this.ItemForCustomerName.Location = new System.Drawing.Point(0, 47);
            this.ItemForCustomerName.Name = "ItemForCustomerName";
            this.ItemForCustomerName.Size = new System.Drawing.Size(350, 28);
            this.ItemForCustomerName.Text = "客户名称";
            this.ItemForCustomerName.TextSize = new System.Drawing.Size(105, 18);
            // 
            // ItemForCustomerEMail
            // 
            this.ItemForCustomerEMail.Control = this.CustomerEMailTextEdit;
            this.ItemForCustomerEMail.Location = new System.Drawing.Point(381, 47);
            this.ItemForCustomerEMail.Name = "ItemForCustomerEMail";
            this.ItemForCustomerEMail.Size = new System.Drawing.Size(324, 28);
            this.ItemForCustomerEMail.Text = "客户邮箱";
            this.ItemForCustomerEMail.TextSize = new System.Drawing.Size(105, 18);
            // 
            // ItemForEmail
            // 
            this.ItemForEmail.Control = this.EmailTextEdit;
            this.ItemForEmail.Location = new System.Drawing.Point(0, 102);
            this.ItemForEmail.Name = "ItemForEmail";
            this.ItemForEmail.Size = new System.Drawing.Size(351, 28);
            this.ItemForEmail.Text = "管理员邮箱";
            this.ItemForEmail.TextSize = new System.Drawing.Size(105, 18);
            // 
            // ItemForPhoneNumber
            // 
            this.ItemForPhoneNumber.Control = this.PhoneNumberTextEdit;
            this.ItemForPhoneNumber.Location = new System.Drawing.Point(376, 102);
            this.ItemForPhoneNumber.Name = "ItemForPhoneNumber";
            this.ItemForPhoneNumber.Size = new System.Drawing.Size(329, 28);
            this.ItemForPhoneNumber.Text = "管理员电话号码";
            this.ItemForPhoneNumber.TextSize = new System.Drawing.Size(105, 18);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 28);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(705, 19);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 130);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(705, 31);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(350, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(31, 28);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(0, 75);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(705, 27);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(351, 102);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(25, 28);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(350, 47);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(31, 28);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(150, 18);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "请在这里填写安装信息";
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(413, 330);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(145, 61);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "安装";
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_ClickAsync);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(617, 330);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(128, 61);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            // 
            // libinfo
            // 
            this.libinfo.Location = new System.Drawing.Point(65, 389);
            this.libinfo.Name = "libinfo";
            this.libinfo.Size = new System.Drawing.Size(0, 18);
            this.libinfo.TabIndex = 4;
            // 
            // installDtoBindingSource
            // 
            this.installDtoBindingSource.DataSource = typeof(IoTSharp.Sdk.InstallDto);
            // 
            // frmInstaller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 439);
            this.Controls.Add(this.libinfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInstall);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dataLayoutControl1);
            this.Name = "frmInstaller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "安装";
            this.Load += new System.EventHandler(this.frmInstaller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenantNameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TenantEMailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerEMailTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneNumberTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenantName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForTenantEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForCustomerEMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.installDtoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit EmailTextEdit;
        private System.Windows.Forms.BindingSource installDtoBindingSource;
        private DevExpress.XtraEditors.TextEdit CustomerNameTextEdit;
        private DevExpress.XtraEditors.TextEdit PasswordTextEdit;
        private DevExpress.XtraEditors.TextEdit TenantNameTextEdit;
        private DevExpress.XtraEditors.TextEdit TenantEMailTextEdit;
        private DevExpress.XtraEditors.TextEdit CustomerEMailTextEdit;
        private DevExpress.XtraEditors.TextEdit PhoneNumberTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPassword;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenantName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForTenantEMail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForCustomerEMail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForEmail;
        private DevExpress.XtraLayout.LayoutControlItem ItemForPhoneNumber;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnInstall;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.LabelControl libinfo;
    }
}