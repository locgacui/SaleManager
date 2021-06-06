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
using System.Data.SqlClient;
using QuanLyBanHang.ManageData;
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class DanhSachNhanVien : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachNhanVien()
        {
            InitializeComponent();
        }

        private void DanhSachNhanVien_Load(object sender, EventArgs e)
        {
            LoadDGVEmployee();
            LoadInfoEmployee();
        }

        BindingSource Employee = new BindingSource();
        private void LoadDGVEmployee()
        {
            Employee.DataSource = CodeEmployee.Instance.ListEmployee();
            gc_Employee.DataSource = Employee;
            gv_Employee.BestFitColumns();
        }
        private void LoadInfoEmployee()
        {
            //tb_MaNhanVien.DataBindings.Add("text", gc_Employee.DataSource, "Id");
            //tb_TenNhanVien.DataBindings.Add("text", gc_Employee.DataSource, "Name");
            //tb_NgaySinh.DataBindings.Add("text", gc_Employee.DataSource, "DateOfBirth");
            //tb_GioiTinh.DataBindings.Add("text", gc_Employee.DataSource, "Sex");
            //tb_ChucVu.DataBindings.Add("text", gc_Employee.DataSource, "Position");
            //tb_CMND.DataBindings.Add("text", gc_Employee.DataSource, "CMND");
            //tb_DienThoai.DataBindings.Add("text", gc_Employee.DataSource, "PhoneNumber");
            //tb_Email.DataBindings.Add("text", gc_Employee.DataSource, "Email");
            //tb_DiaChi.DataBindings.Add("text", gc_Employee.DataSource, "Address");
        }

        private void bt_LietKe_Click(object sender, EventArgs e)
        {
            LoadDGVEmployee();
        }

        private void gc_Employee_MouseDown(object sender, MouseEventArgs e)
        {
            //switch (e.Button)
            //{
            //    case MouseButtons.Right:
            //        {
            //            rightClickMenuStrip.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
            //        }
            //        break;
            //}
        }

        private void gc_ChucNang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachNhanVien report = new ReportDanhSachNhanVien())
                    {
                        report.DataSource = gv_Employee.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if(e.Button.Properties.Caption== "(Ctrl+N) - Thêm")
            {
                using (EditEmployee fr = new EditEmployee())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Employee");
                    fr.Text = "Thêm Nhân Viên";
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVEmployee();
                }
            }
            
            if(e.Button.Properties.Caption=="Esc - Đóng")
            {
                this.Close();
            }
        }

        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (EditEmployee fr = new EditEmployee())
            {
                fr.Id = int.Parse(gv_Employee.GetFocusedRowCellValue(gridColumnId).ToString());
                fr.ShowDialog();
                this.Show();
                LoadDGVEmployee();
            }
        }

        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa nhân viên này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CodeEmployee.Instance.Delete_Employee_Id(int.Parse(gv_Employee.GetFocusedRowCellValue(gridColumnId).ToString()));
                    LoadDGVEmployee();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được nhân viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void DanhSachNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }

        private void DanhSachNhanVien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.N))
            {
                using (EditEmployee fr = new EditEmployee())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Employee");
                    fr.Text = "Thêm Nhân Viên";
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVEmployee();
                }
            }
           
            if (e.Control && e.KeyCode.Equals(Keys.Enter))
            {
                using (EditEmployee fr = new EditEmployee())
                {
                    fr.Id = int.Parse(gv_Employee.GetFocusedRowCellValue(gridColumnId).ToString());
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVEmployee();

                }
            }
            if (e.Control && e.KeyCode.Equals(Keys.Delete))
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa nhân viên này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CodeEmployee.Instance.Delete_Employee_Id(int.Parse(gv_Employee.GetFocusedRowCellValue(gridColumnId).ToString()));
                        LoadDGVEmployee();
                    }
                }
                catch
                {
                    MessageBox.Show("Không xóa được nhân viên này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}