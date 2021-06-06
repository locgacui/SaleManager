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
using System.IO;
using System.Drawing.Imaging;
using QuanLyBanHang.Data;

namespace QuanLyBanHang
{
    public partial class EditEmployee : DevExpress.XtraEditors.XtraForm
    {
        public EditEmployee()
        {
            InitializeComponent();
        }

        private int id;
        private string code;
        private string DuongDan = null;
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

        private void EditEmployee_Load(object sender, EventArgs e)
        {
            LoadInfoEmployee();
        }

        private void LoadInfoEmployee()
        {
            DataTable empPicture = CodeEmployee.Instance.Data_Info_Employee_Id(this.id);
            Employee emp = CodeEmployee.Instance.Info_Employee_Id(id);
            if (emp != null)
            {
                tb_MaNhanVien.DataBindings.Add("text", emp, "code");
                tb_TenNhanVien.DataBindings.Add("text", emp, "name");
                dateEditNgaySinh.DataBindings.Add("text", emp, "dateofbirth");
                cb_GioiTinh.DataBindings.Add("text", emp, "Sex");
                tb_ChucVu.DataBindings.Add("text", emp, "Position");
                tb_CMND.DataBindings.Add("text", emp, "CMND");
                tb_DienThoai.DataBindings.Add("text", emp, "PhoneNumber");
                tb_Email.DataBindings.Add("text", emp, "Email");
                tb_DiaChi.DataBindings.Add("text", emp, "Address");
                pictureEditEmployee.DataBindings.Add(new Binding("Image", empPicture, "Picture", true));
            }
            else
            {
                string LastCode = LenhHayDung.Lhd.GetLastCode("Employee", "Code", "NV");
                code = LenhHayDung.Lhd.NextCode(LastCode, "NV");
                tb_MaNhanVien.Text = code;
                id = LenhHayDung.Lhd.GetId("Employee");
            }
        }

        private void bt_ChonAnh_Click(object sender, EventArgs e)
        {
            ofdOpenFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            ofdOpenFile.FilterIndex = 1;
            ofdOpenFile.RestoreDirectory = true;
            if (ofdOpenFile.ShowDialog() == DialogResult.OK)
            {
                string file = ofdOpenFile.FileName;
                DuongDan = file;
                Image myImage = Image.FromFile(file);
                pictureEditEmployee.Image = myImage;
            }
        }

        //private void LamMoi()
        //{
        //    id = LenhHayDung.Lhd.GetId("Employee");
        //    string LastCode = LenhHayDung.Lhd.GetLastCode("Employee", "Code", "NV");
        //    code = LenhHayDung.Lhd.NextCode(LastCode, "NV");
        //    tb_MaNhanVien.Text = code;
        //    tb_TenNhanVien.Text = "";
        //    tb_ChucVu.Text = "";
        //    tb_CMND.Text = "";
        //    tb_DienThoai.Text = "";
        //    tb_Email.Text = "";
        //    tb_DiaChi.Text = "";
        //    pictureEditEmployee.Image = QuanLyBanHang.Properties.Resources.EmployeePicture;
        //}

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = CodeEmployee.Instance.Info_Employee_Id(id);
                if (emp != null)
                    CodeEmployee.Instance.Update_Employee(id, tb_MaNhanVien.Text, tb_TenNhanVien.Text, dateEditNgaySinh.DateTime, cb_GioiTinh.Text, tb_ChucVu.Text, tb_CMND.Text, tb_DiaChi.Text, tb_DienThoai.Text, tb_Email.Text);
                else
                {
                    CodeEmployee.Instance.Insert_Employee(id, tb_MaNhanVien.Text, tb_TenNhanVien.Text, dateEditNgaySinh.DateTime, cb_GioiTinh.Text, tb_ChucVu.Text, tb_CMND.Text, tb_DiaChi.Text, tb_DienThoai.Text, tb_Email.Text);
                    LoadInfoEmployee();
                }
                //Thêm hình cho nhân viên
                if (DuongDan != null)
                {
                    CodeEmployee.Instance.Insert_Picture(id, DuongDan);
                }
            }
            catch
            {
                MessageBox.Show("Không thêm được nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = CodeEmployee.Instance.Info_Employee_Id(id);
                if (emp != null)
                    CodeEmployee.Instance.Update_Employee(id, tb_MaNhanVien.Text, tb_TenNhanVien.Text, dateEditNgaySinh.DateTime, cb_GioiTinh.Text, tb_ChucVu.Text, tb_CMND.Text, tb_DiaChi.Text, tb_DienThoai.Text, tb_Email.Text);
                else
                {
                    CodeEmployee.Instance.Insert_Employee(id, tb_MaNhanVien.Text, tb_TenNhanVien.Text, dateEditNgaySinh.DateTime, cb_GioiTinh.Text, tb_ChucVu.Text, tb_CMND.Text, tb_DiaChi.Text, tb_DienThoai.Text, tb_Email.Text);
                    LoadInfoEmployee();
                }

                if (DuongDan != null)
                {
                    CodeEmployee.Instance.Insert_Picture(id, DuongDan);
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không chỉnh sửa được nhân viên", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditEmployee_KeyDown(object sender, KeyEventArgs e)
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