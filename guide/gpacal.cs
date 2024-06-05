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
    public partial class gpacal : Form
    {
        
        
        public gpacal()
        {
            
            InitializeComponent();
            //gpa.Value = 0;
        }

        private void gpacal_Load(object sender, EventArgs e)
        {
            /*for (int i = 0; i < 5; i++)
            {

                userinputpanel uip = new userinputpanel();
                flprow.Controls.Add(uip);
            }*/
            
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mpanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        internal void RestbackColor ()
        {
            foreach (var item in flprow.Controls.OfType<userinputpanel>())
            {
                
                item.BackColor = Color.FromArgb(224, 224, 224);

            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            
        }

        public void flprow_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }
        int buttonClickCount = 0;
        double sumgpa = 0;
        private void okbtn_Click(object sender, EventArgs e)
        {
            buttonClickCount++;
            string subname = sujectname.Text;
            string subgrade = grade.Text;
            string subpoint = point.Text;
            int n = 0;

            double pointvalue = Convert.ToDouble(subpoint);
            sumgpa = sumgpa + pointvalue;

            double subject_point = double.Parse(subpoint);
            

            DataTable dt = new DataTable();
            dt.Columns.Add("No");
            dt.Columns.Add("Subname");
            dt.Columns.Add("Subgrade");
            dt.Columns.Add("Subpoint");
            dt.Rows.Add(new object[] { buttonClickCount, subname,subgrade,subpoint});
            

            userinputpanel uip = new userinputpanel();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                uip.No = dt.Rows[i]["No"].ToString();
                uip.Subname = dt.Rows[i]["Subname"].ToString();
                uip.Subgrade = dt.Rows[i]["Subgrade"].ToString();
                uip.Subpoint = dt.Rows[i]["Subpoint"].ToString();
            }
            
            
            //int i;
            //uip.No = dt.Rows[i]["No"].ToString();

            flprow.Controls.Add(uip);
            sujectname.Clear();
            grade.Text = " ";
            point.Clear();
        }

        private void calculatebtn_Click(object sender, EventArgs e)
        {
            double totgpa = sumgpa / buttonClickCount;
            gpavalue.Visible = true;
            gpavalue.Text = totgpa.ToString("F1");
        }

        private void clearallbtn_Click(object sender, EventArgs e)
        {
          /*  // Clear the data from the TableLayoutPanel
            flprow.Controls.Clear();
            flprow.RowStyles.Clear();
            flprow.ColumnStyles.Clear();

            // Reset the number of rows and columns in the TableLayoutPanel
            flprow.RowCount = 0;
            flprow.ColumnCount = 0;*/
        }

        







        /* private void timer1_Tick(object sender, EventArgs e)
         {
            gpa.Value += 1;
            gpa.Text = gpa.Value.ToString();
             if (gpa.Value == 4)
             {
                 timer1.Enabled = false;
             }
         }*/
    }
}
