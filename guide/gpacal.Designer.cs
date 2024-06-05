namespace guide
{
    partial class gpacal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mpanel = new System.Windows.Forms.Panel();
            this.guna2VScrollBar1 = new Guna.UI2.WinForms.Guna2VScrollBar();
            this.flprow = new System.Windows.Forms.FlowLayoutPanel();
            this.details_pnl = new System.Windows.Forms.Panel();
            this.okbtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.point = new Guna.UI2.WinForms.Guna2TextBox();
            this.pointlbl = new System.Windows.Forms.Label();
            this.grade = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grd = new System.Windows.Forms.Label();
            this.sujectname = new Guna.UI2.WinForms.Guna2TextBox();
            this.CV = new System.Windows.Forms.Label();
            this.calculatebtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GPAtxt = new System.Windows.Forms.Label();
            this.gpavalue = new System.Windows.Forms.Label();
            this.clearallbtn = new Guna.UI2.WinForms.Guna2Button();
            this.mpanel.SuspendLayout();
            this.details_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(133)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(398, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "GPA Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "#";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Subject Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(420, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Grade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(576, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Points";
            // 
            // mpanel
            // 
            this.mpanel.BackColor = System.Drawing.Color.White;
            this.mpanel.Controls.Add(this.flprow);
            this.mpanel.Location = new System.Drawing.Point(43, 159);
            this.mpanel.Margin = new System.Windows.Forms.Padding(0);
            this.mpanel.Name = "mpanel";
            this.mpanel.Size = new System.Drawing.Size(702, 394);
            this.mpanel.TabIndex = 6;
            this.mpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mpanel_Paint);
            // 
            // guna2VScrollBar1
            // 
            this.guna2VScrollBar1.AutoRoundedCorners = true;
            this.guna2VScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VScrollBar1.BorderRadius = 4;
            this.guna2VScrollBar1.InUpdate = false;
            this.guna2VScrollBar1.LargeChange = 10;
            this.guna2VScrollBar1.Location = new System.Drawing.Point(759, 162);
            this.guna2VScrollBar1.Name = "guna2VScrollBar1";
            this.guna2VScrollBar1.ScrollbarSize = 11;
            this.guna2VScrollBar1.Size = new System.Drawing.Size(11, 391);
            this.guna2VScrollBar1.TabIndex = 8;
            // 
            // flprow
            // 
            this.flprow.BackColor = System.Drawing.Color.White;
            this.flprow.Location = new System.Drawing.Point(0, 0);
            this.flprow.Margin = new System.Windows.Forms.Padding(0);
            this.flprow.Name = "flprow";
            this.flprow.Size = new System.Drawing.Size(686, 394);
            this.flprow.TabIndex = 0;
            this.flprow.Paint += new System.Windows.Forms.PaintEventHandler(this.flprow_Paint);
            // 
            // details_pnl
            // 
            this.details_pnl.Controls.Add(this.okbtn);
            this.details_pnl.Controls.Add(this.point);
            this.details_pnl.Controls.Add(this.pointlbl);
            this.details_pnl.Controls.Add(this.grade);
            this.details_pnl.Controls.Add(this.grd);
            this.details_pnl.Controls.Add(this.sujectname);
            this.details_pnl.Controls.Add(this.CV);
            this.details_pnl.Location = new System.Drawing.Point(763, 89);
            this.details_pnl.Name = "details_pnl";
            this.details_pnl.Size = new System.Drawing.Size(313, 367);
            this.details_pnl.TabIndex = 7;
            // 
            // okbtn
            // 
            this.okbtn.AutoRoundedCorners = true;
            this.okbtn.BorderRadius = 21;
            this.okbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.okbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.okbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okbtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.okbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.okbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.okbtn.ForeColor = System.Drawing.Color.White;
            this.okbtn.Location = new System.Drawing.Point(13, 303);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(111, 45);
            this.okbtn.TabIndex = 6;
            this.okbtn.Text = "ADD";
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // point
            // 
            this.point.AutoRoundedCorners = true;
            this.point.BorderRadius = 19;
            this.point.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.point.DefaultText = "";
            this.point.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.point.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.point.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.point.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.point.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.point.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.ForeColor = System.Drawing.Color.Black;
            this.point.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.point.Location = new System.Drawing.Point(13, 229);
            this.point.Name = "point";
            this.point.PasswordChar = '\0';
            this.point.PlaceholderText = "";
            this.point.SelectedText = "";
            this.point.Size = new System.Drawing.Size(270, 41);
            this.point.TabIndex = 5;
            // 
            // pointlbl
            // 
            this.pointlbl.AutoSize = true;
            this.pointlbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointlbl.Location = new System.Drawing.Point(21, 203);
            this.pointlbl.Name = "pointlbl";
            this.pointlbl.Size = new System.Drawing.Size(49, 23);
            this.pointlbl.TabIndex = 4;
            this.pointlbl.Text = "Point";
            // 
            // grade
            // 
            this.grade.AutoRoundedCorners = true;
            this.grade.BackColor = System.Drawing.Color.Transparent;
            this.grade.BorderRadius = 17;
            this.grade.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grade.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.grade.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grade.ForeColor = System.Drawing.Color.Black;
            this.grade.ItemHeight = 30;
            this.grade.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "E"});
            this.grade.Location = new System.Drawing.Point(13, 142);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(270, 36);
            this.grade.TabIndex = 3;
            // 
            // grd
            // 
            this.grd.AutoSize = true;
            this.grd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grd.Location = new System.Drawing.Point(21, 116);
            this.grd.Name = "grd";
            this.grd.Size = new System.Drawing.Size(56, 23);
            this.grd.TabIndex = 2;
            this.grd.Text = "Grade";
            // 
            // sujectname
            // 
            this.sujectname.AutoRoundedCorners = true;
            this.sujectname.BorderRadius = 19;
            this.sujectname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sujectname.DefaultText = "";
            this.sujectname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.sujectname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.sujectname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sujectname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.sujectname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sujectname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sujectname.ForeColor = System.Drawing.Color.Black;
            this.sujectname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.sujectname.Location = new System.Drawing.Point(13, 59);
            this.sujectname.Name = "sujectname";
            this.sujectname.PasswordChar = '\0';
            this.sujectname.PlaceholderText = "";
            this.sujectname.SelectedText = "";
            this.sujectname.Size = new System.Drawing.Size(270, 41);
            this.sujectname.TabIndex = 1;
            // 
            // CV
            // 
            this.CV.AutoSize = true;
            this.CV.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CV.Location = new System.Drawing.Point(21, 33);
            this.CV.Name = "CV";
            this.CV.Size = new System.Drawing.Size(117, 23);
            this.CV.TabIndex = 0;
            this.CV.Text = "Subject Name";
            // 
            // calculatebtn
            // 
            this.calculatebtn.AutoRoundedCorners = true;
            this.calculatebtn.BorderRadius = 21;
            this.calculatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calculatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calculatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calculatebtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calculatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calculatebtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.calculatebtn.ForeColor = System.Drawing.Color.White;
            this.calculatebtn.Location = new System.Drawing.Point(565, 567);
            this.calculatebtn.Name = "calculatebtn";
            this.calculatebtn.Size = new System.Drawing.Size(180, 45);
            this.calculatebtn.TabIndex = 8;
            this.calculatebtn.Text = "CALCULATE";
            this.calculatebtn.Click += new System.EventHandler(this.calculatebtn_Click);
            // 
            // GPAtxt
            // 
            this.GPAtxt.AutoSize = true;
            this.GPAtxt.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPAtxt.Location = new System.Drawing.Point(855, 477);
            this.GPAtxt.Name = "GPAtxt";
            this.GPAtxt.Size = new System.Drawing.Size(115, 50);
            this.GPAtxt.TabIndex = 9;
            this.GPAtxt.Text = "GPA :";
            // 
            // gpavalue
            // 
            this.gpavalue.AutoSize = true;
            this.gpavalue.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpavalue.Location = new System.Drawing.Point(872, 522);
            this.gpavalue.Name = "gpavalue";
            this.gpavalue.Size = new System.Drawing.Size(0, 41);
            this.gpavalue.TabIndex = 10;
            this.gpavalue.Visible = false;
            // 
            // clearallbtn
            // 
            this.clearallbtn.AutoRoundedCorners = true;
            this.clearallbtn.BorderRadius = 21;
            this.clearallbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.clearallbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.clearallbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.clearallbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.clearallbtn.FillColor = System.Drawing.Color.Silver;
            this.clearallbtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearallbtn.ForeColor = System.Drawing.Color.White;
            this.clearallbtn.Location = new System.Drawing.Point(360, 567);
            this.clearallbtn.Name = "clearallbtn";
            this.clearallbtn.Size = new System.Drawing.Size(180, 45);
            this.clearallbtn.TabIndex = 11;
            this.clearallbtn.Text = "Clear";
            this.clearallbtn.Click += new System.EventHandler(this.clearallbtn_Click);
            // 
            // gpacal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1079, 646);
            this.Controls.Add(this.guna2VScrollBar1);
            this.Controls.Add(this.clearallbtn);
            this.Controls.Add(this.gpavalue);
            this.Controls.Add(this.GPAtxt);
            this.Controls.Add(this.calculatebtn);
            this.Controls.Add(this.details_pnl);
            this.Controls.Add(this.mpanel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gpacal";
            this.Tag = " ";
            this.Text = "gpacal";
            this.Load += new System.EventHandler(this.gpacal_Load);
            this.mpanel.ResumeLayout(false);
            this.details_pnl.ResumeLayout(false);
            this.details_pnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel mpanel;
        public System.Windows.Forms.FlowLayoutPanel flprow;
        private System.Windows.Forms.Panel details_pnl;
        private Guna.UI2.WinForms.Guna2ComboBox grade;
        private System.Windows.Forms.Label grd;
        private Guna.UI2.WinForms.Guna2TextBox sujectname;
        private System.Windows.Forms.Label CV;
        private Guna.UI2.WinForms.Guna2GradientButton okbtn;
        private Guna.UI2.WinForms.Guna2TextBox point;
        private System.Windows.Forms.Label pointlbl;
        private Guna.UI2.WinForms.Guna2VScrollBar guna2VScrollBar1;
        private Guna.UI2.WinForms.Guna2GradientButton calculatebtn;
        private System.Windows.Forms.Label GPAtxt;
        private System.Windows.Forms.Label gpavalue;
        private Guna.UI2.WinForms.Guna2Button clearallbtn;
    }
}