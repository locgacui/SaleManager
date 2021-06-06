using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanLyBanHang.ManageData;
using QuanLyBanHang.Data;
using DevExpress.XtraTab;
using QuanLyBanHang.Report;

namespace QuanLyBanHang
{
    public partial class frBanHang : DevExpress.XtraBars.Ribbon.RibbonForm
    {   
        public frBanHang()
        {
            InitializeComponent();
        }

        private int idAccount;
        private string username;
        private int idDocSale;
        private int idDocImport;
        private int idDocExport;

        BindingSource item = new BindingSource();
        BindingSource warehouse = new BindingSource();
        BindingSource employee = new BindingSource();
        Employee emp = null;

        public string Username
        {
            get
            {
                return username;
            }

            set
            {
                username = value;
            }
        }

        public int IdDocSaLe
        {
            get
            {
                return idDocSale;
            }

            set
            {
                idDocSale = value;
            }
        }

        public int IdAccount
        {
            get
            {
                return idAccount;
            }

            set
            {
                idAccount = value;
            }
        }

        public int IdDocImport
        {
            get
            {
                return idDocImport;
            }

            set
            {
                idDocImport = value;
            }
        }

        public int IdDocExport
        {
            get
            {
                return idDocExport;
            }

            set
            {
                idDocExport = value;
            }
        }

        private void frBanHang_Load(object sender, EventArgs e)
        {
            LoadGiaoDien(); //Load giao diện
            LoadStaticBar(); //Load thanh trạng thái

            //Tổng quan
            LoadTuNgayDenNgay();
            LoadDGVDonHangGanNhat();

            //Bán hàng
            LoadInfo_Document();//Load thông tin đơn hàng
            LoadDGVDocumentSale(); //Load bảng chi tiết hóa đơn vào gridcontrol
            LoadItem_Document(); //Load mặt hàng vào chi tiết bán hàng của gridview

            //Nhập hàng
            LoadInfoDocumentImport();//Load thông tin nhập hàng
            LoadDGV_PN();//Load bảng chi tiết hóa đơn của phiếu nhập hàng

            //Xuất hàng
            LoadInfoDocumentExport();//Load thông tin xuất hàng
            LoadDGV_PX();//Load bảng chi tiết hóa đơn của phiếu xuất hàng
            //LoadItem_DocumentExport();//Load mặt hàng vào chi tiết phiếu xuất của gridview
        }

        private void LoadStaticBar()
        {
            Time.Start();
            Account a = CodeAccount.Instance.Info_Account_Id(idAccount);
            Status_User.Caption = a.UserName;
            StatusTime.Caption = DateTime.Now.ToLongTimeString();
            StatusDate.Caption = DateTime.Now.ToShortDateString();
        }
        #region Bán Hàng
        private void LoadInfo_Document()
        {
            //Load Nhân Viên Lập
            emp = CodeEmployee.Instance.Info_Employee_IdAccount(idAccount);
            tb_NhanVienLap_HD.Text = emp.Name.ToString();

            //Load Mã Hóa Đơn
            string LastCodeDoc = LenhHayDung.Lhd.GetLastCode("Document", "Code", "HD");
            tb_MaHoaDonBan.Text = LenhHayDung.Lhd.NextCode(LastCodeDoc, "HD");
            //tb_MaHoaDonBan.Text = LenhHayDung.Lhd.GetId("Document").ToString();

            //Load khách hàng
            cb_TenKhachHang_HD.Properties.DataSource = CodeCustomer.Instance.List_Customer();
            cb_TenKhachHang_HD.Properties.DisplayMember = "Name";
            cb_TenKhachHang_HD.Properties.ValueMember = "Id";
            cb_TenKhachHang_HD.Properties.NullText = "Chọn Khách Hàng";
            gridLookUpEditCustomer.BestFitColumns();

            //Load Ngày hiện hành vào ngày lập hóa đơn
            dateEditNgayLapBan.Text = DateTime.Now.ToShortDateString();
        }

        private void LoadDGVDocumentSale()
        {
            int LastIDDoc = LenhHayDung.Lhd.GetId("Document");
            gc_HoaDonBan.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(LastIDDoc);
            gv_HoaDonBan.BestFitColumns();
        }

        private void LoadUnit_Document(int idItem)
        {
            repositoryItemGridLookUpEditUnit.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
            repositoryItemGridLookUpEditUnit.DisplayMember = "Name";
            repositoryItemGridLookUpEditUnit.ValueMember = "Id";
            repositoryItemGridLookUpEditUnit.NullText = "Chọn ĐVT";
            //gridColumnUnit.ColumnEdit = repositoryItemGridLookUpEditUnit;
        }

        private void LoadItem_Document()
        {
            repositoryItemGridLookUpEditItem.DataSource = CodeItem.Instance.List_Item();
            repositoryItemGridLookUpEditItem.DisplayMember = "Name";
            repositoryItemGridLookUpEditItem.ValueMember = "Id";
            repositoryItemGridLookUpEditItem.NullText = "Chọn Mặt Hàng";
            repositoryItemGridLookUpEdit1View.BestFitColumns();
            colNameItem_DocSale.ColumnEdit = repositoryItemGridLookUpEditItem;
        }

        
        private void repositoryItemGridLookUpEditItem_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Caption=="Sửa")
            {
                try
                {
                    int id = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colNameItem_DocSale).ToString());
                    using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                    {
                        fr.Id = id;
                        fr.ShowDialog();
                        this.Show();
                        LoadItem_Document();
                        gv_HoaDonBan.SetFocusedRowCellValue(colNameItem_DocSale, fr.Id);
                    }
                }
                catch { }
            }
        }

        private void gv_HoaDon_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "NameItem")
            {
                try
                {
                    //Lấy mã mặt hàng vừa được chọn vào grid
                    int idItem = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colNameItem_DocSale).ToString());
                    //Kiểm tra xem mặt hàng đã có trong chi tiết hóa đơn chưa
                    int Tong = gv_HoaDonBan.RowCount;
                    int kq = 1;
                    for (int i = 0; i < Tong - 1; i++)
                    {
                        if (i != gv_HoaDonBan.GetFocusedDataSourceRowIndex())//Kiểm tra xem có khác với dòng vừa chọn không
                        {
                            if (idItem == int.Parse((gv_HoaDonBan.GetRowCellValue(i, e.Column)).ToString()))
                            {
                                gv_HoaDonBan.CancelUpdateCurrentRow();
                                kq = 0;
                                break;
                            }
                        }
                        else
                            kq = 1;
                    }
                    //Nếu như mặt hàng chưa có
                    if (kq == 1)
                    {
                        //Load mã mặt hàng vừa chọn
                        Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                        gv_HoaDonBan.SetRowCellValue(e.RowHandle, colCodeItem_DocSale, i.Code);

                        //Load VAT mặt hàng
                        gv_HoaDonBan.SetRowCellValue(e.RowHandle, colVAT_DocSale, i.VAT);

                        //Load các đơn vị tính của hàng hóa vừa chọn
                        LoadUnit_Document(idItem);

                        gv_HoaDonBan.SetFocusedRowCellValue(colDiscount_DocSale, 0);

                        ////Load đơn giá cho hàng hóa (đơn giá theo đơn vị tính có hệ số là 1)
                        //UnitPrice up = CodeUnitPrice.Instance.Info_UnitPrice_IdItem(idItem);
                        //if (up != null)
                        //    gv_HoaDonBan.SetRowCellValue(e.RowHandle, "Price", up.Price);
                        //else
                        //{
                        //    MessageBox.Show("Mặt hàng này chưa có giá bán", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    gv_HoaDonBan.SetRowCellValue(e.RowHandle, "Price", 0);
                        //}
                    }
                }
                catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

            //Khi số lượng thay đổi
            if (e.Column == colQuantily_DocSale)
            {
                try
                {
                    decimal vat = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colVAT_DocSale).ToString());
                    int qty = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colQuantily_DocSale).ToString());
                    decimal uprice = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colPrice_DocSale).ToString());
                    decimal amountorigin = qty * uprice;
                    decimal amountvat = amountorigin * vat / 100;
                    decimal amount = amountorigin + amountvat;
                    decimal discount = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colDiscount_DocSale).ToString());
                    decimal amountDiscount = amount * discount / 100;
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountDiscount_DocSale, amountDiscount);
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountOrigin_DocSale, amountorigin);
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountVAT_DocSale, amountvat);
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmount_DocSale, amount);
                }
                catch { }
            }

            //Khi thay đổi mặt hàng khác -> giá bán thay đổi -> thì sẽ load lại các giá trị 
            if(e.Column == colPrice_DocSale)
            {
                try
                {
                    decimal vat = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colVAT_DocSale).ToString());
                    int qty = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colQuantily_DocSale).ToString());
                    decimal uprice = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colPrice_DocSale).ToString());
                    decimal amountorigin = qty * uprice;
                    decimal amountvat = amountorigin * vat / 100;
                    decimal amount = amountorigin + amountvat;
                    decimal discount = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colDiscount_DocSale).ToString());
                    decimal amountDiscount = amount * discount / 100;
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountDiscount_DocSale, amountDiscount);
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountOrigin_DocSale, amountorigin);
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountVAT_DocSale, amountvat);
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmount_DocSale, amount);
                }
                catch { }
            }

            //Sau khi chọn lại đơn vị tính
            if(e.Column == colNameUnit_DocSale)
            {
                try
                {
                    int idItem = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colNameItem_DocSale).ToString());
                    int idUnit = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colNameUnit_DocSale).ToString());
                    decimal uprice = CodeItem.Instance.Price_UnitItem(idItem, idUnit);
                    //Thay đổi giá bán
                    gv_HoaDonBan.SetRowCellValue(e.RowHandle, "Price", uprice);

                    //Thay đổi số lượng còn lại
                    //Đặt số lượng lớn nhất
                    gv_HoaDonBan.SetFocusedRowCellValue(colQuantily_DocSale, 0);
                    repositoryItemSpinEditQlySale.MaxValue = CodeItem.Instance.StockItem_InStore_IdItem_IdUnit(idItem,idUnit,idDocSale);
                    if (repositoryItemSpinEditQlySale.MaxValue == 0)
                    {
                        gv_HoaDonBan.SetFocusedRowCellValue(colNameUnit_DocSale, null);
                        gv_HoaDonBan.CancelUpdateCurrentRow();
                        MessageBox.Show("Hiện tại mặt hàng này trong cửa hàng đã hết", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch
                {
                    MessageBox.Show("Mặt hàng này chưa có giá bán", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gv_HoaDonBan.CancelUpdateCurrentRow();
                }
            }

            //Khi nhập chiết khấu
            if(e.Column == colDiscount_DocSale)
            {
                try
                {
                    decimal amount = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colAmountOrigin_DocSale).ToString());
                    decimal discount = decimal.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colDiscount_DocSale).ToString());
                    decimal amountDiscount = amount * discount / 100;
                    gv_HoaDonBan.SetFocusedRowCellValue(colAmountDiscount_DocSale, amountDiscount);
                }
                catch
                { }
            }
            gv_HoaDonBan.BestFitColumns();
        }

        //Load đơn vị tính của mỗi mặt hàng từng dòng sau khi đổi dòng chọn
        private void gv_HoaDonBan_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int idItem = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colNameItem_DocSale).ToString());
                //Load các đơn vị tính của hàng hóa vừa chọn
                LoadUnit_Document(idItem);

                //Đặt số lượng lớn nhất
                try
                {
                    int idUnit = int.Parse(gv_HoaDonBan.GetFocusedRowCellValue(colNameUnit_DocSale).ToString());
                    repositoryItemSpinEditQlySale.MaxValue = CodeItem.Instance.StockItem_InStore_IdItem_IdUnit(idItem, idUnit, idDocSale);
                }
                catch { gv_HoaDonBan.SetFocusedRowCellValue(colQuantily_DocSale, 0); }
            }
            catch
            {
                repositoryItemGridLookUpEditUnit.DataSource = CodeUnit.Instance.List_Unit();
            }
        }
        private void cb_MaKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idCus = int.Parse(cb_TenKhachHang_HD.EditValue.ToString());
                Customer cus = CodeCustomer.Instance.Info_Customer_Id(idCus);
                tb_MaKhachHang.Text = cus.Code.ToString();
                tb_SdtKH.Text = cus.PhoneNumber.ToString();
                tb_MaSoThue.Text = cus.TaxCode.ToString();
                tb_Email.Text = cus.Email.ToString();
                tb_DiaChi.Text = cus.Address.ToString();
            }
            catch
            {
                MessageBox.Show("Không có khách hàng nào có thông tin như trên!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaKhachHang.Text = "";
                tb_SdtKH.Text = "";
                tb_MaSoThue.Text = "";
                tb_Email.Text = "";
                tb_DiaChi.Text = "";
            }
        }

        //Khi người dùng ấn delete trên grid sẽ xóa dòng đó (chỉ khi nào dừng edit)
        private void gv_HoaDonBan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gv_HoaDonBan.DeleteSelectedRows();
            }
        }

        private void cb_TenKhachHang_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Thêm khách hàng
            if(e.Button.Caption=="Thêm")
            {
                using (ChinhSuaKhachHang fr = new ChinhSuaKhachHang())
                {
                    fr.Text = "Thêm Khách Hàng";
                    fr.ShowDialog();
                    this.Show();

                    //Chọn khách hàng vừa thêm vào combobox
                    cb_TenKhachHang_HD.Properties.DataSource = CodeCustomer.Instance.List_Customer();
                    gridLookUpEditCustomer.BestFitColumns();
                    if (fr.Id!=LenhHayDung.Lhd.GetId("Customer"))
                    {
                        cb_TenKhachHang_HD.EditValue = fr.Id;

                        //Load lại thông tin khách hàng ở từng textbox
                        int idCus = int.Parse(cb_TenKhachHang_HD.EditValue.ToString());
                        Customer cus = CodeCustomer.Instance.Info_Customer_Id(idCus);
                        tb_MaKhachHang.Text = cus.Code.ToString();
                        tb_SdtKH.Text = cus.PhoneNumber.ToString();
                        tb_MaSoThue.Text = cus.TaxCode.ToString();
                        tb_Email.Text = cus.Email.ToString();
                        tb_DiaChi.Text = cus.Address.ToString();
                    }
                }
            }

            //Sửa khách hàng
            if(e.Button.Caption=="Sửa")
            {
                try
                {
                    using (ChinhSuaKhachHang fr = new ChinhSuaKhachHang())
                    {
                        int id = int.Parse(cb_TenKhachHang_HD.EditValue.ToString());
                        fr.Id = id;
                        fr.ShowDialog();
                        this.Show();

                        //Load lại thông tin khách hàng vào combobox
                        cb_TenKhachHang_HD.Properties.DataSource = CodeCustomer.Instance.List_Customer();
                        gridLookUpEditCustomer.BestFitColumns();
                        cb_TenKhachHang_HD.EditValue = fr.Id;

                        //Load lại thông tin khách hàng ở từng textbox
                        int idCus = int.Parse(cb_TenKhachHang_HD.EditValue.ToString());
                        Customer cus = CodeCustomer.Instance.Info_Customer_Id(idCus);
                        tb_MaKhachHang.Text = cus.Code.ToString();
                        tb_SdtKH.Text = cus.PhoneNumber.ToString();
                        tb_MaSoThue.Text = cus.TaxCode.ToString();
                        tb_Email.Text = cus.Email.ToString();
                        tb_DiaChi.Text = cus.Address.ToString();
                    }
                }
                catch { }
            }
        }

        //Xử lý thêm phiếu bán hàng và chi tiết phiếu bán hàng
        private void gC_PhieuBanHang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if(e.Button.Properties.Caption== "Tạo Mới")
            {
                this.idDocSale = LenhHayDung.Lhd.GetId("Document");
                LoadInfo_Document();
                LoadDGVDocumentSale();
            }

            if (e.Button.Properties.Caption == "Đóng")
            {
                xTPBanHang.PageVisible = false;
            }
            if (e.Button.Properties.Caption == "Lưu")
            {
                try
                {
                    string code = tb_MaHoaDonBan.Text;
                    DateTime date = dateEditNgayLapBan.DateTime;
                    int idCustomer = int.Parse(cb_TenKhachHang_HD.EditValue.ToString());
                    int idEmployee = emp.Id;
                    string description = tb_GhiChuBan.Text;

                    //Kiểm tra xem phiếu bán hàng này đã có chưa
                    Document d = CodeDocument.Instance.Info_Document_IdDocument(idDocSale);
                    if(d != null && tb_MaHoaDonBan.Text == d.Code)
                    {
                    //Cập nhật phiếu bán hàng đang có
                    CodeDocument.Instance.UPDATE_DocumentSale_IdDocument(idDocSale, code, date, idCustomer, idEmployee, description);

                    //Cập nhật lại chi tiết phiếu bán hàng thì sẽ xóa hết chi tiết cũ
                    CodeDocDetail.Insatnce.Delete_DocDetailSale_IdDoc(idDocSale);

                    }
                    else
                    {
                        idDocSale = LenhHayDung.Lhd.GetId("Document");
                        //Thêm phiếu bán hàng
                        CodeDocument.Instance.Insert_DocumentSale(idDocSale, code, date, idCustomer, idEmployee, description);  
                    }

                    try
                    {
                        //Thêm chi tiết bán hàng
                        for (int i = 0; i < gv_HoaDonBan.RowCount - 1; i++)
                        {
                            int id = LenhHayDung.Lhd.GetId("DocumentDetail");
                            int idItem = int.Parse(gv_HoaDonBan.GetRowCellValue(i, colNameItem_DocSale).ToString());
                            int idUnit = int.Parse(gv_HoaDonBan.GetRowCellValue(i, colNameUnit_DocSale).ToString());
                            int quantily = int.Parse(gv_HoaDonBan.GetRowCellValue(i, colQuantily_DocSale).ToString());
                            decimal price = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colPrice_DocSale).ToString());
                            decimal amountOrigin = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colAmountOrigin_DocSale).ToString());
                            decimal vat = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colVAT_DocSale).ToString());
                            decimal discount = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colDiscount_DocSale).ToString());
                            decimal amountDiscount = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colAmountDiscount_DocSale).ToString());
                            decimal amountVat = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colAmountVAT_DocSale).ToString());
                            decimal amount = decimal.Parse(gv_HoaDonBan.GetRowCellValue(i, colAmount_DocSale).ToString());
                            CodeDocDetail.Insatnce.Insert_DocumentSaleDetail(id, idDocSale, idItem, idUnit, quantily, price, amountOrigin, discount, amountDiscount, vat, amountVat, amount);
                        }
                    }
                    catch
                    {
                        CodeDocument.Instance.Cancel_Document_IdDoc(idDocSale);
                        MessageBox.Show("Không lưu được phiếu bán hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    CodeDocument.Instance.Cancel_Document_IdDoc(idDocSale);
                    MessageBox.Show("Không lưu được phiếu bán hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if(e.Button.Properties.Caption == "Xuất Phiếu")
            {
                try
                {
                    //Kiểm tra xem phiếu bán hàng này đã có chưa
                    Document d = CodeDocument.Instance.Info_Document_IdDocument(idDocSale);
                    if(d != null && tb_MaHoaDonBan.Text == d.Code)
                    {
                        using (FormReport fr = new FormReport())
                        {
                            using (ReportDocumentSaleDetail report = new ReportDocumentSaleDetail())
                            {
                                report.Document = CodeDocument.Instance.InfoReport_DocumentSale(idDocSale);
                                report.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDocSale);
                                report.Date = dateEditNgayLapBan.DateTime;
                                report.BindDataDocument();
                                report.BindDataDocumentDetail();
                                fr.Report = report;
                                fr.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng lưu phiếu trước khi xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
        }
        #endregion

        #region Nhập Hàng
        private void LoadInfoDocumentImport()
        {
            //Load Nhân Viên Lập
            emp = CodeEmployee.Instance.Info_Employee_IdAccount(idAccount);
            tb_NhanVienLap_PN.Text = emp.Name.ToString();

            //Load Mã Hóa Đơn
            string LastCodeDoc = LenhHayDung.Lhd.GetLastCode("Document", "Code", "PN");
            tb_MaPhieuNhap.Text = LenhHayDung.Lhd.NextCode(LastCodeDoc, "PN");
            //tb_MaHoaDonBan.Text = LenhHayDung.Lhd.GetId("Document").ToString();

            //Load nhà cung cấp
            cb_TenNCC_PN.Properties.DataSource = CodeSupplier.Instance.List_Supplier();
            cb_TenNCC_PN.Properties.DisplayMember = "Name";
            cb_TenNCC_PN.Properties.ValueMember = "Id";
            cb_TenNCC_PN.Properties.NullText = "Chọn Nhà Cung Cấp";
            gridViewNCC_PN.BestFitColumns();

            //Load Ngày hiện hành vào ngày lập hóa đơn
            date_PN.Text = DateTime.Now.ToShortDateString();

            //Load thông tin kho nhập
            cb_KhoNhapPN.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
            cb_KhoNhapPN.Properties.DisplayMember = "Name";
            cb_KhoNhapPN.Properties.ValueMember = "Id";
            gridLookUpEditKhoNhap.BestFitColumns();

        }

        private void cb_TenNCC_PN_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(cb_TenNCC_PN.EditValue.ToString());
                Supplier supplier = CodeSupplier.Instance.Info_Supplier_Id(id);
                tb_MaNCC.Text = supplier.Code;
                tb_SdtNCC.Text = supplier.PhoneNumber;
                tb_FaxNCC_PN.Text = supplier.Fax;
                tb_EmailNCC.Text = supplier.Email;
                tb_DiaChiNCC.Text = supplier.Address;

                //Load danh sách mặt hàng của nhà cung cấp đó
                for (int i = 0; i < gv_PhieuNhap.RowCount - 1; i++)
                {
                    gv_PhieuNhap.DeleteRow(i);
                }
                LoadItem_PN(id);
            }
            catch
            {
                MessageBox.Show("Không có nhà cung cáp nào có thông tin như trên!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_MaNCC.Text = "";
                tb_SdtNCC.Text = "";
                tb_FaxNCC_PN.Text = "";
                tb_EmailNCC.Text = "";
                tb_DiaChiNCC.Text = "";
            }
        }

        private void LoadDGV_PN()
        {
            int LastIDDoc = LenhHayDung.Lhd.GetId("Document");
            gc_PhieuNhap.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(LastIDDoc);
            gv_PhieuNhap.BestFitColumns();
        }

        private void LoadUnit_PN(int idItem)
        {
            repositoryItemGridLookUpEditUnit_PN.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
            repositoryItemGridLookUpEditUnit_PN.DisplayMember = "Name";
            repositoryItemGridLookUpEditUnit_PN.ValueMember = "Id";
            repositoryItemGridLookUpEditUnit_PN.NullText = "Chọn ĐVT";
            //gridColumnUnit.ColumnEdit = repositoryItemGridLookUpEditUnit;
        }

        private void LoadItem_PN(int idSupplier)
        {
            repositoryItemGridLookUpEditItem_PN.DataSource = CodeItem.Instance.List_Item_Supplier(idSupplier);
            repositoryItemGridLookUpEditItem_PN.DisplayMember = "Name";
            repositoryItemGridLookUpEditItem_PN.ValueMember = "Id";
            repositoryItemGridLookUpEditItem_PN.NullText = "Chọn Mặt Hàng";
            gridView3.BestFitColumns();
            col_NameItem_PN.ColumnEdit = repositoryItemGridLookUpEditItem_PN;
        }

        private void repositoryItemGridLookUpEditItem_PN_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Sửa")
            {
                try
                {
                    int id = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_NameItem_PN).ToString());
                    using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                    {
                        fr.Id = id;
                        fr.ShowDialog();
                        this.Show();
                        LoadItem_Document();
                        gv_PhieuNhap.SetFocusedRowCellValue(col_NameItem_PN, fr.Id);
                    }
                }
                catch { }
            }
        }

        //Thêm và sửa nhà cung cấp ở phiếu nhập
        private void cb_TenNCC_PN_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Caption == "Thêm")
            {
                try
                {
                    using (ChinhSuaNCC fr = new ChinhSuaNCC())
                    {
                        fr.Text = "Thêm Nhà Cung Cấp";
                        fr.ShowDialog();
                        this.Show();

                        //Gán NCC vừa thêm vào combobox
                        cb_TenNCC_PN.Properties.DataSource = CodeSupplier.Instance.List_Supplier();
                        gridViewNCC_PN.BestFitColumns();
                        Supplier sup = CodeSupplier.Instance.Info_Supplier_Id(fr.Id);
                        if(sup != null)
                        {
                            cb_TenNCC_PN.EditValue = fr.Id;
                        } 
                    }
                }
                catch
                { }
            }
            if(e.Button.Caption == "Sửa")
            {
                try
                {
                    using (ChinhSuaNCC fr = new ChinhSuaNCC())
                    {
                        fr.Id = int.Parse(cb_TenNCC_PN.EditValue.ToString());
                        fr.ShowDialog();
                        this.Show();
                        cb_TenNCC_PN.Properties.DataSource = CodeSupplier.Instance.List_Supplier();
                        gridViewNCC_PN.BestFitColumns();

                        //load lại thông tin của nhả cung cấp
                        Supplier supplier = CodeSupplier.Instance.Info_Supplier_Id(fr.Id);
                        tb_MaNCC.Text = supplier.Code;
                        tb_SdtNCC.Text = supplier.PhoneNumber;
                        tb_FaxNCC_PN.Text = supplier.Fax;
                        tb_EmailNCC.Text = supplier.Email;
                        tb_DiaChiNCC.Text = supplier.Address;
                    }
                }
                catch
                {

                }
            }
        }

        //Thêm kho và chỉnh sửa kho nhập
        private void cb_KhoNhapPN_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Caption == "Thêm")
            {
                try
                {
                    using (ChinhSuaKho fr = new ChinhSuaKho())
                    {
                        fr.Text = "Thêm Kho";
                        fr.ShowDialog();
                        this.Show();

                        //Gán kho vừa thêm vào combobox
                        cb_KhoNhapPN.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
                        gridLookUpEditKhoNhap.BestFitColumns();
                        Warehouse wh = CodeWarehouse.Instance.Info_Warehouse_Id(fr.Id);
                        if(wh != null)
                        {
                            cb_KhoNhapPN.EditValue = fr.Id;
                        }
                    }
                }
                catch { }
            }

            if(e.Button.Caption == "Sửa")
            {
                try
                {
                    using (ChinhSuaKho fr = new ChinhSuaKho())
                    {
                        fr.Id = int.Parse(cb_KhoNhapPN.EditValue.ToString());
                        fr.ShowDialog();
                        this.Show();
                        cb_KhoNhapPN.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
                    }
                }
                catch { }
            }
        }

        private void gv_PhieuNhap_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "NameItem")
            {
                try
                {
                    //Lấy mã mặt hàng vừa được chọn vào grid
                    int idItem = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_NameItem_PN).ToString());
                    //Kiểm tra xem mặt hàng đã có trong chi tiết hóa đơn chưa
                    int Tong = gv_PhieuNhap.RowCount;
                    int kq = 1;
                    for (int i = 0; i < Tong - 1; i++)
                    {
                        if (i != gv_PhieuNhap.GetFocusedDataSourceRowIndex())//Kiểm tra xem có khác với dòng vừa chọn không
                        {
                            if (idItem == int.Parse((gv_PhieuNhap.GetRowCellValue(i, e.Column)).ToString()))
                            {
                                gv_PhieuNhap.CancelUpdateCurrentRow();
                                kq = 0;
                                break;
                            }
                        }
                        else
                            kq = 1;
                    }
                    //Nếu như mặt hàng chưa có
                    if (kq == 1)
                    {
                        //Load mã mặt hàng vừa chọn
                        Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                        gv_PhieuNhap.SetRowCellValue(e.RowHandle, col_CodeItem_PN, i.Code);

                        //Load VAT mặt hàng
                        gv_PhieuNhap.SetRowCellValue(e.RowHandle, col_VATItem_PN, i.VAT);

                        //Load các đơn vị tính của hàng hóa vừa chọn
                        LoadUnit_PN(idItem);

                        ////Load đơn giá cho hàng hóa (đơn giá theo đơn vị tính có hệ số là 1)
                        //UnitPrice up = CodeUnitPrice.Instance.Info_UnitPrice_IdItem(idItem);
                        //if (up != null)
                        //    gv_HoaDonBan.SetRowCellValue(e.RowHandle, "Price", up.Price);
                        //else
                        //{
                        //    MessageBox.Show("Mặt hàng này chưa có giá bán", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //    gv_HoaDonBan.SetRowCellValue(e.RowHandle, "Price", 0);
                        //}
                    }
                }
                catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }
            //Khi số lượng thay đổi
            if (e.Column == col_QuantilyItem_PN)
            {
                try
                {
                    decimal vat = decimal.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_VATItem_PN).ToString());
                    decimal qty = decimal.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_QuantilyItem_PN).ToString());
                    decimal uprice = decimal.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_PriceItem_PN).ToString());
                    decimal amountorigin = qty * uprice;
                    decimal amountvat = amountorigin * vat / 100;
                    decimal amount = amountorigin + amountvat;
                    gv_PhieuNhap.SetFocusedRowCellValue(col_AmountOrigin_PN, amountorigin);
                    gv_PhieuNhap.SetFocusedRowCellValue(col_AmountVAT_PN, amountvat);
                    gv_PhieuNhap.SetFocusedRowCellValue(col_Amount_PN, amount);
                }
                catch { }
            }

            //Khi thay đổi mặt hàng khác -> giá bán thay đổi -> thì sẽ load lại các giá trị 
            if (e.Column == col_PriceItem_PN)
            {
                try
                {
                    int vat = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_VATItem_PN).ToString());
                    int qty = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_QuantilyItem_PN).ToString());
                    decimal uprice = decimal.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_PriceItem_PN).ToString());
                    decimal amountorigin = qty * uprice;
                    decimal amountvat = amountorigin * vat / 100;
                    decimal amount = amountorigin + amountvat;
                    gv_PhieuNhap.SetFocusedRowCellValue(col_AmountOrigin_PN, amountorigin);
                    gv_PhieuNhap.SetFocusedRowCellValue(col_AmountVAT_PN, amountvat);
                    gv_PhieuNhap.SetFocusedRowCellValue(col_Amount_PN, amount);
                }
                catch { }
            }

            //Sau khi chọn lại đơn vị tính
            if (e.Column == col_UnitItem_PN)
            {
                try
                {
                    int idItem = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_NameItem_PN).ToString());
                    int idUnit = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_UnitItem_PN).ToString());
                    decimal uprice = CodeItem.Instance.ImportPrice_UnitItem(idItem, idUnit);
                    //Thay đổi giá bán
                    gv_PhieuNhap.SetRowCellValue(e.RowHandle, "Price", uprice);
                }
                catch
                {
                    MessageBox.Show("Mặt hàng này chưa có giá nhập", "Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gv_PhieuNhap.CancelUpdateCurrentRow();
                }
            }
            gv_HoaDonBan.BestFitColumns();
        }

        //Load đơn vị tính của mỗi mặt hàng từng dòng sau khi đổi dòng chọn
        private void gv_PhieuNhap_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int idItem = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_NameItem_PN).ToString());
                //Load các đơn vị tính của hàng hóa vừa chọn
                LoadUnit_PN(idItem);
            }
            catch
            {
                repositoryItemGridLookUpEditUnit_PN.DataSource = CodeUnit.Instance.List_Unit();
            }
        }

        private void gv_PhieuNhap_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if(e.FocusedColumn != col_UnitItem_PN)
                    repositoryItemGridLookUpEditUnit_PN.DataSource = CodeUnit.Instance.List_Unit();
                else
                {
                    try
                    {
                        int idItem = int.Parse(gv_PhieuNhap.GetFocusedRowCellValue(col_NameItem_PN).ToString());
                        //Load các đơn vị tính của hàng hóa vừa chọn
                        LoadUnit_PN(idItem);
                    }
                    catch
                    {
                        repositoryItemGridLookUpEditUnit_PN.DataSource = CodeUnit.Instance.List_Unit();
                    }
                }
            }
            catch { }
        }

        private void gv_PhieuNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                gv_PhieuNhap.DeleteSelectedRows();
            }
        }


        private void gC_PhieuNhapHang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tạo Mới")
            {
                this.idDocImport = LenhHayDung.Lhd.GetId("Document");
                LoadInfoDocumentImport();
                LoadDGV_PN();
            }

            if (e.Button.Properties.Caption == "Đóng")
            {
                xTPNhapHang.PageVisible = false;
            }
            if (e.Button.Properties.Caption == "Lưu")
            {
                try
                {
                    string code = tb_MaPhieuNhap.Text;
                    DateTime date = date_PN.DateTime;
                    int idSupplier = int.Parse(cb_TenNCC_PN.EditValue.ToString());
                    int idWarehouse = int.Parse(cb_KhoNhapPN.EditValue.ToString());
                    int idEmployee = emp.Id;
                    string description = tb_GhiChuPN.Text;

                    //Kiểm tra xem phiếu bán hàng này đã có chưa
                    Document d = CodeDocument.Instance.Info_Document_IdDocument(idDocImport);
                    if (d != null && tb_MaPhieuNhap.Text == d.Code)
                    {
                        //Cập nhật phiếu bán hàng đang có
                        CodeDocument.Instance.UPDATE_DocumentImport_IdDocument(idDocImport, code, date, idSupplier, idEmployee, description);

                        //Cập nhật lại chi tiết phiếu bán hàng thì sẽ xóa hết chi tiết cũ
                        CodeDocDetail.Insatnce.Delete_DocDetailSale_IdDoc(idDocImport);

                    }
                    else
                    {
                        idDocImport = LenhHayDung.Lhd.GetId("Document");
                        //Thêm phiếu bán hàng
                        CodeDocument.Instance.Insert_DocumentImport(idDocImport, code, date, idSupplier, idEmployee, description);
                    }

                    try
                    {
                        //Thêm chi tiết bán hàng
                        for (int i = 0; i < gv_PhieuNhap.RowCount - 1; i++)
                        {
                            int id = LenhHayDung.Lhd.GetId("DocumentDetail");
                            int idItem = int.Parse(gv_PhieuNhap.GetRowCellValue(i, col_NameItem_PN).ToString());
                            int idUnit = int.Parse(gv_PhieuNhap.GetRowCellValue(i, col_UnitItem_PN).ToString());
                            int quantily = int.Parse(gv_PhieuNhap.GetRowCellValue(i, col_QuantilyItem_PN).ToString());
                            decimal price = decimal.Parse(gv_PhieuNhap.GetRowCellValue(i, col_PriceItem_PN).ToString());
                            decimal amountOrigin = decimal.Parse(gv_PhieuNhap.GetRowCellValue(i, col_AmountOrigin_PN).ToString());
                            decimal vat = decimal.Parse(gv_PhieuNhap.GetRowCellValue(i, col_VATItem_PN).ToString());
                            decimal amountVat = decimal.Parse(gv_PhieuNhap.GetRowCellValue(i, col_AmountVAT_PN).ToString());
                            decimal amount = decimal.Parse(gv_PhieuNhap.GetRowCellValue(i, col_Amount_PN).ToString());
                            CodeDocDetail.Insatnce.Insert_DocumentImportDetail(id, idDocImport, idItem, idWarehouse, idUnit, quantily, price, amountOrigin, vat, amountVat, amount);
                        }
                    }
                    catch
                    {
                        CodeDocument.Instance.Cancel_Document_IdDoc(idDocImport);
                        MessageBox.Show("Không lưu được phiếu nhập hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    CodeDocument.Instance.Cancel_Document_IdDoc(idDocSale);
                    MessageBox.Show("Không lưu được phiếu nhập hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (e.Button.Properties.Caption == "Xuất Phiếu")
            {
                try
                {
                    //Kiểm tra xem phiếu bán hàng này đã có chưa
                    Document d = CodeDocument.Instance.Info_Document_IdDocument(idDocImport);
                    if (d != null && tb_MaPhieuNhap.Text == d.Code)
                    {
                        using (FormReport fr = new FormReport())
                        {
                            using (ReportDocumentImportDetail report = new ReportDocumentImportDetail())
                            {
                                report.Document = CodeDocument.Instance.InfoReport_DocumentImport(idDocImport);
                                report.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDocImport);
                                report.Date = date_PN.DateTime;
                                report.BindDataDocument();
                                report.BindDataDocumentDetail();
                                fr.Report = report;
                                fr.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng lưu phiếu trước khi xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
        }

        #endregion

        #region Xuất Hàng
        private void LoadInfoDocumentExport()
        {
            //Load Nhân Viên Lập
            emp = CodeEmployee.Instance.Info_Employee_IdAccount(idAccount);
            tb_NhanVienLap_PX.Text = emp.Name.ToString();

            //Load Mã Hóa Đơn
            string LastCodeDoc = LenhHayDung.Lhd.GetLastCode("Document", "Code", "PX");
            tb_MaPhieuXuat.Text = LenhHayDung.Lhd.NextCode(LastCodeDoc, "PX");
            //tb_MaHoaDonBan.Text = LenhHayDung.Lhd.GetId("Document").ToString();

            //Load Ngày hiện hành vào ngày lập hóa đơn
            date_PX.Text = DateTime.Now.ToShortDateString();

            //Load thông tin kho nhập
            cb_KhoXuat_PX.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
            cb_KhoXuat_PX.Properties.DisplayMember = "Name";
            cb_KhoXuat_PX.Properties.ValueMember = "Id";
            gridViewKhoXuat.BestFitColumns();

        }

        private void LoadDGV_PX()
        {
            int LastIDDoc = LenhHayDung.Lhd.GetId("Document");
            gC_PhieuXuat.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(LastIDDoc);
            gV_PhieuXuat.BestFitColumns();
        }

        private void LoadItem_DocumentExport(int idWarehouse)
        {
            repositoryItemGridLookUpEditItem_PX.DataSource = CodeItem.Instance.List_Item_Warehouse(idWarehouse);
            repositoryItemGridLookUpEditItem_PX.DisplayMember = "Name";
            repositoryItemGridLookUpEditItem_PX.ValueMember = "Id";
            repositoryItemGridLookUpEditItem_PX.NullText = "Chọn Mặt Hàng";
            gridViewItem_PX.BestFitColumns();
            col_NameItem_PX.ColumnEdit = repositoryItemGridLookUpEditItem_PX;
        }

        private void cb_KhoXuat_PX_EditValueChanged(object sender, EventArgs e)
        {
            int idWarehouse = int.Parse(cb_KhoXuat_PX.EditValue.ToString());
            LoadItem_DocumentExport(idWarehouse);
        }

        private void cb_KhoXuat_PX_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Thêm")
            {
                try
                {
                    using (ChinhSuaKho fr = new ChinhSuaKho())
                    {
                        fr.Text = "Thêm Kho";
                        fr.ShowDialog();
                        this.Show();

                        //Gán kho vừa thêm vào combobox
                        cb_KhoXuat_PX.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
                        gridViewKhoXuat.BestFitColumns();
                        Warehouse wh = CodeWarehouse.Instance.Info_Warehouse_Id(fr.Id);
                        if (wh != null)
                        {
                            cb_KhoXuat_PX.EditValue = fr.Id;
                        }
                    }
                }
                catch { }
            }

            if (e.Button.Caption == "Sửa")
            {
                try
                {
                    using (ChinhSuaKho fr = new ChinhSuaKho())
                    {
                        fr.Id = int.Parse(cb_KhoXuat_PX.EditValue.ToString());
                        fr.ShowDialog();
                        this.Show();
                        cb_KhoXuat_PX.Properties.DataSource = CodeWarehouse.Instance.ListWarehouse();
                    }
                }
                catch { }
            }
        }

        private void LoadUnit_DocumentExport(int idItem)
        {
            repositoryItemGridLookUpEditUnit_PX.DataSource = CodeUnit.Instance.List_UnitItem_IdItem(idItem);
            repositoryItemGridLookUpEditUnit_PX.DisplayMember = "Name";
            repositoryItemGridLookUpEditUnit_PX.ValueMember = "Id";
            repositoryItemGridLookUpEditUnit_PX.NullText = "Chọn ĐVT";
            //gridColumnUnit.ColumnEdit = repositoryItemGridLookUpEditUnit;
        }

        private void repositoryItemGridLookUpEditItem_PX_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "Sửa")
            {
                try
                {
                    int id = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_NameItem_PX).ToString());
                    using (ChinhSuaMatHang fr = new ChinhSuaMatHang())
                    {
                        fr.Id = id;
                        fr.ShowDialog();
                        this.Show();
                        int idWarehouse = int.Parse(cb_KhoXuat_PX.EditValue.ToString());
                        LoadItem_DocumentExport(idWarehouse);
                        gV_PhieuXuat.SetFocusedRowCellValue(col_NameItem_PX, fr.Id);
                    }
                }
                catch { }
            }
        }

        private void gV_PhieuXuat_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "NameItem")
            {
                try
                {
                    //Lấy mã mặt hàng vừa được chọn vào grid
                    int idItem = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_NameItem_PX).ToString());
                    //Kiểm tra xem mặt hàng đã có trong chi tiết hóa đơn chưa
                    int Tong = gV_PhieuXuat.RowCount;
                    int kq = 1;
                    for (int i = 0; i < Tong - 1; i++)
                    {
                        if (i != gV_PhieuXuat.GetFocusedDataSourceRowIndex())//Kiểm tra xem có khác với dòng vừa chọn không
                        {
                            if (idItem == int.Parse((gV_PhieuXuat.GetRowCellValue(i, e.Column)).ToString()))
                            {
                                gV_PhieuXuat.CancelUpdateCurrentRow();
                                kq = 0;
                                break;
                            }
                        }
                        else
                            kq = 1;
                    }
                    //Nếu như mặt hàng chưa có
                    if (kq == 1)
                    {
                        //Load mã mặt hàng vừa chọn
                        Item i = CodeItem.Instance.Info_Item_IdItem(idItem);
                        gV_PhieuXuat.SetRowCellValue(e.RowHandle, col_CodeItem_PX, i.Code);

                        //Load các đơn vị tính của hàng hóa vừa chọn
                        LoadUnit_DocumentExport(idItem);
                    }
                }
                catch { MessageBox.Show("Vui lòng chọn lại mặt hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            }

            //Sau khi chọn lại đơn vị tính
            if (e.Column == col_Unit_PX)
            {
                int idItem = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_NameItem_PX).ToString());
                int idUnit = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_Unit_PX).ToString());
                int idWarehouse = int.Parse(cb_KhoXuat_PX.EditValue.ToString());
                decimal uprice = CodeItem.Instance.Price_UnitItem(idItem, idUnit);

                //Thay đổi giá bán
                gV_PhieuXuat.SetFocusedRowCellValue(col_Price_PX, uprice);
                //Thay đổi số lượng còn lại
                //Đặt số lượng lớn nhất
                gV_PhieuXuat.SetFocusedRowCellValue(col_Quantily_PX, 0);
                repositoryItemSpinEditQly_PX.MaxValue = CodeItem.Instance.StockItem_InWarehouse_IdItem_IdUnit(idItem, idUnit, idDocExport, idWarehouse);
                if (repositoryItemSpinEditQly_PX.MaxValue == 0)
                {
                    gV_PhieuXuat.CancelUpdateCurrentRow();
                    MessageBox.Show("Hiện tại mặt hàng này trong kho hàng này đã hết", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            if (e.Column == col_Price_PX)
            {
                try
                {
                    int qty = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_Quantily_PX).ToString());
                    decimal uprice = decimal.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_Price_PX).ToString());
                    decimal amountorigin = qty * uprice;
                    gV_PhieuXuat.SetFocusedRowCellValue(col_AmountOrigin_PX, amountorigin);
                }
                catch { }
            }

            if(e.Column == col_Quantily_PX)
            {
                try
                {
                    int qty = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_Quantily_PX).ToString());
                    decimal uprice = decimal.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_Price_PX).ToString());
                    decimal amountorigin = qty * uprice;
                    gV_PhieuXuat.SetFocusedRowCellValue(col_AmountOrigin_PX, amountorigin);
                }
                catch { }
            }
            gV_PhieuXuat.BestFitColumns();
        }

        private void gV_PhieuXuat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int idItem = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_NameItem_PX).ToString());
                //Load các đơn vị tính của hàng hóa vừa chọn
                LoadUnit_DocumentExport(idItem);
            }
            catch
            {
                repositoryItemGridLookUpEditUnit_PX.DataSource = CodeUnit.Instance.List_Unit();
            }
        }

        private void gV_PhieuXuat_FocusedColumnChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventArgs e)
        {
            try
            {
                if (e.FocusedColumn != col_Unit_PX)
                    repositoryItemGridLookUpEditUnit_PX.DataSource = CodeUnit.Instance.List_Unit();
                else
                {
                    try
                    {
                        int idItem = int.Parse(gV_PhieuXuat.GetFocusedRowCellValue(col_NameItem_PX).ToString());
                        //Load các đơn vị tính của hàng hóa vừa chọn
                        LoadUnit_DocumentExport(idItem);
                    }
                    catch
                    {
                        repositoryItemGridLookUpEditUnit_PX.DataSource = CodeUnit.Instance.List_Unit();
                    }
                }
            }
            catch { }
        }

        private void gC_XuatHang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Tạo Mới")
            {
                this.idDocExport = LenhHayDung.Lhd.GetId("Document");
                LoadInfoDocumentExport();
                LoadDGV_PX();
            }

            if (e.Button.Properties.Caption == "Đóng")
            {
                xTPXuathang.PageVisible = false;
            }
            if (e.Button.Properties.Caption == "Lưu")
            {
                try
                {
                    string code = tb_MaPhieuXuat.Text;
                    DateTime date = date_PX.DateTime;
                    int idWarehouse = int.Parse(cb_KhoXuat_PX.EditValue.ToString());
                    int idEmployee = emp.Id;
                    string description = tb_GhiChu_PX.Text;

                    //Kiểm tra xem phiếu bán hàng này đã có chưa
                    Document d = CodeDocument.Instance.Info_Document_IdDocument(idDocExport);
                    if (d != null && tb_MaPhieuXuat.Text == d.Code)
                    {
                        //Cập nhật phiếu bán hàng đang có
                        CodeDocument.Instance.UPDATE_DocumentExport_IdDocument(idDocExport, code, date, idEmployee, description);

                        //Cập nhật lại chi tiết phiếu bán hàng thì sẽ xóa hết chi tiết cũ
                        CodeDocDetail.Insatnce.Delete_DocDetailSale_IdDoc(idDocExport);

                    }
                    else
                    {
                        idDocExport = LenhHayDung.Lhd.GetId("Document");
                        //Thêm phiếu bán hàng
                        CodeDocument.Instance.Insert_DocumentExport(idDocExport, code, date, idEmployee, description);
                    }

                    try
                    {
                        //Thêm chi tiết bán hàng
                        for (int i = 0; i < gV_PhieuXuat.RowCount - 1; i++)
                        {
                            int id = LenhHayDung.Lhd.GetId("DocumentDetail");
                            int idItem = int.Parse(gV_PhieuXuat.GetRowCellValue(i, col_NameItem_PX).ToString());
                            int idUnit = int.Parse(gV_PhieuXuat.GetRowCellValue(i, col_Unit_PX).ToString());
                            int quantily = int.Parse(gV_PhieuXuat.GetRowCellValue(i, col_Quantily_PX).ToString());
                            decimal price = decimal.Parse(gV_PhieuXuat.GetRowCellValue(i, col_Price_PX).ToString());
                            decimal amountOrigin = decimal.Parse(gV_PhieuXuat.GetRowCellValue(i, col_AmountOrigin_PX).ToString());
                            CodeDocDetail.Insatnce.Insert_DocumentExportDetail(id, idDocExport, idItem, idWarehouse, idUnit, quantily, price, amountOrigin);
                        }
                    }
                    catch
                    {
                        CodeDocument.Instance.Cancel_Document_IdDoc(idDocExport);
                        MessageBox.Show("Không lưu được phiếu xuất hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    CodeDocument.Instance.Cancel_Document_IdDoc(idDocSale);
                    MessageBox.Show("Không lưu được phiếu xuất hàng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if(e.Button.Properties.Caption == "Xuất Phiếu")
            {
                try
                {
                    //Kiểm tra xem phiếu bán hàng này đã có chưa
                    Document d = CodeDocument.Instance.Info_Document_IdDocument(idDocExport);
                    if (d != null && tb_MaPhieuXuat.Text == d.Code)
                    {
                        using (FormReport fr = new FormReport())
                        {
                            using (ReportDocumentExportDetail report = new ReportDocumentExportDetail())
                            {
                                report.Document = CodeDocument.Instance.InfoReport_DocumentExport(idDocExport);
                                report.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDocExport);
                                report.Date = date_PX.DateTime;
                                report.BindDataDocument();
                                report.BindDataDocumentDetail();
                                fr.Report = report;
                                fr.ShowDialog();
                                this.Show();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng lưu phiếu trước khi xuất", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch { }
            }
        }
        #endregion

        #region Tổng Quan

        private void LoadTuNgayDenNgay()
        {
            dateEditTuNgay.DateTime = DateTime.Parse("1/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString());
            dateEditDenNgay.DateTime = DateTime.Now;
        }
        private void LoadDGVDonHangGanNhat()
        {
            gC_DonHangGanNhat.DataSource = CodeDocument.Instance.List_DocumentSale_FromTo_(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
        }

        private void dateEditTuNgay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gC_DonHangGanNhat.DataSource = CodeDocument.Instance.List_DocumentSale_FromTo_(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
                if (gV_DonHangGanNhat.RowCount == 0)
                    gC_ChiTietDonHang.DataSource = null;
                else
                {
                    gV_DonHangGanNhat.BestFitColumns();
                    int idDoc = int.Parse(gV_DonHangGanNhat.GetFocusedRowCellValue(gridColumnIdDocSale).ToString());
                    gC_ChiTietDonHang.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                    gV_ChiTietDonHang.BestFitColumns();
                }
                LoadOverview();
            }
            catch { }
        }

        private void dateEditDenNgay_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                gC_DonHangGanNhat.DataSource = CodeDocument.Instance.List_DocumentSale_FromTo_(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime);
                if (gV_DonHangGanNhat.RowCount == 0)
                    gC_ChiTietDonHang.DataSource = null;
                else
                {
                    gV_DonHangGanNhat.BestFitColumns();
                    int idDoc = int.Parse(gV_DonHangGanNhat.GetFocusedRowCellValue(gridColumnIdDocSale).ToString());
                    gC_ChiTietDonHang.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                    gV_ChiTietDonHang.BestFitColumns();
                }
                LoadOverview();
            }
            catch { }
        }

        private void gV_DonHangGanNhat_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                int idDoc = int.Parse(gV_DonHangGanNhat.GetFocusedRowCellValue(gridColumnIdDocSale).ToString());
                gC_ChiTietDonHang.DataSource = CodeDocDetail.Insatnce.LIST_DocumentSaleDetail_IdDocument(idDoc);
                gV_ChiTietDonHang.BestFitColumns();
            }
            catch{}
        }

        private void LoadOverview()
        {
            //lb_DTHomNay.Text = CodeDocument.Instance.TotalRevenue_FromTo(DateTime.Now, DateTime.Now).ToString() + " đ";
            //lb_DoanhThu.Text = CodeDocument.Instance.TotalRevenue_FromTo(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime).ToString() + " đ";
            //lb_TongDon.Text = gV_DonHangGanNhat.RowCount.ToString();
        }
        #endregion
        public void LoadGiaoDien()
        {
            //DevExpress.LookAndFeel.DefaultLookAndFeel GiaoDien = new DevExpress.LookAndFeel.DefaultLookAndFeel();
            //GiaoDien.LookAndFeel.SkinName = "McSkin";//Chọn giao diện cho lúc đầu load form
        }

        private void frBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Close();
        }

        private void bt_TaoTKNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (TaoTKNhanVien fr = new TaoTKNhanVien())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_DoiMatKhau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DoiMatKhau fr = new DoiMatKhau())
            {
                Account a = CodeAccount.Instance.Info_Account_Id(idAccount);
                fr.Id = a.Id;
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_BanHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xTPBanHang.PageVisible = true;
            tabHienThi.SelectedTabPage = xTPBanHang;
        }

        private void bt_ThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (EditEmployee fr = new EditEmployee())
            {
                fr.Id = emp.Id;
                fr.Code = emp.Code;
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_DanhSachNV_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachNhanVien fr = new DanhSachNhanVien())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_DanhSachKhachHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachKhachHang fr = new DanhSachKhachHang())
            {
                fr.ShowDialog();
                this.Show();
                cb_TenKhachHang_HD.Properties.DataSource = CodeCustomer.Instance.List_Customer();
            }
        }

        private void bt_TonKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (TonKho fr = new TonKho())
            {
                fr.ShowDialog();
                this.Show();
            }
        }
        
        private void bt_DanhSachMatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachMatHang fr = new DanhSachMatHang())
            {
                fr.ShowDialog();
                this.Show();
                repositoryItemGridLookUpEditItem.DataSource = CodeItem.Instance.List_Item();
            }
        }

        private void bt_DanhSachLoaiMH_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachLoaiHang fr = new DanhSachLoaiHang())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_MuaHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xTPNhapHang.PageVisible = true;
            tabHienThi.SelectedTabPage = xTPNhapHang;
        }

        private void bt_DangXuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            this.Close();
        }

        private void Time_Tick(object sender, EventArgs e)
        {
            StatusTime.Caption = DateTime.Now.ToLongTimeString();
            Time.Start();
        }

        private void navBarDoiMatKhau_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (DoiMatKhau fr = new DoiMatKhau())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void navBarThongTinCaNhan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (EditEmployee fr = new EditEmployee())
            {
                fr.Id = emp.Id;
                fr.ShowDialog();
                this.Show();
            }
        }

        private void navBarTaoTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (TaoTKNhanVien fr = new TaoTKNhanVien())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachTaiKhoan fr = new DanhSachTaiKhoan())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void navBarDanhSachTaiKhoan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (DanhSachTaiKhoan fr = new DanhSachTaiKhoan())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void gC_PhieuMuaHang_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            if (e.Button.Properties.Caption == "Đóng")
            {
                xTPNhapHang.PageVisible = false;
            }
        }

        private void navBarItem24_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTPBanHang.PageVisible = true;
        }

        private void navBarMuaHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            xTPNhapHang.PageVisible = true;
        }

        private void bt_DSNCC_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachNCC fr = new DanhSachNCC())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void navBarDanhSachNhaCungCap_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (DanhSachNCC fr = new DanhSachNCC())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void navBarTonKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (TonKho fr = new TonKho())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_NhapKho_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ChuyenKho fr = new ChuyenKho())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void navBarChuyenKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            using (ChuyenKho fr = new ChuyenKho())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void bt_PhieuXuatHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xTPXuathang.PageVisible = true;
            tabHienThi.SelectedTabPage = xTPXuathang;
        }

        private void bt_DanhSachDVT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachDVT fr = new DanhSachDVT())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (DanhSachKho fr = new DanhSachKho())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void tabHienThi_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.XtraTabControl tabControl = sender as DevExpress.XtraTab.XtraTabControl;
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs closeEventArg = e as DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs;
            (closeEventArg.Page as DevExpress.XtraTab.XtraTabPage).PageVisible = false;
        }

        private void bt_TongQuan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            xTPTongQuan.PageVisible = true;
            tabHienThi.SelectedTabPage = xTPTongQuan;
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoNVBH fr = new BaoCaoNVBH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoSanPhamBH fr = new BaoCaoSanPhamBH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoKhachHangBH fr = new BaoCaoKhachHangBH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem8_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoNCCBH fr = new BaoCaoNCCBH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoNVNH fr = new BaoCaoNVNH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoNVXH fr = new BaoCaoNVXH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoSanPhamNH fr = new BaoCaoSanPhamNH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoKhoNH fr = new BaoCaoKhoNH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoNCCNH fr = new BaoCaoNCCNH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoSanPhamXH fr = new BaoCaoSanPhamXH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoKhoXH fr = new BaoCaoKhoXH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (BaoCaoNCCXH fr = new BaoCaoNCCXH())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ReportDocumentSaleForm fr = new ReportDocumentSaleForm())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ReportDocumentExportForm fr = new ReportDocumentExportForm())
            {
                fr.ShowDialog();
                this.Show();
            }
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ReportDocumentImportForm fr = new ReportDocumentImportForm())
            {
                fr.ShowDialog();
                this.Show();
            }
        }
    }
}
