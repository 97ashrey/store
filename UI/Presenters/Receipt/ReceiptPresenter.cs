using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;
using UI.Events.Messages;
using UI.Views.Receipt;
//using StoreLibrary.Models;
//using StoreLibrary.DataAccess;


namespace UI.Presenters.Receipt
{
    public class ReceiptPresenter
    {
        private IReceiptView view;

        public ReceiptPresenter(IReceiptView view)
        {
            this.view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            view.PublishReceiptTriggered += PublishReceiptHandler;
            view.UpdateReceiptRecordTriggered += UpdateReceiptRecrodHandler;
            view.ClearReceiptTriggered += ClearReceiptHandler;
            EventAggregator.Instance.Subscribe<ReceiptPriceUpdatedMessage>(TotalPriceUpdatedHandler);
        }


        private void PublishReceiptHandler(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new PublishReceiptMessage());
            //ReceiptModel receipt = new ReceiptModel(view.Price, DateTime.Now);
            //receipt = DataConnection.Instance.CreateReceipt(receipt);
            //if(receipt == null)
            //{
            //    AlertMessage errorMessage = new AlertMessage(
            //        AlertMessage.MessageType.Error,
            //        "Došlo je do greške prilikom izdavanja računa!"
            //        );
            //    EventAggregator.Instance.Publish(errorMessage);
            //    return;
            //}

            //EventAggregator.Instance.Publish(new ClearReceiptMessage());
            //AlertMessage successMessage = new AlertMessage(
            //    AlertMessage.MessageType.Success,
            //    "Račun uspešno izdat."
            //    );
            //EventAggregator.Instance.Publish(successMessage);
        }

        private void UpdateReceiptRecrodHandler(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new UpdateReceiptRecordQuantityMessage(view.Quantity));
        }

        private void TotalPriceUpdatedHandler(ReceiptPriceUpdatedMessage message)
        {
            view.Price = message.Price;
        }


        private void ClearReceiptHandler(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ClearReceiptMessage());
        }

    }
}
