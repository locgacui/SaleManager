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
    public partial class CapNhatGiaMH : DevExpress.XtraEditors.XtraForm
    {
        public CapNhatGiaMH()
        {
            InitializeComponent();
        }
        private int idItem;

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

        private void CapNhatGiaMH_Load(object sender, EventArgs e)
        {
            LoadDGVItem();
            Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
            if (i!=null)
            {
                cb_MaMatHang.EditValue = i.Id;
                cb_MaMatHang.ReadOnly = true;
                spin_GiaBan.Focus();
            }      
        }

        private void LoadDGVItem()
        {
            cb_MaMatHang.Properties.DataSource = CodeItem.Instance.List_Item();
            cb_MaMatHang.Properties.DisplayMember = "Code";
            cb_MaMatHang.Properties.ValueMember = "Id";
        }

        private void bt_Lưu_Click(object sender, EventArgs e)
        {
            cb_MaMatHang.Focus();
            int id = LenhHayDung.Lhd.GetId("UnitPrice");
            string dateupdate = DateTime.Now.ToString("yyyy-MM-dd") + " " + DateTime.Now.ToLongTimeString();
            CodeUnitPrice.Instance.Insert_UnitPrice(id, idItem, decimal.Parse(spin_GiaBan.Value.ToString()), dateupdate);
            this.Close();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CapNhatGiaMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                bt_Luu.PerformClick();
            if (e.KeyCode == Keys.Escape)
                bt_Huy.PerformClick();
        }
    }
}