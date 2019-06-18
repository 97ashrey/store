using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Events.Messages
{
    public class FindReceiptsInPeriodMessage: IApplicationEvent
    {
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }

        public FindReceiptsInPeriodMessage(DateTime dateFrom, DateTime dateTo)
        {
            DateFrom = dateFrom;
            DateTo = dateTo;
        }
    }
}
