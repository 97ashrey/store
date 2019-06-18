using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views.Product
{
    public partial class AddProductToReceiptView : Form, IAddProductToReceiptView
    {

        public AddProductToReceiptView()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
        }

        public string NameValue { get => lblName.Text; set => lblName.Text = value; }
        public string PriiceValue { get => lblPrice.Text; set => lblPrice.Text = value; }
        public string DiscountValue { get => lblDiscount.Text; set => lblDiscount.Text = value; }
        public int Quantity { get => (int)numericUpDown1.Value; set => numericUpDown1.Value = value; }
        public object Presenter { private get; set; }

        public event EventHandler AddProductTriggered;

        public new void Show()
        {
            ShowDialog();
        }

        private void btnAddToReceipt_Click(object sender, EventArgs e)
        {
            AddProductTriggered?.Invoke(this, e);
        }
    }
}
