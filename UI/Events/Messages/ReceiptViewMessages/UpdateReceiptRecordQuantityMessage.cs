using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Events.Messages
{
    public class UpdateReceiptRecordQuantityMessage : IApplicationEvent
    {
        public int Quantity { get; set; }

        public UpdateReceiptRecordQuantityMessage(int quantity)
        {
            Quantity = quantity;
        }
    }
}
