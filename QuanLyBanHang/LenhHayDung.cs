using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanHang
{
    class LenhHayDung
    {
        private static LenhHayDung lhd;

        //public string cn = "Data Source=ERP-LOCNT38\\SQLEXPRESS;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        public string cn = "workstation id=QuanLyBanHang2021.mssql.somee.com;packet size=4096;user id=ufm17DTH_MIS_SQLLogin_1;pwd=99p2lls6zs;data source=QuanLyBanHang2021.mssql.somee.com;persist security info=False;initial catalog=QuanLyBanHang2021";
        //public string cn = "Data Source=SNOWFOX\\SQLEXPRESS;Initial Catalog=ThucTap_BanHang_Bravo;Persist Security Info=True;User ID=sa; Password=locgacui";
        //public string cn = "Data Source=DESKTOP-LL06IO8;Initial Catalog=QuanLyBanHang;Integrated Security=True";
        internal static LenhHayDung Lhd
        {
            get
            {
                if (lhd == null) lhd = new LenhHayDung();
                return lhd;
            }

            set
            {
                lhd = value;
            }
        }
        public string Cn
        {
            get
            {
                return cn;
            }

            set
            {
                cn = value;
            }
        }

        private LenhHayDung() { }

        private SqlConnection con;

        public void connect()
        {
            try
            {
                con = new SqlConnection(cn);
                con.Open();
            }
            catch
            {
                MessageBox.Show("Không Kết nối tới CSDL", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void disconect()
        {
            con.Close();
            con.Dispose();
            con = null;
        }

        public DataTable ExecuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(cn))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }

            return data;
        }

        public int ExecuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(cn))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }

            return data;
        }

        public object ExecuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(cn))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' ');
                    int i = 0;
                    foreach (string item in listPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }

            return data;
        }

        public int GetId(string TableName)
        {
            int id = 1;
            string code = "select * from " + TableName;
            using (DataTable table = ExecuteQuery(code))
            {
                foreach (DataRow rw in table.Rows)
                {
                    if (id == int.Parse(rw["Id"].ToString()))
                        id++;
                }
            }
            return id;
        }

        public string GetLastCode(string nameTable, string nameSelectColumn, string type)
        {
            string sql = "SELECT TOP 1 " + nameSelectColumn + " FROM " + nameTable + " WHERE " + nameSelectColumn + " LIKE N'"+ type + "%' ORDER BY " + nameSelectColumn + " DESC";
            return (string)ExecuteScalar(sql);
        }

        public string GetLastCode_Document(string TypeDoc)
        {
            string sql = "SELECT TOP 1 Code FROM dbo.Document WHERE Code LIKE '" + TypeDoc + "%' ORDER BY Code DESC";
            return (string)ExecuteScalar(sql);
        }

        public string NextCode(string lastCode, string prefixCode)
        {
            if (lastCode == "")
            {
                return prefixCode + "0001";  // fixwidth default
            }
            int nextID = int.Parse(lastCode.Remove(0, prefixCode.Length)) + 1;
            int lengthNumerID = lastCode.Length - prefixCode.Length;
            string zeroNumber = "";
            for (int i = 1; i <= lengthNumerID; i++)
            {
                if (nextID < Math.Pow(10, i))
                {
                    for (int j = 1; j <= lengthNumerID - i; i++)
                    {
                        zeroNumber += "0";
                    }
                    return prefixCode + zeroNumber + nextID.ToString();
                }
            }
            return prefixCode + nextID;
        }
    }
}
