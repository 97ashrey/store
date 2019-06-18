using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.UserControls
{
    public class UCGroup: System.Windows.Forms.Button
    {
        public int GroupID { get; set; }

        public UCGroup()
        {

        }

        public UCGroup(int groupID)
        {
            GroupID = groupID;
        }
    }
}
