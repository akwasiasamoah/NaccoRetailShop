using System;
using System.Collections.Generic;
using System.Text;

namespace NaccoRetailShop.Models
{
    public class Item
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal WholesalePrice { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Discount { get; set; }

        public Item(string name, decimal retailprice, decimal wholesaleprice, string description, int stock, decimal discount) {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.RetailPrice = retailprice;
            this.WholesalePrice = wholesaleprice;
            this.Description = description;
            this.Stock = stock;
            this.Discount = discount;
        }
    }
}
