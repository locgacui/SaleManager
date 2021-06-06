﻿using System;
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
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class BaoCaoSanPhamNH : DevExpress.XtraEditors.XtraForm
    {
        public BaoCaoSanPhamNH()
        {
            InitializeComponent();
        }

        private bool all;
        private void ThucThi()
        {
            try
            {
                DateTime dateFrom = DateTime.Parse(date_TuNgay.DateTime.ToShortDateString());
                DateTime dateTo = DateTime.Parse(date_DenNgay.DateTime.ToShortDateString());
                gC_BaoCao.DataSource = CodeItem.Instance.Report_ImportItem(dateFrom.AddDays(-1), dateTo.AddDays(1));
                all = false;
            }
            catch { }
        }
        private void bt_ThucThi_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFrom = DateTime.Parse(date_TuNgay.DateTime.ToShortDateString());
                DateTime dateTo = DateTime.Parse(date_DenNgay.DateTime.ToShortDateString());
                gC_BaoCao.DataSource = CodeItem.Instance.Report_ImportItem(dateFrom.AddDays(-1), dateTo.AddDays(1));
                all = false;
            }
            catch { }
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            try
            {
                gC_BaoCao.DataSource = CodeItem.Instance.ReportAll_ImportItem();
                all = true;
            }
            catch { }
        }

        private void BaoCaoSanPhamNH_Load(object sender, EventArgs e)
        {
            date_TuNgay.DateTime = DateTime.Parse("1/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            date_DenNgay.DateTime = DateTime.Now;
        }

        private void bt_XuatBaoCao_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportItemImport report = new ReportItemImport())
                    {
                        for (int i = 0; i < gV_BaoCao.RowCount; i++)
                        {
                            report.SumQuan = report.SumQuan + double.Parse(gV_BaoCao.GetRowCellValue(i, col_Quantily).ToString());
                            report.SumThanhTien = report.SumThanhTien + double.Parse(gV_BaoCao.GetRowCellValue(i, col_AmountOrigin).ToString());
                            report.SumVAT = report.SumVAT + double.Parse(gV_BaoCao.GetRowCellValue(i, col_AmountVAT).ToString());
                            report.SumThanhToan = report.SumThanhToan + double.Parse(gV_BaoCao.GetRowCellValue(i, col_Amount).ToString());
                        }

                        report.DateForm = date_TuNgay.DateTime;
                        report.DateTo = date_DenNgay.DateTime;

                        if (all == false)
                            report.LoadDate();


                        report.DataSource = gV_BaoCao.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch { }
        }

        private void BaoCaoSanPhamNH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Escape))
                this.Close();
        }

        private void date_TuNgay_EditValueChanged(object sender, EventArgs e)
        {
            ThucThi();
        }

        private void date_DenNgay_EditValueChanged(object sender, EventArgs e)
        {
            ThucThi();
        }
    }
}