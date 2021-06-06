using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportStockWarehouse : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportStockWarehouse()
        {
            InitializeComponent();
        }
        private DateTime dateForm;
        private DateTime dateTo;
        private string Kho;

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

        public string Kho1
        {
            get
            {
                return Kho;
            }

            set
            {
                Kho = value;
            }
        }

        public void LoadDate()
        {
            lb_Kho.Text = "Kho: " + Kho;
            lb_ThoiGian.Text = "Tháng: " + dateForm.ToString("MM/yyyy");
        }

        public void BindData()
        {
            lb_MaMatHang.DataBindings.Add("Text", DataSource, "CodeItem");
            lb_TenMatHang.DataBindings.Add("Text", DataSource, "NameItem");
            lb_DonViTinh.DataBindings.Add("Text", DataSource, "NameUnit");
            lb_TKDK.DataBindings.Add("Text", DataSource, "TKDK");
            lb_NKTK.DataBindings.Add("Text", DataSource, "NKTK");
            lb_XKTK.DataBindings.Add("Text", DataSource, "XKTK");
            lb_TKCK.DataBindings.Add("Text", DataSource, "TKCk");
        }
    }
}
