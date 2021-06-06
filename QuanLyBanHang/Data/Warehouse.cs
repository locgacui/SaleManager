using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Warehouse
    {
        public Warehouse(int id, string code, string name, string address, string phonenumber)
        {
            this.id = id;
            this.code = code;
            this.name = name;
            this.address = address;
            this.phoneNumber = phonenumber;
        }

        public Warehouse(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.code = rw["Code"].ToString().Trim();
            this.name = rw["Name"].ToString().Trim();
            this.address = rw["Address"].ToString().Trim();
            this.phoneNumber = rw["PhoneNumber"].ToString().Trim();
        } 

        private int id;
        private string code;
        private string name;
        private string address;
        private string phoneNumber;

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
    }
}
