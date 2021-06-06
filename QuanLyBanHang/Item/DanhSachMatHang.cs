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
    public partial class DanhSachMatHang : DevExpress.XtraEditors.XtraForm
    {
        public DanhSachMatHang()
        {
            InitializeComponent();
        }

        private void DanhSachMatHang_Load(object sender, EventArgs e)
        {
            LoadDGVItem();
        }

        BindingSource item = new BindingSource();
        private void LoadDGVItem()
        {
            item.DataSource = CodeItem.Instance.Data_Item();
            gC_Item.DataSource = item;
            gV_Item.BestFitColumns();
        }

        //Xử lý khi người dùng chọn một mặt hàng
        private void gV_Item_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int IdItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());

                //Load danh sách đơn vị tính
                gC_Unit.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(IdItem);
                //Load bảng giá bán
                gC_UnitPrice.DataSource = CodeUnitPrice.Instance.List_UnitPrice_IdItem(IdItem);
            }
            catch
            {
                //Load danh sách đơn vị tính
                gC_Unit.DataSource = null;
                //Load bảng giá bán
                gC_UnitPrice.DataSource = null;
            }
        }

        //Chỉnh sửa mặt hàng
        private void repositoryItemButtonEditEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                {
                    int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                    fr.Id = idItem;
                    fr.ShowDialog();
                    this.Show();
                    LoadDGVItem();
                    Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                    gV_Item.ClearSelection();
                    int row = gV_Item.LocateByDisplayText(0, gridColumnCodeItem, i.Code);
                    gV_Item.SelectRow(row);
                    gV_Item.MovePrev();
                    gV_Item.MoveNext();
                    gV_Item.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất File")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDanhSachMatHang report = new ReportDanhSachMatHang())
                    {
                        report.DataSource = gC_Item.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            if(e.Button.Properties.Caption== "(Ctrl+N) - Thêm")
            {
                using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("Item");
                    fr.ShowDialog();
                    int idItem = fr.Id;
                    this.Show();
                    LoadDGVItem();
                    Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                    if (i != null)
                    {
                        gV_Item.ClearSelection();
                        int row = gV_Item.LocateByDisplayText(0, gridColumnCodeItem, i.Code);
                        gV_Item.MoveBy(row);
                    }
                    gV_Item.SelectRow(gV_Item.FocusedRowHandle);
                    gV_Item.MovePrev();
                    gV_Item.MoveNext();
                    gV_Item.Focus();
                }
            }
            if (e.Button.Properties.Caption == "Esc - Đóng")
                this.Close();
        }

        private void repositoryItemButtonEditDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                if (MessageBox.Show("Bạn có muốn xóa mặt hàng "+i.Code+" không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    CodeItem.Instance.Delete_Item_IdItem(idItem);
                    LoadDGVItem();
                    gV_Item.ClearSelection();
                    int row = gV_Item.LocateByDisplayText(0, gridColumnCodeItem, i.Code);
                    gV_Item.SelectRow(row);
                    gV_Item.MovePrev();
                    gV_Item.MoveNext();
                    gV_Item.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupControl3_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "(Ctrl+U) - Thêm")
            {
                try
                {
                    TC_HienThi.SelectedTabPage = xTPDVT;
                    int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                    using (ThemDVTMH fr = new ThemDVTMH())
                    {
                        fr.IdItem = idItem;
                        fr.ShowDialog();
                        this.Show();
                        //Load danh sách đơn vị tính
                        gC_Unit.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
                    }
                }
                catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void repositoryItemButtonEditDelUnit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int idUnit = int.Parse(gV_Unit.GetFocusedRowCellDisplayText(gridColumnIdUnit).ToString());
            int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
            CodeUnit.Instance.Delete_ItemUnit(idItem, idUnit);
            //Load danh sách đơn vị tính
            gC_Unit.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption== "(Ctrl+P) - Cập Nhật")
            {
                try
                {
                    TC_HienThi.SelectedTabPage = xTPDanhSachGia;
                    int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                    using (CapNhatGiaMH fr = new CapNhatGiaMH())
                    {
                        fr.IdItem = idItem;
                        fr.ShowDialog();
                        this.Show();
                        //Load bảng giá bán
                        gC_UnitPrice.DataSource = CodeUnitPrice.Instance.List_UnitPrice_IdItem(idItem);
                    }
                }
                catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void DanhSachMatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void DanhSachMatHang_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    try
                    {
                        using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                        {
                            int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                            fr.Id = idItem;
                            fr.ShowDialog();
                            this.Show();
                            LoadDGVItem();
                            Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                            gV_Item.ClearSelection();
                            int row = gV_Item.LocateByDisplayText(0, gridColumnCodeItem, i.Code);
                            gV_Item.SelectRow(row);
                            gV_Item.MovePrev();
                            gV_Item.MoveNext();
                            gV_Item.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (e.KeyCode.Equals(Keys.Delete))
                {
                    try
                    {
                        int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                        Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                        if (MessageBox.Show("Bạn có muốn xóa mặt hàng " + i.Code + " không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            CodeItem.Instance.Delete_Item_IdItem(idItem);
                            LoadDGVItem();
                            gV_Item.ClearSelection();
                            int row = gV_Item.LocateByDisplayText(0, gridColumnCodeItem, i.Code);
                            gV_Item.SelectRow(row);
                            gV_Item.MovePrev();
                            gV_Item.MoveNext();
                            gV_Item.Focus();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                if (e.KeyCode.Equals(Keys.N))
                {
                    using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                    {
                        fr.Id = LenhHayDung.Lhd.GetId("Item");
                        fr.ShowDialog();
                        int idItem = fr.Id;
                        this.Show();
                        LoadDGVItem();
                        Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                        if (i != null)
                        {
                            gV_Item.ClearSelection();
                            int row = gV_Item.LocateByDisplayText(0, gridColumnCodeItem, i.Code);
                            gV_Item.MoveBy(row);
                        }
                        gV_Item.SelectRow(gV_Item.FocusedRowHandle);
                        gV_Item.MovePrev();
                        gV_Item.MoveNext();
                        gV_Item.Focus();
                    }
                }

                if (e.KeyCode == Keys.P)
                {
                    try
                    {
                        TC_HienThi.SelectedTabPage = xTPDanhSachGia;
                        int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                        using (CapNhatGiaMH fr = new CapNhatGiaMH())
                        {
                            fr.IdItem = idItem;
                            fr.ShowDialog();
                            this.Show();
                            //Load bảng giá bán
                            gC_UnitPrice.DataSource = CodeUnitPrice.Instance.List_UnitPrice_IdItem(idItem);
                        }
                    }
                    catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }

                if (e.KeyCode == Keys.U)
                {
                    try
                    {
                        TC_HienThi.SelectedTabPage = xTPDVT;
                        int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                        using (ThemDVTMH fr = new ThemDVTMH())
                        {
                            fr.IdItem = idItem;
                            fr.ShowDialog();
                            this.Show();
                            //Load danh sách đơn vị tính
                            gC_Unit.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
                        }
                    }
                    catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
        }

        private void repositoryItemButtonEditUnit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int idItem = int.Parse(gV_Item.GetFocusedRowCellDisplayText(gridColumnIdItem).ToString());
                int idUnit = int.Parse(gV_Unit.GetFocusedRowCellDisplayText(gridColumnIdUnit).ToString());
                using (ThemDVTMH fr = new ThemDVTMH())
                {
                    fr.IdItem = idItem;
                    fr.IdUnit = idUnit;
                    fr.ShowDialog();
                    this.Show();
                    //Load danh sách đơn vị tính
                    gC_Unit.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
                }
            }
            catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}