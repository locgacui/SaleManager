using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using QuanLyBanHang.Data;

namespace QuanLyBanHang.ManageData
{
    public class CodeEmployee
    {
        private static CodeEmployee instance;

        public static CodeEmployee Instance
        {
            get
            {
                if (instance == null)
                    instance = new CodeEmployee();
                return instance;
            }

            private set
            {
                instance = value;
            }
        }

        private CodeEmployee() { }

        public List<Employee> ListEmployee()
        {
            string sql = "EXEC dbo.List_Employee";
            List<Employee> list = new List<Employee>();
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
            {
                foreach(DataRow rw in table.Rows)
                {
                    Employee emp = new Employee(rw);
                    list.Add(emp);
                }
            }
            return list;
        }

        public DataTable Data_List_Employee()
        {
            string sql = "EXEC dbo.List_Employee";
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql))
                return table;
        }

        public void Insert_Employee(int id,string code , string name, DateTime dateofbirth, string sex, string position, string cmnd, string address, string phonenumber, string email)
        {
            string c = "EXEC Insert_Employee " + id + ", N'" + code + "', N'" + name + "', '" + dateofbirth.ToString("yyyy-MM-dd") + "', N'" + sex + "', N'" + position + "', N'" + cmnd + "', N'" + address + "', '" + phonenumber + "', '" + email + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(c);
        }

        public void Delete_Employee_Id(int id)
        {
            string code = "EXEC Delete_Employee_Id " + id;
            LenhHayDung.Lhd.ExecuteNonQuery(code);
        }

        public Employee Info_Employee_Id(int id)
        {
            string code = "EXEC Info_Employee_Id " + id;
            Employee emp = null;
            using (DataTable table = LenhHayDung.Lhd.ExecuteQuery(code))
            {
                foreach (DataRow rw in table.Rows)
                    emp = new Employee(rw);
            }
            return emp;
        }

        public DataTable Data_Info_Employee_Id(int id)
        {
            string sql = "EXEC Info_Employee_Id " + id;
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public void Update_Employee(int id, string code, string name, DateTime dateofbirth, string sex, string position, string cmnd, string address, string phonenumber, string email)
        {
            string c = "EXEC Update_Employee " + id + ", N'" + code + "', N'" + name + "', '" + dateofbirth.ToString("yyyy-MM-dd") + "', N'" + sex + "', N'" + position + "', '" + cmnd + "', N'" + address + "', '" + phonenumber + "', '" + email + "'";
            LenhHayDung.Lhd.ExecuteNonQuery(c);
        }

        public List<Employee> Find_Employee(string Find)
        {
            List<Employee> list = new List<Employee>();
            DataTable emp = new DataTable();
            string code = "EXEC Find_Employee N'" + Find + "'";
            emp = LenhHayDung.Lhd.ExecuteQuery(code);

            foreach (DataRow rw in emp.Rows)
            {
                Employee employee = new Employee(rw);
                list.Add(employee);
            }
            return list;
        }

        public List<Employee> List_Employee_NotAccount()
        {
            List<Employee> list = new List<Employee>();
            string code = "EXEC dbo.List_Employee_NotAccount";
            DataTable emp = LenhHayDung.Lhd.ExecuteQuery(code);
            foreach(DataRow rw in emp.Rows)
            {
                Employee employee = new Employee(rw);
                list.Add(employee);
            }
            return list;
        }

        public void Insert_Picture(int id, string DuongDan)
        {
            string code = "UPDATE dbo.Employee SET Picture = (SELECT * FROM Openrowset( Bulk N'" + DuongDan + "', Single_Blob) as image) WHERE Id = " + id + "";
            LenhHayDung.Lhd.ExecuteNonQuery(code);
        }

        public Employee Info_Employee_IdAccount(int id)
        {
            string code = "EXEC dbo.Info_Employee_IdAccount " + id + "";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(code);
            Employee emp = null;
            foreach(DataRow rw in table.Rows)
            {
                emp = new Employee(rw);
                return emp;
            }
            return emp;
        }

        public DataTable Report_SaleEmployee(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_SaleEmployee @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_SaleEmployee()
        {
            string sql = "EXEC dbo.ReportAll_SaleEmployee";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ExportEmployee(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ExportEmployee @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ExportEmployee()
        {
            string sql = "EXEC dbo.ReportAll_ExportEmployee";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable Report_ImportEmployee(DateTime DateFrom, DateTime DateTo)
        {
            string sql = @"EXEC dbo.Report_ImportEmployee @DateFrom = '" + DateFrom.ToString("yyyy-MM-dd") + @"', --date
                          @DateTo = '" + DateTo.ToString("yyyy-MM-dd") + "'-- date";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }

        public DataTable ReportAll_ImportEmployee()
        {
            string sql = "EXEC dbo.ReportAll_ImportEmployee";
            DataTable table = LenhHayDung.Lhd.ExecuteQuery(sql);
            return table;
        }
    }
}
