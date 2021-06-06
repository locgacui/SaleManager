using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeCustomer
    {
        private static CodeCustomer instance;

        public static CodeCustomer Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeCustomer();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        public CodeCustomer() { }

        public List<Customer> List_Customer()
        {
            string code = "EXEC dbo.List_Customer";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            List<Customer> list = new List<Customer>();
            foreach(DataRow rw in table.Rows)
            {
                Customer customer = new Customer(rw);
                list.Add(customer);
            }
            return list;
        }

        public DataTable Table_Customer()
        {
            string code = "EXEC dbo.List_Customer";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            return table;
        }

        public Customer Info_Customer_Id(int id)
        {
            string code = "EXEC dbo.Info_Customer_Id @Id = " + id;
            Customer customer = null;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            foreach(DataRow rw in table.Rows)
            {
                customer = new Customer(rw);
                return customer;
            }
            return customer;
        }

        public void Delete_Customer_Id(int id)
        {
            string sql = "EXEC dbo.Delete_Customer_Id @IdCustomer = " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Update_Customer_Id(int id, string code, string name, string phonenumber, DateTime dateofbirth, string address, string taxcode, string sex, string email)
        {
            string sql = "EXEC dbo.Update_Customer_Id " + id + ", N'" + code + "', N'" + name + "', N'" + phonenumber + "', '" + dateofbirth.ToString("yyyy-MM-dd") + "', N'" + address + "', N'" + taxcode + "', N'" + sex + "', '" + email + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public void Insert_Customer(int id, string code, string name, string phonenumber, DateTime dateofbirth, string address, string taxcode, string sex, string email)
        {
            string sql= "EXEC dbo.Insert_Customer " + id + ", N'" + code + "', N'" + name + "', N'" + phonenumber + "', '" + dateofbirth.ToString("yyyy-MM-dd") + "', N'" + address + "', N'" + taxcode + "', N'" + sex + "', '" + email + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(sql);
        }

        public DataTable Report_SaleCustomer(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_SaleCustomer @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_SaleCustomer()
        {
            string sql = "EXEC dbo.ReportAll_SaleCustomer";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }
    }
}
