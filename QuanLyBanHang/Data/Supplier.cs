using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Supplier
    {
        public Supplier(int id, string code, string name, string phoneNumber, string address, string fax, string email)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.phoneNumber = phoneNumber;
            this.address = address;
            this.fax = fax;
            this.email = email;
        }

        public Supplier(DataRow rw)
        {
            this.id = int.Parse(rw["id"].ToString());
            this.code = rw["code"].ToString().Trim();
            this.name = rw["name"].ToString().Trim();
            this.phoneNumber = rw["phoneNumber"].ToString().Trim();
            this.address = rw["Address"].ToString().Trim();
            this.fax = rw["Fax"].ToString().Trim();
            this.email = rw["Email"].ToString().Trim();
        }

        private int id;
        private string code;
        private string name;
        private string phoneNumber;
        private string address;
        private string fax;
        private string email;

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

        public string Code
        {
            get
            {
                return code;
            }

            set
            {
                code = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }

            set
            {
                phoneNumber = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string Fax
        {
            get
            {
                return fax;
            }

            set
            {
                fax = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
