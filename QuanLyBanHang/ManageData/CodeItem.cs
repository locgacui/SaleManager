using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeItem
    {
        private static CodeItem instance;

        public static CodeItem Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeItem();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeItem() { }

        public List<Item> List_Item()
        {
            string sql = "EXEC dbo.List_Item";
            List<Item> list = new List<Item>();
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            foreach(DataRow rw in table.Rows)
            {
                Item item = new Item(rw);
                list.Add(item);
            }
            return list;
        } 

        public List<Item> List_Item_Warehouse(int idWarehouse)
        {
            string sql = "EXEC dbo.List_Item_Warehouse @IdWarehouse = " + idWarehouse;
            List<Item> list = new List<Item>();
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            foreach(DataRow rw in table.Rows)
            {
                Item item = new Item(rw);
                list.Add(item);
            }
            return list;
        }

        public void Insert_Picture(int id, string DuongDan)
        {
            string code = "UPDATE dbo.Item SET Picture = (SELECT * FROM Openrowset( Bulk N'" + DuongDan + "', Single_Blob) as image) WHERE Id = " + id + "";
            LenhHayDung.Lhd.ExecuteNonQuery(code);
        }

        public List<Item> List_Item_Supplier(int idSupplier)
        {
            string sql = "EXEC dbo.List_Item_Supplier @IdSupplier = " + idSupplier;
            List<Item> list = new List<Item>();
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            foreach (DataRow rw in table.Rows)
            {
                Item item = new Item(rw);
                list.Add(item);
            }
            return list;
        }

        public DataTable Data_Item()
        {
            string sql = "EXEC dbo.List_Item";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public Item Info_Item_IdItem(int IdItem)
        {
            string sql = "EXEC dbo.Info_Item_IdItem " + IdItem;
            Item item = null;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            foreach(DataRow rw in table.Rows)
            {
                item = new Item(rw);
                return item;
            }
            return item;
        }

        public DataTable Data_Info_Item_IdItem(int IdItem)
        {
            string sql = "EXEC dbo.Info_Item_IdItem " + IdItem;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
                return table;
        }

        public void Update_Item_IdItem(int id, int idSupplier, string code, string name, int idgroupitem, float entryprice, decimal vat, string description)
        {
            string sql = "EXEC dbo.Update_Item_IdItem " + id + ", " + idSupplier + ", N'" + code + "', N'" + name + "', " + idgroupitem + ", " + entryprice + ", " + vat + ", N'" + description + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_Item(int id, int idSupplier, string code, string name, int idgroupitem, float entryprice, decimal vat, string description)
        {
            string sql= "EXEC dbo.Insert_Item " + id + ", " + idSupplier + ", N'" + code + "', N'" + name + "', " + idgroupitem + ", " + entryprice + ", " + vat + ", N'" + description + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Delete_Item_IdItem(int idItem)
        {
            string sql = "EXEC dbo.Delete_Item_IdItem @IdItem = " + idItem;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public int StockItem_InStore_IdItem_IdUnit(int idItem, int idUnit, int idDoc)
        {
            string sql = "SELECT dbo.StockItem_InStore_IdItem_IdUnit(" + idItem + ", " + idUnit + ", " + idDoc + ")";
            try
            {
                int qly = int.Parse(LenhHayDung.Lhd.ExecuteScalar(sql).ToString());
                return qly;
            }
            catch { return 0; }
        }

        public int StockItem_InWarehouse_IdItem_IdUnit(int idItem, int idUnit, int idDoc, int idWarehouse)
        {
            string sql = "SELECT dbo.StockItem_InWarehouse_IdItem_IdUnit(" + idItem + "," + idUnit + "," + idDoc + "," + idWarehouse + ")";
            try
            {
                int qly = int.Parse(LenhHayDung.Lhd.ExecuteScalar(sql).ToString());
                return qly;
            }
            catch { return 0; }
        }

        public decimal Price_UnitItem(int idItem, int idUnit)
        {
            string sql = "SELECT dbo.Price_UnitItem(" + idItem + ", " + idUnit + ")";
            try
            {
                decimal price = decimal.Parse(LenhHayDung.Lhd.ExecuteScalar(sql).ToString());
                return price;
            }
            catch { return 0; }
        }

        public decimal ImportPrice_UnitItem(int idItem, int idUnit)
        {
            string sql = "SELECT dbo.ImportPrice_UnitItem(" + idItem + ", " + idUnit + ")";
            try
            {
                decimal price = decimal.Parse(LenhHayDung.Lhd.ExecuteScalar(sql).ToString());
                return price;
            }
            catch
            {
                return 0;
            }
        }

        public DataTable Report_SaleItem(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_SaleItem @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_SaleItem()
        {
            string sql = "EXEC dbo.ReportAll_SaleItem";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ImportItem(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ImportItem @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ImportItem()
        {
            string sql = "EXEC dbo.ReportAll_ImportItem";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ExportItem(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ExportItem @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ExportItem()
        {
            string sql = "EXEC dbo.ReportAll_ExportItem";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }
    }
}
