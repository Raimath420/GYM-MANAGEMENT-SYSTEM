using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymFitnessCenter
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int start = 0;
        int start2 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 20;
            start2 += 10;

            panel2.Size = new Size(15, start2);
            panel1.Size = new Size(start, 20);

            if (start == 600)
            {
                timer1.Stop();
                Loggin loggin = new Loggin();
                loggin.Show();
                this.Hide();

            }

        }

        private void login_Click(object sender, EventArgs e)
        {
            timer1.Start();

        }

        private void process1_Exited(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
