using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Views.Receipt
{
    public interface IReceiptsView: IPresenter
    {
        event EventHandler SearchTriggered;
        event EventHandler Closing;

        DateTime DateFrom { get; set; }
        DateTime DateTo { get; set; }


        void Show();
    }
}
