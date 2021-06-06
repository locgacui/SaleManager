using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Data;
using System.Data;
using System.Data.Entity;

namespace QuanLyBanHang.ManageData
{
    public class CodeDocDetail
    {
        private static CodeDocDetail insatnce;

        public static CodeDocDetail Insatnce
        {
            get
            {
                if (insatnce == null)
                    insatnce = new CodeDocDetail();
                return insatnce;
            }

            private set
            {
                insatnce = value;
            }
        }

        public CodeDocDetail() { }

        public DataTable LIST_DocumentSaleDetail_IdDocument(int IdDocument)
        {
            string code = "EXEC dbo.LIST_DocumentSaleDetail_IdDocument " + IdDocument;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            return table;
        }

        public void Insert_DocumentSaleDetail(int id, int idDocument, int idItem, int idUnit, int quantily, decimal price, decimal amountOrigin, decimal discount, decimal amountDiscount, decimal vat, decimal amountVat, decimal amount)
        {
            string sql = @"EXEC dbo.Insert_DocumentSaleDetail @Id = "+ id +@",                -- int
                                   @IdDocument = "+ idDocument + @",        -- int
                                   @IdItem = "+ idItem + @",            -- int
                                   @IdUnit = "+ idUnit + @",            -- int
                                   @Quantily = "+ quantily + @",          -- int
                                   @Price = "+ price + @",          -- decimal(15, 2)
                                   @AmountOrigin = "+ amountOrigin + @",   -- decimal(15, 2)
                                   @Discount = "+ discount + @",       -- decimal(15, 1)
                                   @AmountDiscount = "+ amountDiscount + @", -- decimal(15, 2)
                                   @VAT = "+ vat + @",            -- decimal(15, 1)
                                   @AmountVAT = "+ amountVat + @",      -- decimal(15, 2)
                                   @Amount = "+ amount + @"          -- decimal(15, 2)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_DocumentImportDetail(int id, int idDocument, int idItem, int idWarehouse, int idUnit, int quantily, decimal price, decimal amountOrigin, decimal vat, decimal amountVat, decimal amount)
        {
            string sql = @"EXEC dbo.Insert_DocumentImportDetail @Id = " + id + @",              -- int
                                     @IdDocument = " + idDocument + @",      -- int
                                     @IdItem = " + idItem + @",          -- int
                                     @IdWarehouse = " + idWarehouse + @",     -- int
                                     @IdUnit = " + idUnit + @",          -- int
                                     @Quantily = " + quantily + @",        -- int
                                     @Price = " + price + @",        -- decimal(15, 2)
                                     @AmountOrigin = " + amountOrigin + @", -- decimal(15, 2)
                                     @VAT = " + vat + @",             -- int
                                     @AmountVAT = " + amountVat + @",    -- decimal(15, 2)
                                     @Amount = " + amount + @"        -- decimal(15, 2)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_DocumentExportDetail(int id, int idDocument, int idItem, int idWarehouse, int idUnit, int quantily, decimal price, decimal amountOrigin)
        {
            string sql = @"EXEC dbo.Insert_DocumentExportDetail @Id = " + id + @",              -- int
                                     @IdDocument = " + idDocument + @",      -- int
                                     @IdItem = " + idItem + @",          -- int
                                     @IdWarehouse = " + idWarehouse + @",     -- int
                                     @IdUnit = " + idUnit + @",          -- int
                                     @Quantily = " + quantily + @",
                                     @Price = "+price+@",
                                     @AmountOrigin = "+amountOrigin;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);       
        }

        public void Delete_DocDetailSale_IdDoc(int idDoc)
        {
            string sql = "EXEC dbo.Delete_DocDetailSale_IdDoc @IdDoc = " + idDoc;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }
    }
}
