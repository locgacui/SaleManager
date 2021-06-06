using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class UnitPrice
    {
        public UnitPrice(int id, int iditem, decimal price, DateTime dateupdate)
        {
            this.id = id;
            this.idItem = iditem;
            this.Price = price;
            this.dateUpdate = dateupdate;
        }

        public UnitPrice(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.idItem = int.Parse(rw["IdItem"].ToString());
            this.Price = decimal.Parse(rw["Price"].ToString());
            this.dateUpdate = DateTime.Parse(rw["DateUpdate"].ToString());
        }

        private int id;
        private int idItem;
        private decimal price;
        private DateTime dateUpdate;
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

        public DateTime DateUpdate
        {
            get
            {
                return dateUpdate;
            }

            set
            {
                dateUpdate = value;
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
    }
}
