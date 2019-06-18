using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Helpers;
using UI.Views.Product;
using UI.Views.Group;
using UI.Events.Messages;

namespace UI.Views
{
    public partial class MainView : Form, IMainView
    {
        private IGroupsView groupsView;
        private IProductsView productsView;
        private Control receiptView;

        public event EventHandler ShowReceiptsTriggered;

        public object Presenter { private get; set; }

        protected MainView()
        {
            InitializeComponent();
        }

        public MainView(IGroupsView groupsView, IProductsView productsView, Control receiptView): this()
        {
            this.groupsView = groupsView;
            this.productsView = productsView;
            this.receiptView = receiptView;
            (this.groupsView as Control).Dock = DockStyle.Fill;
            (this.productsView as Control).Dock = DockStyle.Fill;
            this.receiptView.Dock = DockStyle.Fill;
            splitContainer.Panel1.Controls.Add(this.receiptView);
            ShowGroupsView();
        }

        public void ShowGroupsView()
        {
            panelPageContainer.Controls.Clear();
            panelPageContainer.Controls.Add(groupsView as Control);
            groupsView.Reload();
        }

        public void ShowProductsView()
        {
            panelPageContainer.Controls.Clear();
            panelPageContainer.Controls.Add(productsView as Control);
            productsView.Reload();
        }

        private void btnCheckReceipts_Click(object sender, EventArgs e)
        {
            ShowReceiptsTriggered?.Invoke(this, e);
        }

        public void ShowAlert(AlertMessage message)
        {
            MessageBoxIcon icon = Extensions.AlertToMessageBox(message.Type);
            MessageBox.Show(message.Message, "", MessageBoxButtons.OK, icon);
        }
    }
}
