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
    public partial class DanhSachKho : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachKho()
        {
            InitializeComponent();
        }

        private void DanhSachKho_Load(object sender, EventArgs e)
        {
            LoadDGVWarehouse();
        }

        BindingSource Warehouse = new BindingSource();
        private void LoadDGVWarehouse()
        {
            Warehouse.DataSource = CodeWarehouse.Instance.ListWarehouse();
            gC_Kho.DataSource = Warehouse.DataSource;
            gV_Kho.BestFitColumns();
        }

        private void gC_ChucNang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachKho report = new ReportDanhSachKho())
                    {
                        report.DataSource = gC_Kho.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if (e.Button.Properties.Caption == "(Ctrl+N) - Thêm")
            {
                using (ChinhSuaKho fr = new ChinhSuaKho())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Warehouse");
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVWarehouse();
                }
            }
            if (e.Button.Properties.Caption == "Esc - Đóng")
            {
                this.Close();
            }
        }

        private void DanhSachKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }

        private void DanhSachKho_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode.Equals(Keys.N))
            {
                using (ChinhSuaKho fr = new ChinhSuaKho())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Warehouse");
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVWarehouse();
                }
            }

            if (e.Control && e.KeyCode.Equals(Keys.Enter))
            {
                using (ChinhSuaKho fr = new ChinhSuaKho())
                {
                    fr.Id = int.Parse(gV_Kho.GetFocusedRowCellValue(gridColumnId).ToString());
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVWarehouse();

                }
            }
            if (e.Control && e.KeyCode.Equals(Keys.Delete))
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa kho này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                    {
                        CodeWarehouse.Instance.Delete_Warehouse_Id(int.Parse(gV_Kho.GetFocusedRowCellValue(gridColumnId).ToString()));
                        LoadDGVWarehouse();
                    }
                }
                catch
                {
                    MessageBox.Show("Không xóa được kho này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (ChinhSuaKho fr = new ChinhSuaKho())
            {
                fr.Id = int.Parse(gV_Kho.GetFocusedRowCellValue(gridColumnId).ToString());
                fr.ShowDialog();
                this.Show();
                LoadDGVWarehouse();
            }
        }

        private void repositoryItemButtonDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa kho này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.Yes)
                {
                    CodeWarehouse.Instance.Delete_Warehouse_Id(int.Parse(gV_Kho.GetFocusedRowCellValue(gridColumnId).ToString()));
                    LoadDGVWarehouse();
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được kho này", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}