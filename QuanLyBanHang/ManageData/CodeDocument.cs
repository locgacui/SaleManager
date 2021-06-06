using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeDocument
    {
        private static CodeDocument instance;

        public static CodeDocument Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeDocument();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeDocument() { }

        public List<Document> List_Document()
        {
            string code = "EXEC dbo.List_Document";
            List<Document> list = new List<Document>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
            {
                foreach (DataRow rw in table.Rows)
                {
                    Document document = new Document(rw);
                    list.Add(document);
                }
            }
            return list;
        }

        public DataTable Table_Document()
        {
            string code = "EXEC dbo.List_Document";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }

        public DataTable List_DocumentImport_FromTo_(DateTime DateFrom, DateTime DateTo)
        {
            string sql = "EXEC dbo.List_DocumentImport_FromTo_ @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + " 12:00:00" + "', @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + " 23:59:59" + "'";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
                return table;
        }

        public DataTable List_DocumentExport_FromTo_(DateTime DateFrom, DateTime DateTo)
        {
            string sql = "EXEC dbo.List_DocumentExport_FromTo_ @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + " 12:00:00" + "', @DateTo = '"+ DateTo.ToString("yyyy-MM-dd") + " 23:59:59"+"'";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
                return table;
        }

        public DataTable List_DocumentSale_FromTo_(DateTime DateFrom, DateTime DateTo)
        {
            string sql = "EXEC dbo.List_DocumentSale_FromTo_ @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + " 12:00:00" + "', @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + " 23:59:59" + "'";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
                return table;
        }

        public void Insert_DocumentSale(int id, string code, DateTime date, int idCustomer, int idEmployee, string Description)
        {
            string sql = "EXEC dbo.Insert_DocumentSale " + id + ", N'" + code + "', '" + date.ToString("yyyy-MM-dd") + " " + date.ToShortTimeString() + "', " + idCustomer + ", " + idEmployee + ", N'" + Description + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_DocumentImport(int id, string code, DateTime date, int idSupplier, int idEmployee, string Description)
        {
            string sql = @"EXEC dbo.Insert_DocumentImport @Id = " + id + @",                       -- int
                               @Code = N'" + code + @"',                   -- nchar(10)
                               @Date = '" + date.ToString("yyyy-MM-dd") + " " + date.ToLongTimeString() + @"', -- datetime
                               @IdSupplier = " + idSupplier + @",               -- int
                               @IdEmployee = " + idEmployee + @",               -- int
                               @Description = N'" + Description + "'             -- nvarchar(150)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_DocumentExport(int id, string code, DateTime date, int idEmployee, string Description)
        {
            string sql = @"EXEC dbo.Insert_DocumentExport @Id = " + id + @",                       -- int
                               @Code = N'" + code + @"',                   -- nchar(10)
                               @Date = '" + date.ToString("yyyy-MM-dd") + @"', -- datetime
                               @IdEmployee = " + idEmployee + @",               -- int
                               @Description = N'" + Description + "'             -- nvarchar(150)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Cancel_Document_IdDoc(int id)
        {
            string sql = "EXEC dbo.Cancel_Document_IdDoc @Id = " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public Document Info_Document_IdDocument(int id)
        {
            string sql = "EXEC dbo.Info_Document_IdDocument @IdDocument = " + id;
            Document doc = null;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            foreach(DataRow rw in table.Rows)
            {
                doc = new Document(rw);
                if (doc != null)
                    break;
            }
            return doc;
        }

        public void UPDATE_DocumentSale_IdDocument(int id, string code, DateTime date, int idCustomer, int idEmployee, string Description)
        {
            string sql= "EXEC dbo.UPDATE_DocumentSale_IdDocument " + id + ", N'" + code + "', '" + date.ToString("yyyy-MM-dd") + " " + date.ToShortTimeString() + "', " + idCustomer + ", " + idEmployee + ", N'" + Description + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void UPDATE_DocumentImport_IdDocument(int id, string code, DateTime date, int idSupplier, int idEmployee, string Description)
        {
            string sql = @"EXEC dbo.UPDATE_DocumentImport_IdDocument @Id = " + id + @",                       -- int
                               @Code = N'" + code + @"',                   -- nchar(10)
                               @Date = '" + date.ToString("yyyy-MM-dd") + " " + date.ToShortTimeString() + @"', -- datetime
                               @IdSupplier = " + idSupplier + @",               -- int
                               @IdEmployee = " + idEmployee + @",               -- int
                               @Description = N'" + Description + "'             -- nvarchar(150)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void UPDATE_DocumentExport_IdDocument(int id, string code, DateTime date, int idEmployee, string Description)
        {
            string sql = @"EXEC dbo.UPDATE_DocumentExport_IdDocument @Id = " + id + @",                       -- int
                               @Code = N'" + code + @"',                   -- nchar(10)
                               @Date = '" + date.ToString("yyyy-MM-dd") + @"', -- datetime
                               @IdEmployee = " + idEmployee + @",               -- int
                               @Description = N'" + Description + "'             -- nvarchar(150)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public decimal TotalRevenue_FromTo(DateTime DateFrom, DateTime DateTo)
        {
            try
            {
                string sql = "SELECT dbo.TotalRevenue_FromTo('" + DateFrom.ToString("yyyy-MM-dd") + " 12:00:00" + "', '" + DateTo.ToString("yyyy-MM-dd") + " 23:59:59" + "')";
                return decimal.Parse(LenhHayDung.Lhd.ExecuteScalar(sql).ToString());
            }
            catch
            {
                return 0;
            }
        }

        public DataTable ListAll_DocumentSale()
        {
            string code = "EXEC dbo.ListAll_DocumentSale";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }

        public DataTable ListAll_DocumentExport()
        {
            string code = "EXEC dbo.ListAll_DocumentExport";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }

        public DataTable ListAll_DocumentImport()
        {
            string code = "EXEC dbo.ListAll_DocumentImport";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }

        public DataTable InfoReport_DocumentSale(int id)
        {
            string code = "EXEC dbo.InfoReport_DocumentSale @Id = " + id;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }

        public DataTable InfoReport_DocumentExport(int id)
        {
            string code = "EXEC dbo.InfoReport_DocumentExport @Id = " + id;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }

        public DataTable InfoReport_DocumentImport(int id)
        {
            string code = "EXEC dbo.InfoReport_DocumentImport @Id = " + id;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
                return table;
        }
    }
}
