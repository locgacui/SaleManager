﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLyBanHang.Data
{
    public class GroupItem
    {
        public GroupItem(int id, string code, string name)
        {
            this.id = id;
            this.code = code;
            this.name = name;
        }

        public GroupItem(DataRow rw)
        {
            this.id = int.Parse(rw["Id"].ToString());
            this.code = rw["Code"].ToString().Trim();
            this.name = rw["Name"].ToString().Trim();
        }

        private int id;
        private string code;
        private string name;

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
