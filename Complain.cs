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
    public partial class Complain : Form
    {
        public Complain()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OPolice oproduct = new OPolice();
            SqlDataAdapter sql = oproduct.showcomplain();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Criminal a = new Criminal();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = textBox1.Text;

            OPolice oPolice = new OPolice();
            int number = oPolice.deletecomplain(ePolice);

            if (number > 0)
            {
                MessageBox.Show("Successfully Remove");
            }
            else
            {
                MessageBox.Show("Not Remove");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
