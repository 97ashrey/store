using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;
using UI.Events.Messages;
using UI.Views.Product;
using StoreLibrary.Models;
using StoreLibrary.DataAccess;

namespace UI.Presenters.Product
{
    public class AddNewProductPresenter
    {
        private IAddNewProductView view;

        public AddNewProductPresenter(IAddNewProductView view)
        {
            this.view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            view.AddProductTriggered += AddProductHandler;
            EventAggregator.Instance.Subscribe<ShowAddNewProductViewMessage>(ShowAddNewProductsViewHandler);
        }

        private void PopulateProduct(ProductModel product)
        {
            product.Name = view.NameValue.ToLower();
            product.Price = view.PriceValue;
            product.Discount = view.DiscountValue;
        }

        private void AddProductHandler(object sender, EventArgs e)
        {
            // get view values
            ProductModel product = new ProductModel();
            PopulateProduct(product);

            product = DataConnection.Instance.CreateProduct(product, GlobalValues.SelectedGroup);

            if(product == null)
            {
                AlertMessage errorMessage = new AlertMessage(
                    AlertMessage.MessageType.Error,
                    "Došlo je do greške prilikom dodavanja proizvoda!"
                    );
                EventAggregator.Instance.Publish(errorMessage);
                return;
            }
            AlertMessage successMessage = new AlertMessage(
                    AlertMessage.MessageType.Success,
                    "Proizvod uspešno kreiran."
                    );
            EventAggregator.Instance.Publish(successMessage);
            view.ClearControls();
            // send message to add new product
            EventAggregator.Instance.Publish(new NewProductCreatedMessage(product));
        }

        private void ShowAddNewProductsViewHandler(ShowAddNewProductViewMessage mesage)
        {
            view.Show();
        }
    }
}
