using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreLibrary.Models;
namespace UI.Events.Messages
{
    public class ShowAddProductToReciptView: IApplicationEvent
    {
        public ProductModel Product { get; set; }

        public ShowAddProductToReciptView(ProductModel product)
        {
            Product = product;
        }
    }
}
