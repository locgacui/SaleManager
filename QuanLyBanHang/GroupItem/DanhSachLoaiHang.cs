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
    public partial class DanhSachLoaiHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachLoaiHang()
        {
            InitializeComponent();
        }

        private void DanhSachLoaiHang_Load(object sender, EventArgs e)
        {
            LoadDGVGroupItem();
        }

        private void LoadDGVGroupItem()
        {
            gC_LoaiHang.DataSource = CodeGroupItem.Instance.List_GroupItem();
            gV_LoaiHang.BestFitColumns();
        }

        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int id = int.Parse(gV_LoaiHang.GetFocusedRowCellValue(gridColumnId).ToString());
            using (ChinhSuaNhomMH fr = new ChinhSuaNhomMH())
            {
                fr.Id = id;
                fr.ShowDialog();
                this.Show();
                LoadDGVGroupItem();
            }
        }

        private void DanhSachLoaiHang_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void gc_ChucNang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachNhomHang report = new ReportDanhSachNhomHang())
                    {
                        report.DataSource = gC_LoaiHang.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if(e.Button.Properties.Caption== "(Ctrl+N) - Thêm")
            {
                using (ChinhSuaNhomMH fr = new ChinhSuaNhomMH())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("GroupItem");
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVGroupItem();
                }
            }
            if(e.Button.Properties.Caption== "Esc - Đóng")
            {
                this.Close();
            }
        }

        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa loại hàng này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int id = int.Parse(gV_LoaiHang.GetFocusedRowCellValue(gridColumnId).ToString());
                CodeGroupItem.Instance.Delete_GroupItem_IdGroupItem(id);
                LoadDGVGroupItem();
            }
        }

        private void DanhSachLoaiHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.Enter))
            {
                int id = int.Parse(gV_LoaiHang.GetFocusedRowCellValue(gridColumnId).ToString());
                using (ChinhSuaNhomMH fr = new ChinhSuaNhomMH())
                {
                    fr.Id = id;
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVGroupItem();
                }
            }

            if (e.Control && e.KeyCode.Equals(Keys.N))
            {
                using (ChinhSuaNhomMH fr = new ChinhSuaNhomMH())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("GroupItem");
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVGroupItem();
                }
            }

            if (e.Control && e.KeyCode.Equals(Keys.Delete))
            {
                if (MessageBox.Show("Bạn có muốn xóa loại hàng này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(gV_LoaiHang.GetFocusedRowCellValue(gridColumnId).ToString());
                    CodeGroupItem.Instance.Delete_GroupItem_IdGroupItem(id);
                    LoadDGVGroupItem();
                }
            }

        }
    }
}