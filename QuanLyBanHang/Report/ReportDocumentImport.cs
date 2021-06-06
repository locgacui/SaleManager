using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDocumentImport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDocumentImport()
        {
            InitializeComponent();
        }

        private DateTime dateForm;
        private DateTime dateTo;
        private double sumQuan;
        private double sumThanhTien;
        private double sumVAT;
        private double sumThanhToan;
        public DateTime DateForm
        {
            get
            {
                return dateForm;
            }

            set
            {
                dateForm = value;
            }
        }

        public DateTime DateTo
        {
            get
            {
                return dateTo;
            }

            set
            {
                dateTo = value;
            }
        }

        public double SumQuan
        {
            get
            {
                return sumQuan;
            }

            set
            {
                sumQuan = value;
            }
        }

        public double SumThanhTien
        {
            get
            {
                return sumThanhTien;
            }

            set
            {
                sumThanhTien = value;
            }
        }

        public double SumVAT
        {
            get
            {
                return sumVAT;
            }

            set
            {
                sumVAT = value;
            }
        }

        public double SumThanhToan
        {
            get
            {
                return sumThanhToan;
            }

            set
            {
                sumThanhToan = value;
            }
        }

        public void LoadDate()
        {
            lb_ThoiGian.Text = "Từ ngày " + dateForm.ToString("dd/MM/yyyy") + " đến ngày " + dateTo.ToString("dd/MM/yyyy");
        }

        public void BindData()
        {
            lb_NgayLap.DataBindings.Add("Text", DataSource, "Date").FormatString = "{0:dd/MM/yyyy}";
            lb_MaPhieuXuat.DataBindings.Add("Text", DataSource, "Code");
            lb_NhanVienLap.DataBindings.Add("Text", DataSource, "NameEmployee");
            lb_KhoNhap.DataBindings.Add("Text", DataSource, "NameWarehouse");
            lb_SoLuong.DataBindings.Add("Text", DataSource, "Quantily");
            lb_ThanhTien.DataBindings.Add("Text", DataSource, "AmountOrigin");
            lb_NhaCungCap.DataBindings.Add("Text", DataSource, "NameSupplier");
            lb_VAT.DataBindings.Add("Text", DataSource, "AmountVAT");
            lb_ThanhToan.DataBindings.Add("Text", DataSource, "Amount");

            lb_SumQuan.Text = sumQuan.ToString("#,#");
            lb_SumThanhTien.Text = sumThanhTien.ToString("#,#");
            lb_SumVAT.Text = SumVAT.ToString("#,#");
            lb_SumThanhToan.Text = sumThanhToan.ToString("#,#");
        }
    }
}
