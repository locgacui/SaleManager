using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Customer
    {
        public Customer(int id, string code, string name, string phonenumber, DateTime dayofbirth, string address, string taxcode, string sex, string email)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.phoneNumber = phonenumber;
            this.dayOfBirth = dayofbirth;
            this.address = address;
            this.taxCode = taxcode;
            this.sex = sex;
            this.email = email;
        }

        public Customer(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.code = rw["Code"].ToString().Trim();
            this.name = rw["Name"].ToString().Trim();
            this.phoneNumber = rw["PhoneNumber"].ToString();
            this.dayOfBirth = DateTime.Parse(rw["DayOfBirth"].ToString());
            this.address = rw["Address"].ToString().Trim();
            this.taxCode = rw["TaxCode"].ToString().Trim();
            this.sex = rw["Sex"].ToString().Trim();
            this.email = rw["Email"].ToString().Trim();
        }

        private int id;
        private string code;
        private string name;
        private string phoneNumber;
        private DateTime dayOfBirth;
        private string address;
        private string taxCode;
        private string sex;
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

        public DateTime DayOfBirth
        {
            get
            {
                return dayOfBirth;
            }

            set
            {
                dayOfBirth = value;
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

        public string TaxCode
        {
            get
            {
                return taxCode;
            }

            set
            {
                taxCode = value;
            }
        }

        public string Sex
        {
            get
            {
                return sex;
            }

            set
            {
                sex = value;
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
    }
}
