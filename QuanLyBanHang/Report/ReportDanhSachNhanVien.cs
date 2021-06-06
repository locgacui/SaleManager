using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachNhanVien : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachNhanVien()
        {
            InitializeComponent();
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            tb_MaNV.DataBindings.Add("Text", DataSource, "Code");
            tb_TenNV.DataBindings.Add("Text", DataSource, "Name");
            tb_NgaySinh.DataBindings.Add("Text", DataSource, "DateOfBirth").FormatString = "{0:dd/MM/yyyy}";
            tb_GioiTinh.DataBindings.Add("Text", DataSource, "Sex");
            tb_ChucVu.DataBindings.Add("Text", DataSource, "Position");
            tb_DiaChi.DataBindings.Add("Text", DataSource, "Address");
            tb_DienThoai.DataBindings.Add("Text", DataSource, "PhoneNumber");
            tb_CMND.DataBindings.Add("Text", DataSource, "CMND");
            tb_Email.DataBindings.Add("Text", DataSource, "Email");
        }
    }
}
