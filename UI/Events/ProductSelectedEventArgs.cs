using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Events
{
    public class ProductSelectedEventArgs: EventArgs
    {
        public enum OperationType
        {
            Add,
            Update,
            Delete
        }

        public int ID { get; set; }
        public OperationType Operation { get; set; }

        public ProductSelectedEventArgs(int id, OperationType operation)
        {
            ID = id;
            Operation = operation;
        }
    }
}
