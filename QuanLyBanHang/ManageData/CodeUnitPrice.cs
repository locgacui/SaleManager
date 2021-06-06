using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeUnitPrice
    {
        private static CodeUnitPrice instance;

        public static CodeUnitPrice Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeUnitPrice();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeUnitPrice() { }

        public UnitPrice Info_UnitPrice_IdItem(int IdItem)
        {
            string code = "EXEC dbo.Info_UnitPrice_IdItem @IdItem = " + IdItem;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            UnitPrice unitprice = null;
            foreach(DataRow rw in table.Rows)
            {
                unitprice = new UnitPrice(rw);
                return unitprice;
            }
            return unitprice;
        }

        public List<UnitPrice> List_UnitPrice_IdItem(int IdItem)
        {
            string code = "EXEC dbo.List_UnitPrice_IdItem @IdItem = " + IdItem;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            List<UnitPrice> list = new List<UnitPrice>();
            foreach(DataRow rw in table.Rows)
            {
                UnitPrice unitprice = new UnitPrice(rw);
                list.Add(unitprice);
            }
            return list;
        }

        public void Insert_UnitPrice(int id, int iditem, decimal price, string dateupdate)
        {
            string sql = "EXEC dbo.Insert_UnitPrice " + id + ", " + iditem + ", " + price + ", '" + dateupdate + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }
    }
}
