namespace demoprojrect
{
    partial class dashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewBooking = new System.Windows.Forms.Button();
            this.lblBookingDashboard = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgBookingDetails = new System.Windows.Forms.DataGridView();
            this.lblNewBooking = new System.Windows.Forms.Button();
            this.sn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crtyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fueltyp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ulm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brkdn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalcost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgBookingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnNewBooking);
            this.panel1.Controls.Add(this.lblBookingDashboard);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1550, 45);
            this.panel1.TabIndex = 0;
            // 
            // btnNewBooking
            // 
            this.btnNewBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewBooking.Location = new System.Drawing.Point(1371, -2);
            this.btnNewBooking.Name = "btnNewBooking";
            this.btnNewBooking.Size = new System.Drawing.Size(179, 45);
            this.btnNewBooking.TabIndex = 2;
            this.btnNewBooking.Text = "New Booking";
            this.btnNewBooking.UseVisualStyleBackColor = false;
            this.btnNewBooking.Click += new System.EventHandler(this.btnNewBooking_Click);
            // 
            // lblBookingDashboard
            // 
            this.lblBookingDashboard.AutoSize = true;
            this.lblBookingDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingDashboard.Location = new System.Drawing.Point(3, 8);
            this.lblBookingDashboard.Name = "lblBookingDashboard";
            this.lblBookingDashboard.Size = new System.Drawing.Size(281, 32);
            this.lblBookingDashboard.TabIndex = 0;
            this.lblBookingDashboard.Text = "Booking Dashboard";
            this.lblBookingDashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgBookingDetails);
            this.panel2.Controls.Add(this.lblNewBooking);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1550, 798);
            this.panel2.TabIndex = 1;
            // 
            // dtgBookingDetails
            // 
            this.dtgBookingDetails.AllowUserToAddRows = false;
            this.dtgBookingDetails.AllowUserToDeleteRows = false;
            this.dtgBookingDetails.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dtgBookingDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgBookingDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sn,
            this.FName,
            this.LName,
            this.age,
            this.address,
            this.crtyp,
            this.fueltyp,
            this.VL,
            this.NOD,
            this.ulm,
            this.brkdn,
            this.totalcost});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgBookingDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dtgBookingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgBookingDetails.Location = new System.Drawing.Point(0, 0);
            this.dtgBookingDetails.Name = "dtgBookingDetails";
            this.dtgBookingDetails.ReadOnly = true;
            this.dtgBookingDetails.RowHeadersWidth = 51;
            this.dtgBookingDetails.RowTemplate.Height = 24;
            this.dtgBookingDetails.Size = new System.Drawing.Size(1550, 798);
            this.dtgBookingDetails.TabIndex = 0;
            this.dtgBookingDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblNewBooking
            // 
            this.lblNewBooking.BackColor = System.Drawing.Color.SteelBlue;
            this.lblNewBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBooking.Location = new System.Drawing.Point(1282, 175);
            this.lblNewBooking.Name = "lblNewBooking";
            this.lblNewBooking.Size = new System.Drawing.Size(206, 49);
            this.lblNewBooking.TabIndex = 1;
            this.lblNewBooking.Text = "New Booking";
            this.lblNewBooking.UseVisualStyleBackColor = false;
            // 
            // sn
            // 
            this.sn.HeaderText = "S.N";
            this.sn.MinimumWidth = 6;
            this.sn.Name = "sn";
            this.sn.ReadOnly = true;
            this.sn.Width = 125;
            // 
            // FName
            // 
            this.FName.HeaderText = "First Name";
            this.FName.MinimumWidth = 6;
            this.FName.Name = "FName";
            this.FName.ReadOnly = true;
            this.FName.Width = 125;
            // 
            // LName
            // 
            this.LName.HeaderText = "Last Name";
            this.LName.MinimumWidth = 6;
            this.LName.Name = "LName";
            this.LName.ReadOnly = true;
            this.LName.Width = 125;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.MinimumWidth = 6;
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 125;
            // 
            // address
            // 
            this.address.HeaderText = "Address";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 125;
            // 
            // crtyp
            // 
            this.crtyp.HeaderText = "Car Type";
            this.crtyp.MinimumWidth = 6;
            this.crtyp.Name = "crtyp";
            this.crtyp.ReadOnly = true;
            this.crtyp.Width = 125;
            // 
            // fueltyp
            // 
            this.fueltyp.HeaderText = "Fuel Type";
            this.fueltyp.MinimumWidth = 6;
            this.fueltyp.Name = "fueltyp";
            this.fueltyp.ReadOnly = true;
            this.fueltyp.Width = 125;
            // 
            // VL
            // 
            this.VL.HeaderText = "Valid License";
            this.VL.MinimumWidth = 6;
            this.VL.Name = "VL";
            this.VL.ReadOnly = true;
            this.VL.Width = 125;
            // 
            // NOD
            // 
            this.NOD.HeaderText = "No.of Days";
            this.NOD.MinimumWidth = 6;
            this.NOD.Name = "NOD";
            this.NOD.ReadOnly = true;
            this.NOD.Width = 125;
            // 
            // ulm
            // 
            this.ulm.HeaderText = "Unlimited Mileage";
            this.ulm.MinimumWidth = 6;
            this.ulm.Name = "ulm";
            this.ulm.ReadOnly = true;
            this.ulm.Width = 125;
            // 
            // brkdn
            // 
            this.brkdn.HeaderText = "Breakdown Cover";
            this.brkdn.MinimumWidth = 6;
            this.brkdn.Name = "brkdn";
            this.brkdn.ReadOnly = true;
            this.brkdn.Width = 125;
            // 
            // totalcost
            // 
            this.totalcost.HeaderText = "Total Cost";
            this.totalcost.MinimumWidth = 6;
            this.totalcost.Name = "totalcost";
            this.totalcost.ReadOnly = true;
            this.totalcost.Width = 125;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1550, 843);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.Text = "WeAreCars";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgBookingDetails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblBookingDashboard;
        private System.Windows.Forms.Button lblNewBooking;
        private System.Windows.Forms.DataGridView dtgBookingDetails;
        private System.Windows.Forms.Button btnNewBooking;
        private System.Windows.Forms.DataGridViewTextBoxColumn sn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn crtyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn fueltyp;
        private System.Windows.Forms.DataGridViewTextBoxColumn VL;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ulm;
        private System.Windows.Forms.DataGridViewTextBoxColumn brkdn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalcost;
    }
}