namespace guide
{
    partial class Details
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.details_cancel_btn = new Guna.UI2.WinForms.Guna2Button();
            this.details_ok_btn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pointcombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gradecombobox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.subnamebox = new Guna.UI2.WinForms.Guna2TextBox();
            this.subpoint = new System.Windows.Forms.Label();
            this.gradelabel = new System.Windows.Forms.Label();
            this.subnamelabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(589, 35);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.details_cancel_btn);
            this.panel2.Controls.Add(this.details_ok_btn);
            this.panel2.Controls.Add(this.pointcombobox);
            this.panel2.Controls.Add(this.gradecombobox);
            this.panel2.Controls.Add(this.subnamebox);
            this.panel2.Controls.Add(this.subpoint);
            this.panel2.Controls.Add(this.gradelabel);
            this.panel2.Controls.Add(this.subnamelabel);
            this.panel2.Location = new System.Drawing.Point(8, 43);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(589, 423);
            this.panel2.TabIndex = 1;
            // 
            // details_cancel_btn
            // 
            this.details_cancel_btn.AutoRoundedCorners = true;
            this.details_cancel_btn.BorderRadius = 18;
            this.details_cancel_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.details_cancel_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.details_cancel_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.details_cancel_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.details_cancel_btn.FillColor = System.Drawing.Color.Silver;
            this.details_cancel_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_cancel_btn.ForeColor = System.Drawing.Color.White;
            this.details_cancel_btn.Location = new System.Drawing.Point(328, 309);
            this.details_cancel_btn.Name = "details_cancel_btn";
            this.details_cancel_btn.Size = new System.Drawing.Size(159, 39);
            this.details_cancel_btn.TabIndex = 7;
            this.details_cancel_btn.Text = "Cancel";
            // 
            // details_ok_btn
            // 
            this.details_ok_btn.AutoRoundedCorners = true;
            this.details_ok_btn.BorderRadius = 18;
            this.details_ok_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.details_ok_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.details_ok_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.details_ok_btn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.details_ok_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.details_ok_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.details_ok_btn.ForeColor = System.Drawing.Color.White;
            this.details_ok_btn.Location = new System.Drawing.Point(70, 309);
            this.details_ok_btn.Name = "details_ok_btn";
            this.details_ok_btn.Size = new System.Drawing.Size(159, 39);
            this.details_ok_btn.TabIndex = 6;
            this.details_ok_btn.Text = "OK";
            this.details_ok_btn.Click += new System.EventHandler(this.details_ok_btn_Click);
            // 
            // pointcombobox
            // 
            this.pointcombobox.AutoRoundedCorners = true;
            this.pointcombobox.BackColor = System.Drawing.Color.Transparent;
            this.pointcombobox.BorderRadius = 17;
            this.pointcombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.pointcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pointcombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pointcombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.pointcombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pointcombobox.ForeColor = System.Drawing.Color.Black;
            this.pointcombobox.ItemHeight = 30;
            this.pointcombobox.Items.AddRange(new object[] {
            "4.0",
            "3.7",
            "3.3",
            "3.0",
            "2.7",
            "2.3",
            "2.0",
            "1.7",
            "1.3",
            "1.0",
            "0.0"});
            this.pointcombobox.Location = new System.Drawing.Point(262, 177);
            this.pointcombobox.Name = "pointcombobox";
            this.pointcombobox.Size = new System.Drawing.Size(225, 36);
            this.pointcombobox.TabIndex = 5;
            // 
            // gradecombobox
            // 
            this.gradecombobox.AutoRoundedCorners = true;
            this.gradecombobox.BackColor = System.Drawing.Color.Transparent;
            this.gradecombobox.BorderRadius = 17;
            this.gradecombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gradecombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gradecombobox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gradecombobox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gradecombobox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gradecombobox.ForeColor = System.Drawing.Color.Black;
            this.gradecombobox.ItemHeight = 30;
            this.gradecombobox.Items.AddRange(new object[] {
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
            this.gradecombobox.Location = new System.Drawing.Point(262, 112);
            this.gradecombobox.Name = "gradecombobox";
            this.gradecombobox.Size = new System.Drawing.Size(225, 36);
            this.gradecombobox.TabIndex = 4;
            // 
            // subnamebox
            // 
            this.subnamebox.AutoRoundedCorners = true;
            this.subnamebox.BorderColor = System.Drawing.Color.Gainsboro;
            this.subnamebox.BorderRadius = 19;
            this.subnamebox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.subnamebox.DefaultText = "";
            this.subnamebox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.subnamebox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.subnamebox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subnamebox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.subnamebox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subnamebox.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.subnamebox.ForeColor = System.Drawing.Color.Black;
            this.subnamebox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.subnamebox.Location = new System.Drawing.Point(262, 42);
            this.subnamebox.Name = "subnamebox";
            this.subnamebox.PasswordChar = '\0';
            this.subnamebox.PlaceholderForeColor = System.Drawing.Color.White;
            this.subnamebox.PlaceholderText = "";
            this.subnamebox.SelectedText = "";
            this.subnamebox.Size = new System.Drawing.Size(225, 41);
            this.subnamebox.TabIndex = 3;
            // 
            // subpoint
            // 
            this.subpoint.AutoSize = true;
            this.subpoint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subpoint.Location = new System.Drawing.Point(32, 187);
            this.subpoint.Name = "subpoint";
            this.subpoint.Size = new System.Drawing.Size(49, 23);
            this.subpoint.TabIndex = 2;
            this.subpoint.Text = "Point";
            // 
            // gradelabel
            // 
            this.gradelabel.AutoSize = true;
            this.gradelabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradelabel.Location = new System.Drawing.Point(32, 118);
            this.gradelabel.Name = "gradelabel";
            this.gradelabel.Size = new System.Drawing.Size(56, 23);
            this.gradelabel.TabIndex = 1;
            this.gradelabel.Text = "Grade";
            // 
            // subnamelabel
            // 
            this.subnamelabel.AutoSize = true;
            this.subnamelabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subnamelabel.Location = new System.Drawing.Point(32, 50);
            this.subnamelabel.Name = "subnamelabel";
            this.subnamelabel.Size = new System.Drawing.Size(117, 23);
            this.subnamelabel.TabIndex = 0;
            this.subnamelabel.Text = "Subject Name";
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(607, 474);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Details";
            this.Text = "Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox subnamebox;
        private System.Windows.Forms.Label subpoint;
        private System.Windows.Forms.Label gradelabel;
        private System.Windows.Forms.Label subnamelabel;
        private Guna.UI2.WinForms.Guna2ComboBox pointcombobox;
        private Guna.UI2.WinForms.Guna2ComboBox gradecombobox;
        private Guna.UI2.WinForms.Guna2Button details_cancel_btn;
        private Guna.UI2.WinForms.Guna2GradientButton details_ok_btn;
    }
}