using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachKhachHang : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachKhachHang()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaKhachHang.DataBindings.Add("Text", DataSource, "Code");
            lb_TenKhachHang.DataBindings.Add("Text", DataSource, "Name");
            lb_SoDienThoai.DataBindings.Add("Text", DataSource, "PhoneNumber");
            lb_NgaySinh.DataBindings.Add("Text", DataSource, "DayOfBirth").FormatString = "{0:dd/MM/yyyy}";
            lb_DiaChi.DataBindings.Add("Text", DataSource, "Address");
            lb_MaSoThue.DataBindings.Add("Text", DataSource, "TaxCode");
            lb_GioiTinh.DataBindings.Add("Text", DataSource, "Sex");
            lb_Email.DataBindings.Add("Text", DataSource, "Email");
        }
    }
}
