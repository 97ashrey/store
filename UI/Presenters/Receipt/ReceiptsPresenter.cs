using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;
using UI.Events.Messages;
using UI.Views.Receipt;


namespace UI.Presenters.Receipt
{
    public class ReceiptsPresenter
    {
        IReceiptsView view;

        public ReceiptsPresenter(IReceiptsView view)
        {
            this.view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            EventAggregator.Instance.Subscribe<ShowReceiptsViewMessage>(ShowHandler);
            view.SearchTriggered += SearchHandler;
            view.Closing += View_Closing;
        }

        private void ShowHandler(ShowReceiptsViewMessage message)
        {
            view.Show();
        }

        private void View_Closing(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ClearReceiptsMessage());
        }

        private void SearchHandler(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(
                new FindReceiptsInPeriodMessage(view.DateFrom.Date, view.DateTo.Date));
        }
    }
}
