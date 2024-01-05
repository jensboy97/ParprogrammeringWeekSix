using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParprogrammeringWeekSix
{
    internal class ElectronicItem : InventoryItem, ISellable
    {
       public string WarrantyInfo { get; set; }
        
        public string Watt { get; set; }
        public ElectronicItem(string name, int quantity, decimal price, string warrantyInfo,  string watt) : base(name, quantity, price)
        {
            WarrantyInfo = warrantyInfo;
            Watt = watt;
        }

        public decimal CalculatePrice()
        {
            return Price * 1.1m;
        }

        
    }
}
