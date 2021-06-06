using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachMatHang : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachMatHang()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaMatHang.DataBindings.Add("Text", DataSource, "Code");
            lb_TenMatHang.DataBindings.Add("Text", DataSource, "Name");
            lb_NhomHang.DataBindings.Add("Text", DataSource, "GroupName");
            lb_NhaCungCap.DataBindings.Add("Text", DataSource, "NameSupplier");
            lb_GiaNhap.DataBindings.Add("Text", DataSource, "EntryPrice");
            lb_VAT.DataBindings.Add("Text", DataSource, "VAT");
        }
    }
}
