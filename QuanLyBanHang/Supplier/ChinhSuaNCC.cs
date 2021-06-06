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
    public partial class ChinhSuaNCC : DevExpress.XtraEditors.XtraForm
    {
        public ChinhSuaNCC()
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

        private void ChinhSuaNCC_Load(object sender, EventArgs e)
        {
            LoadInfoSupplier();
        } 

        private void LoadInfoSupplier()
        {
            Supplier sup = CodeSupplier.Instance.Info_Supplier_Id(id);
            if (sup != null)
            {
                tb_MaNCC.DataBindings.Add("text", sup, "Code");
                tb_TenNCC.DataBindings.Add("text", sup, "Name");
                tb_SDT.DataBindings.Add("text", sup, "PhoneNumber");
                tb_Fax.DataBindings.Add("text", sup, "Fax");
                tb_Email.DataBindings.Add("text", sup, "Email");
                tb_DiaChi.DataBindings.Add("text", sup, "Address");
            }
            else
                id = LenhHayDung.Lhd.GetId("Supplier");
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier sup = CodeSupplier.Instance.Info_Supplier_Id(id);
                if (sup != null)
                    CodeSupplier.Instance.Update_Supplier_Id(id, tb_MaNCC.Text, tb_TenNCC.Text, tb_SDT.Text, tb_DiaChi.Text, tb_Fax.Text, tb_Email.Text);
                else
                {
                    CodeSupplier.Instance.Insert_Supplier(id, tb_MaNCC.Text, tb_TenNCC.Text, tb_SDT.Text, tb_DiaChi.Text, tb_Fax.Text, tb_Email.Text);
                    LoadInfoSupplier();
                }
            }
            catch
            {
                MessageBox.Show("Không lưu được nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            try
            {
                Supplier sup = CodeSupplier.Instance.Info_Supplier_Id(id);
                if (sup != null)
                    CodeSupplier.Instance.Update_Supplier_Id(id, tb_MaNCC.Text, tb_TenNCC.Text, tb_SDT.Text, tb_DiaChi.Text, tb_Fax.Text, tb_Email.Text);
                else
                {
                    CodeSupplier.Instance.Insert_Supplier(id, tb_MaNCC.Text, tb_TenNCC.Text, tb_SDT.Text, tb_DiaChi.Text, tb_Fax.Text, tb_Email.Text);
                    LoadInfoSupplier();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không lưu được nhà cung cấp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaNCC_KeyDown(object sender, KeyEventArgs e)
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