using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Views;
using UI.Views.Product;
using UI.Views.Group;
using UI.Views.Receipt;
using UI.Views.Data;
using UI.Presenters;
using UI.Presenters.Data;
using UI.Presenters.Product;
using UI.Presenters.Group;
using UI.Presenters.Receipt;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            MainView mainView = CreateMainView();

            ReceiptsView receiptsView = CreateReceiptsView();

            AddNewProductView addNewProductView = new AddNewProductView();
            addNewProductView.Presenter = new AddNewProductPresenter(addNewProductView);

            UpdateProductView updateProductView = new UpdateProductView();
            updateProductView.Presenter = new UpdateProductPresenter(updateProductView);

            AddProductToReceiptView addProductToReceiptView = new AddProductToReceiptView();
            addProductToReceiptView.Presenter = new AddProductToReceiptPresenter(addProductToReceiptView);

            Application.Run(mainView);
        }

        private static MainView CreateMainView()
        {
            ProductsView productsView = CreateProductsView();
            GroupsView groupsView = CreateGroupsView();
            ReceiptView receiptView = CreateReceiptView();
            MainView mainView = new MainView(groupsView, productsView, receiptView);
            mainView.Presenter = new MainPresenter(mainView);
            return mainView;
        }

        private static ProductsView CreateProductsView()
        {
            ProductsView productsView = new ProductsView();
            productsView.Presenter = new ProductsPresenter(productsView);
            return productsView;
        }

        private static GroupsView CreateGroupsView()
        {
            GroupsView groupsView = new GroupsView();
            groupsView.Presenter = new GroupsPresenter(groupsView);
            return groupsView;
        }

        private static ReceiptView CreateReceiptView()
        {
            TableView tableView = new TableView();
            tableView.Presenter = new ReceiptTablePresenter(tableView);

            ReceiptView receiptView = new ReceiptView(tableView);
            receiptView.Presenter = new ReceiptPresenter(receiptView);
            return receiptView;
        }

        private static ReceiptsView CreateReceiptsView()
        {
            TableView tableView = new TableView();
            tableView.Presenter = new ReceiptsTablePresenter(tableView);
            ReceiptsView receiptsView = new ReceiptsView(tableView);
            receiptsView.Presenter = new ReceiptsPresenter(receiptsView);
            return receiptsView;
        }
    }
}
