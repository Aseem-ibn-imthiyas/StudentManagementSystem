namespace FINAL_PROJECT
{
    partial class StudentRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRegister));
            this.linklbllogout = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbboxregno = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtcontactnumparent = new System.Windows.Forms.TextBox();
            this.txtnic = new System.Windows.Forms.TextBox();
            this.txtparentname = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txthomephone = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radiobtnfemale = new System.Windows.Forms.RadioButton();
            this.radiobtnmale = new System.Windows.Forms.RadioButton();
            this.dtpdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linklblexit = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // linklbllogout
            // 
            this.linklbllogout.AutoSize = true;
            this.linklbllogout.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklbllogout.Location = new System.Drawing.Point(12, 9);
            this.linklbllogout.Name = "linklbllogout";
            this.linklbllogout.Size = new System.Drawing.Size(48, 16);
            this.linklbllogout.TabIndex = 0;
            this.linklbllogout.TabStop = true;
            this.linklbllogout.Text = "Logout";
            this.linklbllogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklbllogout_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Skills International";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbboxregno);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.btndelete);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnclear);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnupdate);
            this.groupBox1.Controls.Add(this.btnregister);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(644, 775);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Registration";
            // 
            // cmbboxregno
            // 
            this.cmbboxregno.FormattingEnabled = true;
            this.cmbboxregno.Location = new System.Drawing.Point(194, 41);
            this.cmbboxregno.Name = "cmbboxregno";
            this.cmbboxregno.Size = new System.Drawing.Size(141, 27);
            this.cmbboxregno.TabIndex = 8;
            this.cmbboxregno.SelectedIndexChanged += new System.EventHandler(this.cmbboxregno_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtcontactnumparent);
            this.groupBox4.Controls.Add(this.txtnic);
            this.groupBox4.Controls.Add(this.txtparentname);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Location = new System.Drawing.Point(26, 516);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(591, 145);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parent Details";
            // 
            // txtcontactnumparent
            // 
            this.txtcontactnumparent.Location = new System.Drawing.Point(168, 105);
            this.txtcontactnumparent.Name = "txtcontactnumparent";
            this.txtcontactnumparent.Size = new System.Drawing.Size(152, 24);
            this.txtcontactnumparent.TabIndex = 5;
            // 
            // txtnic
            // 
            this.txtnic.Location = new System.Drawing.Point(168, 70);
            this.txtnic.Name = "txtnic";
            this.txtnic.Size = new System.Drawing.Size(151, 24);
            this.txtnic.TabIndex = 4;
            // 
            // txtparentname
            // 
            this.txtparentname.Location = new System.Drawing.Point(168, 37);
            this.txtparentname.Name = "txtparentname";
            this.txtparentname.Size = new System.Drawing.Size(377, 24);
            this.txtparentname.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(39, 108);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 19);
            this.label13.TabIndex = 2;
            this.label13.Text = "Contact Number";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "NIC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Parent Name";
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(542, 718);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 35);
            this.btndelete.TabIndex = 7;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txthomephone);
            this.groupBox3.Controls.Add(this.txtmobileno);
            this.groupBox3.Controls.Add(this.txtemail);
            this.groupBox3.Controls.Add(this.txtaddress);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(26, 320);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(591, 173);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contact Details";
            // 
            // txthomephone
            // 
            this.txthomephone.Location = new System.Drawing.Point(421, 127);
            this.txthomephone.Name = "txthomephone";
            this.txthomephone.Size = new System.Drawing.Size(126, 24);
            this.txthomephone.TabIndex = 7;
            // 
            // txtmobileno
            // 
            this.txtmobileno.Location = new System.Drawing.Point(168, 127);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(141, 24);
            this.txtmobileno.TabIndex = 6;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(169, 89);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(378, 24);
            this.txtemail.TabIndex = 5;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(168, 47);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(378, 36);
            this.txtaddress.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 19);
            this.label10.TabIndex = 3;
            this.label10.Text = "Home Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mobile Phone";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Address";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(453, 718);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 35);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radiobtnfemale);
            this.groupBox2.Controls.Add(this.radiobtnmale);
            this.groupBox2.Controls.Add(this.dtpdateofbirth);
            this.groupBox2.Controls.Add(this.txtlastname);
            this.groupBox2.Controls.Add(this.txtfirstname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(26, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 204);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Details";
            // 
            // radiobtnfemale
            // 
            this.radiobtnfemale.AutoSize = true;
            this.radiobtnfemale.Location = new System.Drawing.Point(262, 172);
            this.radiobtnfemale.Name = "radiobtnfemale";
            this.radiobtnfemale.Size = new System.Drawing.Size(78, 23);
            this.radiobtnfemale.TabIndex = 8;
            this.radiobtnfemale.Text = "Female";
            this.radiobtnfemale.UseVisualStyleBackColor = true;
            // 
            // radiobtnmale
            // 
            this.radiobtnmale.AutoSize = true;
            this.radiobtnmale.Checked = true;
            this.radiobtnmale.Location = new System.Drawing.Point(169, 172);
            this.radiobtnmale.Name = "radiobtnmale";
            this.radiobtnmale.Size = new System.Drawing.Size(63, 23);
            this.radiobtnmale.TabIndex = 7;
            this.radiobtnmale.TabStop = true;
            this.radiobtnmale.Text = "Male";
            this.radiobtnmale.UseVisualStyleBackColor = true;
            // 
            // dtpdateofbirth
            // 
            this.dtpdateofbirth.CustomFormat = "";
            this.dtpdateofbirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdateofbirth.Location = new System.Drawing.Point(169, 128);
            this.dtpdateofbirth.Name = "dtpdateofbirth";
            this.dtpdateofbirth.Size = new System.Drawing.Size(152, 24);
            this.dtpdateofbirth.TabIndex = 6;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(169, 86);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(377, 24);
            this.txtlastname.TabIndex = 5;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(169, 45);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(378, 24);
            this.txtfirstname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Gender";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data of Birth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "First Name";
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(116, 718);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 35);
            this.btnupdate.TabIndex = 5;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnregister
            // 
            this.btnregister.Location = new System.Drawing.Point(26, 718);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(84, 35);
            this.btnregister.TabIndex = 4;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = true;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reg No";
            // 
            // linklblexit
            // 
            this.linklblexit.AutoSize = true;
            this.linklblexit.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linklblexit.Location = new System.Drawing.Point(644, 850);
            this.linklblexit.Name = "linklblexit";
            this.linklblexit.Size = new System.Drawing.Size(28, 16);
            this.linklblexit.TabIndex = 8;
            this.linklblexit.TabStop = true;
            this.linklblexit.Text = "Exit";
            this.linklblexit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblexit_LinkClicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 871);
            this.Controls.Add(this.linklblexit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linklbllogout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration -  Skills International";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklbllogout;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.LinkLabel linklblexit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.RadioButton radiobtnfemale;
        private System.Windows.Forms.RadioButton radiobtnmale;
        private System.Windows.Forms.DateTimePicker dtpdateofbirth;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txthomephone;
        private System.Windows.Forms.TextBox txtmobileno;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtcontactnumparent;
        private System.Windows.Forms.TextBox txtnic;
        private System.Windows.Forms.TextBox txtparentname;
        private System.Windows.Forms.ComboBox cmbboxregno;
    }
}