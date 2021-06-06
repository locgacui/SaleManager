namespace QuanLyBanHang
{
    partial class DanhSachKho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachKho));
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
            this.gC_ChucNang = new DevExpress.XtraEditors.GroupControl();
            this.gC_Kho = new DevExpress.XtraGrid.GridControl();
            this.gV_Kho = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhoneNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_ChucNang)).BeginInit();
            this.gC_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_Kho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDel)).BeginInit();
            this.SuspendLayout();
            // 
            // gC_ChucNang
            // 
            this.gC_ChucNang.Controls.Add(this.gC_Kho);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            buttonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.add_16x16;
            buttonImageOptions3.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.gC_ChucNang.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất File", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("(Ctrl+N) - Thêm", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Esc - Đóng", true, buttonImageOptions3, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.gC_ChucNang.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.gC_ChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.gC_ChucNang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gC_ChucNang.Name = "gC_ChucNang";
            this.gC_ChucNang.Size = new System.Drawing.Size(561, 371);
            this.gC_ChucNang.TabIndex = 2;
            this.gC_ChucNang.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gC_ChucNang_CustomButtonClick);
            // 
            // gC_Kho
            // 
            this.gC_Kho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_Kho.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gC_Kho.Location = new System.Drawing.Point(2, 29);
            this.gC_Kho.MainView = this.gV_Kho;
            this.gC_Kho.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gC_Kho.Name = "gC_Kho";
            this.gC_Kho.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit,
            this.repositoryItemButtonDel});
            this.gC_Kho.Size = new System.Drawing.Size(557, 340);
            this.gC_Kho.TabIndex = 0;
            this.gC_Kho.UseEmbeddedNavigator = true;
            this.gC_Kho.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gV_Kho});
            // 
            // gV_Kho
            // 
            this.gV_Kho.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCode,
            this.gridColumnName,
            this.gridColumnAddress,
            this.gridColumnPhoneNumber,
            this.gridColumnEdit,
            this.gridColumnDel});
            this.gV_Kho.DetailHeight = 284;
            this.gV_Kho.GridControl = this.gC_Kho;
            this.gV_Kho.Name = "gV_Kho";
            this.gV_Kho.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gV_Kho.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gV_Kho.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.MinWidth = 21;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.gridColumnId.Width = 81;
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Mã kho";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.MinWidth = 21;
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            this.gridColumnCode.Width = 81;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Tên kho";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.MinWidth = 21;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 81;
            // 
            // gridColumnAddress
            // 
            this.gridColumnAddress.Caption = "Địa chỉ";
            this.gridColumnAddress.FieldName = "Address";
            this.gridColumnAddress.MinWidth = 21;
            this.gridColumnAddress.Name = "gridColumnAddress";
            this.gridColumnAddress.Visible = true;
            this.gridColumnAddress.VisibleIndex = 2;
            this.gridColumnAddress.Width = 81;
            // 
            // gridColumnPhoneNumber
            // 
            this.gridColumnPhoneNumber.Caption = "Số điện thoại";
            this.gridColumnPhoneNumber.FieldName = "PhoneNumber";
            this.gridColumnPhoneNumber.MinWidth = 21;
            this.gridColumnPhoneNumber.Name = "gridColumnPhoneNumber";
            this.gridColumnPhoneNumber.Visible = true;
            this.gridColumnPhoneNumber.VisibleIndex = 3;
            this.gridColumnPhoneNumber.Width = 81;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.Caption = "(Ctrl+Enter) - Sửa";
            this.gridColumnEdit.ColumnEdit = this.repositoryItemButtonEdit;
            this.gridColumnEdit.MinWidth = 21;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 4;
            this.gridColumnEdit.Width = 81;
            // 
            // repositoryItemButtonEdit
            // 
            this.repositoryItemButtonEdit.AutoHeight = false;
            editorButtonImageOptions1.Image = global::QuanLyBanHang.Properties.Resources.pencolor_16x16;
            this.repositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
            this.repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit_ButtonClick);
            // 
            // gridColumnDel
            // 
            this.gridColumnDel.Caption = "(Ctrl+Del) - Xóa";
            this.gridColumnDel.ColumnEdit = this.repositoryItemButtonDel;
            this.gridColumnDel.MinWidth = 21;
            this.gridColumnDel.Name = "gridColumnDel";
            this.gridColumnDel.Visible = true;
            this.gridColumnDel.VisibleIndex = 5;
            this.gridColumnDel.Width = 81;
            // 
            // repositoryItemButtonDel
            // 
            this.repositoryItemButtonDel.AutoHeight = false;
            editorButtonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.clear_16x16;
            this.repositoryItemButtonDel.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonDel.Name = "repositoryItemButtonDel";
            this.repositoryItemButtonDel.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonDel.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonDel_ButtonClick);
            // 
            // DanhSachKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 371);
            this.Controls.Add(this.gC_ChucNang);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DanhSachKho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Kho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachKho_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhSachKho_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DanhSachKho_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gC_ChucNang)).EndInit();
            this.gC_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gC_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_Kho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonDel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl gC_ChucNang;
        private DevExpress.XtraGrid.GridControl gC_Kho;
        private DevExpress.XtraGrid.Views.Grid.GridView gV_Kho;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhoneNumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonDel;
    }
}