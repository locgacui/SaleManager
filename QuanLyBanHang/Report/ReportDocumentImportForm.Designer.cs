namespace QuanLyBanHang.Report
{
    partial class ReportDocumentImportForm
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
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportDocumentImportForm));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.col_Amount_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gc_DocDetail = new DevExpress.XtraGrid.GridControl();
            this.gv_DocDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CodeItem_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameItem_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameUnit_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Quantily_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Price_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AmountOrigin_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_VAT_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AmountVAT_DocDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gc_Document = new DevExpress.XtraGrid.GridControl();
            this.gv_Document = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_Id_Document = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Date_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Code_Document = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CodeEmployee_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameEmployee_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CodeSupplier_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameSupplier_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_CodeCustomer_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_NameCustomer_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Amount_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bt_XuatPhieu = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.date_DenNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.bt_All = new DevExpress.XtraEditors.SimpleButton();
            this.date_TuNgay = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.col_Quantily_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AmountOrigin_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_AmountVAT_Doc = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_DocDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DocDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Document)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_XuatPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_DenNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_DenNgay.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_TuNgay.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_TuNgay.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // col_Amount_DocDetail
            // 
            this.col_Amount_DocDetail.Caption = "Thanh Toán";
            this.col_Amount_DocDetail.FieldName = "Amount";
            this.col_Amount_DocDetail.Name = "col_Amount_DocDetail";
            this.col_Amount_DocDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Tổng Thanh Toán={0:0.##}")});
            this.col_Amount_DocDetail.Visible = true;
            this.col_Amount_DocDetail.VisibleIndex = 8;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 21.3F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 38.7F)});
            this.tablePanel1.Controls.Add(this.groupControl3);
            this.tablePanel1.Controls.Add(this.groupControl2);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(2, 2);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1213, 741);
            this.tablePanel1.TabIndex = 11;
            // 
            // groupControl3
            // 
            this.groupControl3.CaptionImageOptions.Image = global::QuanLyBanHang.Properties.Resources.productsalesreport_16x16;
            this.tablePanel1.SetColumn(this.groupControl3, 1);
            this.groupControl3.Controls.Add(this.gc_DocDetail);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(434, 3);
            this.groupControl3.Name = "groupControl3";
            this.tablePanel1.SetRow(this.groupControl3, 0);
            this.groupControl3.Size = new System.Drawing.Size(776, 735);
            this.groupControl3.TabIndex = 13;
            this.groupControl3.Text = "Chi Tiết Hóa Đơn";
            // 
            // gc_DocDetail
            // 
            this.gc_DocDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_DocDetail.Location = new System.Drawing.Point(2, 23);
            this.gc_DocDetail.MainView = this.gv_DocDetail;
            this.gc_DocDetail.Name = "gc_DocDetail";
            this.gc_DocDetail.Size = new System.Drawing.Size(772, 710);
            this.gc_DocDetail.TabIndex = 11;
            this.gc_DocDetail.UseEmbeddedNavigator = true;
            this.gc_DocDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_DocDetail});
            // 
            // gv_DocDetail
            // 
            this.gv_DocDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id_DocDetail,
            this.col_CodeItem_DocDetail,
            this.col_NameItem_DocDetail,
            this.col_NameUnit_DocDetail,
            this.col_Quantily_DocDetail,
            this.col_Price_DocDetail,
            this.col_AmountOrigin_DocDetail,
            this.col_VAT_DocDetail,
            this.col_AmountVAT_DocDetail,
            this.col_Amount_DocDetail});
            this.gv_DocDetail.GridControl = this.gc_DocDetail;
            this.gv_DocDetail.Name = "gv_DocDetail";
            this.gv_DocDetail.OptionsBehavior.Editable = false;
            this.gv_DocDetail.OptionsView.ShowFooter = true;
            // 
            // col_Id_DocDetail
            // 
            this.col_Id_DocDetail.Caption = "Id";
            this.col_Id_DocDetail.FieldName = "Id";
            this.col_Id_DocDetail.Name = "col_Id_DocDetail";
            this.col_Id_DocDetail.OptionsColumn.AllowShowHide = false;
            // 
            // col_CodeItem_DocDetail
            // 
            this.col_CodeItem_DocDetail.Caption = "Mã Mặt Hàng";
            this.col_CodeItem_DocDetail.FieldName = "CodeItem";
            this.col_CodeItem_DocDetail.Name = "col_CodeItem_DocDetail";
            this.col_CodeItem_DocDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "CodeItem", "Số Mặt Hàng: {0}")});
            this.col_CodeItem_DocDetail.Visible = true;
            this.col_CodeItem_DocDetail.VisibleIndex = 0;
            // 
            // col_NameItem_DocDetail
            // 
            this.col_NameItem_DocDetail.Caption = "Tên Mặt Hàng";
            this.col_NameItem_DocDetail.FieldName = "NameItem";
            this.col_NameItem_DocDetail.Name = "col_NameItem_DocDetail";
            this.col_NameItem_DocDetail.Visible = true;
            this.col_NameItem_DocDetail.VisibleIndex = 1;
            // 
            // col_NameUnit_DocDetail
            // 
            this.col_NameUnit_DocDetail.Caption = "ĐVT";
            this.col_NameUnit_DocDetail.FieldName = "NameUnit";
            this.col_NameUnit_DocDetail.Name = "col_NameUnit_DocDetail";
            this.col_NameUnit_DocDetail.Visible = true;
            this.col_NameUnit_DocDetail.VisibleIndex = 2;
            // 
            // col_Quantily_DocDetail
            // 
            this.col_Quantily_DocDetail.Caption = "Số Lượng";
            this.col_Quantily_DocDetail.DisplayFormat.FormatString = "#,#";
            this.col_Quantily_DocDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Quantily_DocDetail.FieldName = "Quantily";
            this.col_Quantily_DocDetail.Name = "col_Quantily_DocDetail";
            this.col_Quantily_DocDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Quantily", "Tổng Số Lượng={0:#,#}")});
            this.col_Quantily_DocDetail.Visible = true;
            this.col_Quantily_DocDetail.VisibleIndex = 3;
            // 
            // col_Price_DocDetail
            // 
            this.col_Price_DocDetail.Caption = "Đơn Giá";
            this.col_Price_DocDetail.DisplayFormat.FormatString = "#,#";
            this.col_Price_DocDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Price_DocDetail.FieldName = "Price";
            this.col_Price_DocDetail.Name = "col_Price_DocDetail";
            this.col_Price_DocDetail.Visible = true;
            this.col_Price_DocDetail.VisibleIndex = 4;
            // 
            // col_AmountOrigin_DocDetail
            // 
            this.col_AmountOrigin_DocDetail.Caption = "Thành Tiền";
            this.col_AmountOrigin_DocDetail.DisplayFormat.FormatString = "#,#";
            this.col_AmountOrigin_DocDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_AmountOrigin_DocDetail.FieldName = "AmountOrigin";
            this.col_AmountOrigin_DocDetail.Name = "col_AmountOrigin_DocDetail";
            this.col_AmountOrigin_DocDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountOrigin", "Tổng Thành Tiền={0:#,#}")});
            this.col_AmountOrigin_DocDetail.Visible = true;
            this.col_AmountOrigin_DocDetail.VisibleIndex = 5;
            // 
            // col_VAT_DocDetail
            // 
            this.col_VAT_DocDetail.Caption = "VAT";
            this.col_VAT_DocDetail.DisplayFormat.FormatString = "#.##\'%\'";
            this.col_VAT_DocDetail.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_VAT_DocDetail.FieldName = "VAT";
            this.col_VAT_DocDetail.Name = "col_VAT_DocDetail";
            this.col_VAT_DocDetail.Visible = true;
            this.col_VAT_DocDetail.VisibleIndex = 6;
            // 
            // col_AmountVAT_DocDetail
            // 
            this.col_AmountVAT_DocDetail.Caption = "Tiền Thuế";
            this.col_AmountVAT_DocDetail.FieldName = "AmountVAT";
            this.col_AmountVAT_DocDetail.Name = "col_AmountVAT_DocDetail";
            this.col_AmountVAT_DocDetail.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "AmountVAT", "Tổng Tiền Thuế={0:0.##}")});
            this.col_AmountVAT_DocDetail.Visible = true;
            this.col_AmountVAT_DocDetail.VisibleIndex = 7;
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.Image = global::QuanLyBanHang.Properties.Resources.productsalesreport_16x16;
            this.tablePanel1.SetColumn(this.groupControl2, 0);
            this.groupControl2.Controls.Add(this.gc_Document);
            buttonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("buttonImageOptions1.Image")));
            this.groupControl2.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Xuất Báo Cáo", true, buttonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", -1, true, null, true, false, true, null, -1)});
            this.groupControl2.CustomHeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(3, 3);
            this.groupControl2.Name = "groupControl2";
            this.tablePanel1.SetRow(this.groupControl2, 0);
            this.groupControl2.Size = new System.Drawing.Size(425, 735);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "Hóa Đơn";
            this.groupControl2.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControl2_CustomButtonClick);
            // 
            // gc_Document
            // 
            this.gc_Document.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_Document.Location = new System.Drawing.Point(2, 29);
            this.gc_Document.MainView = this.gv_Document;
            this.gc_Document.Name = "gc_Document";
            this.gc_Document.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.bt_XuatPhieu});
            this.gc_Document.Size = new System.Drawing.Size(421, 704);
            this.gc_Document.TabIndex = 10;
            this.gc_Document.UseEmbeddedNavigator = true;
            this.gc_Document.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_Document});
            // 
            // gv_Document
            // 
            this.gv_Document.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_Id_Document,
            this.col_Date_Doc,
            this.col_Code_Document,
            this.col_CodeEmployee_Doc,
            this.col_NameEmployee_Doc,
            this.col_CodeSupplier_Doc,
            this.col_NameSupplier_Doc,
            this.col_CodeCustomer_Doc,
            this.col_NameCustomer_Doc,
            this.col_Amount_Doc,
            this.gridColumn1,
            this.col_Quantily_Doc,
            this.col_AmountOrigin_Doc,
            this.col_AmountVAT_Doc});
            this.gv_Document.GridControl = this.gc_Document;
            this.gv_Document.Name = "gv_Document";
            this.gv_Document.OptionsView.ShowFooter = true;
            this.gv_Document.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_Document_FocusedRowChanged);
            // 
            // col_Id_Document
            // 
            this.col_Id_Document.Caption = "Id";
            this.col_Id_Document.FieldName = "Id";
            this.col_Id_Document.Name = "col_Id_Document";
            this.col_Id_Document.OptionsColumn.AllowShowHide = false;
            // 
            // col_Date_Doc
            // 
            this.col_Date_Doc.Caption = "Ngày Lập";
            this.col_Date_Doc.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.col_Date_Doc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_Date_Doc.FieldName = "Date";
            this.col_Date_Doc.Name = "col_Date_Doc";
            this.col_Date_Doc.OptionsColumn.AllowEdit = false;
            this.col_Date_Doc.OptionsColumn.ReadOnly = true;
            this.col_Date_Doc.Visible = true;
            this.col_Date_Doc.VisibleIndex = 0;
            // 
            // col_Code_Document
            // 
            this.col_Code_Document.Caption = "Mã Hóa Đơn";
            this.col_Code_Document.FieldName = "Code";
            this.col_Code_Document.Name = "col_Code_Document";
            this.col_Code_Document.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "Code", "Số Hóa Đơn: {0}")});
            this.col_Code_Document.Visible = true;
            this.col_Code_Document.VisibleIndex = 1;
            // 
            // col_CodeEmployee_Doc
            // 
            this.col_CodeEmployee_Doc.Caption = "Mã Nhân Viên Lập";
            this.col_CodeEmployee_Doc.FieldName = "CodeEmployee";
            this.col_CodeEmployee_Doc.Name = "col_CodeEmployee_Doc";
            // 
            // col_NameEmployee_Doc
            // 
            this.col_NameEmployee_Doc.Caption = "Tên Nhân Viên Lập";
            this.col_NameEmployee_Doc.FieldName = "NameEmployee";
            this.col_NameEmployee_Doc.Name = "col_NameEmployee_Doc";
            this.col_NameEmployee_Doc.Visible = true;
            this.col_NameEmployee_Doc.VisibleIndex = 2;
            // 
            // col_CodeSupplier_Doc
            // 
            this.col_CodeSupplier_Doc.Caption = "Mã NCC";
            this.col_CodeSupplier_Doc.FieldName = "CodeSupplier";
            this.col_CodeSupplier_Doc.Name = "col_CodeSupplier_Doc";
            // 
            // col_NameSupplier_Doc
            // 
            this.col_NameSupplier_Doc.Caption = "Nhà Cung Cấp";
            this.col_NameSupplier_Doc.FieldName = "NameSupplier";
            this.col_NameSupplier_Doc.Name = "col_NameSupplier_Doc";
            this.col_NameSupplier_Doc.Visible = true;
            this.col_NameSupplier_Doc.VisibleIndex = 3;
            // 
            // col_CodeCustomer_Doc
            // 
            this.col_CodeCustomer_Doc.Caption = "Mã Kho Nhập";
            this.col_CodeCustomer_Doc.FieldName = "CodeWarehouse";
            this.col_CodeCustomer_Doc.Name = "col_CodeCustomer_Doc";
            // 
            // col_NameCustomer_Doc
            // 
            this.col_NameCustomer_Doc.Caption = "Tên Kho Nhập";
            this.col_NameCustomer_Doc.FieldName = "NameWarehouse";
            this.col_NameCustomer_Doc.Name = "col_NameCustomer_Doc";
            this.col_NameCustomer_Doc.Visible = true;
            this.col_NameCustomer_Doc.VisibleIndex = 4;
            // 
            // col_Amount_Doc
            // 
            this.col_Amount_Doc.Caption = "Thanh Toán";
            this.col_Amount_Doc.DisplayFormat.FormatString = "#,#";
            this.col_Amount_Doc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.col_Amount_Doc.FieldName = "Amount";
            this.col_Amount_Doc.Name = "col_Amount_Doc";
            this.col_Amount_Doc.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "Tổng Thanh Toán={0:#,#}")});
            this.col_Amount_Doc.Visible = true;
            this.col_Amount_Doc.VisibleIndex = 5;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Xuất Phiếu";
            this.gridColumn1.ColumnEdit = this.bt_XuatPhieu;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 6;
            // 
            // bt_XuatPhieu
            // 
            this.bt_XuatPhieu.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.bt_XuatPhieu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.bt_XuatPhieu.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_XuatPhieu.ContextImageOptions.Image")));
            this.bt_XuatPhieu.Name = "bt_XuatPhieu";
            this.bt_XuatPhieu.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.bt_XuatPhieu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.bt_XuatPhieu_ButtonClick);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.tablePanel1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 37);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.ShowCaption = false;
            this.groupControl1.Size = new System.Drawing.Size(1217, 745);
            this.groupControl1.TabIndex = 13;
            this.groupControl1.Text = "groupControl1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.date_DenNgay);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.bt_All);
            this.panelControl1.Controls.Add(this.date_TuNgay);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1217, 37);
            this.panelControl1.TabIndex = 12;
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
            // col_Quantily_Doc
            // 
            this.col_Quantily_Doc.Caption = "Số Lượng";
            this.col_Quantily_Doc.FieldName = "Quantily";
            this.col_Quantily_Doc.Name = "col_Quantily_Doc";
            this.col_Quantily_Doc.OptionsColumn.AllowShowHide = false;
            // 
            // col_AmountOrigin_Doc
            // 
            this.col_AmountOrigin_Doc.Caption = "Thành Tiền";
            this.col_AmountOrigin_Doc.FieldName = "AmountOrigin";
            this.col_AmountOrigin_Doc.Name = "col_AmountOrigin_Doc";
            this.col_AmountOrigin_Doc.OptionsColumn.AllowShowHide = false;
            // 
            // col_AmountVAT_Doc
            // 
            this.col_AmountVAT_Doc.Caption = "VAT";
            this.col_AmountVAT_Doc.FieldName = "AmountVAT";
            this.col_AmountVAT_Doc.Name = "col_AmountVAT_Doc";
            this.col_AmountVAT_Doc.OptionsColumn.AllowShowHide = false;
            // 
            // ReportDocumentImportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 782);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "ReportDocumentImportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Nhập Hàng Theo Phiếu Nhập Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReportDocumentImportForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ReportDocumentImportForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_DocDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_DocDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Document)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bt_XuatPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
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

        private DevExpress.XtraGrid.Columns.GridColumn col_Amount_DocDetail;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gc_DocDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_CodeItem_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameItem_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameUnit_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_Quantily_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_Price_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_AmountOrigin_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_VAT_DocDetail;
        private DevExpress.XtraGrid.Columns.GridColumn col_AmountVAT_DocDetail;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gc_Document;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_Document;
        private DevExpress.XtraGrid.Columns.GridColumn col_Id_Document;
        private DevExpress.XtraGrid.Columns.GridColumn col_Date_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_Code_Document;
        private DevExpress.XtraGrid.Columns.GridColumn col_CodeEmployee_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameEmployee_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_CodeCustomer_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameCustomer_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_Amount_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit bt_XuatPhieu;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit date_DenNgay;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton bt_All;
        private DevExpress.XtraEditors.DateEdit date_TuNgay;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn col_CodeSupplier_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_NameSupplier_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_Quantily_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_AmountOrigin_Doc;
        private DevExpress.XtraGrid.Columns.GridColumn col_AmountVAT_Doc;
    }
}