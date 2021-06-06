using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeWarehouse
    {
        private static CodeWarehouse instance;

        internal static CodeWarehouse Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeWarehouse();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeWarehouse() { }

        public List<Warehouse> ListWarehouse()
        {
            string sql = "EXEC dbo.List_Warehouse";
            List<Warehouse> list = new List<Warehouse>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    Warehouse warehouse = new Warehouse(rw);
                    list.Add(warehouse);
                }
            }
            return list;
        }

        public Warehouse Info_Warehouse_Id(int id)
        {
            string sql = "EXEC dbo.Info_Warehouse_Id @Id = " + id;
            Warehouse warehouse = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    warehouse = new Warehouse(rw);
                }
            }
            return warehouse;
        }

        public DataTable Item_Warehouse_IdItem(int idItem)
        {
            string code = "EXEC Item_Warehouse_IdItem " + idItem;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            return table;
        }

        public void Delete_Warehouse_Id(int id)
        {
            string sql = "EXEC dbo.Delete_Warehouse_Id @Id = " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_Warehouse(int id, string code, string name, string address, string phoneNumber)
        {
            string sql = @"EXEC dbo.Insert_Warehouse @Id = " + id + @",           -- int
                          @Code = N'"+code+@"',       --nchar(10)
                          @Name = N'"+name+@"',       --nvarchar(50)
                          @Address = N'"+address+@"',    --nvarchar(100)
                          @PhoneNumber = N'"+phoneNumber+@"'-- nchar(10)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Update_Warehouse_Id(int id, string code, string name, string address, string phoneNumber)
        {
            string sql = @"EXEC dbo.Update_Warehouse_Id @Id = "+id+@",           -- int
                             @Code = N'"+code+@"',       -- nchar(10)
                             @Name = N'"+name+@"',       -- nvarchar(50)
                             @Address = N'"+address+@"',    -- nvarchar(100)
                             @PhoneNumber = N'"+phoneNumber+@"' -- nchar(10)";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public DataTable Report_Stock_IdWareHouse_FromTo(int IdWarehouse, DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_Stock_IdWareHouse_FromTo @IdWarehouse = " + IdWarehouse + @",         -- int
                          @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ImportWarehouse(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ImportWarehouse @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ImportWarehouse()
        {
            string sql = "EXEC dbo.ReportAll_ImportWarehouse";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ExportWarehouse(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ExportWarehouse @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ExportWarehouse()
        {
            string sql = "EXEC dbo.ReportAll_ExportWarehouse";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }
    }
}
