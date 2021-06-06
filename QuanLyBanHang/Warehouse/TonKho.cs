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
    public partial class TonKho : DevExpress.XtraEditors.XtraForm
    {
        public TonKho()
        {
            InitializeComponent();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            date_ThoiGian.DateTime = DateTime.Parse(DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            LoadListWarehouse();
        }

        private void LoadListWarehouse()
        {
            cb_Kho.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
            cb_Kho.Properties.DisplayMember = "Name";
            cb_Kho.Properties.ValueMember = "Id";

        }

        private void LoadDGVStock()
        {
            int idWareHouse = int.Parse(cb_Kho.EditValue.ToString());
            DateTime dateFrom = DateTime.Parse(date_ThoiGian.DateTime.ToShortDateString());
            DateTime dateTo = dateFrom.AddMonths(1);
            gc_TonKho.DataSource = CodeWarehouse.Instance.Report_Stock_IdWareHouse_FromTo(idWareHouse, dateFrom, dateTo);
        }

        private void cb_Kho_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Sửa")
            {
                try
                {
                    using (ChinhSuaKho fr = new ChinhSuaKho())
                    {
                        fr.Id = int.Parse(cb_Kho.EditValue.ToString());
                        fr.ShowDialog();
                        LoadListWarehouse();
                        this.Show();
                    }
                }
                catch { }
            }
        }

        private void bt_ThucThi_Click(object sender, EventArgs e)
        {
            try
            {
                LoadDGVStock();
            }
            catch { }
        }

        private void bt_XuatBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportStockWarehouse report = new ReportStockWarehouse())
                    {
                        report.DateForm = DateTime.Parse(date_ThoiGian.DateTime.ToShortDateString());
                        report.Kho1 = cb_Kho.Text;
                        report.LoadDate();


                        report.DataSource = gV_TonKho.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch { }
        }

        private void TonKho_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }

        private void cb_Kho_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDGVStock();
            }
            catch { }
        }

        private void date_ThoiGian_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                LoadDGVStock();
            }
            catch { }
        }
    }
}