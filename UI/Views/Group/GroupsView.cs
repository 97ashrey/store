using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.UserControls;
using UI.Events;

namespace UI.Views.Group
{
    public partial class GroupsView : UserControl, IGroupsView
    {
        public GroupsView()
        {
            InitializeComponent();
        }

        const int ROWHEIGTH = 60;

        public object Presenter { private get; set; }

        public event EventHandler<GroupSelectedEventArgs> GroupSelected;

        public event EventHandler Loaded;

        public void AddGroup(int groupID, string groupName)
        {
            AddRow();

            UCGroup group = new UCGroup()
            {
                GroupID = groupID,
                Text = groupName,
                Dock = DockStyle.Fill
            };

            group.Click += GroupClickedHandler;

            tableLayoutPanel1.Controls.Add(group);
        }

        private void ResetTable()
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.Height = ROWHEIGTH;
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, ROWHEIGTH));
        }

        private void AddRow()
        {
            if (tableLayoutPanel1.Controls.Count > 0)
            {
                Control lastControl = tableLayoutPanel1.Controls[tableLayoutPanel1.Controls.Count - 1];

                TableLayoutPanelCellPosition position = tableLayoutPanel1.GetPositionFromControl(lastControl);
                if (position.Column == tableLayoutPanel1.ColumnCount - 1 &&
                   position.Row == tableLayoutPanel1.RowCount - 1)
                {
                    tableLayoutPanel1.RowCount += 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, ROWHEIGTH));
                    tableLayoutPanel1.Height += ROWHEIGTH;
                }
            }
        }

        public void Reload()
        {
            ResetTable();
            Loaded?.Invoke(this, new EventArgs());
        }

        public void GroupClickedHandler(object sender, EventArgs e)
        {
            UCGroup group = sender as UCGroup;
            GroupSelectedEventArgs eventArgs = new GroupSelectedEventArgs(group.GroupID);
            GroupSelected?.Invoke(this,eventArgs);
        }
    }
}
