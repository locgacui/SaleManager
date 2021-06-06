using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class DocDetail
    {
        public DocDetail(int id, int idDocument, int idItem, int idWarehouse, int idUnit, int quantily, decimal price, decimal amountOrigin, decimal discount, decimal amountDiscount, decimal vAT, decimal amountVAT, decimal amount)
        {
            this.id = id;
            this.idDocument = idDocument;
            this.idItem = idItem;
            this.idWarehouse = idWarehouse;
            this.idUnit = idUnit;
            this.Quantily = quantily;
            this.price = price;
            this.amountOrigin = amountOrigin;
            this.discount = discount;
            this.amountDiscount = amountDiscount;
            this.vAT = vAT;
            this.amountVAT = AmountVAT;
            this.amount = amount;
        }

        public DocDetail(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.idDocument = int.Parse(rw["IdDocument"].ToString());
            this.idItem = int.Parse(rw["CodeItem"].ToString());
            this.idWarehouse = int.Parse(rw["CodeWarehouse"].ToString());
            this.idUnit = int.Parse(rw["CodeUnit"].ToString());
            this.Quantily = int.Parse(rw["Quantily"].ToString());
            this.price = decimal.Parse(rw["Price"].ToString());
            this.amountOrigin = decimal.Parse(rw["AmountOrigin"].ToString());
            this.vAT = decimal.Parse(rw["VAT"].ToString());
            this.amountVAT = decimal.Parse(rw["AmountVAT"].ToString());
            this.amount = decimal.Parse(rw["Amount"].ToString());
        }

        private int id;
        private int idDocument;
        private int idItem;
        private int idWarehouse;
        private int idUnit;
        private int quantily;
        private decimal price;
        private decimal amountOrigin;
        private decimal discount;
        private decimal amountDiscount;
        private decimal vAT;
        private decimal amountVAT;
        private decimal amount;

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

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        public decimal AmountOrigin
        {
            get
            {
                return amountOrigin;
            }

            set
            {
                amountOrigin = value;
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

        public decimal AmountVAT
        {
            get
            {
                return amountVAT;
            }

            set
            {
                amountVAT = value;
            }
        }

        public decimal Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public int IdDocument
        {
            get
            {
                return idDocument;
            }

            set
            {
                idDocument = value;
            }
        }

        public int IdItem
        {
            get
            {
                return idItem;
            }

            set
            {
                idItem = value;
            }
        }

        public int IdWarehouse
        {
            get
            {
                return idWarehouse;
            }

            set
            {
                idWarehouse = value;
            }
        }

        public int IdUnit
        {
            get
            {
                return idUnit;
            }

            set
            {
                idUnit = value;
            }
        }

        public int Quantily
        {
            get
            {
                return quantily;
            }

            set
            {
                quantily = value;
            }
        }

        public decimal Discount
        {
            get
            {
                return discount;
            }

            set
            {
                discount = value;
            }
        }

        public decimal AmountDiscount
        {
            get
            {
                return amountDiscount;
            }

            set
            {
                amountDiscount = value;
            }
        }
    }
}
