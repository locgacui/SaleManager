using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;

namespace QuanLyBanHang.Report
{
    public partial class ReportDanhSachNhaCC : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDanhSachNhaCC()
        {
            InitializeComponent();
        }

        private DataTable table;

        public DataTable Table
        {
            get
            {
                return table;
            }

            set
            {
                table = value;
            }
        }

        public void BindData()
        {
            lb_ThoiGian.Text = "Ngày: " + System.DateTime.Now.ToString("dd/MM/yyyy");
            lb_MaNhaCungCap.DataBindings.Add("Text", DataSource, "Code");
            lb_TenNhaCungCap.DataBindings.Add("Text", DataSource, "Name");
            lb_SoDienThoai.DataBindings.Add("Text", DataSource, "PhoneNumber");
            lb_DiaChi.DataBindings.Add("Text", DataSource, "Address");
            lb_Fax.DataBindings.Add("Text", DataSource, "Fax");
            lb_Email.DataBindings.Add("Text", DataSource, "Email");
        }
    }
}
