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
    public partial class Form1 : Form
    {
        DoctorManager manager;
        public Form1()
        {
            InitializeComponent();
            manager = new DoctorManager();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //Patient._FullName = textBox1.Text;
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string t_name = name.Text;
            string t_sex = sex.Text;
            int t_age = int.Parse(age.Text);
            string t_spec = spec.Text;
            string t_qual = qual.Text;
            int t_exp = int.Parse(exp.Text);
            string t_email = mail.Text;
            int t_phone = int.Parse(phone.Text);
            string t_add = add.Text;


            Doctor d = new Doctor(t_name, t_age, t_qual, t_exp, t_spec, t_sex, t_phone, t_email, t_add);

            Program.finalManage.add(d);

            dataGridView1.DataSource = null;
            //dataGridView1.Refresh();

            dataGridView1.DataSource = Program.finalManage.doclist;


            MessageBox.Show("Registration Completed");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sex_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    }
}
