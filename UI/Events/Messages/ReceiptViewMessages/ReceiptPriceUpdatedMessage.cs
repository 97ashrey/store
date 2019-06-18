using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Events.Messages
{
    public class ReceiptPriceUpdatedMessage : IApplicationEvent
    {
        public double Price { get; set; }

        public ReceiptPriceUpdatedMessage(double price)
        {
            Price = price;
        }
    }
}
