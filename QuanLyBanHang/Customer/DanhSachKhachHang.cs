using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanHang.ManageData;
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class DanhSachKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachKhachHang()
        {
            InitializeComponent();
        }

        private void DanhSachKhachHang_Load(object sender, EventArgs e)
        {
            LoadDGVCustomer();
        }
        BindingSource customer = new BindingSource();
        private void LoadDGVCustomer()
        {
            customer.DataSource = CodeCustomer.Instance.List_Customer();
            gC_KhachHang.DataSource = customer;
            gV_KhachHang.BestFitColumns();
        }

        private void gc_ChucNang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachKhachHang report = new ReportDanhSachKhachHang())
                    {
                        report.DataSource = gC_KhachHang.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if(e.Button.Properties.Caption == "(Ctrl+N) - Thêm")
            {
                using (ChinhSuaKhachHang fr = new ChinhSuaKhachHang())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Customer");
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVCustomer();
                }
            }
            if(e.Button.Properties.Caption=="Esc - Đóng")
            {
                this.Close();
            }
        }

        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (ChinhSuaKhachHang fr = new ChinhSuaKhachHang())
            {
                int id = int.Parse(gV_KhachHang.GetFocusedRowCellValue(gridColumnId).ToString());
                fr.Id = id;
                fr.ShowDialog();
                this.Show();
                LoadDGVCustomer();
            }
        }

        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa khách hàng này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(gV_KhachHang.GetFocusedRowCellValue(gridColumnId).ToString());
                CodeCustomer.Instance.Delete_Customer_Id(id);
                LoadDGVCustomer();
            }
        }

        private void DanhSachKhachHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DanhSachKhachHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.N))
            {
                using (ChinhSuaKhachHang fr = new ChinhSuaKhachHang())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Customer");
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVCustomer();
                }
            }
            if (e.Control && e.KeyCode.Equals(Keys.Enter))
            {
                using (ChinhSuaKhachHang fr = new ChinhSuaKhachHang())
                {
                    int id = int.Parse(gV_KhachHang.GetFocusedRowCellValue(gridColumnId).ToString());
                    fr.Id = id;
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVCustomer();
                }
            }
            if (e.Control && e.KeyCode.Equals(Keys.Delete))
            {
                if (MessageBox.Show("Bạn có muốn xóa khách hàng này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(gV_KhachHang.GetFocusedRowCellValue(gridColumnId).ToString());
                    CodeCustomer.Instance.Delete_Customer_Id(id);
                    LoadDGVCustomer();
                }
            }
        }
    }
}