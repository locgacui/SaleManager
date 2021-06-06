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
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class ReportDocumentSaleForm : DevExpress.XtraEditors.XtraForm
    {
        public ReportDocumentSaleForm()
        {
            InitializeComponent();
        }

        private void ThucThi()
        {
            try
            {
                DateTime dateFrom = DateTime.Parse(date_TuNgay.DateTime.ToShortDateString());
                DateTime dateTo = DateTime.Parse(date_DenNgay.DateTime.ToShortDateString());
                gc_Document.DataSource = CodeDocument.Instance.List_DocumentSale_FromTo_(dateFrom, dateTo);
                if (gv_Document.RowCount == 0)
                    gc_DocDetail.DataSource = null;
                else
                {
                    gv_Document.BestFitColumns();
                    int idDoc = int.Parse(gv_Document.GetFocusedRowCellValue(col_Id_Document).ToString());
                    gc_DocDetail.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                    gv_DocDetail.BestFitColumns();
                }
            }
            catch { }
        }

        private void bt_ThucThi_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime dateFrom = DateTime.Parse(date_TuNgay.DateTime.ToShortDateString());
                DateTime dateTo = DateTime.Parse(date_DenNgay.DateTime.ToShortDateString());
                gc_Document.DataSource = CodeDocument.Instance.List_DocumentSale_FromTo_(dateFrom, dateTo);
                if (gv_Document.RowCount == 0)
                    gc_DocDetail.DataSource = null;
                else
                {
                    gv_Document.BestFitColumns();
                    int idDoc = int.Parse(gv_Document.GetFocusedRowCellValue(col_Id_Document).ToString());
                    gc_DocDetail.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                    gv_DocDetail.BestFitColumns();
                }
            }
            catch { }
        }

        private void bt_All_Click(object sender, EventArgs e)
        {
            try
            {
                gc_Document.DataSource = CodeDocument.Instance.ListAll_DocumentSale();
                if (gv_Document.RowCount == 0)
                    gc_DocDetail.DataSource = null;
                else
                {
                    gv_Document.BestFitColumns();
                    int idDoc = int.Parse(gv_Document.GetFocusedRowCellValue(col_Id_Document).ToString());
                    gc_DocDetail.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                    gv_DocDetail.BestFitColumns();
                }
            }
            catch { }
        }

        private void ReportDocumentSaleForm_Load(object sender, EventArgs e)
        {
            date_TuNgay.DateTime = DateTime.Parse("1/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            date_DenNgay.DateTime = DateTime.Now;
        }

        private void gv_Document_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int idDoc = int.Parse(gv_Document.GetFocusedRowCellValue(col_Id_Document).ToString());
                gc_DocDetail.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                gv_DocDetail.BestFitColumns();
            }
            catch { }
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption == "Xuất Báo Cáo")
            {
                using (FormReport fr = new FormReport())
                {
                    using (ReportDocumentSale report = new ReportDocumentSale())
                    {
                        for (int i = 0; i < gv_Document.RowCount; i++) 
                        {
                            report.SumQuan = report.SumQuan + double.Parse(gv_Document.GetRowCellValue(i, col_Quantily_Doc).ToString());
                            report.SumThanhTien = report.SumThanhTien + double.Parse(gv_Document.GetRowCellValue(i, col_AmountOrigin_Doc).ToString());
                            report.SumCK = report.SumCK + double.Parse(gv_Document.GetRowCellValue(i, col_AmountDiscount_Doc).ToString());
                            report.SumVAT = report.SumVAT + double.Parse(gv_Document.GetRowCellValue(i, col_AmountVAT_Doc).ToString());
                            report.SumThanhToan = report.SumThanhToan + double.Parse(gv_Document.GetRowCellValue(i, col_Amount_Doc).ToString());
                            report.SumLoiNhuan = report.SumLoiNhuan + double.Parse(gv_Document.GetRowCellValue(i, col_Profit_Doc).ToString());
                        }

                        report.DateForm = date_TuNgay.DateTime;
                        report.DateTo = date_DenNgay.DateTime;

                        if (gv_Document.RowCount != CodeDocument.Instance.ListAll_DocumentSale().Rows.Count)
                            report.LoadDate();


                        report.DataSource = gc_Document.DataSource;
                        report.BindData();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
        }

        private void bt_XuatPhieu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            try
            {
                int id = int.Parse(gv_Document.GetFocusedRowCellValue(col_Id_Document).ToString());
                using (FormReport fr = new FormReport())
                {
                    using (ReportDocumentSaleDetail report = new ReportDocumentSaleDetail())
                    {
                        report.Document = CodeDocument.Instance.InfoReport_DocumentSale(id);
                        report.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(id);
                        report.Date = DateTime.Parse(gv_Document.GetFocusedRowCellValue(col_Date_Doc).ToString());
                        report.BindDataDocument();
                        report.BindDataDocumentDetail();
                        fr.Report = report;
                        fr.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch
            {

            }
        }

        private void ReportDocumentSaleForm_KeyDown(object sender, KeyEventArgs e)
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