namespace QuanLyBanHang.Report
{
    partial class ReportStockWarehouse
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
            this.lb_DonViTinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_TKDK = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_NKTK = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_XKTK = new DevExpress.XtraReports.UI.XRTableCell();
            this.lb_TKCK = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lb_Kho = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.lb_ThoiGian = new DevExpress.XtraReports.UI.XRLabel();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrControlStyle1 = new DevExpress.XtraReports.UI.XRControlStyle();
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
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.OddStyleName = "xrControlStyle1";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(969F, 25F);
            this.xrTable2.StylePriority.UseBorders = false;
            this.xrTable2.StylePriority.UseFont = false;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.lb_MaMatHang,
            this.lb_TenMatHang,
            this.lb_DonViTinh,
            this.lb_TKDK,
            this.lb_NKTK,
            this.lb_XKTK,
            this.lb_TKCK});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // lb_MaMatHang
            // 
            this.lb_MaMatHang.Multiline = true;
            this.lb_MaMatHang.Name = "lb_MaMatHang";
            this.lb_MaMatHang.Text = "Mã Mặt Hàng";
            this.lb_MaMatHang.Weight = 1D;
            // 
            // lb_TenMatHang
            // 
            this.lb_TenMatHang.Multiline = true;
            this.lb_TenMatHang.Name = "lb_TenMatHang";
            this.lb_TenMatHang.Text = "Tên Mặt Hàng";
            this.lb_TenMatHang.Weight = 1D;
            // 
            // lb_DonViTinh
            // 
            this.lb_DonViTinh.Multiline = true;
            this.lb_DonViTinh.Name = "lb_DonViTinh";
            this.lb_DonViTinh.Text = "Đơn Vị Tính";
            this.lb_DonViTinh.Weight = 0.69147794583756617D;
            // 
            // lb_TKDK
            // 
            this.lb_TKDK.Multiline = true;
            this.lb_TKDK.Name = "lb_TKDK";
            this.lb_TKDK.NullValueText = "0";
            this.lb_TKDK.StylePriority.UseTextAlignment = false;
            this.lb_TKDK.Text = "Tồn Kho Đầu Kỳ";
            this.lb_TKDK.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lb_TKDK.TextFormatString = "{0:#,#}";
            this.lb_TKDK.Weight = 1.150498538809541D;
            // 
            // lb_NKTK
            // 
            this.lb_NKTK.Multiline = true;
            this.lb_NKTK.Name = "lb_NKTK";
            this.lb_NKTK.NullValueText = "0";
            this.lb_NKTK.StylePriority.UseTextAlignment = false;
            this.lb_NKTK.Text = "Nhập Kho Trong Kỳ";
            this.lb_NKTK.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lb_NKTK.TextFormatString = "{0:#,#}";
            this.lb_NKTK.Weight = 1.1580235153528928D;
            // 
            // lb_XKTK
            // 
            this.lb_XKTK.Multiline = true;
            this.lb_XKTK.Name = "lb_XKTK";
            this.lb_XKTK.NullValueText = "0";
            this.lb_XKTK.StylePriority.UseTextAlignment = false;
            this.lb_XKTK.Text = "Xuất Kho Trong Kỳ";
            this.lb_XKTK.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lb_XKTK.TextFormatString = "{0:#,#}";
            this.lb_XKTK.Weight = 1D;
            // 
            // lb_TKCK
            // 
            this.lb_TKCK.Multiline = true;
            this.lb_TKCK.Name = "lb_TKCK";
            this.lb_TKCK.StylePriority.UseTextAlignment = false;
            this.lb_TKCK.Text = "Tồn Kho Cuối Kỳ";
            this.lb_TKCK.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.lb_TKCK.TextFormatString = "{0:#,#}";
            this.lb_TKCK.Weight = 1D;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lb_Kho,
            this.xrLabel1,
            this.lb_ThoiGian,
            this.xrTable1});
            this.ReportHeader.HeightF = 128.125F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lb_Kho
            // 
            this.lb_Kho.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.lb_Kho.LocationFloat = new DevExpress.Utils.PointFloat(298.0833F, 23.79169F);
            this.lb_Kho.Multiline = true;
            this.lb_Kho.Name = "lb_Kho";
            this.lb_Kho.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_Kho.SizeF = new System.Drawing.SizeF(347.9166F, 23F);
            this.lb_Kho.StylePriority.UseFont = false;
            this.lb_Kho.StylePriority.UseTextAlignment = false;
            this.lb_Kho.Text = "Kho";
            this.lb_Kho.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(969F, 23F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "BÁO CÁO TỒN KHO";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // lb_ThoiGian
            // 
            this.lb_ThoiGian.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lb_ThoiGian.LocationFloat = new DevExpress.Utils.PointFloat(298.0833F, 46.79168F);
            this.lb_ThoiGian.Multiline = true;
            this.lb_ThoiGian.Name = "lb_ThoiGian";
            this.lb_ThoiGian.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lb_ThoiGian.SizeF = new System.Drawing.SizeF(347.9167F, 24.04165F);
            this.lb_ThoiGian.StylePriority.UseFont = false;
            this.lb_ThoiGian.StylePriority.UseTextAlignment = false;
            this.lb_ThoiGian.Text = "(Từ trước đến nay)";
            this.lb_ThoiGian.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // xrTable1
            // 
            this.xrTable1.BackColor = System.Drawing.Color.Gray;
            this.xrTable1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrTable1.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 86.45834F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(969F, 41.66666F);
            this.xrTable1.StylePriority.UseBackColor = false;
            this.xrTable1.StylePriority.UseBorders = false;
            this.xrTable1.StylePriority.UseFont = false;
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.xrTableCell1,
            this.xrTableCell2,
            this.xrTableCell5,
            this.xrTableCell3,
            this.xrTableCell4,
            this.xrTableCell6,
            this.xrTableCell7});
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
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Đơn Vị Tính";
            this.xrTableCell5.Weight = 0.69147750492312465D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Tồn Kho Đầu Kỳ";
            this.xrTableCell3.Weight = 1.1504989797239826D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Nhập Kho Trong Kỳ";
            this.xrTableCell4.Weight = 1.1580235153528928D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "Xuất Kho Trong Kỳ";
            this.xrTableCell6.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Tồn Kho Cuối Kỳ";
            this.xrTableCell7.Weight = 1D;
            // 
            // xrControlStyle1
            // 
            this.xrControlStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.xrControlStyle1.Name = "xrControlStyle1";
            this.xrControlStyle1.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // ReportStockWarehouse
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
        private DevExpress.XtraReports.UI.XRLabel lb_Kho;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLabel lb_ThoiGian;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell lb_MaMatHang;
        private DevExpress.XtraReports.UI.XRTableCell lb_TenMatHang;
        private DevExpress.XtraReports.UI.XRTableCell lb_TKDK;
        private DevExpress.XtraReports.UI.XRTableCell lb_NKTK;
        private DevExpress.XtraReports.UI.XRTableCell lb_XKTK;
        private DevExpress.XtraReports.UI.XRTableCell lb_TKCK;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRTableCell lb_DonViTinh;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
    }
}
