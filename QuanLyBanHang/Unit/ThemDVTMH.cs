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
    public partial class ThemDVTMH : DevExpress.XtraEditors.XtraForm
    {
        public ThemDVTMH()
        {
            InitializeComponent();
        }

        private int idItem;
        private int idUnit;
        private string code;

        public int IdItem
        {
            get
            {
                return idItem;
            }

            set
            {
                idItem = value;
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

        public int IdUnit
        {
            get
            {
                return idUnit;
            }

            set
            {
                idUnit = value;
            }
        }

        private void ThemDVTMH_Load(object sender, EventArgs e)
        {
            LoadInfoItem();
            LoadListDVT();
        }

        private void LoadInfoItem()
        {
            LoadDGVItem();
            Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
            if(i!=null)
            {
                cb_MaMatHang.EditValue = i.Id;
                cb_MaMatHang.ReadOnly = true;
                cb_DVT.Focus();
            }
        }

        private void LoadDGVItem()
        {
            cb_MaMatHang.Properties.DataSource = CodeItem.Instance.List_Item();
            cb_MaMatHang.Properties.DisplayMember = "Name";
            cb_MaMatHang.Properties.ValueMember = "Id";
        }

        private void LoadListDVT()
        {
            if (IdUnit == 0)
                cb_DVT.Properties.DataSource = CodeUnit.Instance.List_NotExistUnit_IdItem(idItem);
            else
            {
                cb_DVT.Properties.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
                cb_DVT.ReadOnly = true;
            }
            cb_DVT.Properties.DisplayMember = "Name";
            cb_DVT.Properties.ValueMember = "Id";
            cb_DVT.EditValue = IdUnit;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            cb_MaMatHang.Focus();
            try
            {
                int IdUnit = int.Parse(cb_DVT.EditValue.ToString());
                int HeSo = int.Parse(spin_HeSo.Value.ToString());
                Unit u = CodeUnit.Instance.Info_Unit_IdItem_IdUnit(this.idItem, IdUnit);
                if (u != null) 
                {
                    CodeUnit.Instance.Update_ItemUnit_IdUnit_IdItem(idItem, IdUnit, HeSo);
                    this.Close();
                }
                else
                {
                    CodeUnit.Instance.Insert_ItemUnit(idItem, IdUnit, HeSo);
                    this.Close();
                }
            }
            catch
            {
                MessageBox.Show("Không lưu được đơn vị tính cho mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThemDVTMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                bt_Luu.PerformClick();
            if (e.KeyCode == Keys.Escape)
                bt_Huy.PerformClick();
        }

        private void cb_DVT_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Thêm")
            {
                using (ChinhSuaDVT fr = new ChinhSuaDVT())
                {
                    fr.ShowDialog();
                    int id = fr.Id;
                    this.Show();
                    LoadListDVT();
                    Unit u = CodeUnit.Instance.Info_Unit_Id(id);
                    if (u != null)
                    {
                        cb_DVT.EditValue = id;
                    }
                }
            }
        }
    }
}