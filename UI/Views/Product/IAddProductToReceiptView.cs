using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views.Product
{
    public interface IAddProductToReceiptView: IPresenter
    {
        event EventHandler AddProductTriggered;

        string NameValue { get; set; }
        string PriiceValue { get; set; }
        string DiscountValue { get; set; }
        int Quantity { get; set; }

        void Show();
        void Close();
    }
}
