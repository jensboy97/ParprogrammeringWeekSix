using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ParprogrammeringWeekSix;


public class ClothingItem : InventoryItem, ISellable
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public ClothingItem(string name, int quantity, decimal price, string size, string color)
            : base(name, quantity, price)
        {
            Size = size;
            Color = color;
        }

        public decimal CalculatePrice()
        {
            return Price * 0.9m;
        }
    }
