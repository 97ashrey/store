using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;
using UI.Events.Messages;
using UI.Views.Group;
using StoreLibrary.Models;
using StoreLibrary.DataAccess;


namespace UI.Presenters.Group
{
    public class GroupsPresenter
    {
        private IGroupsView view;
        List<GroupModel> groups;
        public GroupsPresenter(IGroupsView view)
        {
            this.view = view;
            SubsribeToEvents();
        }

        private void SubsribeToEvents()
        {
            view.Loaded += ViewLoadedHandler;
            view.GroupSelected += GroupSelectedHandler;
        }

        // Event handlers
        private void ViewLoadedHandler(object sender, EventArgs e)
        {
            groups = DataConnection.Instance.GetGroups();
            foreach(GroupModel group in groups)
            {
                view.AddGroup(group.ID, group.Name);
            }
        }

        private void GroupSelectedHandler(object sender, GroupSelectedEventArgs e)
        {
            GroupModel group = groups.Find(model => model.ID == e.GroupID);
            if(group == null)
            {
                return;
            }
            GlobalValues.SelectedGroup = group;
            // Send Switch View Message
            EventAggregator.Instance.Publish(new ShowProductsViewMessage());
        }

    }
}
