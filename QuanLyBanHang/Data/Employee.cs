using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Employee
    {
        public Employee(int id,string code, string name, DateTime dateofbirth, string sex, string position, string cmnd, string address, string phonenumber, string email, byte[] picture, bool isactive)
        {
            this.Id = id;
            this.Code = code;
            this.Name = name;
            this.DateOfBirth = dateofbirth;
            this.Sex = sex;
            this.Position = position;
            this.CMND = cmnd;
            this.Address = address;
            this.PhoneNumber = phonenumber;
            this.Email = email;
            this.Picture = picture;
        }

        public Employee(DataRow rw)
        {
            this.Id = int.Parse(rw["Id"].ToString().Trim());
            this.Code = rw["Code"].ToString().Trim();
            this.Name = rw["Name"].ToString().Trim();
            this.DateOfBirth = DateTime.Parse(rw["DateOfBirth"].ToString().Trim());
            this.Sex = rw["Sex"].ToString().Trim();
            this.Position = rw["Position"].ToString().Trim();
            this.CMND = rw["CMND"].ToString().Trim();
            this.Address = rw["Address"].ToString().Trim();
            this.PhoneNumber = rw["PhoneNumber"].ToString().Trim();
            this.Email = rw["Email"].ToString().Trim();
        }

        private int id;
        private string code;
        private string name;
        private DateTime dateOfBirth;
        private string sex;
        private string position;
        private string cMND;
        private string address;
        private string phoneNumber;
        private string email;
        private byte[] picture;

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

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
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

        public string Position
        {
            get
            {
                return position;
            }

            set
            {
                position = value;
            }
        }

        public string CMND
        {
            get
            {
                return cMND;
            }

            set
            {
                cMND = value;
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

        public byte[] Picture
        {
            get
            {
                return picture;
            }

            set
            {
                picture = value;
            }
        }
    }
}
