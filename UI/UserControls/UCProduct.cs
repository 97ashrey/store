using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class UCProduct : UserControl
    {
        protected UCProduct()
        {
            InitializeComponent();

           
        }

        public event EventHandler AddClick;
        public event EventHandler DeleteClick;
        public event EventHandler UpdateClick;

        public string NameText { get => lblName.Text; set => lblName.Text = value; }
        public string PriceText { get => lblPrice.Text; set => lblPrice.Text = value; }
        public string DiscountText { get => lblDiscount.Text; set => lblDiscount.Text = value + " %"; }

        public UCProduct(string name,string price, string discount): this()
        {
            NameText = name;
            PriceText = price;
            DiscountText = discount;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddClick?.Invoke(this, e);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(this, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClick?.Invoke(this, e);
        }
    }
}
