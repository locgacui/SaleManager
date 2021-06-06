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
using QuanLyBanHang.Data;

namespace QuanLyBanHang
{
    public partial class TaoTKNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public TaoTKNhanVien()
        {
            InitializeComponent();
        }


        private void TaoTKNhanVien_Load(object sender, EventArgs e)
        {
            LoadDGVEmployee();
            LoadIdEmployee();

            cb_TenNhanVien.Focus();
        }

        private void LoadDGVEmployee()
        {
            cb_TenNhanVien.Properties.DataSource = CodeEmployee.Instance.List_Employee_NotAccount();
            cb_TenNhanVien.Properties.DisplayMember = "Name";
            cb_TenNhanVien.Properties.ValueMember = "Id";
        }

        private void LoadIdEmployee()
        {
            //tb_MaNhanVien.DataBindings.Add("Text", gridLookUpEdit1View.DataSource, "Code");
        }

        private void bt_LietKe_Click(object sender, EventArgs e)
        {
            LoadDGVEmployee();
        }

        //private void bt_Huy_Click(object sender, EventArgs e)
        //{
        //    if (bt_Chon.Text == "Chọn")
        //    {
        //        gc_Employee.DataSource = CodeEmployee.Instance.Find_Employee(tb_MaNhanVien.Text);
        //        tb_TenTaiKhoan.ReadOnly = false;
        //        tb_MatKhau.ReadOnly = false;
        //        tb_NhapLaiMatKhau.ReadOnly = false;
        //        bt_TaoTaiKhoan.Enabled = true;
        //        bt_LietKe.Enabled = false;
        //        bt_Chon.Text = "Hủy";
        //        bt_Chon.ImageOptions.Image = QuanLyBanHang.Properties.Resources.cancel_16x16;
        //    }
        //    else
        //    {
        //        LoadDGVEmployee();
        //        tb_MaNhanVien.Text = "";
        //        tb_TenTaiKhoan.ReadOnly = true;
        //        tb_MatKhau.ReadOnly = true;
        //        tb_NhapLaiMatKhau.ReadOnly = true;
        //        bt_TaoTaiKhoan.Enabled = false;
        //        bt_LietKe.Enabled = true;
        //        bt_Chon.Text = "Chọn";
        //        bt_Chon.ImageOptions.Image = QuanLyBanHang.Properties.Resources.apply_16x16;
        //    }
        //}

        private void bt_TaoTaiKhoan_Click(object sender, EventArgs e)
        {
            if (CodeAccount.Instance.Check_UserName(tb_TenTaiKhoan.Text) == true)
            {
                MessageBox.Show("Tên tài đã có người sử dụng", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb_MatKhau.Text == tb_NhapLaiMatKhau.Text)
            {
                try
                {
                    int id = LenhHayDung.Lhd.GetId("Account");
                    int idEmp = int.Parse(cb_TenNhanVien.EditValue.ToString());
                    CodeAccount.Instance.Insert_Account(id, tb_TenTaiKhoan.Text, tb_MatKhau.Text, idEmp);
                    MessageBox.Show("Tạo tài khoản thành công cho nhân viên mã " + tb_MaNhanVien.Text, "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_TenTaiKhoan.Text = "";
                    tb_MatKhau.Text = "";
                    tb_NhapLaiMatKhau.Text = "";
                    tb_MaNhanVien.Text = "";
                    tb_TenTaiKhoan.ReadOnly = true;
                    tb_MatKhau.ReadOnly = true;
                    tb_NhapLaiMatKhau.ReadOnly = true;
                    bt_TaoTaiKhoan.Enabled = false;
                    cb_TenNhanVien.Focus();
                    cb_TenNhanVien.Properties.DataSource = CodeEmployee.Instance.List_Employee_NotAccount();
                    //bt_LietKe.Enabled = true;
                    //bt_Chon.Text = "Chọn";
                    //bt_Chon.ImageOptions.Image = QuanLyBanHang.Properties.Resources.apply_16x16;
                }
                catch
                {
                    MessageBox.Show("Không thêm được tài khoản", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu chưa trùng khớp", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            //if(e.Button.Properties.Caption=="Liệt Kê")
            //{
            //    LoadDGVEmployee();
            //    tb_TenTaiKhoan.ReadOnly = true;
            //    tb_MatKhau.ReadOnly = true;
            //    tb_NhapLaiMatKhau.ReadOnly = true;
            //    bt_TaoTaiKhoan.Enabled = false;
            //}
            //if (e.Button.Properties.Caption == "Chọn")
            //{
            //    int idEmp = int.Parse(gv_Employee.GetFocusedRowCellValue(gridColumnId).ToString());
            //    gc_Employee.DataSource = CodeEmployee.Instance.Data_Info_Employee_Id(idEmp);
            //    tb_TenTaiKhoan.ReadOnly = false;
            //    tb_MatKhau.ReadOnly = false;
            //    tb_NhapLaiMatKhau.ReadOnly = false;
            //    bt_TaoTaiKhoan.Enabled = true;
            //}
        }

        private void TaoTKNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                bt_TaoTaiKhoan.PerformClick();
            if (e.KeyCode == Keys.Escape)
                bt_Thoat.PerformClick();
        }

        private void cb_TenNhanVien_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cb_TenNhanVien.EditValue.ToString());
                Employee emp = CodeEmployee.Instance.Info_Employee_Id(id);
                tb_MaNhanVien.Text = emp.Code;

                tb_TenTaiKhoan.ReadOnly = false;
                tb_MatKhau.ReadOnly = false;
                tb_NhapLaiMatKhau.ReadOnly = false;
                bt_TaoTaiKhoan.Enabled = true;
            }
            catch { }
        }
    }
}