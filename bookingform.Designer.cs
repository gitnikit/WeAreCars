namespace demoprojrect
{
    partial class bookingform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bookingform));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.MaskedTextBox();
            this.txtlastname = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.MaskedTextBox();
            this.txtage = new System.Windows.Forms.MaskedTextBox();
            this.cmbcartype = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbfueltype = new System.Windows.Forms.ComboBox();
            this.numdays = new System.Windows.Forms.NumericUpDown();
            this.btnbooking = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnNo = new System.Windows.Forms.RadioButton();
            this.radiobtnYes = new System.Windows.Forms.RadioButton();
            this.chkbreakdown = new System.Windows.Forms.CheckBox();
            this.chkmileage = new System.Windows.Forms.CheckBox();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdays)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(783, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 469);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "No.of days:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Age:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 25);
            this.label7.TabIndex = 7;
            this.label7.Text = "Fuel Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Car Type:";
            this.label6.Click += new System.EventHandler(this.label7_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Valid License:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(26, 527);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(151, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Optional Extras:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(222, 36);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(332, 22);
            this.txtfirstname.TabIndex = 12;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(222, 94);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(332, 22);
            this.txtlastname.TabIndex = 13;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(222, 157);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(332, 22);
            this.txtaddress.TabIndex = 14;
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(222, 220);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(332, 22);
            this.txtage.TabIndex = 15;
            // 
            // cmbcartype
            // 
            this.cmbcartype.BackColor = System.Drawing.Color.LightBlue;
            this.cmbcartype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcartype.FormattingEnabled = true;
            this.cmbcartype.Items.AddRange(new object[] {
            "City Car",
            "Family Car",
            "Sports Car",
            "Hybrid Car",
            "SUV Car",
            "Full electric Car"});
            this.cmbcartype.Location = new System.Drawing.Point(222, 343);
            this.cmbcartype.Name = "cmbcartype";
            this.cmbcartype.Size = new System.Drawing.Size(332, 24);
            this.cmbcartype.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbfueltype
            // 
            this.cmbfueltype.BackColor = System.Drawing.Color.LightBlue;
            this.cmbfueltype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbfueltype.FormattingEnabled = true;
            this.cmbfueltype.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Full Electric"});
            this.cmbfueltype.Location = new System.Drawing.Point(222, 404);
            this.cmbfueltype.Name = "cmbfueltype";
            this.cmbfueltype.Size = new System.Drawing.Size(332, 24);
            this.cmbfueltype.TabIndex = 19;
            this.cmbfueltype.SelectedIndexChanged += new System.EventHandler(this.cmbfueltype_SelectedIndexChanged);
            // 
            // numdays
            // 
            this.numdays.Location = new System.Drawing.Point(222, 474);
            this.numdays.Maximum = new decimal(new int[] {
            28,
            0,
            0,
            0});
            this.numdays.Name = "numdays";
            this.numdays.Size = new System.Drawing.Size(332, 22);
            this.numdays.TabIndex = 20;
            // 
            // btnbooking
            // 
            this.btnbooking.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnbooking.Enabled = false;
            this.btnbooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbooking.Location = new System.Drawing.Point(248, 575);
            this.btnbooking.Name = "btnbooking";
            this.btnbooking.Size = new System.Drawing.Size(151, 47);
            this.btnbooking.TabIndex = 12;
            this.btnbooking.Text = "Add Booking";
            this.btnbooking.UseVisualStyleBackColor = false;
            this.btnbooking.Click += new System.EventHandler(this.btnbooking_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radiobtnNo);
            this.groupBox1.Controls.Add(this.radiobtnYes);
            this.groupBox1.Controls.Add(this.chkbreakdown);
            this.groupBox1.Controls.Add(this.chkmileage);
            this.groupBox1.Controls.Add(this.btnclose);
            this.groupBox1.Controls.Add(this.btnbooking);
            this.groupBox1.Controls.Add(this.numdays);
            this.groupBox1.Controls.Add(this.cmbfueltype);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbcartype);
            this.groupBox1.Controls.Add(this.txtage);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(86, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(631, 631);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // radiobtnNo
            // 
            this.radiobtnNo.AutoSize = true;
            this.radiobtnNo.Location = new System.Drawing.Point(293, 287);
            this.radiobtnNo.Name = "radiobtnNo";
            this.radiobtnNo.Size = new System.Drawing.Size(46, 20);
            this.radiobtnNo.TabIndex = 27;
            this.radiobtnNo.TabStop = true;
            this.radiobtnNo.Text = "No";
            this.radiobtnNo.UseVisualStyleBackColor = true;
            this.radiobtnNo.CheckedChanged += new System.EventHandler(this.radiobtnNo_CheckedChanged);
            // 
            // radiobtnYes
            // 
            this.radiobtnYes.AutoSize = true;
            this.radiobtnYes.Location = new System.Drawing.Point(221, 287);
            this.radiobtnYes.Name = "radiobtnYes";
            this.radiobtnYes.Size = new System.Drawing.Size(52, 20);
            this.radiobtnYes.TabIndex = 26;
            this.radiobtnYes.TabStop = true;
            this.radiobtnYes.Text = "Yes";
            this.radiobtnYes.UseVisualStyleBackColor = true;
            this.radiobtnYes.CheckedChanged += new System.EventHandler(this.radiobtnYes_CheckedChanged);
            // 
            // chkbreakdown
            // 
            this.chkbreakdown.AutoSize = true;
            this.chkbreakdown.BackColor = System.Drawing.Color.Transparent;
            this.chkbreakdown.Location = new System.Drawing.Point(382, 532);
            this.chkbreakdown.Name = "chkbreakdown";
            this.chkbreakdown.Size = new System.Drawing.Size(136, 20);
            this.chkbreakdown.TabIndex = 25;
            this.chkbreakdown.Text = "Breakdown Cover";
            this.chkbreakdown.UseVisualStyleBackColor = false;
            this.chkbreakdown.CheckedChanged += new System.EventHandler(this.chkbreakdown_CheckedChanged);
            // 
            // chkmileage
            // 
            this.chkmileage.AutoSize = true;
            this.chkmileage.BackColor = System.Drawing.Color.Transparent;
            this.chkmileage.Location = new System.Drawing.Point(221, 533);
            this.chkmileage.Name = "chkmileage";
            this.chkmileage.Size = new System.Drawing.Size(137, 20);
            this.chkmileage.TabIndex = 24;
            this.chkmileage.Text = "Unlimited mileage";
            this.chkmileage.UseVisualStyleBackColor = false;
            this.chkmileage.CheckedChanged += new System.EventHandler(this.chkmileage_CheckedChanged);
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.IndianRed;
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclose.Location = new System.Drawing.Point(405, 575);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(120, 47);
            this.btnclose.TabIndex = 23;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // bookingform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 767);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "bookingform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeAreCars";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numdays)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtfirstname;
        private System.Windows.Forms.MaskedTextBox txtlastname;
        private System.Windows.Forms.MaskedTextBox txtaddress;
        private System.Windows.Forms.MaskedTextBox txtage;
        private System.Windows.Forms.ComboBox cmbcartype;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbfueltype;
        private System.Windows.Forms.NumericUpDown numdays;
        private System.Windows.Forms.Button btnbooking;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.RadioButton radiobtnNo;
        private System.Windows.Forms.RadioButton radiobtnYes;
        private System.Windows.Forms.CheckBox chkbreakdown;
        private System.Windows.Forms.CheckBox chkmileage;
    }
}