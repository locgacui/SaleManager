using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Account
    {
        public Account(int id, string username, string password, int idemployee)
        {
            this.id = id;
            this.userName = username;
            this.password = password;
            this.idEmployee = idemployee;
        }

        public Account(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.userName = rw["Username"].ToString().Trim();
            this.password = rw["Password"].ToString().Trim();
            this.idEmployee = int.Parse(rw["IdEmployee"].ToString());
        }

        private int id;
        private string userName;
        private string password;
        private int idEmployee;

        public string UserName
        {
            get
            {
                return userName;
            }

            set
            {
                userName = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public int IdEmployee
        {
            get
            {
                return idEmployee;
            }

            set
            {
                idEmployee = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
