using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.UserControls
{
    public partial class UCHeading : UserControl
    {
        public UCHeading()
        {
            InitializeComponent();
            Height = MinimumSize.Height;
        }

        [
        Category("Heading"),
        Description("Sets the text of the heading")
        ]
        public string HeadingText { get => lblHeading.Text; set => lblHeading.Text = value; }
    }
}
