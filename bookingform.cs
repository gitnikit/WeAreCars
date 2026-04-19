using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoprojrect
{
    public partial class bookingform : Form
    {
        public bookingform()
        {
            InitializeComponent();
        }
        public static String firstName, lastName, address, age;
        public static String validlicense;
        public static String unlimitedMileage="", breakdownCover="";
        public static int noOfDays = 0;
        public static int serial = 0;
        public static String fuelType;
        public static String carType;
        public static Double totalCost = 0.0;

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
           
        private void chkyes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkbreakdown_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbreakdown.Checked==true) 
            {
                breakdownCover="Yes"; 
            }
            else
            { breakdownCover = "No"; }
        }

        private void radiobtnYes_CheckedChanged(object sender, EventArgs e)
        {
            validlicense = "Yes";
            btnbooking.Enabled = true;
        }
            

        private void radiobtnNo_CheckedChanged(object sender, EventArgs e)
        {
            validlicense = "No";
            btnbooking.Enabled = false;
        }

        private void chkmileage_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmileage.Checked == true) 
            {
                unlimitedMileage="Yes"; 
            }
            else
            {                
                unlimitedMileage="No"; 
            }
        }


        private void btnbooking_Click(object sender, EventArgs e)
        {
            carType = cmbcartype.SelectedItem.ToString();
            fuelType = cmbfueltype.Text;
            if (txtfirstname.Text == "" || txtlastname.Text == "" || txtaddress.Text == "" || cmbcartype.SelectedIndex == -1 || cmbfueltype.SelectedIndex == -1)
            {
                MessageBox.Show("Please Provide all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (validlicense == "")
            {
                MessageBox.Show("Please Provide all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (noOfDays < 0 || noOfDays > 28)
            {
                MessageBox.Show("Number of days should be between 1 and 28", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                serial++;//increment serial number for each booking//
                firstName = txtfirstname.Text;
                lastName = txtlastname.Text;
                address = txtaddress.Text;
                validlicense = "Yes";
                noOfDays = Convert.ToInt32(numdays.Value.ToString());
                age = txtage.Text;
                totalCost = noOfDays * 25;//This is the base cost for booking a car which is 25 pound per day.


                //FInalizing the overall cost for booking a car based on user selection.
                if (cmbcartype.Text == "Family Car")
                {
                    totalCost += 50;
                }
                else if (carType == "Sports Car")
                {
                    totalCost += 75;
                }
                else if (carType == "SUV")
                {
                    totalCost += 65;
                }
               if(fuelType=="Hybrid")
                {
                    totalCost += 30;
                }
               else if(fuelType== "Full Electric")
                {
                    totalCost += 50;
                }
                if (unlimitedMileage == "Yes") 
                {
                    totalCost += noOfDays * 10;
                }
                if (breakdownCover == "Yes") 
                {
                    totalCost += noOfDays * 2;
                }


                    summaryfrm summary = new summaryfrm();
                summary.lblFirstName.Text = firstName;
                summary.lblLastName.Text = lastName;
                summary.lblAddress.Text = address;
                summary.lblAge.Text = age;
                summary.lblCarType.Text = carType;
                summary.lblFuelType.Text = fuelType;
                summary.lblValidLicense.Text = validlicense;
                summary.lblUnlimitedMileage.Text = unlimitedMileage;
                summary.lblBreakdownCover.Text = breakdownCover;
                summary.lblTotalCost.Text = "£" + totalCost.ToString();
                summary.ShowDialog();


            }
        }

        private void cmbfueltype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
