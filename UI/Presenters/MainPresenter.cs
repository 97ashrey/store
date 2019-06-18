using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Views;
using UI.Events;
using UI.Events.Messages;

namespace UI.Presenters
{
    public class MainPresenter
    {
        private IMainView view;

        public MainPresenter(IMainView view)
        {
            this.view = view;
            SubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            EventAggregator.Instance.Subscribe<ShowGroupsViewMessage>(ShowGroupsViewHandler);
            EventAggregator.Instance.Subscribe<ShowProductsViewMessage>(ShowProductsViewHandler);
            EventAggregator.Instance.Subscribe<AlertMessage>(AlertMessageHandler);
            view.ShowReceiptsTriggered += View_ShowReceiptsTriggered;
        }

        private void AlertMessageHandler(AlertMessage message)
        {
            view.ShowAlert(message);
        }

        private void View_ShowReceiptsTriggered(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new ShowReceiptsViewMessage());
        }

        private void ShowGroupsViewHandler(ShowGroupsViewMessage message)
        {
            view.ShowGroupsView();
        }

        private void ShowProductsViewHandler(ShowProductsViewMessage message)
        {
            view.ShowProductsView();
        }
    }
}
