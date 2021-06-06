using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyBanHang.Data;
using System.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeGroupItem
    {
        private static CodeGroupItem instance;

        public static CodeGroupItem Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeGroupItem();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeGroupItem() { }

        public GroupItem Info_GroupItem_IdItem(int IdItem)
        {
            string sql = "EXEC dbo.Info_GroupItem_IdItem @IdItem = " + IdItem;
            GroupItem gi = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach (DataRow rw in table.Rows)
                {
                    gi = new GroupItem(rw);
                }
            }
            return gi;
        }

        public List<GroupItem> List_GroupItem()
        {
            string sql = "EXEC dbo.List_GroupItem";
            List<GroupItem> List = new List<GroupItem>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    GroupItem gi = new GroupItem(rw);
                    List.Add(gi);
                }
            }
            return List;
        }

        public GroupItem Info_GroupItem_IdGroupItem(int IdGroupItem)
        {
            string sql = "EXEC dbo.Info_GroupItem_IdGroupItem @IdGroupItem = " + IdGroupItem;
            GroupItem gi = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    gi = new GroupItem(rw);
                }
            }
            return gi;
        }

        public void Update_GroupItem_IdGroupItem(int id, string code, string name)
        {
            string sql = "EXECUTE dbo.Update_GroupItem_IdGroupItem " + id + ", N'" + code + "', N'" + name + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_GroupItem(int id, string code, string name)
        {
            string sql = "EXEC dbo.Insert_GroupItem " + id + ", N'" + code + "', N'" + name + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Delete_GroupItem_IdGroupItem(int IdGroupItem)
        {
            string sql = "EXEC dbo.Delete_GroupItem_IdGroupItem @IdGroupItem = " + IdGroupItem;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }
    }
}
