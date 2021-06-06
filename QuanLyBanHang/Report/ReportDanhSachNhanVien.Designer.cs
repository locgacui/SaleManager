namespace QuanLyBanHang.Report
{
    partial class ReportDanhSachNhanVien
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
            this.tb_MaNV = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_TenNV = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_NgaySinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_GioiTinh = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_ChucVu = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_CMND = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_DiaChi = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_DienThoai = new DevExpress.XtraReports.UI.XRTableCell();
            this.tb_Email = new DevExpress.XtraReports.UI.XRTableCell();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.xrTableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell2 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell4 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
            this.xrTableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
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
            this.Detail.HeightF = 44.50002F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            // 
            // xrTable2
            // 
            this.xrTable2.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.xrTable2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrTable2.Name = "xrTable2";
            this.xrTable2.OddStyleName = "xrControlStyle1";
            this.xrTable2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
            this.xrTable2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow2});
            this.xrTable2.SizeF = new System.Drawing.SizeF(969.0001F, 44.50002F);
            this.xrTable2.StylePriority.UseFont = false;
            this.xrTable2.StylePriority.UseTextAlignment = false;
            this.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTableRow2
            // 
            this.xrTableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tb_MaNV,
            this.tb_TenNV,
            this.tb_NgaySinh,
            this.tb_GioiTinh,
            this.tb_ChucVu,
            this.tb_CMND,
            this.tb_DiaChi,
            this.tb_DienThoai,
            this.tb_Email});
            this.xrTableRow2.Name = "xrTableRow2";
            this.xrTableRow2.Weight = 1D;
            // 
            // tb_MaNV
            // 
            this.tb_MaNV.Multiline = true;
            this.tb_MaNV.Name = "tb_MaNV";
            this.tb_MaNV.StylePriority.UseTextAlignment = false;
            this.tb_MaNV.Text = "Mã Nhân Viên";
            this.tb_MaNV.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.tb_MaNV.Weight = 1D;
            // 
            // tb_TenNV
            // 
            this.tb_TenNV.Multiline = true;
            this.tb_TenNV.Name = "tb_TenNV";
            this.tb_TenNV.Text = "Tên Nhân Viên";
            this.tb_TenNV.Weight = 1D;
            // 
            // tb_NgaySinh
            // 
            this.tb_NgaySinh.Multiline = true;
            this.tb_NgaySinh.Name = "tb_NgaySinh";
            this.tb_NgaySinh.StylePriority.UseTextAlignment = false;
            this.tb_NgaySinh.Text = "Ngày Sinh";
            this.tb_NgaySinh.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            this.tb_NgaySinh.Weight = 1D;
            // 
            // tb_GioiTinh
            // 
            this.tb_GioiTinh.Multiline = true;
            this.tb_GioiTinh.Name = "tb_GioiTinh";
            this.tb_GioiTinh.Text = "Giới Tính";
            this.tb_GioiTinh.Weight = 0.71362235630079607D;
            // 
            // tb_ChucVu
            // 
            this.tb_ChucVu.Multiline = true;
            this.tb_ChucVu.Name = "tb_ChucVu";
            this.tb_ChucVu.Text = "Chức Vụ";
            this.tb_ChucVu.Weight = 1.286377643699204D;
            // 
            // tb_CMND
            // 
            this.tb_CMND.Multiline = true;
            this.tb_CMND.Name = "tb_CMND";
            this.tb_CMND.Text = "CMND";
            this.tb_CMND.Weight = 1D;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Multiline = true;
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Text = "Địa Chỉ";
            this.tb_DiaChi.Weight = 1D;
            // 
            // tb_DienThoai
            // 
            this.tb_DienThoai.Multiline = true;
            this.tb_DienThoai.Name = "tb_DienThoai";
            this.tb_DienThoai.StylePriority.UseTextAlignment = false;
            this.tb_DienThoai.Text = "Điện Thoại";
            this.tb_DienThoai.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.tb_DienThoai.Weight = 1D;
            // 
            // tb_Email
            // 
            this.tb_Email.Multiline = true;
            this.tb_Email.Name = "tb_Email";
            this.tb_Email.Text = "Email";
            this.tb_Email.Weight = 1D;
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
            this.xrTable1.SizeF = new System.Drawing.SizeF(969F, 51.16666F);
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
            this.xrTableCell6,
            this.xrTableCell7,
            this.xrTableCell8,
            this.xrTableCell9});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // xrTableCell1
            // 
            this.xrTableCell1.Multiline = true;
            this.xrTableCell1.Name = "xrTableCell1";
            this.xrTableCell1.Text = "Mã Nhân Viên";
            this.xrTableCell1.Weight = 1D;
            // 
            // xrTableCell2
            // 
            this.xrTableCell2.Multiline = true;
            this.xrTableCell2.Name = "xrTableCell2";
            this.xrTableCell2.Text = "Tên Nhân Viên";
            this.xrTableCell2.Weight = 1D;
            // 
            // xrTableCell4
            // 
            this.xrTableCell4.Multiline = true;
            this.xrTableCell4.Name = "xrTableCell4";
            this.xrTableCell4.Text = "Ngày Sinh";
            this.xrTableCell4.Weight = 1D;
            // 
            // xrTableCell3
            // 
            this.xrTableCell3.Multiline = true;
            this.xrTableCell3.Name = "xrTableCell3";
            this.xrTableCell3.Text = "Giới Tính";
            this.xrTableCell3.Weight = 0.71362240912375441D;
            // 
            // xrTableCell5
            // 
            this.xrTableCell5.Multiline = true;
            this.xrTableCell5.Name = "xrTableCell5";
            this.xrTableCell5.Text = "Chức Vụ";
            this.xrTableCell5.Weight = 1.2863775908762456D;
            // 
            // xrTableCell6
            // 
            this.xrTableCell6.Multiline = true;
            this.xrTableCell6.Name = "xrTableCell6";
            this.xrTableCell6.Text = "CMND";
            this.xrTableCell6.Weight = 1D;
            // 
            // xrTableCell7
            // 
            this.xrTableCell7.Multiline = true;
            this.xrTableCell7.Name = "xrTableCell7";
            this.xrTableCell7.Text = "Địa Chỉ";
            this.xrTableCell7.Weight = 1D;
            // 
            // xrTableCell8
            // 
            this.xrTableCell8.Multiline = true;
            this.xrTableCell8.Name = "xrTableCell8";
            this.xrTableCell8.Text = "Điện Thoại";
            this.xrTableCell8.Weight = 1D;
            // 
            // xrTableCell9
            // 
            this.xrTableCell9.Multiline = true;
            this.xrTableCell9.Name = "xrTableCell9";
            this.xrTableCell9.Text = "Email";
            this.xrTableCell9.Weight = 1D;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.xrLabel1.Multiline = true;
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(968.9999F, 22.99999F);
            this.xrLabel1.StylePriority.UseFont = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "DANH SÁCH NHÂN VIÊN";
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
            this.lb_ThoiGian.SizeF = new System.Drawing.SizeF(969F, 24.04165F);
            this.lb_ThoiGian.StylePriority.UseFont = false;
            this.lb_ThoiGian.StylePriority.UseTextAlignment = false;
            this.lb_ThoiGian.Text = "lb_ThoiGian";
            this.lb_ThoiGian.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // ReportDanhSachNhanVien
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
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell2;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell3;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell4;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell5;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell6;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell7;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell8;
        private DevExpress.XtraReports.UI.XRTableCell xrTableCell9;
        private DevExpress.XtraReports.UI.XRTable xrTable2;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow2;
        private DevExpress.XtraReports.UI.XRTableCell tb_MaNV;
        private DevExpress.XtraReports.UI.XRTableCell tb_TenNV;
        private DevExpress.XtraReports.UI.XRTableCell tb_NgaySinh;
        private DevExpress.XtraReports.UI.XRTableCell tb_GioiTinh;
        private DevExpress.XtraReports.UI.XRTableCell tb_ChucVu;
        private DevExpress.XtraReports.UI.XRTableCell tb_CMND;
        private DevExpress.XtraReports.UI.XRTableCell tb_DiaChi;
        private DevExpress.XtraReports.UI.XRTableCell tb_DienThoai;
        private DevExpress.XtraReports.UI.XRTableCell tb_Email;
        private DevExpress.XtraReports.UI.XRControlStyle xrControlStyle1;
        private DevExpress.XtraReports.UI.XRLabel lb_ThoiGian;
    }
}
