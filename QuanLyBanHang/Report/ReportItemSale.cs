using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportItemSale : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportItemSale()
        {
            InitializeComponent();
        }

        private DateTime dateForm;
        private DateTime dateTo;
        private double sumQuan;
        private double sumThanhTien;
        private double sumCK;
        private double sumVAT;
        private double sumThanhToan;
        private double sumLoiNhuan;
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

        public double SumCK
        {
            get
            {
                return sumCK;
            }

            set
            {
                sumCK = value;
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

        public double SumLoiNhuan
        {
            get
            {
                return sumLoiNhuan;
            }

            set
            {
                sumLoiNhuan = value;
            }
        }

        public void LoadDate()
        {
            lb_ThoiGian.Text = "Từ ngày " + dateForm.ToString("dd/MM/yyyy") + " đến ngày " + dateTo.ToString("dd/MM/yyyy");
        }

        public void BindData()
        {
            lb_MaMatHang.DataBindings.Add("Text", DataSource, "Code");
            lb_TenMatHang.DataBindings.Add("Text", DataSource, "Name");
            lb_LoaiMatHang.DataBindings.Add("Text", DataSource, "NameGroupItem");
            lb_NhaCungCap.DataBindings.Add("Text", DataSource, "NameSupplier");
            lb_SoLuong.DataBindings.Add("Text", DataSource, "Quantily");
            lb_ThanhTien.DataBindings.Add("Text", DataSource, "AmountOrigin");
            lb_TienChietKhau.DataBindings.Add("Text", DataSource, "AmountDiscount");
            lb_VAT.DataBindings.Add("Text", DataSource, "AmountVAT");
            lb_DoanhThu.DataBindings.Add("Text", DataSource, "Amount");
            lb_LoiNhuan.DataBindings.Add("Text", DataSource, "Profit");

            lb_SumQuan.Text = sumQuan.ToString("#,#");
            lb_SumThanhTien.Text = sumThanhTien.ToString("#,#");
            lb_SumCK.Text = sumCK.ToString("#,#");
            lb_SumVAT.Text = SumVAT.ToString("#,#");
            lb_SumThanhToan.Text = sumThanhToan.ToString("#,#");
            lb_SumLoiNhuan.Text = sumLoiNhuan.ToString("#,#");
        }

    }
}
