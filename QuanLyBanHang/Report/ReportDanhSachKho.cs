using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachKho : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachKho()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaKho.DataBindings.Add("Text", DataSource, "Code");
            lb_TenKho.DataBindings.Add("Text", DataSource, "Name");
            lb_DiaChi.DataBindings.Add("Text", DataSource, "Address");
            lb_SoDienThoai.DataBindings.Add("Text", DataSource, "PhoneNumber");
        }
    }
}
