using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Events
{
    public class GroupSelectedEventArgs: EventArgs
    {
        public int GroupID { get;}

        public GroupSelectedEventArgs(int groupID)
        {
            GroupID = groupID;
        }
    }
}
