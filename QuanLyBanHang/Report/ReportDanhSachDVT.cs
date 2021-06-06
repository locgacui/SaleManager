using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachDVT : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachDVT()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaDonViTinh.DataBindings.Add("Text", DataSource, "Code");
            lb_TenDonViTinh.DataBindings.Add("Text", DataSource, "Name");
        }
    }
}
