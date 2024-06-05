using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guide
{
    public partial class userinputpanel : UserControl
    {
        gpacal master = (gpacal)Application.OpenForms["gpacal"];
        public userinputpanel()
        {
            InitializeComponent();
        }

        public String No
        {
            get { return no.Text; }
            set { no.Text = value; }

        }

        public String Subname
        {
            get { return subjectname.Text; }
            set { subjectname.Text = value; }

        }

        public String Subgrade
        {
            get { return Grade.Text; }
            set { Grade.Text = value; }

        }

        public String Subpoint
        {
            get { return point.Text; }
            set { point.Text = value; }

        }

        private void userinputpanel_Load(object sender, EventArgs e)
        {

        }


        private void userinputpanel_MouseClick(object sender, MouseEventArgs e)
        {
            //master.RestbackColor();
            //deletebtn.Visible = true;
            //tableLayoutPanel1.BackColor = Color.FromArgb(161, 173, 255);
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            gpacal g = new gpacal();

            /*Button deleteButton = sender as Button;
            TableLayoutPanelCellPosition cellPosition = g.flprow.GetPositionFromControl(deleteButton);
            g.flprow.Controls.Remove(deleteButton);
            g.flprow.Controls.RemoveAt(cellPosition.Column + (cellPosition.Row * g.flprow.ColumnCount));*/

            this.Controls.Remove(this);
            this.Dispose();

        }
    }
}
