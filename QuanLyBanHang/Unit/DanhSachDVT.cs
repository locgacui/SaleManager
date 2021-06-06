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
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class DanhSachDVT : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachDVT()
        {
            InitializeComponent();
        }

        private void DanhSachDVT_Load(object sender, EventArgs e)
        {
            LoadDGVUnit();
        }

        BindingSource Unit = new BindingSource();
        private void LoadDGVUnit()
        {
            Unit.DataSource = CodeUnit.Instance.List_Unit();
            gC_DVT.DataSource = Unit;
            gV_DVT.BestFitColumns();
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (ChinhSuaDVT fr = new ChinhSuaDVT())
                {
                    int id = int.Parse(gV_DVT.GetFocusedRowCellValue(colId).ToString());
                    fr.Id = id;
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVUnit();
                }
            }
            catch { MessageBox.Show("Vui lòng chọn lại đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void repositoryItemButtonEdit2_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn xóa đơn vị tính này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(gV_DVT.GetFocusedRowCellValue(colId).ToString());
                    CodeUnit.Instance.Delete_Unit_Id(id);
                    LoadDGVUnit();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachDVT report = new ReportDanhSachDVT())
                    {
                        report.DataSource = gC_DVT.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if(e.Button.Properties.Caption == "(Ctrl+N) - Thêm")
            {
                using (ChinhSuaDVT fr = new ChinhSuaDVT())
                {
                    fr.Text = "Thêm Đơn Vị Tính";
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVUnit();
                }
            }

            if(e.Button.Properties.Caption == "Esc - Đóng")
            {
                this.Close();
            }
        }

        private void DanhSachDVT_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode==Keys.N)
            {
                using (ChinhSuaDVT fr = new ChinhSuaDVT())
                {
                    fr.Text = "Thêm Đơn Vị Tính";
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVUnit();
                }
            }

            if(e.Control && e.KeyCode==Keys.Enter)
            {
                try
                {
                    using (ChinhSuaDVT fr = new ChinhSuaDVT())
                    {
                        int id = int.Parse(gV_DVT.GetFocusedRowCellValue(colId).ToString());
                        fr.Id = id;
                        fr.ShowDialog();
                        this.Show();
                        LoadDGVUnit();
                    }
                }
                catch { MessageBox.Show("Vui lòng chọn lại đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }

            if(e.Control && e.KeyCode==Keys.Delete)
            {
                try
                {
                    if (MessageBox.Show("Bạn có muốn xóa đơn vị tính này không", "CẢNH BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int id = int.Parse(gV_DVT.GetFocusedRowCellValue(colId).ToString());
                        CodeUnit.Instance.Delete_Unit_Id(id);
                        LoadDGVUnit();
                    }
                }
                catch
                {
                    MessageBox.Show("Vui lòng chọn lại đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DanhSachDVT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }
    }
}