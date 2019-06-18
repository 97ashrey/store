using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;
using UI.Events.Messages;
using UI.Models;
using UI.Views.Product;
using StoreLibrary.Models;


namespace UI.Presenters.Product
{
    public class AddProductToReceiptPresenter
    {
        IAddProductToReceiptView view;

        ProductModel selectedProduct;

        public AddProductToReceiptPresenter(IAddProductToReceiptView view)
        {
            this.view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            EventAggregator.Instance.Subscribe<ShowAddProductToReciptView>(ProductSelectedHandler);
            view.AddProductTriggered += AddProductHandler;
        }

        private void AddProductHandler(object sender, EventArgs e)
        {
            ReceiptRecordModel receiptRecord = new ReceiptRecordModel(selectedProduct, view.Quantity);
            EventAggregator.Instance.Publish(new AddRecordToReceiptMessage(receiptRecord));
            view.Close();
        }

        private void ProductSelectedHandler(ShowAddProductToReciptView message)
        {
            selectedProduct = message.Product;
            view.NameValue = selectedProduct.Name;
            view.PriiceValue = selectedProduct.Price.ToString();
            view.DiscountValue = selectedProduct.Discount.ToString();
            view.Show();
        }
    }
}
