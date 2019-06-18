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
    public class UpdateProductPresenter
    {
        private IAddNewProductView view;

        private ProductModel currentProduct;

        public UpdateProductPresenter(IAddNewProductView view)
        {
            this.view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            view.AddProductTriggered += UpdateProductHandler;
            EventAggregator.Instance.Subscribe<ShowUpdateProductView>(ShowAddNewProductsViewHandler);
        }

        private void PopulateProduct(ProductModel product)
        {
            product.Name = view.NameValue.ToLower();
            product.Price = view.PriceValue;
            product.Discount = view.DiscountValue;
        }

        private void PopulateView(ProductModel product)
        {
            view.NameValue = product.Name;
            view.PriceValue = product.Price;
            view.DiscountValue = product.Discount;
        }

        private void UpdateProductHandler(object sender, EventArgs e)
        {
            // get view values
            PopulateProduct(currentProduct);

            currentProduct = DataConnection.Instance.UpdateProduct(currentProduct);

            if (currentProduct == null)
            {
                AlertMessage errorMessage = new AlertMessage(
                    AlertMessage.MessageType.Error,
                    "Došlo je do greške prilikom ažuriranja proizvoda!"
                    );
                EventAggregator.Instance.Publish(errorMessage);
                return;
            }
            AlertMessage successMessage = new AlertMessage(
                    AlertMessage.MessageType.Success,
                    "Proizvod uspešno ažuriran."
                    );
            EventAggregator.Instance.Publish(successMessage);
            view.ClearControls();
            view.Close();
            // send message to add new product
            EventAggregator.Instance.Publish(new ProductUpdatedMessage(currentProduct));
        }

        private void ShowAddNewProductsViewHandler(ShowUpdateProductView message)
        {
            currentProduct = message.product;
            PopulateView(currentProduct);
            view.Show();
        }
    }
}
