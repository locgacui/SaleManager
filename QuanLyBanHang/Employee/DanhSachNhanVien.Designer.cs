namespace QuanLyBanHang
{
    partial class DanhSachNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhSachNhanVien));
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
            this.gc_Employee = new DevExpress.XtraGrid.GridControl();
            this.gv_Employee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDateofbirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSex = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPosition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCmnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhonenumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditDel = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).BeginInit();
            this.gc_ChucNang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Employee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).BeginInit();
            this.SuspendLayout();
            // 
            // gc_ChucNang
            // 
            this.gc_ChucNang.AutoSize = true;
            this.gc_ChucNang.Controls.Add(this.gc_Employee);
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
            this.gc_ChucNang.Size = new System.Drawing.Size(1288, 848);
            this.gc_ChucNang.TabIndex = 4;
            this.gc_ChucNang.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gc_ChucNang_CustomButtonClick);
            // 
            // gc_Employee
            // 
            this.gc_Employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Employee.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_Employee.Location = new System.Drawing.Point(2, 33);
            this.gc_Employee.MainView = this.gv_Employee;
            this.gc_Employee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gc_Employee.Name = "gc_Employee";
            this.gc_Employee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditEdit,
            this.repositoryItemButtonEditDel});
            this.gc_Employee.ShowOnlyPredefinedDetails = true;
            this.gc_Employee.Size = new System.Drawing.Size(1284, 813);
            this.gc_Employee.TabIndex = 0;
            this.gc_Employee.UseEmbeddedNavigator = true;
            this.gc_Employee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Employee});
            this.gc_Employee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gc_Employee_MouseDown);
            // 
            // gv_Employee
            // 
            this.gv_Employee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCode,
            this.gridColumnName,
            this.gridColumnDateofbirth,
            this.gridColumnSex,
            this.gridColumnPosition,
            this.gridColumnCmnd,
            this.gridColumnAddress,
            this.gridColumnPhonenumber,
            this.gridColumnEmail,
            this.gridColumnEdit,
            this.gridColumnDel});
            this.gv_Employee.DetailHeight = 431;
            this.gv_Employee.GridControl = this.gc_Employee;
            this.gv_Employee.Name = "gv_Employee";
            this.gv_Employee.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Employee.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gv_Employee.OptionsBehavior.ReadOnly = true;
            this.gv_Employee.OptionsView.ShowAutoFilterRow = true;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.MinWidth = 23;
            this.gridColumnId.Name = "gridColumnId";
            this.gridColumnId.OptionsColumn.AllowShowHide = false;
            this.gridColumnId.OptionsColumn.ReadOnly = true;
            this.gridColumnId.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowOnlyInEditor;
            this.gridColumnId.Width = 87;
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Mã Nhân Viên";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.MinWidth = 23;
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            this.gridColumnCode.Width = 87;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Tên Nhân Viên";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.MinWidth = 23;
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            this.gridColumnName.Width = 87;
            // 
            // gridColumnDateofbirth
            // 
            this.gridColumnDateofbirth.Caption = "Ngày Sinh";
            this.gridColumnDateofbirth.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.gridColumnDateofbirth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumnDateofbirth.FieldName = "DateOfBirth";
            this.gridColumnDateofbirth.MinWidth = 23;
            this.gridColumnDateofbirth.Name = "gridColumnDateofbirth";
            this.gridColumnDateofbirth.Visible = true;
            this.gridColumnDateofbirth.VisibleIndex = 2;
            this.gridColumnDateofbirth.Width = 87;
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
            // gridColumnPosition
            // 
            this.gridColumnPosition.Caption = "Chức Vụ";
            this.gridColumnPosition.FieldName = "Position";
            this.gridColumnPosition.MinWidth = 23;
            this.gridColumnPosition.Name = "gridColumnPosition";
            this.gridColumnPosition.Visible = true;
            this.gridColumnPosition.VisibleIndex = 4;
            this.gridColumnPosition.Width = 87;
            // 
            // gridColumnCmnd
            // 
            this.gridColumnCmnd.Caption = "CMND";
            this.gridColumnCmnd.FieldName = "CMND";
            this.gridColumnCmnd.MinWidth = 23;
            this.gridColumnCmnd.Name = "gridColumnCmnd";
            this.gridColumnCmnd.Visible = true;
            this.gridColumnCmnd.VisibleIndex = 5;
            this.gridColumnCmnd.Width = 87;
            // 
            // gridColumnAddress
            // 
            this.gridColumnAddress.Caption = "Địa Chỉ";
            this.gridColumnAddress.FieldName = "Address";
            this.gridColumnAddress.MinWidth = 23;
            this.gridColumnAddress.Name = "gridColumnAddress";
            this.gridColumnAddress.Visible = true;
            this.gridColumnAddress.VisibleIndex = 6;
            this.gridColumnAddress.Width = 87;
            // 
            // gridColumnPhonenumber
            // 
            this.gridColumnPhonenumber.Caption = "Điện Thoại";
            this.gridColumnPhonenumber.FieldName = "PhoneNumber";
            this.gridColumnPhonenumber.MinWidth = 23;
            this.gridColumnPhonenumber.Name = "gridColumnPhonenumber";
            this.gridColumnPhonenumber.Visible = true;
            this.gridColumnPhonenumber.VisibleIndex = 7;
            this.gridColumnPhonenumber.Width = 87;
            // 
            // gridColumnEmail
            // 
            this.gridColumnEmail.Caption = "Email";
            this.gridColumnEmail.FieldName = "Email";
            this.gridColumnEmail.MinWidth = 23;
            this.gridColumnEmail.Name = "gridColumnEmail";
            this.gridColumnEmail.Visible = true;
            this.gridColumnEmail.VisibleIndex = 8;
            this.gridColumnEmail.Width = 87;
            // 
            // gridColumnEdit
            // 
            this.gridColumnEdit.Caption = "(Ctrl+Enter) - Sửa";
            this.gridColumnEdit.ColumnEdit = this.repositoryItemButtonEditEdit;
            this.gridColumnEdit.MinWidth = 23;
            this.gridColumnEdit.Name = "gridColumnEdit";
            this.gridColumnEdit.Visible = true;
            this.gridColumnEdit.VisibleIndex = 9;
            this.gridColumnEdit.Width = 87;
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
            // gridColumnDel
            // 
            this.gridColumnDel.Caption = "(Ctrl+Del) - Xóa";
            this.gridColumnDel.ColumnEdit = this.repositoryItemButtonEditDel;
            this.gridColumnDel.MinWidth = 23;
            this.gridColumnDel.Name = "gridColumnDel";
            this.gridColumnDel.Visible = true;
            this.gridColumnDel.VisibleIndex = 10;
            this.gridColumnDel.Width = 87;
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
            // DanhSachNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 848);
            this.Controls.Add(this.gc_ChucNang);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DanhSachNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Nhân Viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachNhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhSachNhanVien_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DanhSachNhanVien_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).EndInit();
            this.gc_ChucNang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Employee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditDel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl gc_ChucNang;
        private DevExpress.XtraGrid.GridControl gc_Employee;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Employee;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDateofbirth;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSex;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPosition;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCmnd;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnAddress;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhonenumber;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEmail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditEdit;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDel;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditDel;
    }
}