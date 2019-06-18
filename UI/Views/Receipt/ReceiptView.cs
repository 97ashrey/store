using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views.Receipt
{
    public partial class ReceiptView : UserControl, IReceiptView
    {
        private Control receiptTable;

        protected ReceiptView()
        {
            InitializeComponent();
        }

        public ReceiptView(Control receiptTable):this()
        {
            this.receiptTable = receiptTable;
            this.receiptTable.Dock = DockStyle.Fill;
            panelTableContainer.Controls.Add(this.receiptTable);
        }

        public double Price { get => double.Parse(lblPrice.Text); set => lblPrice.Text = value.ToString(); }
        public int Quantity { get => (int)numericUpDown1.Value; set => numericUpDown1.Value = value; }
        public object Presenter { private get; set; }

        public event EventHandler UpdateReceiptRecordTriggered;
        public event EventHandler PublishReceiptTriggered;
        public event EventHandler ClearReceiptTriggered;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateReceiptRecordTriggered?.Invoke(this, e);
        }

        private void btnCreateReceipt_Click(object sender, EventArgs e)
        {
            PublishReceiptTriggered?.Invoke(this, e);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearReceiptTriggered?.Invoke(this, e);
        }
    }
}
