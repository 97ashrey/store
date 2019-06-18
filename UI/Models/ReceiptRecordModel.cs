using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;

namespace UI.Models
{
    public class ReceiptRecordModel
    {
        public ProductModel Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get => Product.Price * Quantity - (Product.Price * Product.Discount/100); }

        public string ProductName { get => Product.Name; }

        public ReceiptRecordModel(ProductModel product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }
    }
}
