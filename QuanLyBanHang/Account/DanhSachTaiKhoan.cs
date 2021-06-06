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

namespace QuanLyBanHang
{
    public partial class DanhSachTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachTaiKhoan()
        {
            InitializeComponent();
        }

        private void DanhSachTaiKhoan_Load(object sender, EventArgs e)
        {
            LoadDGVAccount();
        }

        private void LoadDGVAccount()
        {
            gC_TaiKhoan.DataSource = CodeAccount.Instance.Data_List_Account();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gV_TaIKhoan.GetFocusedRowCellValue(colId).ToString());
                using (DoiMatKhau fr = new DoiMatKhau())
                {
                    fr.Id = id;
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVAccount();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại một tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gV_TaIKhoan.GetFocusedRowCellValue(colId).ToString());
                CodeAccount.Instance.Delete_Account_Id(id);
                LoadDGVAccount();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại một tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gc_ChucNang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "(Ctrl+N) - Thêm")
            {
                using (TaoTKNhanVien fr = new TaoTKNhanVien())
                {
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVAccount();
                }
            }
            if (e.Button.Properties.Caption == "Esc - Đóng")
                this.Close();
        }

        private void DanhSachTaiKhoan_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.N)
            {
                using (TaoTKNhanVien fr = new TaoTKNhanVien())
                {
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVAccount();
                }
            }

            if (e.Control && e.KeyCode == Keys.Enter)
            {
                try
                {
                    int id = int.Parse(gV_TaIKhoan.GetFocusedRowCellValue(colId).ToString());
                    using (DoiMatKhau fr = new DoiMatKhau())
                    {
                        fr.Id = id;
                        fr.ShowDialog();
                        this.Show();
                        LoadDGVAccount();
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn lại một tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (e.Control && e.KeyCode == Keys.Delete)
            {
                try
                {
                    int id = int.Parse(gV_TaIKhoan.GetFocusedRowCellValue(colId).ToString());
                    CodeAccount.Instance.Delete_Account_Id(id);
                    LoadDGVAccount();
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn lại một tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DanhSachTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}