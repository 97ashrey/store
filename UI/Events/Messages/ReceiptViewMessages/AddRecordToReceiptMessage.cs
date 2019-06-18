using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Models;

namespace UI.Events.Messages
{
    public class AddRecordToReceiptMessage: IApplicationEvent
    {
        public ReceiptRecordModel ReceiptRecord { get; set; }

        public AddRecordToReceiptMessage(ReceiptRecordModel receiptRecord)
        {
            ReceiptRecord = receiptRecord;
        }
    }
}
