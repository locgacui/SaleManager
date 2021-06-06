namespace QuanLyBanHang
{
    partial class DanhSachKhachHang
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachKhachHang));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.gC_KhachHang = new DevExpress.XtraGrid.GridControl();
            this.gV_KhachHang = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDayOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTaxCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gc_ChucNang = new DevExpress.XtraEditors.GroupControl();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.bandedGridColumn2 = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gC_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).BeginInit();
            this.gc_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gC_KhachHang
            // 
            this.gC_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_KhachHang.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gC_KhachHang.Location = new System.Drawing.Point(2, 34);
            this.gC_KhachHang.MainView = this.gV_KhachHang;
            this.gC_KhachHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gC_KhachHang.Name = "gC_KhachHang";
            this.gC_KhachHang.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditEdit,
            this.repositoryItemButtonEditDel});
            this.gC_KhachHang.Size = new System.Drawing.Size(1171, 609);
            this.gC_KhachHang.TabIndex = 0;
            this.gC_KhachHang.UseEmbeddedNavigator = true;
            this.gC_KhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gV_KhachHang});
            // 
            // gV_KhachHang
            // 
            this.gV_KhachHang.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCode,
            this.gridColumnName,
            this.gridColumnPhoneNumber,
            this.gridColumnDayOfBirth,
            this.gridColumnAddress,
            this.gridColumnTaxCode,
            this.gridColumnSex,
            this.gridColumnEmail,
            this.gridColumn1,
            this.gridColumn2});
            this.gV_KhachHang.DetailHeight = 431;
            this.gV_KhachHang.GridControl = this.gC_KhachHang;
            this.gV_KhachHang.Name = "gV_KhachHang";
            this.gV_KhachHang.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gV_KhachHang.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gV_KhachHang.OptionsBehavior.ReadOnly = true;
            this.gV_KhachHang.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.True;
            this.gV_KhachHang.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.MinWidth = 23;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.Width = 87;
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Mã Khách Hàng";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.MinWidth = 23;
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            this.gridColumnCode.Width = 87;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Tên Khách Hàng";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.MinWidth = 23;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 87;
            // 
            // gridColumnPhoneNumber
            // 
            this.gridColumnPhoneNumber.Caption = "Số Điện Thoại";
            this.gridColumnPhoneNumber.FieldName = "PhoneNumber";
            this.gridColumnPhoneNumber.MinWidth = 23;
            this.gridColumnPhoneNumber.Name = "gridColumnPhoneNumber";
            this.gridColumnPhoneNumber.Visible = true;
            this.gridColumnPhoneNumber.VisibleIndex = 2;
            this.gridColumnPhoneNumber.Width = 87;
            // 
            // gridColumnDayOfBirth
            // 
            this.gridColumnDayOfBirth.Caption = "Ngày Sinh";
            this.gridColumnDayOfBirth.FieldName = "DayOfBirth";
            this.gridColumnDayOfBirth.MinWidth = 23;
            this.gridColumnDayOfBirth.Name = "gridColumnDayOfBirth";
            this.gridColumnDayOfBirth.Visible = true;
            this.gridColumnDayOfBirth.VisibleIndex = 4;
            this.gridColumnDayOfBirth.Width = 87;
            // 
            // gridColumnAddress
            // 
            this.gridColumnAddress.Caption = "Địa Chỉ";
            this.gridColumnAddress.FieldName = "Address";
            this.gridColumnAddress.MinWidth = 23;
            this.gridColumnAddress.Name = "gridColumnAddress";
            this.gridColumnAddress.Visible = true;
            this.gridColumnAddress.VisibleIndex = 5;
            this.gridColumnAddress.Width = 87;
            // 
            // gridColumnTaxCode
            // 
            this.gridColumnTaxCode.Caption = "Mã Số Thuế";
            this.gridColumnTaxCode.FieldName = "TaxCode";
            this.gridColumnTaxCode.MinWidth = 23;
            this.gridColumnTaxCode.Name = "gridColumnTaxCode";
            this.gridColumnTaxCode.Visible = true;
            this.gridColumnTaxCode.VisibleIndex = 6;
            this.gridColumnTaxCode.Width = 87;
            // 
            // gridColumnSex
            // 
            this.gridColumnSex.Caption = "Giới Tính";
            this.gridColumnSex.FieldName = "Sex";
            this.gridColumnSex.MinWidth = 23;
            this.gridColumnSex.Name = "gridColumnSex";
            this.gridColumnSex.Visible = true;
            this.gridColumnSex.VisibleIndex = 3;
            this.gridColumnSex.Width = 87;
            // 
            // gridColumnEmail
            // 
            this.gridColumnEmail.Caption = "Email";
            this.gridColumnEmail.FieldName = "Email";
            this.gridColumnEmail.MinWidth = 23;
            this.gridColumnEmail.Name = "gridColumnEmail";
            this.gridColumnEmail.Visible = true;
            this.gridColumnEmail.VisibleIndex = 7;
            this.gridColumnEmail.Width = 87;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "(Ctrl+Enter) - Sửa";
            this.gridColumn1.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 8;
            this.gridColumn1.Width = 87;
            // 
            // repositoryItemButtonEditEdit
            // 
            this.repositoryItemButtonEditEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = global::QuanLyBanHang.Properties.Resources.pencolor_16x16;
            this.repositoryItemButtonEditEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEditEdit.Name = "repositoryItemButtonEditEdit";
            this.repositoryItemButtonEditEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditEdit_ButtonClick);
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "(Ctrl+Del) - Xóa";
            this.gridColumn2.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 9;
            this.gridColumn2.Width = 87;
            // 
            // repositoryItemButtonEditDel
            // 
            this.repositoryItemButtonEditDel.AutoHeight = false;
            editorButtonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.clear_16x16;
            this.repositoryItemButtonEditDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEditDel.Name = "repositoryItemButtonEditDel";
            this.repositoryItemButtonEditDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEditDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditDel_ButtonClick);
            // 
            // gc_ChucNang
            // 
            this.gc_ChucNang.AutoSize = true;
            this.gc_ChucNang.Controls.Add(this.gC_KhachHang);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.add_16x16;
            buttonImageOptions3.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.gc_ChucNang.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất File", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("(Ctrl+N) - Thêm", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Esc - Đóng", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.gc_ChucNang.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.gc_ChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.gc_ChucNang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_ChucNang.Name = "gc_ChucNang";
            this.gc_ChucNang.Size = new System.Drawing.Size(1175, 645);
            this.gc_ChucNang.TabIndex = 5;
            this.gc_ChucNang.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gc_ChucNang_CustomButtonClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "gridBand1";
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.VisibleIndex = -1;
            // 
            // bandedGridColumn2
            // 
            this.bandedGridColumn2.Name = "bandedGridColumn2";
            // 
            // DanhSachKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 645);
            this.Controls.Add(this.gc_ChucNang);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Khách Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachKhachHang_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhSachKhachHang_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DanhSachKhachHang_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gC_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).EndInit();
            this.gc_ChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gC_KhachHang;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn bandedGridColumn2;
        private DevExpress.XtraGrid.Views.Grid.GridView gV_KhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDayOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTaxCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSex;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
        private DevExpress.XtraEditors.GroupControl gc_ChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
    }
}