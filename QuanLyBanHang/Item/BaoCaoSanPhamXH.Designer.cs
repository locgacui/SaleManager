﻿namespace QuanLyBanHang
{
    partial class BaoCaoSanPhamXH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaoCaoSanPhamXH));
            this.gC_BaoCao = new DevExpress.XtraGrid.GridControl();
            this.gV_BaoCao = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Naame = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameGroupItem = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameSupplier = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Quantily = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Amount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.bt_XuatBaoCao = new DevExpress.XtraEditors.SimpleButton();
            this.date_DenNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_All = new DevExpress.XtraEditors.SimpleButton();
            this.date_TuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gC_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_BaoCao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_DenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_DenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_TuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_TuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gC_BaoCao
            // 
            this.gC_BaoCao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gC_BaoCao.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gC_BaoCao.Location = new System.Drawing.Point(0, 37);
            this.gC_BaoCao.MainView = this.gV_BaoCao;
            this.gC_BaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gC_BaoCao.Name = "gC_BaoCao";
            this.gC_BaoCao.Size = new System.Drawing.Size(968, 451);
            this.gC_BaoCao.TabIndex = 6;
            this.gC_BaoCao.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gV_BaoCao});
            // 
            // gV_BaoCao
            // 
            this.gV_BaoCao.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id,
            this.col_Code,
            this.col_Naame,
            this.col_NameGroupItem,
            this.col_NameSupplier,
            this.col_Quantily,
            this.col_Amount});
            this.gV_BaoCao.DetailHeight = 284;
            this.gV_BaoCao.GridControl = this.gC_BaoCao;
            this.gV_BaoCao.Name = "gV_BaoCao";
            this.gV_BaoCao.OptionsBehavior.Editable = false;
            this.gV_BaoCao.OptionsView.ShowFooter = true;
            // 
            // col_Id
            // 
            this.col_Id.Caption = "Id";
            this.col_Id.FieldName = "Id";
            this.col_Id.MinWidth = 21;
            this.col_Id.Name = "col_Id";
            this.col_Id.OptionsColumn.AllowShowHide = false;
            this.col_Id.Width = 81;
            // 
            // col_Code
            // 
            this.col_Code.Caption = "Mã Mặt Hàng";
            this.col_Code.FieldName = "Code";
            this.col_Code.MinWidth = 21;
            this.col_Code.Name = "col_Code";
            this.col_Code.Visible = true;
            this.col_Code.VisibleIndex = 0;
            this.col_Code.Width = 81;
            // 
            // col_Naame
            // 
            this.col_Naame.Caption = "Tên Mặt Hàng";
            this.col_Naame.FieldName = "Name";
            this.col_Naame.MinWidth = 21;
            this.col_Naame.Name = "col_Naame";
            this.col_Naame.Visible = true;
            this.col_Naame.VisibleIndex = 1;
            this.col_Naame.Width = 81;
            // 
            // col_NameGroupItem
            // 
            this.col_NameGroupItem.Caption = "Loại Mặt Hàng";
            this.col_NameGroupItem.FieldName = "NameGroupItem";
            this.col_NameGroupItem.MinWidth = 21;
            this.col_NameGroupItem.Name = "col_NameGroupItem";
            this.col_NameGroupItem.Visible = true;
            this.col_NameGroupItem.VisibleIndex = 2;
            this.col_NameGroupItem.Width = 81;
            // 
            // col_NameSupplier
            // 
            this.col_NameSupplier.Caption = "Nhà Cung Cấp";
            this.col_NameSupplier.FieldName = "NameSupplier";
            this.col_NameSupplier.MinWidth = 21;
            this.col_NameSupplier.Name = "col_NameSupplier";
            this.col_NameSupplier.Visible = true;
            this.col_NameSupplier.VisibleIndex = 3;
            this.col_NameSupplier.Width = 81;
            // 
            // col_Quantily
            // 
            this.col_Quantily.Caption = "Số Lượng";
            this.col_Quantily.DisplayFormat.FormatString = "#,#";
            this.col_Quantily.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Quantily.FieldName = "Quantily";
            this.col_Quantily.MinWidth = 21;
            this.col_Quantily.Name = "col_Quantily";
            this.col_Quantily.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantily", "Tổng Số Lượng={0:#,#}")});
            this.col_Quantily.Visible = true;
            this.col_Quantily.VisibleIndex = 4;
            this.col_Quantily.Width = 81;
            // 
            // col_Amount
            // 
            this.col_Amount.Caption = "Thành Tiền";
            this.col_Amount.DisplayFormat.FormatString = "#,#";
            this.col_Amount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Amount.FieldName = "Amount";
            this.col_Amount.MinWidth = 21;
            this.col_Amount.Name = "col_Amount";
            this.col_Amount.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Tổng Thành Tiền={0:#,#}")});
            this.col_Amount.Visible = true;
            this.col_Amount.VisibleIndex = 5;
            this.col_Amount.Width = 81;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.bt_XuatBaoCao);
            this.panelControl1.Controls.Add(this.date_DenNgay);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.bt_All);
            this.panelControl1.Controls.Add(this.date_TuNgay);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(968, 37);
            this.panelControl1.TabIndex = 5;
            // 
            // bt_XuatBaoCao
            // 
            this.bt_XuatBaoCao.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_XuatBaoCao.ImageOptions.Image")));
            this.bt_XuatBaoCao.Location = new System.Drawing.Point(668, 5);
            this.bt_XuatBaoCao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_XuatBaoCao.Name = "bt_XuatBaoCao";
            this.bt_XuatBaoCao.Size = new System.Drawing.Size(103, 24);
            this.bt_XuatBaoCao.TabIndex = 14;
            this.bt_XuatBaoCao.Text = "Xuất Báo Cáo";
            this.bt_XuatBaoCao.Click += new System.EventHandler(this.bt_XuatBaoCao_Click);
            // 
            // date_DenNgay
            // 
            this.date_DenNgay.EditValue = null;
            this.date_DenNgay.Location = new System.Drawing.Point(403, 7);
            this.date_DenNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_DenNgay.Name = "date_DenNgay";
            this.date_DenNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_DenNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_DenNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_DenNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_DenNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_DenNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_DenNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_DenNgay.Size = new System.Drawing.Size(172, 20);
            this.date_DenNgay.TabIndex = 9;
            this.date_DenNgay.EditValueChanged += new System.EventHandler(this.date_DenNgay_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(315, 10);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(54, 13);
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Đến Ngày";
            // 
            // bt_All
            // 
            this.bt_All.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_All.ImageOptions.Image")));
            this.bt_All.Location = new System.Drawing.Point(581, 5);
            this.bt_All.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_All.Name = "bt_All";
            this.bt_All.Size = new System.Drawing.Size(81, 24);
            this.bt_All.TabIndex = 11;
            this.bt_All.Text = "Tất Cả";
            this.bt_All.Click += new System.EventHandler(this.bt_All_Click);
            // 
            // date_TuNgay
            // 
            this.date_TuNgay.EditValue = null;
            this.date_TuNgay.Location = new System.Drawing.Point(98, 7);
            this.date_TuNgay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.date_TuNgay.Name = "date_TuNgay";
            this.date_TuNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_TuNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_TuNgay.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.date_TuNgay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_TuNgay.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.date_TuNgay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.date_TuNgay.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.date_TuNgay.Size = new System.Drawing.Size(172, 20);
            this.date_TuNgay.TabIndex = 8;
            this.date_TuNgay.EditValueChanged += new System.EventHandler(this.date_TuNgay_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(10, 10);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Từ Ngày";
            // 
            // BaoCaoSanPhamXH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 488);
            this.Controls.Add(this.gC_BaoCao);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "BaoCaoSanPhamXH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo Cáo Xuất Hàng Theo Sản Phẩm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaoCaoSanPhamXH_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BaoCaoSanPhamXH_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.gC_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gV_BaoCao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_DenNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_DenNgay.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_TuNgay.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_TuNgay.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gC_BaoCao;
        private DevExpress.XtraGrid.Views.Grid.GridView gV_BaoCao;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id;
        private DevExpress.XtraGrid.Columns.GridColumn col_Code;
        private DevExpress.XtraGrid.Columns.GridColumn col_Naame;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameGroupItem;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameSupplier;
        private DevExpress.XtraGrid.Columns.GridColumn col_Quantily;
        private DevExpress.XtraGrid.Columns.GridColumn col_Amount;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit date_DenNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_All;
        private DevExpress.XtraEditors.DateEdit date_TuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton bt_XuatBaoCao;
    }
}