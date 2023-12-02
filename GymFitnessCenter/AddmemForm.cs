using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace GymFitnessCenter
{
    public partial class AddmemForm : Form
    {
        public AddmemForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");

       


        private void button1_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "")
            {
                    MessageBox.Show("Missing Information");    
            }
            else if (PhoneTb.TextLength < 10)
            {
                MessageBox.Show("Enter valid Phone Number");
            }
            else
            {
               
                
                    con.Open();
                    try
                    {

                        string querry = "insert into MemberTable values('" + NameTb.Text + "','" + PhoneTb.Text + "','" + AgeTb.Text + "','" + GenCb.SelectedItem.ToString() + "','" + AmountTb.Text + "','" + TimingTb.SelectedItem.ToString() + "')";
                        SqlCommand cmd = new SqlCommand(querry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member Added Successfully");

                        NameTb.Text = "";
                        AmountTb.Text = "";
                        PhoneTb.Text = "";
                        TimingTb.Text = "";
                        AgeTb.Text = "";
                        GenCb.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("PLEASE ENTER VALID INPUTS\n"+ex.Message);
                    }
                
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            AmountTb.Text = "";
            PhoneTb.Text = "";
            TimingTb.Text = "";
            AgeTb.Text = "";
            GenCb.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loggin = new Form1();
            loggin.Show();
            this.Hide();
        }

        private void AddmemForm_Load(object sender, EventArgs e)
        {

        }

        private void NameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PhoneTb_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void AgeTb_KeyPress(object sender, KeyPressEventArgs e)
        {
           if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

               e.Handled = true;

           }
        }

        private void AmountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void GenCb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }
        }

        private void TimingTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {

                e.Handled = true;

            }
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {

                e.Handled = true;

            }
        }
    }
}
