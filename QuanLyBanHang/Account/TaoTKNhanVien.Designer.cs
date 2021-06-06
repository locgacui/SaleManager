namespace QuanLyBanHang
{
    partial class TaoTKNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaoTKNhanVien));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gC_ChonNhanVien = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cb_TenNhanVien = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tb_MaNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.lb_MaNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.gC_NhapTaiKhoan = new DevExpress.XtraEditors.GroupControl();
            this.tb_NhapLaiMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.tb_MatKhau = new DevExpress.XtraEditors.TextEdit();
            this.lb_MatKhau = new DevExpress.XtraEditors.LabelControl();
            this.bt_Thoat = new DevExpress.XtraEditors.SimpleButton();
            this.bt_TaoTaiKhoan = new DevExpress.XtraEditors.SimpleButton();
            this.lb_NhapLaiMatKhau = new DevExpress.XtraEditors.LabelControl();
            this.tb_TenTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.lb_TenTaiKhoan = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC_ChonNhanVien)).BeginInit();
            this.gC_ChonNhanVien.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_TenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_NhapTaiKhoan)).BeginInit();
            this.gC_NhapTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NhapLaiMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenTaiKhoan.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gC_ChonNhanVien);
            this.panelControl1.Controls.Add(this.gC_NhapTaiKhoan);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(272, 298);
            this.panelControl1.TabIndex = 0;
            // 
            // gC_ChonNhanVien
            // 
            this.gC_ChonNhanVien.AutoSize = true;
            this.gC_ChonNhanVien.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gC_ChonNhanVien.CaptionImageOptions.Image")));
            this.gC_ChonNhanVien.Controls.Add(this.labelControl1);
            this.gC_ChonNhanVien.Controls.Add(this.cb_TenNhanVien);
            this.gC_ChonNhanVien.Controls.Add(this.tb_MaNhanVien);
            this.gC_ChonNhanVien.Controls.Add(this.lb_MaNhanVien);
            this.gC_ChonNhanVien.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.gC_ChonNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_ChonNhanVien.Location = new System.Drawing.Point(2, 2);
            this.gC_ChonNhanVien.Name = "gC_ChonNhanVien";
            this.gC_ChonNhanVien.Size = new System.Drawing.Size(268, 96);
            this.gC_ChonNhanVien.TabIndex = 0;
            this.gC_ChonNhanVien.Text = "Chọn Nhân Viên";
            this.gC_ChonNhanVien.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl1_CustomButtonClick);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(10, 69);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên Nhân Viên:";
            // 
            // cb_TenNhanVien
            // 
            this.cb_TenNhanVien.EditValue = "Chọn Nhân Viên";
            this.cb_TenNhanVien.Location = new System.Drawing.Point(111, 66);
            this.cb_TenNhanVien.Name = "cb_TenNhanVien";
            this.cb_TenNhanVien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_TenNhanVien.Properties.ImmediatePopup = true;
            this.cb_TenNhanVien.Properties.NullText = "Chọn Nhân Viên";
            this.cb_TenNhanVien.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cb_TenNhanVien.Properties.PopupView = this.gridLookUpEdit1View;
            this.cb_TenNhanVien.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_TenNhanVien.Size = new System.Drawing.Size(150, 20);
            this.cb_TenNhanVien.TabIndex = 3;
            this.cb_TenNhanVien.EditValueChanged += new System.EventHandler(this.cb_TenNhanVien_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id,
            this.col_Code,
            this.col_Name});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // col_Id
            // 
            this.col_Id.Caption = "Id";
            this.col_Id.FieldName = "Id";
            this.col_Id.Name = "col_Id";
            this.col_Id.OptionsColumn.AllowShowHide = false;
            // 
            // col_Code
            // 
            this.col_Code.Caption = "Mã Nhân Viên";
            this.col_Code.FieldName = "Code";
            this.col_Code.Name = "col_Code";
            this.col_Code.Visible = true;
            this.col_Code.VisibleIndex = 0;
            // 
            // col_Name
            // 
            this.col_Name.Caption = "Tên Nhân Viên";
            this.col_Name.FieldName = "Name";
            this.col_Name.Name = "col_Name";
            this.col_Name.Visible = true;
            this.col_Name.VisibleIndex = 1;
            // 
            // tb_MaNhanVien
            // 
            this.tb_MaNhanVien.Location = new System.Drawing.Point(111, 29);
            this.tb_MaNhanVien.Name = "tb_MaNhanVien";
            this.tb_MaNhanVien.Properties.ReadOnly = true;
            this.tb_MaNhanVien.Size = new System.Drawing.Size(150, 20);
            this.tb_MaNhanVien.TabIndex = 2;
            // 
            // lb_MaNhanVien
            // 
            this.lb_MaNhanVien.Location = new System.Drawing.Point(10, 32);
            this.lb_MaNhanVien.Name = "lb_MaNhanVien";
            this.lb_MaNhanVien.Size = new System.Drawing.Size(69, 13);
            this.lb_MaNhanVien.TabIndex = 1;
            this.lb_MaNhanVien.Text = "Mã Nhân Viên:";
            // 
            // gC_NhapTaiKhoan
            // 
            this.gC_NhapTaiKhoan.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gC_NhapTaiKhoan.CaptionImageOptions.Image")));
            this.gC_NhapTaiKhoan.Controls.Add(this.tb_NhapLaiMatKhau);
            this.gC_NhapTaiKhoan.Controls.Add(this.tb_MatKhau);
            this.gC_NhapTaiKhoan.Controls.Add(this.lb_MatKhau);
            this.gC_NhapTaiKhoan.Controls.Add(this.bt_Thoat);
            this.gC_NhapTaiKhoan.Controls.Add(this.bt_TaoTaiKhoan);
            this.gC_NhapTaiKhoan.Controls.Add(this.lb_NhapLaiMatKhau);
            this.gC_NhapTaiKhoan.Controls.Add(this.tb_TenTaiKhoan);
            this.gC_NhapTaiKhoan.Controls.Add(this.lb_TenTaiKhoan);
            this.gC_NhapTaiKhoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gC_NhapTaiKhoan.Location = new System.Drawing.Point(2, 98);
            this.gC_NhapTaiKhoan.Name = "gC_NhapTaiKhoan";
            this.gC_NhapTaiKhoan.Size = new System.Drawing.Size(268, 198);
            this.gC_NhapTaiKhoan.TabIndex = 1;
            this.gC_NhapTaiKhoan.Text = "Nhập Tài Khoản";
            // 
            // tb_NhapLaiMatKhau
            // 
            this.tb_NhapLaiMatKhau.Location = new System.Drawing.Point(111, 90);
            this.tb_NhapLaiMatKhau.Name = "tb_NhapLaiMatKhau";
            this.tb_NhapLaiMatKhau.Properties.ReadOnly = true;
            this.tb_NhapLaiMatKhau.Properties.UseSystemPasswordChar = true;
            this.tb_NhapLaiMatKhau.Size = new System.Drawing.Size(150, 20);
            this.tb_NhapLaiMatKhau.TabIndex = 5;
            // 
            // tb_MatKhau
            // 
            this.tb_MatKhau.Location = new System.Drawing.Point(111, 57);
            this.tb_MatKhau.Name = "tb_MatKhau";
            this.tb_MatKhau.Properties.ReadOnly = true;
            this.tb_MatKhau.Properties.UseSystemPasswordChar = true;
            this.tb_MatKhau.Size = new System.Drawing.Size(150, 20);
            this.tb_MatKhau.TabIndex = 4;
            // 
            // lb_MatKhau
            // 
            this.lb_MatKhau.Location = new System.Drawing.Point(10, 59);
            this.lb_MatKhau.Name = "lb_MatKhau";
            this.lb_MatKhau.Size = new System.Drawing.Size(49, 13);
            this.lb_MatKhau.TabIndex = 10;
            this.lb_MatKhau.Text = "Mật Khẩu:";
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.bt_Thoat.Location = new System.Drawing.Point(120, 155);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(141, 23);
            this.bt_Thoat.TabIndex = 7;
            this.bt_Thoat.Text = "Esc - Thoát";
            this.bt_Thoat.Click += new System.EventHandler(this.bt_Thoat_Click);
            // 
            // bt_TaoTaiKhoan
            // 
            this.bt_TaoTaiKhoan.Enabled = false;
            this.bt_TaoTaiKhoan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_TaoTaiKhoan.ImageOptions.Image")));
            this.bt_TaoTaiKhoan.Location = new System.Drawing.Point(120, 126);
            this.bt_TaoTaiKhoan.Name = "bt_TaoTaiKhoan";
            this.bt_TaoTaiKhoan.Size = new System.Drawing.Size(141, 23);
            this.bt_TaoTaiKhoan.TabIndex = 6;
            this.bt_TaoTaiKhoan.Text = "F1 - Tạo Tài Khoản";
            this.bt_TaoTaiKhoan.Click += new System.EventHandler(this.bt_TaoTaiKhoan_Click);
            // 
            // lb_NhapLaiMatKhau
            // 
            this.lb_NhapLaiMatKhau.Location = new System.Drawing.Point(10, 92);
            this.lb_NhapLaiMatKhau.Name = "lb_NhapLaiMatKhau";
            this.lb_NhapLaiMatKhau.Size = new System.Drawing.Size(93, 13);
            this.lb_NhapLaiMatKhau.TabIndex = 5;
            this.lb_NhapLaiMatKhau.Text = "Nhập Lại Mật Khẩu:";
            // 
            // tb_TenTaiKhoan
            // 
            this.tb_TenTaiKhoan.Location = new System.Drawing.Point(111, 24);
            this.tb_TenTaiKhoan.Name = "tb_TenTaiKhoan";
            this.tb_TenTaiKhoan.Properties.ReadOnly = true;
            this.tb_TenTaiKhoan.Size = new System.Drawing.Size(150, 20);
            this.tb_TenTaiKhoan.TabIndex = 3;
            // 
            // lb_TenTaiKhoan
            // 
            this.lb_TenTaiKhoan.Location = new System.Drawing.Point(10, 26);
            this.lb_TenTaiKhoan.Name = "lb_TenTaiKhoan";
            this.lb_TenTaiKhoan.Size = new System.Drawing.Size(75, 13);
            this.lb_TenTaiKhoan.TabIndex = 0;
            this.lb_TenTaiKhoan.Text = "Tên Tài Khoản: ";
            // 
            // TaoTKNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 298);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "TaoTKNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TẠO TÀI KHOẢN NHÂN VIÊN";
            this.Load += new System.EventHandler(this.TaoTKNhanVien_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TaoTKNhanVien_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gC_ChonNhanVien)).EndInit();
            this.gC_ChonNhanVien.ResumeLayout(false);
            this.gC_ChonNhanVien.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cb_TenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MaNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gC_NhapTaiKhoan)).EndInit();
            this.gC_NhapTaiKhoan.ResumeLayout(false);
            this.gC_NhapTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_NhapLaiMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_MatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenTaiKhoan.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.GroupControl gC_ChonNhanVien;
        private DevExpress.XtraEditors.GroupControl gC_NhapTaiKhoan;
        private DevExpress.XtraEditors.TextEdit tb_MaNhanVien;
        private DevExpress.XtraEditors.TextEdit tb_NhapLaiMatKhau;
        private DevExpress.XtraEditors.TextEdit tb_MatKhau;
        private DevExpress.XtraEditors.LabelControl lb_MatKhau;
        private DevExpress.XtraEditors.SimpleButton bt_Thoat;
        private DevExpress.XtraEditors.SimpleButton bt_TaoTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lb_NhapLaiMatKhau;
        private DevExpress.XtraEditors.TextEdit tb_TenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl lb_MaNhanVien;
        private DevExpress.XtraEditors.LabelControl lb_TenTaiKhoan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GridLookUpEdit cb_TenNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id;
        private DevExpress.XtraGrid.Columns.GridColumn col_Code;
        private DevExpress.XtraGrid.Columns.GridColumn col_Name;
    }
}