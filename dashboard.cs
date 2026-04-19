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
    public partial class dashboard : Form
    {
        public static DataGridView bookingDetails;
        public dashboard()
        {
            InitializeComponent();
            bookingDetails = dtgBookingDetails;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNewBooking_Click(object sender, EventArgs e)
        {
            bookingform frm=new bookingform();
            frm.ShowDialog();
        }
    }
}
