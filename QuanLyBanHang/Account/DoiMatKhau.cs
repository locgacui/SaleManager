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
    public partial class DoiMatKhau : DevExpress.XtraEditors.XtraForm
    {
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private int id;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        private void DoiMatKhau_Load(object sender, EventArgs e)
        {
            LoadInfoAccount();
        }

        private void LoadInfoAccount()
        {
            Account a = CodeAccount.Instance.Info_Account_Id(id);
            if(a!=null)
            {
                tb_TenTaiKhoan.DataBindings.Add("text", a, "UserName");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (CodeAccount.Instance.Login_Account(tb_TenTaiKhoan.Text, tb_MatKhauCu.Text) == true)
                {
                    if (tb_MatKhauMoi.Text == tb_NhapLaiMatKhau.Text)
                        CodeAccount.Instance.Update_Account_Id(id, tb_MatKhauMoi.Text);
                    else
                        MessageBox.Show("Nhập lại mật khẩu chưa trùng khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mật Khẩu cũ chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi không lưu được tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {

            try
            {
                if (CodeAccount.Instance.Login_Account(tb_TenTaiKhoan.Text, tb_MatKhauCu.Text) == true)
                {
                    if (tb_MatKhauMoi.Text == tb_NhapLaiMatKhau.Text)
                    {
                        CodeAccount.Instance.Update_Account_Id(id, tb_MatKhauMoi.Text);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Nhập lại mật khẩu chưa trùng khớp", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mật Khẩu cũ chưa đúng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Lỗi không lưu được tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DoiMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F1)
                bt_Luu.PerformClick();
            if (e.KeyCode == Keys.F2)
                bt_LuuVaDong.PerformClick();
        }
    }
}