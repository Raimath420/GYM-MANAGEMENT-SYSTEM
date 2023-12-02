using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymFitnessCenter
{
    public partial class Loggin : Form
    {
        public Loggin()
        {
            InitializeComponent();
        }



        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "Raimath" && passTb.Text == "420")
            {
                Form1 home = new Form1();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Userneme or Password");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            passTb.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/raimath_420/");
        }
    }
}
