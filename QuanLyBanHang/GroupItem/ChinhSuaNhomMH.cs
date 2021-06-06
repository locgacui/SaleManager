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
    public partial class ChinhSuaNhomMH : DevExpress.XtraEditors.XtraForm
    {
        public ChinhSuaNhomMH()
        {
            InitializeComponent();
        }

        private int id;
        private string code;

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

        private void ChinhSuaNhomMH_Load(object sender, EventArgs e)
        {
            LoadInfoGroupItem();
        }

        private void LoadInfoGroupItem()
        {
            GroupItem gi = CodeGroupItem.Instance.Info_GroupItem_IdGroupItem(id);
            if (gi != null)
            {
                tb_MaNhom.Text = gi.Code;
                tb_TenNhom.Text = gi.Name;
            }
            else
                id = LenhHayDung.Lhd.GetId("GroupItem");
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_MaNhom.Text == "Để trống tự sinh" || tb_MaNhom.Text == "")
                {
                    string LastCode = LenhHayDung.Lhd.GetLastCode("GroupItem", "Code", "");
                    code = LenhHayDung.Lhd.NextCode(LastCode, "LH");
                    tb_MaNhom.Text = code;
                }
                GroupItem gi = CodeGroupItem.Instance.Info_GroupItem_IdGroupItem(id);
                if (gi != null)
                    CodeGroupItem.Instance.Update_GroupItem_IdGroupItem(id, tb_MaNhom.Text, tb_TenNhom.Text);
                else
                {
                    CodeGroupItem.Instance.Insert_GroupItem(id, tb_MaNhom.Text, tb_TenNhom.Text);
                    LoadInfoGroupItem();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi không lưu được nhóm mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_MaNhom.Text == "Để trống tự sinh" || tb_MaNhom.Text == "")
                {
                    string LastCode = LenhHayDung.Lhd.GetLastCode("GroupItem", "Code", "");
                    code = LenhHayDung.Lhd.NextCode(LastCode, "LH");
                    tb_MaNhom.Text = code;
                }
                else
                    code = tb_MaNhom.Text;
                GroupItem gi = CodeGroupItem.Instance.Info_GroupItem_IdGroupItem(id);
                if (gi != null)
                    CodeGroupItem.Instance.Update_GroupItem_IdGroupItem(id, tb_MaNhom.Text, tb_TenNhom.Text);
                else
                    CodeGroupItem.Instance.Insert_GroupItem(id, tb_MaNhom.Text, tb_TenNhom.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi không lưu được nhóm mặt hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaNhomMH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
                bt_Luu.PerformClick();
            if (e.KeyCode == Keys.F2)
                bt_LuuVaDong.PerformClick();
            if (e.KeyCode == Keys.Escape)
                bt_Huy.PerformClick();
        }
    }
}