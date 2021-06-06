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
    public partial class ChinhSuaMatHang : DevExpress.XtraEditors.XtraForm
    {
        public ChinhSuaMatHang()
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

        private void ChinhSuaMatHang_Load(object sender, EventArgs e)
        {
            LoadInfoItem();
            //LoadDGVUnit();
            //LoadUnitPrice();
            LoadGroupItem();
            LoadSupplier();
        }

        private void LoadInfoItem()
        {
            DataTable iPicture = CodeItem.Instance.Data_Info_Item_IdItem(id);
            Item i = CodeItem.Instance.Info_Item_IdItem(id);
            if (i != null)
            {
                tb_MaSanPham.Text = i.Code;
                tb_TenSanPham.Text = i.Name;
                spin_GiaNhap.Value = decimal.Parse(i.EntryPrice.ToString());
                spin_VAT.Value = i.VAT;
                tb_MoTa.DataBindings.Add("text", i, "Description");
                pictureEditItem.DataBindings.Add(new Binding("Image", iPicture, "Picture", true));
            }
            else
            {
                id = LenhHayDung.Lhd.GetId("Item");
                string LastCode = LenhHayDung.Lhd.GetLastCode("Item", "Code", "MH");
                code = LenhHayDung.Lhd.NextCode(LastCode, "MH");
                tb_MaSanPham.Text = code;
            }
        }

        private void LoadGroupItem()
        {
            cb_LoaiHang.Properties.DataSource = CodeGroupItem.Instance.List_GroupItem();
            cb_LoaiHang.Properties.DisplayMember = "Name";
            cb_LoaiHang.Properties.ValueMember = "Id";
            GroupItem gi = CodeGroupItem.Instance.Info_GroupItem_IdItem(id);
            if (gi != null)
            {
                gridLookUpEditGroupItem.SetFocusedRowCellValue(gridColumnIdGroupItem, gi.Id);
                cb_LoaiHang.EditValue = gi.Id;
            }
        }


        private void LoadSupplier()
        {
            cb_Supplier.Properties.DataSource = CodeSupplier.Instance.List_Supplier();
            cb_Supplier.Properties.DisplayMember = "Name";
            cb_Supplier.Properties.ValueMember = "Id";
            Item i = CodeItem.Instance.Info_Item_IdItem(id);
            try
            {
                cb_Supplier.EditValue = i.IdSupplier;
            }
            catch { }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            tb_MaSanPham.Focus();
            try
            {
                if (tb_MaSanPham.Text == "Để trống tự sinh"|| tb_MaSanPham.Text=="")
                {
                    string LastCode = LenhHayDung.Lhd.GetLastCode("Item", "Code", "MH");
                    code = LenhHayDung.Lhd.NextCode(LastCode, "MH");
                    tb_MaSanPham.Text = code;
                }
                Item i = CodeItem.Instance.Info_Item_IdItem(id);
                if (i != null)
                    CodeItem.Instance.Update_Item_IdItem(id, int.Parse(cb_Supplier.EditValue.ToString()), tb_MaSanPham.Text, tb_TenSanPham.Text, int.Parse(cb_LoaiHang.EditValue.ToString()), float.Parse(spin_GiaNhap.Value.ToString()), decimal.Parse(spin_VAT.Value.ToString()), tb_MoTa.Text);
                else
                {
                    CodeItem.Instance.Insert_Item(id, int.Parse(cb_Supplier.EditValue.ToString()), tb_MaSanPham.Text, tb_TenSanPham.Text, int.Parse(cb_LoaiHang.EditValue.ToString()), float.Parse(spin_GiaNhap.Value.ToString()), decimal.Parse(spin_VAT.Value.ToString()), tb_MoTa.Text);
                    LoadInfoItem();
                }

                //Thêm hình cho mặt hàng
                if (DuongDan != null)
                {
                    CodeItem.Instance.Insert_Picture(id, DuongDan);
                }
            }
            catch
            {
                MessageBox.Show("Không lưu được sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            tb_MaSanPham.Focus();
            try
            {
                if (tb_MaSanPham.Text == "Để trống tự sinh" || tb_MaSanPham.Text == "")
                {
                    string LastCode = LenhHayDung.Lhd.GetLastCode("Item", "Code", "MH");
                    code = LenhHayDung.Lhd.NextCode(LastCode, "MH");
                    tb_MaSanPham.Text = code;
                }
                Item i = CodeItem.Instance.Info_Item_IdItem(id);
                if (i != null)
                    CodeItem.Instance.Update_Item_IdItem(id, int.Parse(cb_Supplier.EditValue.ToString()), tb_MaSanPham.Text, tb_TenSanPham.Text, int.Parse(cb_LoaiHang.EditValue.ToString()), float.Parse(spin_GiaNhap.Value.ToString()), decimal.Parse(spin_VAT.Value.ToString()), tb_MoTa.Text);
                else
                {
                    CodeItem.Instance.Insert_Item(id, int.Parse(cb_Supplier.EditValue.ToString()), tb_MaSanPham.Text, tb_TenSanPham.Text, int.Parse(cb_LoaiHang.EditValue.ToString()), float.Parse(spin_GiaNhap.Value.ToString()), decimal.Parse(spin_VAT.Value.ToString()), tb_MoTa.Text);
                    LoadInfoItem();
                }
                //Thêm hình cho mặt hàng
                if (DuongDan != null)
                {
                    CodeItem.Instance.Insert_Picture(id, DuongDan);
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không lưu được sản phẩm", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaMatHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F1)
                bt_Luu.PerformClick();
            if (e.KeyCode == Keys.F2)
                bt_LuuVaDong.PerformClick();
        }

        //private void LamMoi()
        //{
        //    tb_MaSanPham.Text = "";
        //    tb_TenSanPham.Text = "";
        //    spin_GiaNhap.Value = 0;
        //    spin_VAT.Value = 0;
        //}

        private void cb_LoaiHang_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Caption=="Thêm")
            {
                using (ChinhSuaNhomMH fr = new ChinhSuaNhomMH())
                {
                    fr.Id = LenhHayDung.Lhd.GetId("GroupItem");
                    fr.ShowDialog();
                    this.Show();
                    LoadGroupItem();
                    GroupItem gi = CodeGroupItem.Instance.Info_GroupItem_IdGroupItem(fr.Id);
                    if(gi!=null)
                        cb_LoaiHang.EditValue = fr.Id;
                }
            }
        }

        private void cb_Supplier_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Thêm")
            {
                using (ChinhSuaNCC fr = new ChinhSuaNCC())
                {
                    fr.Text = "Thêm Nhà Cung Cấp";
                    fr.ShowDialog();
                    this.Show();
                    LoadSupplier();
                    Supplier sup = CodeSupplier.Instance.Info_Supplier_Id(fr.Id);
                    if (sup != null)
                        cb_Supplier.EditValue = fr.Id;
                }
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
                pictureEditItem.Image = myImage;
            }
        }

        //private void LoadDGVUnit()
        //{
        //    gC_DVT.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(id);
        //}

        //private void LoadUnitPrice()
        //{
        //    UnitPrice up = CodeUnitPrice.Instance.Info_UnitPrice_IdItem(id);
        //    tb_NgayCapNhat.Text = up.DateUpdate.ToShortDateString() + " " + up.DateUpdate.ToShortTimeString();
        //    spin_GiaBan.Value = up.Price;
        //}
    }
}