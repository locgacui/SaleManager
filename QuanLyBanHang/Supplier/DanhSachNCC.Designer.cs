namespace QuanLyBanHang
{
    partial class DanhSachNCC
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions1 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachNCC));
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions3 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
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
            this.gc_ChucNang = new DevExpress.XtraEditors.GroupControl();
            this.gC_NCC = new DevExpress.XtraGrid.GridControl();
            this.gv_NCC = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bt_Sua = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bt_Xoa = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).BeginInit();
            this.gc_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Sua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Xoa)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_ChucNang
            // 
            this.gc_ChucNang.AutoSize = true;
            this.gc_ChucNang.Controls.Add(this.gC_NCC);
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
            this.gc_ChucNang.Size = new System.Drawing.Size(1006, 559);
            this.gc_ChucNang.TabIndex = 4;
            this.gc_ChucNang.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gc_ChucNang_CustomButtonClick);
            // 
            // gC_NCC
            // 
            this.gC_NCC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_NCC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gC_NCC.Location = new System.Drawing.Point(2, 33);
            this.gC_NCC.MainView = this.gv_NCC;
            this.gC_NCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gC_NCC.Name = "gC_NCC";
            this.gC_NCC.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.bt_Sua,
            this.bt_Xoa});
            this.gC_NCC.Size = new System.Drawing.Size(1002, 524);
            this.gC_NCC.TabIndex = 8;
            this.gC_NCC.UseEmbeddedNavigator = true;
            this.gC_NCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_NCC});
            // 
            // gv_NCC
            // 
            this.gv_NCC.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colName,
            this.colPhoneNumber,
            this.colAddress,
            this.colFax,
            this.colEmail,
            this.colEdit,
            this.colDel});
            this.gv_NCC.DetailHeight = 431;
            this.gv_NCC.GridControl = this.gC_NCC;
            this.gv_NCC.Name = "gv_NCC";
            this.gv_NCC.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_NCC.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_NCC.OptionsBehavior.ReadOnly = true;
            this.gv_NCC.OptionsView.ShowAutoFilterRow = true;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.Width = 87;
            // 
            // colCode
            // 
            this.colCode.Caption = "Mã NCC";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 23;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 87;
            // 
            // colName
            // 
            this.colName.Caption = "Tên NCC";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 23;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 87;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.Caption = "Số Điện Thoại";
            this.colPhoneNumber.FieldName = "PhoneNumber";
            this.colPhoneNumber.MinWidth = 23;
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.Visible = true;
            this.colPhoneNumber.VisibleIndex = 2;
            this.colPhoneNumber.Width = 87;
            // 
            // colAddress
            // 
            this.colAddress.Caption = "Địa Chỉ";
            this.colAddress.FieldName = "Address";
            this.colAddress.MinWidth = 23;
            this.colAddress.Name = "colAddress";
            this.colAddress.Visible = true;
            this.colAddress.VisibleIndex = 3;
            this.colAddress.Width = 87;
            // 
            // colFax
            // 
            this.colFax.Caption = "Fax";
            this.colFax.FieldName = "Fax";
            this.colFax.MinWidth = 23;
            this.colFax.Name = "colFax";
            this.colFax.Visible = true;
            this.colFax.VisibleIndex = 4;
            this.colFax.Width = 87;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.MinWidth = 23;
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 5;
            this.colEmail.Width = 87;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "(Ctrl+Enter)  - Sửa";
            this.colEdit.ColumnEdit = this.bt_Sua;
            this.colEdit.MinWidth = 23;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 6;
            this.colEdit.Width = 87;
            // 
            // bt_Sua
            // 
            this.bt_Sua.AutoHeight = false;
            editorButtonImageOptions1.Image = global::QuanLyBanHang.Properties.Resources.pencolor_16x16;
            this.bt_Sua.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.bt_Sua.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bt_Sua_ButtonClick);
            // 
            // colDel
            // 
            this.colDel.Caption = "(Ctrl+Del) - Xóa";
            this.colDel.ColumnEdit = this.bt_Xoa;
            this.colDel.MinWidth = 23;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 7;
            this.colDel.Width = 87;
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.AutoHeight = false;
            editorButtonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.clear_16x16;
            this.bt_Xoa.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.bt_Xoa.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bt_Xoa_ButtonClick);
            // 
            // DanhSachNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 559);
            this.Controls.Add(this.gc_ChucNang);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhà Cung Cấp";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachNCC_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhSachNCC_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DanhSachNCC_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).EndInit();
            this.gc_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gC_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Sua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_Xoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gc_ChucNang;
        private DevExpress.XtraGrid.GridControl gC_NCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_NCC;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colFax;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bt_Sua;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bt_Xoa;
    }
}