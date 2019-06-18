using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views.Product
{
    public interface IAddNewProductView: IPresenter
    {
        event EventHandler AddProductTriggered;

        string NameValue { get; set; }
        double PriceValue { get; set; }
        double DiscountValue { get; set; }

        void Show();
        void Close();

        void ClearControls();
    }
}
