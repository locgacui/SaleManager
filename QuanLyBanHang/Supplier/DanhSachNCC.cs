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
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class DanhSachNCC : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachNCC()
        {
            InitializeComponent();
        }
        private void DanhSachNCC_Load(object sender, EventArgs e)
        {
            LoadDGVSupplier();
        }

        BindingSource sup = new BindingSource();
        private void LoadDGVSupplier()
        {
            sup.DataSource= CodeSupplier.Instance.List_Supplier();
            gC_NCC.DataSource = sup;
            gv_NCC.BestFitColumns();
        }

        private void gc_ChucNang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachNhaCC report = new ReportDanhSachNhaCC())
                    {
                        DataTable table = CodeSupplier.Instance.Data_Supplier().Clone();
                        for (int i = 0; i < gv_NCC.RowCount; i++)
                            table.ImportRow(gv_NCC.GetDataRow(i));
                        report.DataSource = gv_NCC.DataSource;
                        //report.Table = table;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if(e.Button.Properties.Caption == "(Ctrl+N) - Thêm")
            {
                using (ChinhSuaNCC fr = new ChinhSuaNCC())
                {
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVSupplier();
                }
            }
            if (e.Button.Properties.Caption == "Esc - Đóng")
                this.Close();
        }

        private void bt_Sua_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
                using (ChinhSuaNCC fr = new ChinhSuaNCC())
                {
                    fr.Id = int.Parse(gv_NCC.GetFocusedRowCellValue(colId).ToString());
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVSupplier();
                }
        }

        private void bt_Xoa_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(gv_NCC.GetFocusedRowCellValue(colId).ToString());
                CodeSupplier.Instance.Delete_Supplier_Id(id);
                LoadDGVSupplier();
            }
        }

        private void DanhSachNCC_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control&&e.KeyCode==Keys.N)
            {
                using (ChinhSuaNCC fr = new ChinhSuaNCC())
                {
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVSupplier();
                }
            }

            if(e.Control&&e.KeyCode==Keys.Enter)
            {
                try
                {
                    using (ChinhSuaNCC fr = new ChinhSuaNCC())
                    {
                        fr.Id = int.Parse(gv_NCC.GetFocusedRowCellValue(colId).ToString());
                        fr.ShowDialog();
                        this.Show();
                        LoadDGVSupplier();
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn lại nhà cung cấp cần chỉnh sửa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(e.Control&&e.KeyCode==Keys.Delete)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa nhà cung cấp này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int id = int.Parse(gv_NCC.GetFocusedRowCellValue(colId).ToString());
                        CodeSupplier.Instance.Delete_Supplier_Id(id);
                        LoadDGVSupplier();
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn lại nhà cung cấp cần xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DanhSachNCC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}