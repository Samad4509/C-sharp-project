using Data_AccessLayer.Entity;
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
    public partial class PoliceOfficer : Form
    {
        
        public PoliceOfficer()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-PR2ORBP;Initial Catalog=Police_station;Integrated Security=True");
        private void btnEnter_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "select username, password from TUser where username = '" + txtUserName.Text.Trim() + "' and Password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, connection);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                this.Hide();
                new Criminal().Show();
            }
            else
            {
                MessageBox.Show("Incorrect Email or Password");
            }
            connection.Close();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 pf = new Form2();
            pf.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Form1 pf = new Form1();
            pf.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }
    }

  
  
}
