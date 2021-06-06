namespace QuanLyBanHang
{
    partial class ThemDVTMH
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.spin_HeSo = new DevExpress.XtraEditors.SpinEdit();
            this.cb_DVT = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEditDVT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bt_Huy = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Luu = new DevExpress.XtraEditors.SimpleButton();
            this.cb_MaMatHang = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnCodeItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnNameItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnIdItem = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.spin_HeSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_DVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaMatHang.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Mã Mặt Hàng:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 43);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đơn Vị Tính:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 78);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(32, 13);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Hệ Số:";
            // 
            // spin_HeSo
            // 
            this.spin_HeSo.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_HeSo.Location = new System.Drawing.Point(98, 70);
            this.spin_HeSo.Name = "spin_HeSo";
            this.spin_HeSo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_HeSo.Size = new System.Drawing.Size(229, 20);
            this.spin_HeSo.TabIndex = 10;
            // 
            // cb_DVT
            // 
            this.cb_DVT.EditValue = "Chọn ĐVt";
            this.cb_DVT.Location = new System.Drawing.Point(98, 40);
            this.cb_DVT.Name = "cb_DVT";
            editorButtonImageOptions1.Image = global::QuanLyBanHang.Properties.Resources.add_16x16;
            this.cb_DVT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Thêm", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.cb_DVT.Properties.ImmediatePopup = true;
            this.cb_DVT.Properties.NullText = "Chọn ĐVT";
            this.cb_DVT.Properties.PopupFilterMode = DevExpress.XtraEditors.PopupFilterMode.Contains;
            this.cb_DVT.Properties.PopupView = this.gridLookUpEditDVT;
            this.cb_DVT.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cb_DVT.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.cb_DVT_Properties_ButtonClick);
            this.cb_DVT.Size = new System.Drawing.Size(229, 22);
            this.cb_DVT.TabIndex = 9;
            // 
            // gridLookUpEditDVT
            // 
            this.gridLookUpEditDVT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnId,
            this.gridColumnCode,
            this.gridColumnName});
            this.gridLookUpEditDVT.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEditDVT.Name = "gridLookUpEditDVT";
            this.gridLookUpEditDVT.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEditDVT.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnId
            // 
            this.gridColumnId.Caption = "Id";
            this.gridColumnId.FieldName = "Id";
            this.gridColumnId.Name = "gridColumnId";
            // 
            // gridColumnCode
            // 
            this.gridColumnCode.Caption = "Mã ĐVT";
            this.gridColumnCode.FieldName = "Code";
            this.gridColumnCode.Name = "gridColumnCode";
            this.gridColumnCode.Visible = true;
            this.gridColumnCode.VisibleIndex = 0;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Tên ĐVT";
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 1;
            // 
            // bt_Huy
            // 
            this.bt_Huy.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.cancel_16x16;
            this.bt_Huy.Location = new System.Drawing.Point(251, 96);
            this.bt_Huy.Name = "bt_Huy";
            this.bt_Huy.Size = new System.Drawing.Size(75, 23);
            this.bt_Huy.TabIndex = 12;
            this.bt_Huy.Text = "Esc - Hủy";
            this.bt_Huy.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // bt_Luu
            // 
            this.bt_Luu.ImageOptions.Image = global::QuanLyBanHang.Properties.Resources.save_16x16;
            this.bt_Luu.Location = new System.Drawing.Point(170, 96);
            this.bt_Luu.Name = "bt_Luu";
            this.bt_Luu.Size = new System.Drawing.Size(75, 23);
            this.bt_Luu.TabIndex = 11;
            this.bt_Luu.Text = "F1 - Lưu";
            this.bt_Luu.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // cb_MaMatHang
            // 
            this.cb_MaMatHang.Location = new System.Drawing.Point(98, 9);
            this.cb_MaMatHang.Name = "cb_MaMatHang";
            this.cb_MaMatHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cb_MaMatHang.Properties.NullText = "Chọn mặt hàng";
            this.cb_MaMatHang.Properties.PopupView = this.gridLookUpEdit1View;
            this.cb_MaMatHang.Size = new System.Drawing.Size(229, 20);
            this.cb_MaMatHang.TabIndex = 8;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnCodeItem,
            this.gridColumnNameItem,
            this.gridColumnIdItem});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnCodeItem
            // 
            this.gridColumnCodeItem.Caption = "Mã Mặt Hàng";
            this.gridColumnCodeItem.FieldName = "Code";
            this.gridColumnCodeItem.Name = "gridColumnCodeItem";
            this.gridColumnCodeItem.Visible = true;
            this.gridColumnCodeItem.VisibleIndex = 0;
            // 
            // gridColumnNameItem
            // 
            this.gridColumnNameItem.Caption = "Tên Mặt Hàng";
            this.gridColumnNameItem.FieldName = "Name";
            this.gridColumnNameItem.Name = "gridColumnNameItem";
            this.gridColumnNameItem.Visible = true;
            this.gridColumnNameItem.VisibleIndex = 1;
            // 
            // gridColumnIdItem
            // 
            this.gridColumnIdItem.Caption = "Id";
            this.gridColumnIdItem.FieldName = "Id";
            this.gridColumnIdItem.Name = "gridColumnIdItem";
            this.gridColumnIdItem.OptionsColumn.ReadOnly = true;
            this.gridColumnIdItem.Visible = true;
            this.gridColumnIdItem.VisibleIndex = 2;
            // 
            // ThemDVTMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 128);
            this.Controls.Add(this.cb_MaMatHang);
            this.Controls.Add(this.bt_Luu);
            this.Controls.Add(this.bt_Huy);
            this.Controls.Add(this.cb_DVT);
            this.Controls.Add(this.spin_HeSo);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemDVTMH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Đơn Vị Tính Cho Mặt Hàng";
            this.Load += new System.EventHandler(this.ThemDVTMH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ThemDVTMH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.spin_HeSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_DVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditDVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cb_MaMatHang.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SpinEdit spin_HeSo;
        private DevExpress.XtraEditors.GridLookUpEdit cb_DVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEditDVT;
        private DevExpress.XtraEditors.SimpleButton bt_Huy;
        private DevExpress.XtraEditors.SimpleButton bt_Luu;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraEditors.GridLookUpEdit cb_MaMatHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnCodeItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnNameItem;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnIdItem;
    }
}