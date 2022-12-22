using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace police_station_management_system
{
    public partial class Form1 : Form
    {
        public string password = "admin";
        public Form1()
        {
            InitializeComponent();
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

        private void lblClear_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnLOGIN_Click(object sender, EventArgs e)
        {
            string Name = txtUserName.Text;
            string Password = txtPassword.Text;
            
            if (Name == "admin" && Password ==password )
            {
                Admin ad = new Admin();
                ad.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid information");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PoliceOfficer pf = new PoliceOfficer();
            pf.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Complain_Box pf = new Complain_Box();
            pf.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Mobile:01320001299 ,01320001300" + "--------Phone:  +880-2-223381967,+880-2-223383515", "For Emergency");
            Console.WriteLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
