namespace QuanLyBanHang
{
    partial class DanhSachTaiKhoan
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
            DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions buttonImageOptions2 = new DevExpress.XtraEditors.ButtonsPanelControl.ButtonImageOptions();
            this.gC_TaiKhoan = new DevExpress.XtraGrid.GridControl();
            this.gV_TaIKhoan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPassword = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodeEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colDel = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_ChucNang = new DevExpress.XtraEditors.GroupControl();
            this.col_NameEmployee = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gC_TaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_TaIKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).BeginInit();
            this.gc_ChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // gC_TaiKhoan
            // 
            this.gC_TaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_TaiKhoan.Location = new System.Drawing.Point(2, 29);
            this.gC_TaiKhoan.MainView = this.gV_TaIKhoan;
            this.gC_TaiKhoan.Name = "gC_TaiKhoan";
            this.gC_TaiKhoan.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemButtonEdit2});
            this.gC_TaiKhoan.Size = new System.Drawing.Size(616, 377);
            this.gC_TaiKhoan.TabIndex = 0;
            this.gC_TaiKhoan.UseEmbeddedNavigator = true;
            this.gC_TaiKhoan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gV_TaIKhoan});
            // 
            // gV_TaIKhoan
            // 
            this.gV_TaIKhoan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colUserName,
            this.colPassword,
            this.colCodeEmployee,
            this.col_NameEmployee,
            this.colEdit,
            this.colDel,
            this.colId});
            this.gV_TaIKhoan.GridControl = this.gC_TaiKhoan;
            this.gV_TaIKhoan.Name = "gV_TaIKhoan";
            this.gV_TaIKhoan.OptionsView.ShowAutoFilterRow = true;
            // 
            // colUserName
            // 
            this.colUserName.Caption = "Tên Tài Khoản";
            this.colUserName.FieldName = "UserName";
            this.colUserName.Name = "colUserName";
            this.colUserName.Visible = true;
            this.colUserName.VisibleIndex = 0;
            // 
            // colPassword
            // 
            this.colPassword.Caption = "Mật Khẩu";
            this.colPassword.FieldName = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.Visible = true;
            this.colPassword.VisibleIndex = 1;
            // 
            // colCodeEmployee
            // 
            this.colCodeEmployee.Caption = "Mã Nhân Viên";
            this.colCodeEmployee.FieldName = "CodeEmployee";
            this.colCodeEmployee.Name = "colCodeEmployee";
            this.colCodeEmployee.Visible = true;
            this.colCodeEmployee.VisibleIndex = 2;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "(Ctrl+Enter) - Sửa";
            this.colEdit.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colEdit.Name = "colEdit";
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 4;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = global::QuanLyBanHang.Properties.Resources.pencolor_16x16;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit1_ButtonClick);
            // 
            // colDel
            // 
            this.colDel.Caption = "(Ctrl+Del) - Xóa";
            this.colDel.ColumnEdit = this.repositoryItemButtonEdit2;
            this.colDel.Name = "colDel";
            this.colDel.Visible = true;
            this.colDel.VisibleIndex = 5;
            // 
            // repositoryItemButtonEdit2
            // 
            this.repositoryItemButtonEdit2.AutoHeight = false;
            editorButtonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.clear_16x16;
            this.repositoryItemButtonEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit2.Name = "repositoryItemButtonEdit2";
            this.repositoryItemButtonEdit2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit2.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit2_ButtonClick);
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // gc_ChucNang
            // 
            this.gc_ChucNang.AutoSize = true;
            this.gc_ChucNang.Controls.Add(this.gC_TaiKhoan);
            buttonImageOptions1.Image = global::QuanLyBanHang.Properties.Resources.add_16x16;
            buttonImageOptions2.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.gc_ChucNang.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("(Ctrl+N) - Thêm", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Esc - Đóng", true, buttonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.gc_ChucNang.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.gc_ChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_ChucNang.Location = new System.Drawing.Point(0, 0);
            this.gc_ChucNang.Name = "gc_ChucNang";
            this.gc_ChucNang.Size = new System.Drawing.Size(620, 408);
            this.gc_ChucNang.TabIndex = 5;
            this.gc_ChucNang.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.gc_ChucNang_CustomButtonClick);
            // 
            // col_NameEmployee
            // 
            this.col_NameEmployee.Caption = "Tên Nhân Viên";
            this.col_NameEmployee.FieldName = "NameEmployee";
            this.col_NameEmployee.Name = "col_NameEmployee";
            this.col_NameEmployee.Visible = true;
            this.col_NameEmployee.VisibleIndex = 3;
            // 
            // DanhSachTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 408);
            this.Controls.Add(this.gc_ChucNang);
            this.KeyPreview = true;
            this.Name = "DanhSachTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh Sách Tài Khoản";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DanhSachTaiKhoan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DanhSachTaiKhoan_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DanhSachTaiKhoan_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.gC_TaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_TaIKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_ChucNang)).EndInit();
            this.gc_ChucNang.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gC_TaiKhoan;
        private DevExpress.XtraGrid.Views.Grid.GridView gV_TaIKhoan;
        private DevExpress.XtraGrid.Columns.GridColumn colUserName;
        private DevExpress.XtraGrid.Columns.GridColumn colPassword;
        private DevExpress.XtraEditors.GroupControl gc_ChucNang;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
        private DevExpress.XtraGrid.Columns.GridColumn colDel;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameEmployee;
    }
}