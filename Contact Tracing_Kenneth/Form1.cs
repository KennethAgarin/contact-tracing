using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Kenneth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
              
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your response have been submited");

            Application.Restart();

           StreamWriter file = new StreamWriter (@"C:\Users\DELL LATITUDE\Desktop\Contact Tracing Kenneth\contacttrace.txt", true);
            file.WriteLine("Time : " + txtboxtime.Text + txtboxmonth.Text + txtboxday.Text + txtboxyear.Text);
            file.WriteLine("Name: " + txtbox1stname.Text + txtboxmi.Text + txtboxsurname.Text);
            file.WriteLine("Address: " + txtboxstreet.Text + txtboxbarangay.Text + txtboxcity.Text);
            file.WriteLine("Contact: " + txtboxphonenum.Text + txtboxemail.Text);
            file.WriteLine("Temperature: " + txtboxtemp.Text);
            file.Close();
        }

        private void restartbtn_Click(object sender, EventArgs e)
        {
            Application.Restart();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
