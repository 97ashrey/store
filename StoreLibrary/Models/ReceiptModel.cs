using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary.Models
{
    public class ReceiptModel
    {

        public int ID { get; set; }
        public double Price { get; set; }
        public DateTime Date { get => FullTime.Date; }
        public TimeSpan Time { get => FullTime.TimeOfDay; }
        public DateTime FullTime { get; set; }

        public ReceiptModel()
        {

        }

        public ReceiptModel(double price, DateTime date)
        {
            Price = price;
            FullTime = date;
        }

        public ReceiptModel(int iD, double price, DateTime date)
        {
            ID = iD;
            Price = price;
            FullTime = date;
        }

        public override string ToString()
        {
            return $"Receipt: {ID} \n" +
                   $"Price: {Price} \n" +
                   $"Date: {Date.ToShortDateString()} \n" +
                   $"Time: {Time.Hours}:{Time.Minutes}:{Time.Seconds} \n";
        }   
    }
}
