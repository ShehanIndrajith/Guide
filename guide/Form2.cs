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
    public partial class dashbord : Form
    {
        public dashbord()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void formload(object Form)
        {
            if (this.dashpanel.Controls.Count > 0)
                this.dashpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.dashpanel.Controls.Add(f);
            this.dashpanel.Tag = f;
            f.Show();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            profilpic.Visible = true;
            dash_name.Visible = true;
            Dash_mail.Visible = true;
            btn_show.Visible = false;
            
            btn_hide.Visible = true;
            guna2Separator1.Visible = true;
            edit_profile.Visible = true;
            guna2GradientPanel1.Visible = false;
            guna2GradientPanel1.Width = 280;
            guna2Transition1.ShowSync(guna2GradientPanel1);
        }

        private void btn_hide_Click(object sender, EventArgs e)
        {
            profilpic.Visible = false;
            dash_name.Visible = false;
            Dash_mail.Visible = false;
            btn_hide.Visible = false;
            btn_show.Visible=true;
            
            guna2GradientPanel1.Visible=false;
            guna2Separator1.Visible=false;
            edit_profile.Visible=false;
            guna2GradientPanel1.Width = 62;
            guna2Transition1.ShowSync(guna2GradientPanel1);


        }

        private void dashbord_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            signup s = new signup();
            this.Hide();
            s.ShowDialog();
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            formload(new gpacal());
            
        }
    }
}
