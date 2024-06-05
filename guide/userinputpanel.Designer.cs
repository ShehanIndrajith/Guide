namespace guide
{
    partial class userinputpanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.no = new System.Windows.Forms.Label();
            this.subjectname = new System.Windows.Forms.Label();
            this.Grade = new System.Windows.Forms.Label();
            this.point = new System.Windows.Forms.Label();
            this.deletebtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.42855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.26784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.26784F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.03578F));
            this.tableLayoutPanel1.Controls.Add(this.no, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.subjectname, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Grade, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.point, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.deletebtn, 4, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(682, 44);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userinputpanel_MouseClick);
            // 
            // no
            // 
            this.no.AutoSize = true;
            this.no.Dock = System.Windows.Forms.DockStyle.Fill;
            this.no.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.no.Location = new System.Drawing.Point(0, 0);
            this.no.Margin = new System.Windows.Forms.Padding(0);
            this.no.Name = "no";
            this.no.Size = new System.Drawing.Size(70, 44);
            this.no.TabIndex = 0;
            this.no.Text = "1";
            this.no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.no.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userinputpanel_MouseClick);
            // 
            // subjectname
            // 
            this.subjectname.AutoSize = true;
            this.subjectname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.subjectname.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectname.Location = new System.Drawing.Point(70, 0);
            this.subjectname.Margin = new System.Windows.Forms.Padding(0);
            this.subjectname.Name = "subjectname";
            this.subjectname.Size = new System.Drawing.Size(247, 44);
            this.subjectname.TabIndex = 1;
            this.subjectname.Text = "Subject Name";
            this.subjectname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.subjectname.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userinputpanel_MouseClick);
            // 
            // Grade
            // 
            this.Grade.AutoSize = true;
            this.Grade.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grade.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Grade.Location = new System.Drawing.Point(317, 0);
            this.Grade.Margin = new System.Windows.Forms.Padding(0);
            this.Grade.Name = "Grade";
            this.Grade.Size = new System.Drawing.Size(154, 44);
            this.Grade.TabIndex = 2;
            this.Grade.Text = "Grade";
            this.Grade.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Grade.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userinputpanel_MouseClick);
            // 
            // point
            // 
            this.point.AutoSize = true;
            this.point.Dock = System.Windows.Forms.DockStyle.Fill;
            this.point.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point.Location = new System.Drawing.Point(474, 0);
            this.point.Name = "point";
            this.point.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.point.Size = new System.Drawing.Size(148, 44);
            this.point.TabIndex = 3;
            this.point.Text = "Point";
            this.point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.point.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userinputpanel_MouseClick);
            // 
            // deletebtn
            // 
            this.deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deletebtn.FillColor = System.Drawing.Color.Transparent;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.Image = global::guide.Properties.Resources.toppng_com_edit_delete_icon_delete_icon_980x980;
            this.deletebtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.deletebtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.deletebtn.ImageSize = new System.Drawing.Size(30, 30);
            this.deletebtn.Location = new System.Drawing.Point(635, 3);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.deletebtn.Size = new System.Drawing.Size(40, 38);
            this.deletebtn.TabIndex = 4;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // userinputpanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "userinputpanel";
            this.Size = new System.Drawing.Size(682, 44);
            this.Load += new System.EventHandler(this.userinputpanel_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userinputpanel_MouseClick);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label no;
        private System.Windows.Forms.Label subjectname;
        private System.Windows.Forms.Label Grade;
        private System.Windows.Forms.Label point;
        private Guna.UI2.WinForms.Guna2CircleButton deletebtn;
    }
}
