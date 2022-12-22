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
    public partial class Criminal : Form
    {
        public Criminal()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = txtName.Text;
            ePolice.FatheName = txtFatherName.Text;
            ePolice.Crime = txtCrime.Text;
            ePolice.Address = txtAddress.Text;

            OPolice oproduct = new OPolice();
            int number = oproduct.criminaladd(ePolice);

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
            SqlDataAdapter sql = oproduct.show2();
            DataTable dataTable = new DataTable();
            sql.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = txtName.Text;

            OPolice oPolice = new OPolice();
            int number = oPolice.criminalremove(ePolice);

            if (number > 0)
            {
                MessageBox.Show("Successfully Remove");
            }
            else
            {
                MessageBox.Show("Not Remove");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtFatherName.Text = "";
            txtCrime.Text = "";
            txtAddress.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PoliceOfficer a = new PoliceOfficer();
            a.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Complain pf = new Complain();
            pf.Show();
            this.Hide();
        }

        private void Criminal_Load(object sender, EventArgs e)
        {

        }
    }
}
