namespace QuanLyBanHang.Report
{
    partial class ReportDanhSachMatHang
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable2 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
            this.lb_MaMatHang = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_TenMatHang = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_NhomHang = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_NhaCungCap = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_GiaNhap = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_VAT = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.lb_ThoiGian = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable2});
            this.Detail.HeightF = 51.66667F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.BackColor = System.Drawing.Color.Transparent;
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(6.357829E-05F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.OddStyleName = "xrControlStyle1";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(968.9999F, 51.16665F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lb_MaMatHang,
            this.lb_TenMatHang,
            this.lb_NhomHang,
            this.lb_NhaCungCap,
            this.lb_GiaNhap,
            this.lb_VAT});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // lb_MaMatHang
            // 
            this.lb_MaMatHang.Multiline = true;
            this.lb_MaMatHang.Name = "lb_MaMatHang";
            this.lb_MaMatHang.StylePriority.UseTextAlignment = false;
            this.lb_MaMatHang.Text = "Mã Mặt Hàng";
            this.lb_MaMatHang.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.lb_MaMatHang.Weight = 1D;
            // 
            // lb_TenMatHang
            // 
            this.lb_TenMatHang.Multiline = true;
            this.lb_TenMatHang.Name = "lb_TenMatHang";
            this.lb_TenMatHang.Text = "Tên Mặt Hàng";
            this.lb_TenMatHang.Weight = 2.1506708356179525D;
            // 
            // lb_NhomHang
            // 
            this.lb_NhomHang.Multiline = true;
            this.lb_NhomHang.Name = "lb_NhomHang";
            this.lb_NhomHang.Text = "Nhóm Hàng";
            this.lb_NhomHang.Weight = 0.587202827584491D;
            // 
            // lb_NhaCungCap
            // 
            this.lb_NhaCungCap.Multiline = true;
            this.lb_NhaCungCap.Name = "lb_NhaCungCap";
            this.lb_NhaCungCap.Text = "Nhà Cung Cấp";
            this.lb_NhaCungCap.TextFormatString = "{0}";
            this.lb_NhaCungCap.Weight = 0.710182802769485D;
            // 
            // lb_GiaNhap
            // 
            this.lb_GiaNhap.Multiline = true;
            this.lb_GiaNhap.Name = "lb_GiaNhap";
            this.lb_GiaNhap.Text = "Giá Nhập";
            this.lb_GiaNhap.TextFormatString = "{0:#,#}";
            this.lb_GiaNhap.Weight = 0.82886084589826581D;
            // 
            // lb_VAT
            // 
            this.lb_VAT.Multiline = true;
            this.lb_VAT.Name = "lb_VAT";
            this.lb_VAT.Text = "VAT";
            this.lb_VAT.TextFormatString = "{0}%";
            this.lb_VAT.Weight = 0.72308268812980558D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lb_ThoiGian,
            this.xrTable1,
            this.xrLabel1});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.Gray;
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 48.83334F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(968.9999F, 51.16665F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseFont = false;
            this.xrTable1.StylePriority.UseTextAlignment = false;
            this.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell4,
            this.xrTableCell3,
            this.xrTableCell5,
            this.xrTableCell6});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Mã Mặt Hàng";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Tên Mặt Hàng";
            this.xrTableCell2.Weight = 2.1506708356179525D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Nhóm Hàng";
            this.xrTableCell4.Weight = 0.587202827584491D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Nhà Cung Cấp";
            this.xrTableCell3.Weight = 0.710182802769485D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Giá Nhập";
            this.xrTableCell5.Weight = 0.82886084589826581D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "VAT";
            this.xrTableCell6.Weight = 0.72308268812980558D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.AutoWidth = true;
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(968.9999F, 22.99999F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "DANH SÁCH MẶT HÀNG";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lb_ThoiGian.LocationFloat = new DevExpress.Utils.PointFloat(0F, 22.99999F);
            this.lb_ThoiGian.Multiline = true;
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_ThoiGian.SizeF = new System.Drawing.SizeF(968.9999F, 25.83335F);
            this.lb_ThoiGian.StylePriority.UseFont = false;
            this.lb_ThoiGian.StylePriority.UseTextAlignment = false;
            this.lb_ThoiGian.Text = "lb_ThoiGian";
            this.lb_ThoiGian.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportDanhSachMatHang
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.Detail,
            this.ReportHeader});
            this.Font = new System.Drawing.Font("Arial", 9.75F);
            this.Landscape = true;
            this.PageHeight = 827;
            this.PageWidth = 1169;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.xrControlStyle1});
            this.Version = "19.1";
            ((System.ComponentModel.ISupportInitialize)(this.xrTable2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell lb_MaMatHang;
        private DevExpress.XtraReports.UI.XRTableCell lb_TenMatHang;
        private DevExpress.XtraReports.UI.XRTableCell lb_NhomHang;
        private DevExpress.XtraReports.UI.XRTableCell lb_NhaCungCap;
        private DevExpress.XtraReports.UI.XRTableCell lb_GiaNhap;
        private DevExpress.XtraReports.UI.XRTableCell lb_VAT;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRLabel lb_ThoiGian;
    }
}
