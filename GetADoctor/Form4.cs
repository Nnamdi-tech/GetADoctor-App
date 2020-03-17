using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetADoctor
{
    public partial class AppointmentPage : Form
    {
        public AppointmentPage()
        {
            InitializeComponent();
        }

        private void viewAppointmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void bookAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void BookAppointment_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Show();
            //this.Hide();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Show();
            this.Hide();
        }

        private void AppointmentPage_Load(object sender, EventArgs e)
        {

        }
    }
}
