using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class ProductModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }

        public ProductModel()
        {

        }

        public ProductModel(string name, double price, double discount)
        {
            Name = name;
            Price = price;
            Discount = discount;
        }

        public ProductModel(int iD, string name, double price, double discount)
        {
            ID = iD;
            Name = name;
            Price = price;
            Discount = discount;
        }

        public override string ToString()
        {
            return $"Product: {ID} \n" +
                   $"Name: {Name} \n" +
                   $"Price: {Price} \n" +
                   $"Discount: {Discount} \n";
        }
    }
}
