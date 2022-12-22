using Data_AccessLayer.Entity;
using Data_AccessLayer.Operation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace police_station_management_system
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPolice_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = textBox1.Text;
            ePolice.Email = textBox2.Text;
            ePolice.Number = textBox3.Text;
            ePolice.Password = textBox4.Text;
            ePolice.Gender = textBox5.Text;

            OPolice oproduct = new OPolice();
            int number = oproduct.addpolice(ePolice);

            if (number >= 0)
            {
                MessageBox.Show("Successfully Add");
            }
            else
            {
                MessageBox.Show("Not Add");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            OPolice oproduct = new OPolice();
            SqlDataAdapter sql = oproduct.show();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnRemvePolice_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = textBox1.Text;

            OPolice oPolice = new OPolice();
            int number = oPolice.removepolice(ePolice);

            if (number > 0)
            {
                MessageBox.Show("Successfully Remove");
            }
            else
            {
                MessageBox.Show("Not Remove");
            }
        }

        private void btnUpdatePolice_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = textBox1.Text;
            ePolice.Email = textBox2.Text;
            ePolice.Number = textBox3.Text;
            ePolice.Password = textBox4.Text;
            ePolice.Gender = textBox5.Text;

            OPolice oPolice = new OPolice();
            int number = oPolice.updatepolice(ePolice);

            if (number >= 0)
            {
                MessageBox.Show("Successfully Update");
            }
            else
            {
                MessageBox.Show("Not Update");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }
    }
}
