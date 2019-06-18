using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Events;

namespace UI.Views.Group
{
    public interface IGroupsView: IPresenter, ILoad
    {
        event EventHandler<GroupSelectedEventArgs> GroupSelected;

        void AddGroup(int groupID, string groupName);
    }
}
