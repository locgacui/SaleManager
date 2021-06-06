namespace QuanLyBanHang
{
    partial class CapNhatGiaMH
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.spin_GiaBan = new DevExpress.XtraEditors.SpinEdit();
            this.cb_MaMatHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEditItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spin_GiaBan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditItem)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl1.Location = new System.Drawing.Point(14, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Mặt Hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelControl2.Location = new System.Drawing.Point(14, 60);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 16);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Giá Bán:";
            // 
            // bt_Luu
            // 
            this.bt_Luu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Luu.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.save_16x16;
            this.bt_Luu.Location = new System.Drawing.Point(288, 87);
            this.bt_Luu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(87, 28);
            this.bt_Luu.TabIndex = 3;
            this.bt_Luu.Text = "F1 - Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.bt_Lưu_Click);
            // 
            // bt_Huy
            // 
            this.bt_Huy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_Huy.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.bt_Huy.Location = new System.Drawing.Point(383, 87);
            this.bt_Huy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(87, 28);
            this.bt_Huy.TabIndex = 4;
            this.bt_Huy.Text = "Esc - Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.bt_Huy_Click);
            // 
            // spin_GiaBan
            // 
            this.spin_GiaBan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.spin_GiaBan.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_GiaBan.Location = new System.Drawing.Point(120, 57);
            this.spin_GiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.spin_GiaBan.Name = "spin_GiaBan";
            this.spin_GiaBan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_GiaBan.Size = new System.Drawing.Size(350, 22);
            this.spin_GiaBan.TabIndex = 2;
            // 
            // cb_MaMatHang
            // 
            this.cb_MaMatHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_MaMatHang.EditValue = "Chọn mặt hàng";
            this.cb_MaMatHang.Location = new System.Drawing.Point(120, 11);
            this.cb_MaMatHang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_MaMatHang.Name = "cb_MaMatHang";
            this.cb_MaMatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_MaMatHang.Properties.NullText = "Chọn mặt hàng";
            this.cb_MaMatHang.Properties.PopupView = this.gridLookUpEditItem;
            this.cb_MaMatHang.Size = new System.Drawing.Size(350, 22);
            this.cb_MaMatHang.TabIndex = 1;
            // 
            // gridLookUpEditItem
            // 
            this.gridLookUpEditItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCode,
            this.gridColumnName});
            this.gridLookUpEditItem.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEditItem.Name = "gridLookUpEditItem";
            this.gridLookUpEditItem.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEditItem.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Mã Mặt Hàng";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Tên Mặt Hàng";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            // 
            // CapNhatGiaMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 132);
            this.Controls.Add(this.cb_MaMatHang);
            this.Controls.Add(this.spin_GiaBan);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CapNhatGiaMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cập Nhật Giá Mặt Hàng";
            this.Load += new System.EventHandler(this.CapNhatGiaMH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CapNhatGiaMH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spin_GiaBan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.SpinEdit spin_GiaBan;
        private DevExpress.XtraEditors.GridLookUpEdit cb_MaMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEditItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
    }
}