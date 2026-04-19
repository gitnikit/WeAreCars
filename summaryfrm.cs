using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demoprojrect
{
    public partial class summaryfrm : Form
    {
        public summaryfrm()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirmBooking_Click(object sender, EventArgs e)
        {
            dashboard.bookingDetails.Rows.Add(bookingform.serial,
                bookingform.firstName,
                bookingform.lastName,
                bookingform.age,
                bookingform.address,
                bookingform.carType,
                 bookingform.fuelType,
                bookingform.validlicense,
                bookingform.noOfDays,

                bookingform.unlimitedMileage ,
                bookingform.breakdownCover,
                
                bookingform.totalCost.ToString("C",System.Globalization.CultureInfo.GetCultureInfo("en-GB")));
                this.Close();
        }
    }
}
