using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;

namespace UI.Events.Messages
{
    public class NewProductCreatedMessage : IApplicationEvent
    {
        public ProductModel product { get; set; }

        public NewProductCreatedMessage(ProductModel product)
        {
            this.product = product;
        }
    }
}
