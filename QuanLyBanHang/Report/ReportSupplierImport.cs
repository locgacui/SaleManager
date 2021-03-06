using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportSupplierImport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportSupplierImport()
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
            lb_MaNCC.DataBindings.Add("Text", DataSource, "Code");
            lb_TenNCC.DataBindings.Add("Text", DataSource, "Name");
            lb_SoLuong.DataBindings.Add("Text", DataSource, "Quantily");
            lb_ThanhTien.DataBindings.Add("Text", DataSource, "AmountOrigin");
            lb_VAT.DataBindings.Add("Text", DataSource, "AmountVAT");
            lb_ThanhToan.DataBindings.Add("Text", DataSource, "Amount");

            lb_SumQuan.Text = SumQuan.ToString("#,#");
            lb_SumThanhTien.Text = SumThanhTien.ToString("#,#");
            lb_SumVAT.Text = SumVAT.ToString("#,#");
            lb_SumThanhToan.Text = SumThanhToan.ToString("#,#");
        }
    }
}
