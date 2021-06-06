using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachNhomHang : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachNhomHang()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaNhom.DataBindings.Add("Text", DataSource, "Code");
            lb_TenNhom.DataBindings.Add("Text", DataSource, "Name");
        }
    }
}
