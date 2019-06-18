using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events.Messages;

namespace UI.Views
{
    public interface IMainView: IPresenter
    {
        event EventHandler ShowReceiptsTriggered;

        void ShowGroupsView();
        void ShowProductsView();

        void ShowAlert(AlertMessage message);
    }
}
