using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Data;
using QuanLyBanHang.ManageData;

namespace QuanLyBanHang.Report
{
    public partial class ReportDocumentExportDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDocumentExportDetail()
        {
            InitializeComponent();
        }
        private DateTime date;
        private DataTable document;
        private DataTable documentDetail;

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public DataTable Document
        {
            get
            {
                return document;
            }

            set
            {
                document = value;
            }
        }

        public DataTable DocumentDetail
        {
            get
            {
                return documentDetail;
            }

            set
            {
                documentDetail = value;
            }
        }

        public void BindDataDocument()
        {
            lb_MaHoaDon.DataBindings.Add("Text", document, "Code");
            lb_LyDoXuat.DataBindings.Add("Text", document, "Description");
            lb_KhoXuat.DataBindings.Add("Text", document, "NameWarehouse");
            lb_DiaDiem.DataBindings.Add("Text", document, "Address");
            lb_SumQuan.DataBindings.Add("Text", document, "Quantily");
            lb_SumAmountOrigin.DataBindings.Add("Text", document, "AmountOrigin");

            lb_Ngay.Text = "Ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            lb_Ngay2.Text = "Ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
            lb_TenNVLap.DataBindings.Add("Text", document, "NameEmployee");
        }

        public void BindDataDocumentDetail()
        {
            lb_MaMatHang.DataBindings.Add("Text", DataSource, "CodeItem");
            lb_TenMatHang.DataBindings.Add("Text", DataSource, "NameItem");
            lb_DonViTinh.DataBindings.Add("Text", DataSource, "NameUnit");
            lb_SoLuong.DataBindings.Add("Text", DataSource, "Quantily");
            lb_DonGia.DataBindings.Add("Text", DataSource, "Price");
            lb_ThanhTien.DataBindings.Add("Text", DataSource, "AmountOrigin");
        }
    }
}
