using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;

namespace UI.Events.Messages
{
    public class ShowUpdateProductView : IApplicationEvent
    {
        public ProductModel product { get; set; }

        public ShowUpdateProductView(ProductModel product)
        {
            this.product = product;
        }
    }
}
