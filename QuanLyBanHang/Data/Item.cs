using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class Item
    {
        public Item(int id, int idSupplier, string code, string name, string idgroupitem, float entryprice, decimal vat, string description)
        {
            this.id = id;
            this.idSupplier = idSupplier;
            this.code = code;
            this.name = name;
            this.idGroupItem = idgroupitem;
            this.entryPrice = entryprice;
            this.vAT = vat;
            this.description = description;
        }

        public Item(DataRow rw)
        {
            this.id = int.Parse(rw["id"].ToString());
            this.idSupplier = int.Parse(rw["idSupplier"].ToString());
            this.code = rw["code"].ToString().Trim();
            this.name = rw["name"].ToString().Trim();
            this.idGroupItem = rw["idgroupitem"].ToString().Trim();
            this.entryPrice = float.Parse(rw["entryprice"].ToString());
            this.vAT = decimal.Parse(rw["VAT"].ToString());
            this.description = rw["Description"].ToString();
        }

        public Item() { }

        private int id;
        private int idSupplier;
        private string code;
        private string name;
        private string idGroupItem;
        private float entryPrice;
        private decimal vAT;
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

        public string IdGroupItem
        {
            get
            {
                return idGroupItem;
            }

            set
            {
                idGroupItem = value;
            }
        }

        public float EntryPrice
        {
            get
            {
                return entryPrice;
            }

            set
            {
                entryPrice = value;
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

        public decimal VAT
        {
            get
            {
                return vAT;
            }

            set
            {
                vAT = value;
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

        public int IdSupplier
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
    }
}
