using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace guide
{
    public partial class Details : Form
    {
        
        public Details()
        {
            InitializeComponent();
            
        }

        private void details_ok_btn_Click(object sender, EventArgs e)
        {
            //userinputpanel uip = new userinputpanel();
            gpacal gpa = new gpacal();
            
            //flprow.Controls.Add(uip);
            //typeof(gpacal).GetMethod("flprow_Paint", BindingFlags.NonPublic | BindingFlags.Instance).Invoke(new gpacal(), null);
            
        }
    }
}
