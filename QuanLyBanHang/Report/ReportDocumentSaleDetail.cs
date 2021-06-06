using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using QuanLyBanHang.ManageData;
using System.Data;

namespace QuanLyBanHang
{
    public partial class ReportDocumentSaleDetail : DevExpress.XtraReports.UI.XtraReport
    {
        public ReportDocumentSaleDetail()
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
            lb_TenKhachHang.DataBindings.Add("Text", document, "NameCustomer");
            lb_TenKhachHang2.DataBindings.Add("Text", document, "NameCustomer");
            lb_MaSoThue.DataBindings.Add("Text", document, "TaxCode");
            lb_DiaChi.DataBindings.Add("Text", document, "Address");
            lb_DienThoai.DataBindings.Add("Text", document, "PhoneNumber");
            lb_SumQuan.DataBindings.Add("Text", document, "Quantily");
            lb_SumAmountOrigin.DataBindings.Add("Text", document, "AmountOrigin");
            lb_SumDiscount.DataBindings.Add("Text", document, "AmountDiscount");
            lb_SumVAT.DataBindings.Add("Text", document, "AmountVAT");
            lb_SumAmount.DataBindings.Add("Text", document, "Amount");
            
            lb_Ngay.Text = "Ngày " + date.Day + " tháng " + date.Month + " năm " + date.Year;
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
            lb_TienCK.DataBindings.Add("Text", DataSource, "AmountDiscount");
            lb_TienVAT.DataBindings.Add("Text", DataSource, "AmountVAT");
            lb_ThanhToan.DataBindings.Add("Text", DataSource, "Amount");
        }
    }
}
