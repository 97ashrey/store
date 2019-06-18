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
    public class ProductsPresenter
    {
        private IProductsView view;

        private List<ProductModel> products = new List<ProductModel>();

        public ProductsPresenter(ProductsView view)
        {
            this.view = view;
            SubsribeToEvents();
        }

        private void SubsribeToEvents()
        {
            view.Loaded += ViewLoadedHandler;
            view.ProductSelected += ProductSelectedHandler;
            view.AddNewProductTriggered += AddNewProductHandler;
            view.BackTriggered += BackTriggeredHandler;
            EventAggregator.Instance.Subscribe<NewProductCreatedMessage>(NewProductCreatedHandler);
            EventAggregator.Instance.Subscribe<ProductUpdatedMessage>(ProductUpdateHandler);
        }

       

        private void NewProductCreatedHandler(NewProductCreatedMessage message)
        {
            ProductModel product = message.product;
            products.Add(product);
            view.AddProduct(product.ID, product.Name, product.Price.ToString(), product.Discount.ToString());
        }

        private void AddNewProductHandler(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ShowAddNewProductViewMessage());
        }

        private void ProductSelectedHandler(object sender, ProductSelectedEventArgs e)
        {
            ProductModel product = products.Find(model => model.ID == e.ID);
            if (product != null)
            {
                if (e.Operation == ProductSelectedEventArgs.OperationType.Add)
                {
                    EventAggregator.Instance.Publish(new ShowAddProductToReciptView(product));
                }
                else if (e.Operation == ProductSelectedEventArgs.OperationType.Delete)
                {
                    product = DataConnection.Instance.DeleteProduct(e.ID);
                    if(product == null)
                    {
                        AlertMessage errorMessage = new AlertMessage(
                            AlertMessage.MessageType.Error,
                            "Došlo je do greške prilikom brisanja proizvoda!"
                            );
                        EventAggregator.Instance.Publish(errorMessage);
                        return;
                    }
                    view.DeleteProduct(e.ID);
                }
                else if(e.Operation == ProductSelectedEventArgs.OperationType.Update)
                {
                    EventAggregator.Instance.Publish(new ShowUpdateProductView(product));
                }
            }
        }

        private void ViewLoadedHandler(object sender, EventArgs e)
        {
            int groupId = GlobalValues.SelectedGroup == 0 ? 1 : GlobalValues.SelectedGroup;
            products = DataConnection.Instance.GetProductsInGroup(groupId);
            foreach(ProductModel product in products)
            {
                view.AddProduct(
                    product.ID,
                    product.Name, 
                    product.Price.ToString(), 
                    product.Discount.ToString());
            }
        }

        private void BackTriggeredHandler(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ShowGroupsViewMessage());
        }

        private void ProductUpdateHandler(ProductUpdatedMessage message)
        {
            ProductModel product = message.Product;
            view.UpdateProduct(product.ID, product.Name, product.Price.ToString(), product.Discount.ToString());
        }
    }
}
