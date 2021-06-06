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
using QuanLyBanHang.Data;
using QuanLyBanHang.ManageData;

namespace QuanLyBanHang
{
    public partial class DangNhapNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public DangNhapNhanVien()
        {
            InitializeComponent();
        }

        private void bt_DangNhap_Click(object sender, EventArgs e)
        {
            if (CodeAccount.Instance.Login_Account(tb_TaiKhoan.Text, tb_MatKhau.Text)==true)
            {
                using (frBanHang fr = new frBanHang())
                {
                    Account a = CodeAccount.Instance.Info_Account_UserNamePassword(tb_TaiKhoan.Text, tb_MatKhau.Text);
                    fr.IdAccount = a.Id;
                    this.Hide();
                    fr.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng", "LỖI ĐĂNG NHẬP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhapNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn thoát chương trình? ", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void DangNhapNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                bt_DangNhap.PerformClick();
            if (e.KeyCode == Keys.Escape)
                bt_Thoat.PerformClick();
        }

        private void DangNhapNhanVien_Load(object sender, EventArgs e)
        {
            DevExpress.LookAndFeel.DefaultLookAndFeel GiaoDien = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            GiaoDien.LookAndFeel.SkinName = "McSkin";//Chọn giao diện cho lúc đầu load form
        }
    }
}