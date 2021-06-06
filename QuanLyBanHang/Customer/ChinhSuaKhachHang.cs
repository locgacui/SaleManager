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
    public partial class ChinhSuaKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public ChinhSuaKhachHang()
        {
            InitializeComponent();
        }

        private int id;
        private string code;

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

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        private void ChinhSuaKhachHang_Load(object sender, EventArgs e)
        {
            LoadInfoCustomer();
        }

        private void LoadInfoCustomer()
        {
            Customer cus = CodeCustomer.Instance.Info_Customer_Id(id);
            if(cus!=null)
            {
                tb_MaKhachHang.Text = cus.Code;
                tb_TenKhachHang.Text = cus.Name;
                tb_DienThoai.Text = cus.PhoneNumber;
                tb_Email.Text = cus.Email;
                tb_MaSoThue.Text = cus.TaxCode;
                tb_DiaChi.Text = cus.Address;
                dateEditNgaySinh.Text = cus.DayOfBirth.ToShortDateString();
                cb_GioiTinh.Text = cus.Sex;
            }
            else
            {
                string LastCode = LenhHayDung.Lhd.GetLastCode("Customer", "Code", "KH");
                code = LenhHayDung.Lhd.NextCode(LastCode, "KH");
                tb_MaKhachHang.Text = code;
                id = LenhHayDung.Lhd.GetId("Customer");
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Customer cus = CodeCustomer.Instance.Info_Customer_Id(id);
                if (tb_MaKhachHang.Text == "")
                {
                    string LastCode = LenhHayDung.Lhd.GetLastCode("Customer", "Code", "KH");
                    code = LenhHayDung.Lhd.NextCode(LastCode, "KH");
                    tb_MaKhachHang.Text = code;
                }
                if (cus != null)
                    CodeCustomer.Instance.Update_Customer_Id(id, tb_MaKhachHang.Text, tb_TenKhachHang.Text, tb_DienThoai.Text, dateEditNgaySinh.DateTime, tb_DiaChi.Text, tb_MaSoThue.Text, cb_GioiTinh.Text, tb_Email.Text);
                else
                {
                    CodeCustomer.Instance.Insert_Customer(id, tb_MaKhachHang.Text, tb_TenKhachHang.Text, tb_DienThoai.Text, dateEditNgaySinh.DateTime, tb_DiaChi.Text, tb_MaSoThue.Text, cb_GioiTinh.Text, tb_Email.Text);
                    LoadInfoCustomer();
                }
            }
            catch
            {
                MessageBox.Show("Không lưu được thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }       

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            //try
            //{
                Customer cus = CodeCustomer.Instance.Info_Customer_Id(id);
                if (tb_MaKhachHang.Text == "")
                {
                    string LastCode = LenhHayDung.Lhd.GetLastCode("Customer", "Code", "KH");
                    code = LenhHayDung.Lhd.NextCode(LastCode, "KH");
                    tb_MaKhachHang.Text = code;
                }
                if (cus != null)
                    CodeCustomer.Instance.Update_Customer_Id(id, tb_MaKhachHang.Text, tb_TenKhachHang.Text, tb_DienThoai.Text, dateEditNgaySinh.DateTime, tb_DiaChi.Text, tb_MaSoThue.Text, cb_GioiTinh.Text, tb_Email.Text);
                else
                    CodeCustomer.Instance.Insert_Customer(id, tb_MaKhachHang.Text, tb_TenKhachHang.Text, tb_DienThoai.Text, dateEditNgaySinh.DateTime, tb_DiaChi.Text, tb_MaSoThue.Text, cb_GioiTinh.Text, tb_Email.Text);
                this.Close();
            //}
            //catch
            //{
            //    MessageBox.Show("Không lưu được thông tin khách hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        //private void LamMoi()
        //{
        //    id = LenhHayDung.Lhd.GetId("Customer");
        //    string LastCode = LenhHayDung.Lhd.GetLastCode("Customer", "Code", "KH");
        //    code = LenhHayDung.Lhd.NextCode(LastCode, "KH");
        //    tb_MaKhachHang.Text = code;
        //    tb_MaSoThue.Text = "";
        //    tb_TenKhachHang.Text = "";
        //    tb_DiaChi.Text = "";
        //    tb_DienThoai.Text = "";
        //    tb_Email.Text = "";
        //}

        private void ChinhSuaKhachHang_KeyDown(object sender, KeyEventArgs e)
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