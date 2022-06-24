namespace Contact_Tracing_Kenneth
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Template = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtboxtime = new System.Windows.Forms.TextBox();
            this.txtboxmonth = new System.Windows.Forms.TextBox();
            this.txtboxyear = new System.Windows.Forms.TextBox();
            this.txtbox1stname = new System.Windows.Forms.TextBox();
            this.txtboxmi = new System.Windows.Forms.TextBox();
            this.txtboxsurname = new System.Windows.Forms.TextBox();
            this.txtboxstreet = new System.Windows.Forms.TextBox();
            this.txtboxbarangay = new System.Windows.Forms.TextBox();
            this.txtboxcity = new System.Windows.Forms.TextBox();
            this.txtboxphonenum = new System.Windows.Forms.TextBox();
            this.txtboxemail = new System.Windows.Forms.TextBox();
            this.txtboxday = new System.Windows.Forms.TextBox();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.restartbtn = new System.Windows.Forms.Button();
            this.txtboxtemp = new System.Windows.Forms.TextBox();
            this.temp = new System.Windows.Forms.Label();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.Adminbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Template)).BeginInit();
            this.SuspendLayout();
            // 
            // Template
            // 
            this.Template.BackColor = System.Drawing.Color.Transparent;
            this.Template.Image = ((System.Drawing.Image)(resources.GetObject("Template.Image")));
            this.Template.Location = new System.Drawing.Point(0, -1);
            this.Template.Name = "Template";
            this.Template.Size = new System.Drawing.Size(444, 477);
            this.Template.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Template.TabIndex = 0;
            this.Template.TabStop = false;
            this.Template.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GrayText;
            this.label1.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cornsilk;
            this.label1.Location = new System.Drawing.Point(36, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time and Date:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cornsilk;
            this.label2.Location = new System.Drawing.Point(39, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cornsilk;
            this.label3.Location = new System.Drawing.Point(39, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cornsilk;
            this.label4.Location = new System.Drawing.Point(39, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contact:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "First Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "M.I.";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 14);
            this.label7.TabIndex = 7;
            this.label7.Text = "Surname:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(42, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 14);
            this.label8.TabIndex = 8;
            this.label8.Text = "Street:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(158, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 14);
            this.label9.TabIndex = 9;
            this.label9.Text = "Barangay:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(276, 226);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(90, 14);
            this.label10.TabIndex = 10;
            this.label10.Text = "City, Province:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(42, 316);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 14);
            this.label11.TabIndex = 11;
            this.label11.Text = "Phone Number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(201, 315);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 12;
            this.label12.Text = "Email:";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtboxtime
            // 
            this.txtboxtime.Location = new System.Drawing.Point(39, 68);
            this.txtboxtime.Name = "txtboxtime";
            this.txtboxtime.Size = new System.Drawing.Size(44, 20);
            this.txtboxtime.TabIndex = 13;
            // 
            // txtboxmonth
            // 
            this.txtboxmonth.Location = new System.Drawing.Point(97, 68);
            this.txtboxmonth.Name = "txtboxmonth";
            this.txtboxmonth.Size = new System.Drawing.Size(47, 20);
            this.txtboxmonth.TabIndex = 14;
            // 
            // txtboxyear
            // 
            this.txtboxyear.Location = new System.Drawing.Point(176, 68);
            this.txtboxyear.Name = "txtboxyear";
            this.txtboxyear.Size = new System.Drawing.Size(47, 20);
            this.txtboxyear.TabIndex = 15;
            // 
            // txtbox1stname
            // 
            this.txtbox1stname.Location = new System.Drawing.Point(39, 151);
            this.txtbox1stname.Name = "txtbox1stname";
            this.txtbox1stname.Size = new System.Drawing.Size(162, 20);
            this.txtbox1stname.TabIndex = 18;
            // 
            // txtboxmi
            // 
            this.txtboxmi.Location = new System.Drawing.Point(204, 151);
            this.txtboxmi.Name = "txtboxmi";
            this.txtboxmi.Size = new System.Drawing.Size(29, 20);
            this.txtboxmi.TabIndex = 19;
            // 
            // txtboxsurname
            // 
            this.txtboxsurname.Location = new System.Drawing.Point(239, 151);
            this.txtboxsurname.Name = "txtboxsurname";
            this.txtboxsurname.Size = new System.Drawing.Size(161, 20);
            this.txtboxsurname.TabIndex = 20;
            // 
            // txtboxstreet
            // 
            this.txtboxstreet.Location = new System.Drawing.Point(39, 245);
            this.txtboxstreet.Name = "txtboxstreet";
            this.txtboxstreet.Size = new System.Drawing.Size(112, 20);
            this.txtboxstreet.TabIndex = 21;
            // 
            // txtboxbarangay
            // 
            this.txtboxbarangay.Location = new System.Drawing.Point(157, 245);
            this.txtboxbarangay.Name = "txtboxbarangay";
            this.txtboxbarangay.Size = new System.Drawing.Size(115, 20);
            this.txtboxbarangay.TabIndex = 22;
            // 
            // txtboxcity
            // 
            this.txtboxcity.Location = new System.Drawing.Point(276, 245);
            this.txtboxcity.Name = "txtboxcity";
            this.txtboxcity.Size = new System.Drawing.Size(124, 20);
            this.txtboxcity.TabIndex = 23;
            // 
            // txtboxphonenum
            // 
            this.txtboxphonenum.Location = new System.Drawing.Point(39, 338);
            this.txtboxphonenum.Name = "txtboxphonenum";
            this.txtboxphonenum.Size = new System.Drawing.Size(143, 20);
            this.txtboxphonenum.TabIndex = 24;
            // 
            // txtboxemail
            // 
            this.txtboxemail.Location = new System.Drawing.Point(202, 338);
            this.txtboxemail.Name = "txtboxemail";
            this.txtboxemail.Size = new System.Drawing.Size(198, 20);
            this.txtboxemail.TabIndex = 25;
            // 
            // txtboxday
            // 
            this.txtboxday.Location = new System.Drawing.Point(150, 68);
            this.txtboxday.Name = "txtboxday";
            this.txtboxday.Size = new System.Drawing.Size(20, 20);
            this.txtboxday.TabIndex = 26;
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonsubmit.ForeColor = System.Drawing.Color.Cornsilk;
            this.buttonsubmit.Location = new System.Drawing.Point(218, 427);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(192, 37);
            this.buttonsubmit.TabIndex = 27;
            this.buttonsubmit.Text = "Submit";
            this.buttonsubmit.UseVisualStyleBackColor = false;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.DimGray;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(236, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(191, 15);
            this.label13.TabIndex = 28;
            this.label13.Text = "AGARIN\'S SARI-SARI STORE";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.DimGray;
            this.label14.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(241, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(179, 19);
            this.label14.TabIndex = 29;
            this.label14.Text = "CONTACT TRACING";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.DimGray;
            this.label15.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(274, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 29);
            this.label15.TabIndex = 30;
            this.label15.Text = "FORM";
            // 
            // restartbtn
            // 
            this.restartbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.restartbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartbtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.restartbtn.Location = new System.Drawing.Point(32, 427);
            this.restartbtn.Name = "restartbtn";
            this.restartbtn.Size = new System.Drawing.Size(180, 37);
            this.restartbtn.TabIndex = 31;
            this.restartbtn.Text = "Restart";
            this.restartbtn.UseVisualStyleBackColor = false;
            this.restartbtn.Click += new System.EventHandler(this.restartbtn_Click);
            // 
            // txtboxtemp
            // 
            this.txtboxtemp.Location = new System.Drawing.Point(153, 401);
            this.txtboxtemp.Name = "txtboxtemp";
            this.txtboxtemp.Size = new System.Drawing.Size(143, 20);
            this.txtboxtemp.TabIndex = 34;
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.BackColor = System.Drawing.SystemColors.GrayText;
            this.temp.Font = new System.Drawing.Font("Lucida Bright", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.Color.Cornsilk;
            this.temp.Location = new System.Drawing.Point(135, 385);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(179, 15);
            this.temp.TabIndex = 32;
            this.temp.Text = "Temperature (in Celcius):";
            // 
            // txtpas
            // 
            this.txtpas.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtpas.Location = new System.Drawing.Point(32, 22);
            this.txtpas.Name = "txtpas";
            this.txtpas.Size = new System.Drawing.Size(104, 20);
            this.txtpas.TabIndex = 35;
            this.txtpas.Text = "Password";
            // 
            // Adminbtn
            // 
            this.Adminbtn.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adminbtn.Location = new System.Drawing.Point(138, 22);
            this.Adminbtn.Name = "Adminbtn";
            this.Adminbtn.Size = new System.Drawing.Size(90, 20);
            this.Adminbtn.TabIndex = 36;
            this.Adminbtn.Text = "Admin";
            this.Adminbtn.UseVisualStyleBackColor = true;
            this.Adminbtn.Click += new System.EventHandler(this.Adminbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(150)))), ((int)(((byte)(190)))));
            this.ClientSize = new System.Drawing.Size(443, 472);
            this.Controls.Add(this.Adminbtn);
            this.Controls.Add(this.txtpas);
            this.Controls.Add(this.txtboxtemp);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.restartbtn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.txtboxday);
            this.Controls.Add(this.txtboxemail);
            this.Controls.Add(this.txtboxphonenum);
            this.Controls.Add(this.txtboxcity);
            this.Controls.Add(this.txtboxbarangay);
            this.Controls.Add(this.txtboxstreet);
            this.Controls.Add(this.txtboxsurname);
            this.Controls.Add(this.txtboxmi);
            this.Controls.Add(this.txtbox1stname);
            this.Controls.Add(this.txtboxyear);
            this.Controls.Add(this.txtboxmonth);
            this.Controls.Add(this.txtboxtime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Template);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Template)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Template;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtboxtime;
        private System.Windows.Forms.TextBox txtboxmonth;
        private System.Windows.Forms.TextBox txtboxyear;
        private System.Windows.Forms.TextBox txtbox1stname;
        private System.Windows.Forms.TextBox txtboxmi;
        private System.Windows.Forms.TextBox txtboxsurname;
        private System.Windows.Forms.TextBox txtboxstreet;
        private System.Windows.Forms.TextBox txtboxbarangay;
        private System.Windows.Forms.TextBox txtboxcity;
        private System.Windows.Forms.TextBox txtboxphonenum;
        private System.Windows.Forms.TextBox txtboxemail;
        private System.Windows.Forms.TextBox txtboxday;
        private System.Windows.Forms.Button buttonsubmit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button restartbtn;
        private System.Windows.Forms.TextBox txtboxtemp;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.TextBox txtpas;
        private System.Windows.Forms.Button Adminbtn;
    }
}

