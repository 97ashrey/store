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
    public partial class AddNewProductView : Form, IAddNewProductView
    {
        private TextBox[] controls;

        public AddNewProductView()
        {
            InitializeComponent();

            controls = new TextBox[]
            {
                tbName,
                tbPrice,
                tbDiscount
            };

            foreach(TextBox tb in controls)
            {
                tb.TextChanged += Tb_TextChanged;
            }

            StartPosition = FormStartPosition.CenterParent;
        }


        private void Tb_TextChanged(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if(errorProvider.GetError(control) != "")
            {
                errorProvider.SetError(control, "");
            }
        }

        public string NameValue { get => tbName.Text.Trim(); set => tbName.Text = value; }
        public double PriceValue { get => double.Parse(tbPrice.Text.Trim()); set => tbPrice.Text = value.ToString(); }
        public double DiscountValue { get => double.Parse(tbDiscount.Text.Trim()); set => tbDiscount.Text = value.ToString(); }
        public object Presenter { private get; set; }

        public event EventHandler AddProductTriggered;

        public new void Show()
        {
            ShowDialog();
        }

        private bool Valid()
        {
            bool valid = true;

            foreach(TextBox tb in controls)
            {
                if(tb.Text.Trim() == "")
                {
                    errorProvider.SetError(tb, "Obavezno polje");
                    valid = false;
                }
            }

            return valid;
        }

        private void FocusOnTopError()
        {
            foreach(TextBox tb in controls)
            {
                if(errorProvider.GetError(tb) != "")
                {
                    tb.Focus();
                    break;
                }
            }
        }

        public void ClearControls()
        {
            foreach (TextBox tb in controls)
            {
                tb.Clear();
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (!Valid())
            {
                MessageBox.Show(
                    "Forma neispravno popunjena?",
                    "Greška",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                FocusOnTopError();
                return;
            }
            AddProductTriggered?.Invoke(this, e);
        }
       
    }
}
