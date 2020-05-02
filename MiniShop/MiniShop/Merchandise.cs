﻿using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiniShop
{
    class Merchandise
    {
        public string Id { get; }
        public string Name { get; }
        public double Price { get; }
        public double Weight { get; }
        public Image Image { get; }

        public Merchandise()
        {
        }
        public Merchandise(string id, string name, double price, double weight, string path)
        {
            Id = id;
            Name = name;
            Price = price;
            Weight = weight;
            this.Image = Image.FromFile(path);
        }


    }
}
