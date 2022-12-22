using Data_AccessLayer.Entity;
using Data_AccessLayer.Operation;
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
    public partial class Complain_Box : Form
    {
        public Complain_Box()
        {
            InitializeComponent();
        }

        public string Gender { get; private set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EPolice ePolice = new EPolice();
            ePolice.Name = textBox1.Text;
            ePolice.FatheName = textBox2.Text;
            ePolice.Email = textBox3.Text;
            ePolice.Number = textBox4.Text;
            ePolice.Address = textBox5.Text;
            ePolice.Write_Your_Complain = textBox6.Text;
            ePolice.Gender = textBox7.Text;

            OPolice oPolice = new OPolice();
            int number = oPolice.save(ePolice);


            if (number > 0)
            {
                MessageBox.Show("Successfully Save");
            }
            else
            {
                MessageBox.Show("Not Save");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
