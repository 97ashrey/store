using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;
using UI.Events.Messages;
using UI.Models;
using UI.Views.Data;
using UI.Helpers;
using StoreLibrary.Models;
using StoreLibrary.DataAccess;

namespace UI.Presenters.Data
{
    public class ReceiptTablePresenter : TablePresenter<ReceiptRecordModel>
    {
        private double totalPrice = 0;

        private double TotalPrice
        {
            get => totalPrice;
            set
            {
                totalPrice = value;
                EventAggregator.Instance.Publish(new ReceiptPriceUpdatedMessage(totalPrice));
            }
        }

        public ReceiptTablePresenter(ITableView view): base(view)
        {

        }

        protected override void SubscribeToEvents()
        {
            base.SubscribeToEvents();
            EventAggregator.Instance.Subscribe<AddRecordToReceiptMessage>(AddRecordToReceiptHandler);
            EventAggregator.Instance.Subscribe<UpdateReceiptRecordQuantityMessage>(UpdateRecordQuantityHandler);
            EventAggregator.Instance.Subscribe<ClearReceiptMessage>(ClearReceiptHandler);
            EventAggregator.Instance.Subscribe<PublishReceiptMessage>(PublishReceiptHandler);
        }

        private void PublishReceiptHandler(PublishReceiptMessage obj)
        {
          
            if(dataSource.Count == 0)
            {
                AlertMessage warngingMessage = new AlertMessage(
                   AlertMessage.MessageType.Warning,
                   "Račun nema nijednu stavku!"
                   );
                EventAggregator.Instance.Publish(warngingMessage);
                return;
            }

            ReceiptModel receipt = new ReceiptModel(totalPrice, DateTime.Now);
            receipt = DataConnection.Instance.CreateReceipt(receipt);

            if (receipt == null)
            {
                AlertMessage errorMessage = new AlertMessage(
                    AlertMessage.MessageType.Error,
                    "Došlo je do greške prilikom izdavanja računa!"
                    );
                EventAggregator.Instance.Publish(errorMessage);
                return;
            }

            EventAggregator.Instance.Publish(new ClearReceiptMessage());
            AlertMessage successMessage = new AlertMessage(
                AlertMessage.MessageType.Success,
                "Račun uspešno izdat."
                );
            EventAggregator.Instance.Publish(successMessage);
      
            
        }

        protected override void LoadData()
        {
            dataSource = new List<ReceiptRecordModel>();
            UpdatePrice(0);
            view.DataSource = dataSource;
        }

        protected override void SetTableColumns()
        {
            TableColumnInfo[] columns = new TableColumnInfo[] 
            {
                new TableColumnInfo("Naziv","ProductName"),
                new TableColumnInfo("Cena","Price"),
                new TableColumnInfo("Količina","Quantity")
            };

            view.CreateColumns(columns);
        }

        private void UpdatePrice(double amount)
        {
            TotalPrice = TotalPrice + amount;
        }

        private void AddRecordToReceiptHandler(AddRecordToReceiptMessage message)
        {
            AddNewRecord(message.ReceiptRecord);
            UpdatePrice(message.ReceiptRecord.Price);
        }

        private void UpdateRecordQuantityHandler(UpdateReceiptRecordQuantityMessage message)
        {
            try
            {
                int index = view.SelectedIndexes[0];
                ReceiptRecordModel receiptRecord = dataSource[index];
                if(message.Quantity == 0)
                {
                    // delete record
                    UpdatePrice(-receiptRecord.Price);
                    DeleteRecord(index);
                    return;
                }
                double beforePrice = receiptRecord.Price;
                receiptRecord.Quantity = message.Quantity;
                UpdateRecord(index, receiptRecord);
                double priceDifference = receiptRecord.Price - beforePrice;
                UpdatePrice(priceDifference);
                // recalculate price
            }
            catch (IndexOutOfRangeException)
            {
               
            }
        }

        private void ClearReceiptHandler(ClearReceiptMessage message)
        {
            TotalPrice = 0;
            dataSource.Clear();
            view.DataSource = dataSource.ToList();
        }
    }
}
