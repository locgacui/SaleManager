using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeSupplier
    {
        private static CodeSupplier instance;

        public static CodeSupplier Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeSupplier();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeSupplier() { }

        public List<Supplier> List_Supplier()
        {
            string sql = "EXEC dbo.List_Supplier";
            List<Supplier> list = new List<Supplier>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    Supplier sup = new Supplier(rw);
                    list.Add(sup);
                }
            }
            return list;
        }

        public DataTable Data_Supplier()
        {
            string sql = "EXEC dbo.List_Supplier";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public Supplier Info_Supplier_Id(int id)
        {
            string sql = "EXEC dbo.Info_Supplier_Id @Id = " + id;
            Supplier sup = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    sup = new Supplier(rw);
                }
            }
            return sup;
        }


        public void Insert_Supplier(int id, string code, string name, string phonenumber, string address, string fax, string email)
        {
            string sql = "EXEC dbo.Insert_Supplier " + id + ", " + code + ", N'" + name + "', '" + phonenumber + "', N'" + address + "', '" + fax + "', N'" + email + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Update_Supplier_Id(int id, string code, string name, string phonenumber, string address, string fax, string email)
        {
            string sql= "EXEC dbo.Update_Supplier_Id " + id + ", " + code + ", N'" + name + "', '" + phonenumber + "', N'" + address + "', '" + fax + "', N'" + email + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Delete_Supplier_Id(int id)
        {
            string sql = "EXEC dbo.Delete_Supplier_Id @Id = " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public DataTable Report_SaleSupplier(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_SaleSupplier @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_SaleSupplier()
        {
            string sql = "EXEC dbo.ReportAll_SaleSupplier";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ImportSupplier(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ImportSupplier @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ImportSupplier()
        {
            string sql = "EXEC dbo.ReportAll_ImportSupplier";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ExportSupplier(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ExportSupplier @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ExportSupplier()
        {
            string sql = "EXEC dbo.ReportAll_ExportSupplier";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }
    }
}
