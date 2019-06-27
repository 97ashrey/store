using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;

namespace UI.Views.Product
{
    public interface IProductsView: IPresenter, ILoad
    {
        event EventHandler AddNewProductTriggered;
        event EventHandler BackTriggered;
        event EventHandler<ProductSelectedEventArgs> ProductSelected;

        string Heading { get; set; }

        void AddProduct(int id, string name, string price, string discount);
        void DeleteProduct(int id);
        void UpdateProduct(int id, string name, string price, string discount);

        bool ConfirmDelete(string name, string price, string discount);
    }
}
