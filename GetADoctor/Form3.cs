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
    public partial class Form3 : Form
    {
        DoctorManager manager;
        public Form3()
        {
            InitializeComponent();
            manager = new DoctorManager();
        }

        private void register_Click(object sender, EventArgs e)
        {
            string t_name = name.Text;
            string t_sex = sex.Text;
            int t_age = int.Parse(age.Text);
            string t_bg = bg.Text;
            string t_gnt = gnt.Text;
            string t_email = mail.Text;
            int t_phone = int.Parse(phone.Text);
            string t_add = add.Text;


            Patient p = new Patient(t_name, t_age, t_bg, t_gnt, t_sex, t_phone, t_email, t_add);

            Program.finalManage.PatientsRecord(p);

            PatientView.DataSource = null;

            PatientView.DataSource = Program.finalManage.patlist;
            

            MessageBox.Show("Registration Completed");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
