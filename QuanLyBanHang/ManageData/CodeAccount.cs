using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeAccount
    {
        private static CodeAccount instance;

        public static CodeAccount Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeAccount(); 
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeAccount() { }

        public void Insert_Account(int id, string username, string password, int idemployee)
        {
            string code = "EXEC Insert_Account " + id + ", N'" + username + "', N'" + password + "', " + idemployee;
            LenhHayDung.Lhd.ExecuteNonQuery(code);
        }

        public void Update_Account_Id(int id, string password)
        {
            string sql = "EXEC dbo.Update_Account_Id " + id + ", '" + password + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Delete_Account_Id(int id)
        {
            string sql = "EXEC dbo.Delete_Account_Id @Id = " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public Account Info_Account_Id(int id)
        {
            string sql = "EXEC dbo.Info_Account_Id @Id = " + id;
            Account a = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach (DataRow rw in table.Rows)
                    a = new Account(rw);
            }
            return a;
        }

        public Account Info_Account_UserNamePassword(string UserName, string Password)
        {
            string sql = "EXEC dbo.Info_Account_UserNamePassword '" + UserName + "', '" + Password + "'";
            Account a = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach (DataRow rw in table.Rows)
                {
                    a = new Account(rw);
                }
            }
            return a;
        }
        public bool Check_UserName(string UserName)
        {
            string code = "EXEC dbo.Check_UserName N'" + UserName + "'";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public bool Login_Account(string UserName, string Password)
        {
            string code = "EXEC Login_Account '" + UserName + "', '" + Password + "'";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public List<Account> List_Account()
        {
            string code = "EXEC dbo.List_Account";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            List<Account> list = new List<Account>();
            foreach(DataRow rw in table.Rows)
            {
                Account account = new Account(rw);
                list.Add(account);
            }
            return list;
        }

        public DataTable Data_List_Account()
        {
            string sql = "EXEC dbo.List_Account";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }
    }
}
