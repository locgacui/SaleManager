using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Document
    {
        public Document(int id, string code, DateTime date, int? idCustomer, int idEmployee, int? idSupplier, string description)
        {
            this.id = id;
            this.Code = code;
            this.date = date;
            this.idCustomer = idCustomer;
            this.idEmployee = idEmployee;
            this.idSupplier = idSupplier;
            this.description = description;
        }

        public Document(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.Code = rw["Code"].ToString();
            this.date = DateTime.Parse(rw["Date"].ToString());
            if(rw["IdCustomer"].ToString() != "")
                this.idCustomer = (int?)(rw["IdCustomer"]);
            this.idEmployee = int.Parse(rw["IdEmployee"].ToString());
            if(rw["IdSupplier"].ToString() != "")
                this.idSupplier = (int?)(rw["IdSupplier"]);
            this.description = rw["Description"].ToString();
        }

        private int id;
        private string code;
        private DateTime date;
        private int? idCustomer;
        private int idEmployee;
        private int? idSupplier;
        private string description;

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

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public int? IdCustomer
        {
            get
            {
                return idCustomer;
            }

            set
            {
                idCustomer = value;
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

        public int? IdSupplier
        {
            get
            {
                return idSupplier;
            }

            set
            {
                idSupplier = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
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
