using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Views.Receipt
{
    public partial class ReceiptsView : Form, IReceiptsView
    {
        private Control reciptsTable;

        protected ReceiptsView()
        {
            InitializeComponent();
            FormClosing += ReceiptsView_FormClosing;
        }
    
        public ReceiptsView(Control reciptsTable) : this()
        {
            this.reciptsTable = reciptsTable;
            this.reciptsTable.Dock = DockStyle.Fill;
            this.panelTableContaner.Controls.Add(this.reciptsTable);
            StartPosition = FormStartPosition.CenterParent;
        }

        public new event EventHandler Closing;
        public event EventHandler SearchTriggered;

        public DateTime DateFrom { get => dtpFrom.Value; set => dtpFrom.Value = value; }
        public DateTime DateTo { get => dtpTo.Value; set => dtpTo.Value = value; }
        public object Presenter { private get; set; }


        public new void Show()
        {
            ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchTriggered?.Invoke(this, e);
        }

        private void ReceiptsView_FormClosing(object sender, FormClosingEventArgs e)
        {
            Closing?.Invoke(this, e);
        }
    }
}
