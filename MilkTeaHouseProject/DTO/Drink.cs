﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilkTeaShopManagement.DTO
{
    public class Drink
    {
        int iD;
        string name;
        int price;

        public string Name { get => name; set => name = value; }
        public int Price { get => price; set => price = value; }
        public int ID { get => iD; set => iD = value; }
        public byte[] Image { get; internal set; }

        public Drink(int id, string name, int price)
        {
            this.ID = id;
            this.Name = name;
            this.Price = price;
        }
        public Drink(DataRow row)
        {
            this.ID = (int)row["ID"];
            this.Name = row["Name"].ToString();
            this.Price = (int)row["Price"];
            if (!Convert.IsDBNull(row["Image"]))
                this.Image = (byte[])row["Image"];
        }
    }
}
