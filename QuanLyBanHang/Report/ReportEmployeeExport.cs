using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportEmployeeExport : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportEmployeeExport()
        {
            InitializeComponent();
        }

        private DateTime dateForm;
        private DateTime dateTo;
        private double sumQuan;
        private double sumThanhTien;

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

        public void LoadDate()
        {
            lb_ThoiGian.Text = "Từ ngày " + dateForm.ToString("dd/MM/yyyy") + " đến ngày " + dateTo.ToString("dd/MM/yyyy");
        }

        public void BindData()
        {
            lb_MaNV.DataBindings.Add("Text", DataSource, "Code");
            lb_TenNhanVien.DataBindings.Add("Text", DataSource, "Name");
            lb_SoLuong.DataBindings.Add("Text", DataSource, "Quantily");
            lb_ThanhTien.DataBindings.Add("Text", DataSource, "AmountOrigin");

            lb_SumQuan.Text = sumQuan.ToString("#,#");
            lb_SumThanhTien.Text = sumThanhTien.ToString("#,#");
        }
    }
}
