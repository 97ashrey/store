using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Events;
using UI.UserControls;

namespace UI.Views.Product
{
    public partial class ProductsView : UserControl, IProductsView
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        public object Presenter { private get; set; }

        public string Heading { get => ucHeading1.HeadingText; set => ucHeading1.HeadingText = value; }

        public event EventHandler AddNewProductTriggered;
        public event EventHandler<ProductSelectedEventArgs> ProductSelected;
        public event EventHandler Loaded;
        public event EventHandler BackTriggered;

        private int FindControlIndex(int id)
        {
            int index = -1;
            for (int i = 0; i < panelMain.Controls.Count; i++)
            {
                Control control = panelMain.Controls[i];
                if ((int)control.Tag == id)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public void AddProduct(int id, string name, string price, string discount)
        {
            UCProduct product = new UCProduct(name, price, discount)
            {
                Dock = DockStyle.Top,
                Tag = id
            };

            product.AddClick += ProductSelectedHandler;
            product.DeleteClick += Product_DeleteClick;
            product.UpdateClick += Product_UpdateClick;

            panelMain.Controls.Add(product);
        }

        public void UpdateProduct(int id, string name, string price, string discount)
        {
            int index = FindControlIndex(id);
            if (index != -1)
            {
                UCProduct control = panelMain.Controls[index] as UCProduct;
                control.NameText = name;
                control.PriceText = price;
                control.DiscountText = discount;
            }
        }

        public void DeleteProduct(int id)
        {
            int index = FindControlIndex(id);
            if(index != -1)
            {
                panelMain.Controls.RemoveAt(index);
            }
        }

        public void Reload()
        {
            panelMain.AutoScrollPosition = new Point(0, 0);
            panelMain.Controls.Clear();
            Loaded?.Invoke(this, new EventArgs());
        }

        public bool ConfirmDelete(string name, string price, string discount)
        {
            string text = $"Želite da obrišete proizvod \n" +
                          $"Naziv: {name}\n" +
                          $"Cena: {price}\n" +
                          $"Popust: {discount}";
            DialogResult result = MessageBox.Show
                (
                    text,
                    "Upozorenje",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

            return result == DialogResult.Yes ? true : false;
        }

        // Event handlers

        private void ProductSelectedHandler(object sender, EventArgs e)
        {
            UCProduct product = sender as UCProduct;
            ProductSelectedEventArgs eventArgs = new ProductSelectedEventArgs(
                (int)product.Tag, ProductSelectedEventArgs.OperationType.Add);
            ProductSelected?.Invoke(this, eventArgs);
        }

        private void Product_DeleteClick(object sender, EventArgs e)
        {
            UCProduct product = sender as UCProduct;
            ProductSelectedEventArgs eventArgs = new ProductSelectedEventArgs(
                (int)product.Tag, ProductSelectedEventArgs.OperationType.Delete);
            ProductSelected?.Invoke(this, eventArgs);
        }

        private void Product_UpdateClick(object sender, EventArgs e)
        {
            UCProduct product = sender as UCProduct;
            ProductSelectedEventArgs eventArgs = new ProductSelectedEventArgs(
                (int)product.Tag, ProductSelectedEventArgs.OperationType.Update);
            ProductSelected?.Invoke(this, eventArgs);
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            BackTriggered?.Invoke(this, e);
        }

        private void btnAddNewProduct_Click(object sender, EventArgs e)
        {
            AddNewProductTriggered?.Invoke(this, e);
        }

    
    }
}
