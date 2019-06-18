using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using UI.Views.Data;
using UI.Events;
using UI.Events.Messages;

namespace UI.Presenters.Data
{
    public abstract class TablePresenter<T> 
    {
        protected ITableView view;

        protected List<T> dataSource;

        protected TablePresenter(ITableView view)
        {
            this.view = view;
            SubscribeToEvents();
            SetTableColumns();
        }

        protected virtual void SubscribeToEvents()
        {
            view.LoadData += LoadDataHandler;
        }

        protected abstract void SetTableColumns();

        protected abstract void LoadData();

        protected virtual void AddNewRecord(T data)
        {
            dataSource.Add(data);
            view.DataSource = dataSource.ToList();
        }

        protected virtual void UpdateRecord(int index, T data)
        {
            dataSource[index] = data;
            view.DataSource = dataSource.ToList();
        }

        protected virtual void DeleteRecord(int index)
        {
            dataSource.RemoveAt(index);
            view.DataSource = dataSource.ToList();
        }

        // Event Handlers
        protected virtual void LoadDataHandler(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
