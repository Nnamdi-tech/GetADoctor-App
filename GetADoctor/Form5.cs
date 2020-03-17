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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void gnt_TextChanged(object sender, EventArgs e)
        {

        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox2.DataSource= nameOfDoc;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            int n = Program.finalManage.doclist.Count;
            string[] docName = new string[n];
            string nameOfDoc;
            for (int i = 0; i < n; i++)
            {
                nameOfDoc = Program.finalManage.doclist[i]._FullName;
                docName[i] = nameOfDoc;            
            }
            ComboDoctorName.DataSource = docName;

            int m = Program.finalManage.patlist.Count;
            string[] patName = new string[m];
            string nameOfPat;
            for (int j = 0; j < m; j++)
            {
                nameOfPat = Program.finalManage.patlist[j]._FullName;
                patName[j] = nameOfPat;
            }
            ComboPatientName.DataSource = patName;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            int t_id = Program.finalManage.Apptlist.Count + 1;
            string t_Dname = ComboDoctorName.Text;
            string t_Pname = ComboPatientName.Text;
            string t_ApptDate = AppointdatePicker.Text;
            string t_ApptTime = AppointmentTimePicker.Text;

            Appointment a = new Appointment(t_id, t_Dname, t_Pname, t_ApptDate, t_ApptTime);
            Program.finalManage.Apptlist.Add(a);

            AppointmentGridView.DataSource = null;
            AppointmentGridView.DataSource = Program.finalManage.Apptlist;

        }
    }
}
