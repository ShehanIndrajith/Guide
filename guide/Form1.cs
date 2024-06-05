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
    public partial class signup : Form
    {
        //private Size formOriginalSize;
        //private Rectangle recBut1;
        //private Rectangle recTxt1;
        //private Rectangle recPnl1;
        //private Rectangle recRdo1;
        public signup()
        {
            InitializeComponent();
            
            //this.Resize += Form1_Load;
            //formOriginalSize = this.Size;

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Parent = this;
            pictureBox2.BackColor = Color.Transparent;
            label1.Parent = guna2PictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = guna2PictureBox1;
            label2.BackColor = Color.Transparent;
            guna2Button1.Parent = guna2PictureBox1;
            guna2Button1.BackColor = Color.Transparent;
            label3.Parent = guna2PictureBox1;
            label3.BackColor = Color.Transparent;
            label6.Parent = pictureBox2;
            label6.BackColor = Color.Transparent;
            label7.Parent = pictureBox2;
            label7.BackColor = Color.Transparent;
            guna2Button2.Parent = pictureBox2;
            guna2Button2.BackColor = Color.Transparent;


        }

        private void hide_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar == '●')
            {
                show.BringToFront();
                password.PasswordChar = '\0';
            }
        }

        private void show_Click(object sender, EventArgs e)
        {
            if (password.PasswordChar=='\0')
            {
                hide.BringToFront();
                password.PasswordChar = '●';
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            guna2CircleButton1.Visible = false;
            guna2CircleButton2.Visible = false;
            guna2CircleButton3.Visible = false;
            label5.Visible = false;
            name.Visible = false;
            email.Visible = false;
            password.Visible = false;
            hide.Visible = false;
            show.Visible = false;
            guna2GradientButton1.Visible = false;
            guna2PictureBox1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            
            pictureBox2.Visible = true;
            label7.Visible = true;
            guna2Button2.Visible = true;
            label8.Visible = true;
            fblogin.Visible = true;
            googlepluslogin.Visible = true;
            linkedlogin.Visible = true;
            label9.Visible = true;
            login_name.Visible = true;
            login_password.Visible = true;
            linkLabel1.Visible = true;
            btn_login.Visible = true;
            loginhidebtn.Visible = true;
            //loginshowbtn.Visible = true;
            logshow.Visible = true;
            guna2CheckBox1.Visible = true;
            loginerrormsg.Visible = true;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            guna2CircleButton1.Visible = true;
            guna2CircleButton2.Visible = true;
            guna2CircleButton3.Visible = true;
            label5.Visible = true;
            name.Visible = true;
            email.Visible = true;
            password.Visible = true;
            hide.Visible = true;
            show.Visible = true;
            guna2GradientButton1.Visible = true;
            guna2PictureBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;

            pictureBox2.Visible = false;
            label7.Visible = false;
            guna2Button2.Visible =false;
            label8.Visible = false;
            fblogin.Visible = false;
            googlepluslogin.Visible = false;
            linkedlogin.Visible = false;
            label9.Visible=false;
            login_name.Visible = false;
            login_password.Visible = false;
            linkLabel1.Visible =false;
            btn_login.Visible=false;
            //loginshowbtn.Visible=false;
            loginhidebtn.Visible=false;
            logshow.Visible=false;
            guna2CheckBox1.Visible=false;
            loginerrormsg.Visible=false;
        }

        private void fblogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void loginhidebtn_Click(object sender, EventArgs e)
        {
            if (login_password.PasswordChar == '●')
            {
                logshow.BringToFront();
                login_password.PasswordChar = '\0';
            }
        }

        private void logshow_Click(object sender, EventArgs e)
        {
            if (login_password.PasswordChar == '\0')
            {
                loginhidebtn.BringToFront();
                login_password.PasswordChar = '●';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            String loginname = login_name.Text;
            String loginpassword = login_password.Text;
            dashbord d = new dashbord();

            if (loginname == "SBShehan" && loginpassword == "Bd@20021028")
            {
                this.Hide();
                d.ShowDialog();
            }

            else if (loginname == "" && loginpassword == "")
            {
                
                loginerrormsg.Text = ("Please enter your Username and Password.");
            }
            else
            {
                loginerrormsg.Text = ("Invalid Log in!. Please check your Username and Password again.");
            }

            
            
        }

        private void signup_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
