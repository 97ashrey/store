using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Events.Messages
{
    public class UpdateRecordMessage<T>
    {
        public T Record { get; set; }

        public UpdateRecordMessage(T record)
        {
            Record = record;
        }
    }
}
