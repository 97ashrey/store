using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;

namespace UI.Events.Messages
{
    public class ProductUpdatedMessage : IApplicationEvent
    {
        public ProductModel Product { get; set; }

        public ProductUpdatedMessage(ProductModel product)
        {
            this.Product = product;
        }
    }
}
