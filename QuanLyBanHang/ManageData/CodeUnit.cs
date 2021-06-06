using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeUnit
    {
        private static CodeUnit instance;

        public static CodeUnit Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeUnit();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeUnit() { }
        
        public DataTable List_UnitItem_IdItem(int IdItem)
        {
            string code = "EXEC dbo.List_UnitItem_IdItem @IdItem = " + IdItem;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            return table;
        }

        public List<Unit> List_NotExistUnit_IdItem(int IdItem)
        {
            string sql = "EXEC dbo.List_NotExistUnit_IdItem @IdItem = " + IdItem;
            List<Unit> list = new List<Unit>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    Unit u = new Unit(rw);
                    list.Add(u);
                }
            }
            return list;
        }

        public void Insert_ItemUnit(int IdItem, int IdUnit, int Coefficient)
        {
            string sql = "EXEC dbo.Insert_ItemUnit " + IdItem + ", " + IdUnit + " , " + Coefficient;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Update_ItemUnit_IdUnit_IdItem(int IdItem, int IdUnit, int Coefficient)
        {
            string sql = @"EXEC dbo.Update_ItemUnit_IdUnit_IdItem @IdItem = " + IdItem + @",     -- int
                                       @IdUnit = " + IdUnit + @",     -- int
                                       @Coefficient = " + Coefficient + @" -- int";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Delete_ItemUnit(int IdItem, int IdUnit)
        {
            string sql = "EXEC dbo.Delete_ItemUnit " + IdItem + ", " + IdUnit;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public List<Unit> List_Unit()
        {
            string sql = "EXEC dbo.List_Unit";
            List<Unit> list = new List<Unit>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    Unit u = new Unit(rw);
                    list.Add(u);
                }
            }
            return list;
        }

        public void Insert_Unit(int id, string code, string name)
        {
            string sql = "EXEC dbo.Insert_Unit " + id + ", N'" + code + "', N'" + name + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Update_Unit_Id(int id, string code, string name)
        {
            string sql= "EXEC dbo.Update_Unit_Id " + id + ", N'" + code + "', N'" + name + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Delete_Unit_Id(int id)
        {
            string sql = "EXEC dbo.Delete_Unit_Id @Id = " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public Unit Info_Unit_Id(int id)
        {
            string sql = "EXEC dbo.Info_Unit_Id @Id = " + id;
            Unit u = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach (DataRow rw in table.Rows)
                    u = new Unit(rw);
            }
            return u;
        }

        public Unit Info_Unit_IdItem_IdUnit(int idIditem, int idUnit)
        {
            string sql = @"EXEC dbo.Info_Unit_IdItem_IdUnit @IdItem = " + idIditem + @", -- int
                                 @IdUnit = " + idUnit + @"-- int";
            Unit u = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    u = new Unit(rw);
                }
            }
            return u;
        }
    }
}
