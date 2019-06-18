using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;
using StoreLibrary.DataAccess;
using UI.Events;
using UI.Events.Messages;
using UI.Views.Data;
using UI.Helpers;

namespace UI.Presenters.Data
{
    public class ReceiptsTablePresenter : TablePresenter<ReceiptModel>
    {
        public ReceiptsTablePresenter(ITableView view) : base(view)
        {

        }

        protected override void LoadData()
        {
            dataSource = new List<ReceiptModel>();
        }

        protected override void SetTableColumns()
        {
            TableColumnInfo[] columns = new TableColumnInfo[]
            {
                new TableColumnInfo("ID","ID"),
                new TableColumnInfo("Cena","Price"),
                new TableColumnInfo("Datum","Date"),
                new TableColumnInfo("Vreme","Time")
            };

            view.CreateColumns(columns);
        }

        protected override void SubscribeToEvents()
        {
            base.SubscribeToEvents();
            EventAggregator.Instance.Subscribe<FindReceiptsInPeriodMessage>(FindReceiptsHandler);
            EventAggregator.Instance.Subscribe<ClearReceiptsMessage>(ClearHandler);
        }

        private void ShowWarning(DateTime from, DateTime to)
        {
            AlertMessage warningMessage = new AlertMessage(
                    AlertMessage.MessageType.Warning,
                    $"Nema računa u periodu od {from.ToShortDateString()} do {to.ToShortDateString()}"
                    );
            EventAggregator.Instance.Publish(warningMessage);
        }

        private void FindReceiptsHandler(FindReceiptsInPeriodMessage message)
        {
            view.DataSource = null;
            try
            {
                if (message.DateTo < message.DateFrom)
                {
                    throw new Exception();
                }
                dataSource = DataConnection.Instance.GetReceipts(message.DateFrom, message.DateTo);
                if (dataSource.Count == 0)
                {
                    throw new Exception();
                }
                view.DataSource = dataSource.ToList();
            }
            catch (Exception)
            {
                ShowWarning(message.DateFrom, message.DateTo);
            }

        }

        private void ClearHandler(ClearReceiptsMessage message)
        {
            dataSource.Clear();
            view.DataSource = dataSource.ToList();
        }
    }
}
