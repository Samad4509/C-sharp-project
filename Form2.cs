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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.UserName = textBox1.Text;
            ePolice.Password = textBox2.Text;

            OPolice oproduct = new OPolice();
            int number = oproduct.confiram(ePolice);

            if (number > 0)
            {
                MessageBox.Show("Successfully Add");
            }
            else
            {
                MessageBox.Show("Not Add");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OPolice oproduct = new OPolice();
            SqlDataAdapter sql = oproduct.usershow();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PoliceOfficer a = new PoliceOfficer();
            a.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
