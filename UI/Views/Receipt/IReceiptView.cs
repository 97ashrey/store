using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views.Receipt
{
    public interface IReceiptView: IPresenter
    {
        event EventHandler UpdateReceiptRecordTriggered;
        event EventHandler PublishReceiptTriggered;
        event EventHandler ClearReceiptTriggered;

        double Price { get; set; }
        int Quantity { get; set; }
    }
}
