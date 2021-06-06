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
    public partial class ChinhSuaKho : DevExpress.XtraEditors.XtraForm
    {
        public ChinhSuaKho()
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

        private void ChinhSuaKho_Load(object sender, EventArgs e)
        {
            Load_Info_Warehouse();
        }

        private void Load_Info_Warehouse()
        {
            Warehouse warehouse = CodeWarehouse.Instance.Info_Warehouse_Id(this.id);
            if(warehouse != null)
            {
                tb_MaKho.DataBindings.Add("text", warehouse, "Code");
                tb_TenKho.DataBindings.Add("text", warehouse, "Name");
                tb_SoDienThoai.DataBindings.Add("text", warehouse, "PhoneNumber");
                tb_DiaChi.DataBindings.Add("text", warehouse, "Address");
            }
            else
            {
                string LastCode = LenhHayDung.Lhd.GetLastCode("Warehouse", "Code", "KHO");
                code = LenhHayDung.Lhd.NextCode(LastCode, "KHO");
                tb_MaKho.Text = code;
                id = LenhHayDung.Lhd.GetId("Employee");
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                Warehouse warehouse = CodeWarehouse.Instance.Info_Warehouse_Id(id);
                if(warehouse != null)
                {
                    CodeWarehouse.Instance.Update_Warehouse_Id(id, tb_MaKho.Text, tb_TenKho.Text, tb_DiaChi.Text, tb_SoDienThoai.Text);
                    //Load_Info_Warehouse();
                }
                else
                {
                    CodeWarehouse.Instance.Insert_Warehouse(id, tb_MaKho.Text, tb_TenKho.Text, tb_DiaChi.Text, tb_SoDienThoai.Text);
                    Load_Info_Warehouse();
                }
            }
            catch
            {
                MessageBox.Show("Không lưu được thông tin kho", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_LuuVaDong_Click(object sender, EventArgs e)
        {
            try
            {
                Warehouse warehouse = CodeWarehouse.Instance.Info_Warehouse_Id(id);
                if (warehouse != null)
                {
                    CodeWarehouse.Instance.Update_Warehouse_Id(id, tb_MaKho.Text, tb_TenKho.Text, tb_DiaChi.Text, tb_SoDienThoai.Text);
                    //Load_Info_Warehouse();
                }
                else
                {
                    CodeWarehouse.Instance.Insert_Warehouse(id, tb_MaKho.Text, tb_TenKho.Text, tb_DiaChi.Text, tb_SoDienThoai.Text);
                    Load_Info_Warehouse();
                }
                this.Close();
            }
            catch
            {
                MessageBox.Show("Không lưu được thông tin kho", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChinhSuaKho_KeyDown(object sender, KeyEventArgs e)
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