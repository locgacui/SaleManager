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
    public partial class ChinhSuaDVT : DevExpress.XtraEditors.XtraForm
    {
        public ChinhSuaDVT()
        {
            InitializeComponent();
        }

        private int id;

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

        private void ChinhSuaDVT_Load(object sender, EventArgs e)
        {
            LoadInfoUnit();
        }

        private void LoadInfoUnit()
        {
            Unit u = CodeUnit.Instance.Info_Unit_Id(id);
            if (u != null)
            {
                tb_MaDVT.DataBindings.Add("text", u, "Code");
                tb_TenDVT.DataBindings.Add("text", u, "Name");
            }
            else
                id = LenhHayDung.Lhd.GetId("Unit");
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Unit u = CodeUnit.Instance.Info_Unit_Id(id);
                if (u != null)
                    CodeUnit.Instance.Update_Unit_Id(id, tb_MaDVT.Text, tb_TenDVT.Text);
                else
                    CodeUnit.Instance.Insert_Unit(id, tb_MaDVT.Text, tb_TenDVT.Text);
            }
            catch
            {
                MessageBox.Show("Không lưu được đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }   

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            try
            {
                Unit u = CodeUnit.Instance.Info_Unit_Id(id);
                if (u != null)
                    CodeUnit.Instance.Update_Unit_Id(id, tb_MaDVT.Text, tb_TenDVT.Text);
                else
                    CodeUnit.Instance.Insert_Unit(id, tb_MaDVT.Text, tb_TenDVT.Text);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không lưu được đơn vị tính", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaDVT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
            if (e.KeyCode == Keys.F1)
                bt_Luu.PerformClick();
            if (e.KeyCode == Keys.F2)
                bt_LuuVaDong.PerformClick();
        }
    }
}