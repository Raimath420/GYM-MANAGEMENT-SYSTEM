
using System.Data;
using System.Data.SqlClient;

namespace GymFitnessCenter
{
    public partial class Update : Form
    {
        
        public Update()
        {
            InitializeComponent();
            
        }



        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
        public int duplicate()
        {
            string sql1 = "select * from MemberTable WHERE MName = '" + NameTb.Text + "'";
            SqlCommand cmd = new SqlCommand(sql1, con);
            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            return temp;
        }

        private void populate()
        {
            con.Open();
            String querry = "select * from MemberTable";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        private void Update_Load(object sender, EventArgs e)
        {
            populate();
        }
        int key = 0;
        private void MDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            key = Convert.ToInt32(MDGV.SelectedRows[0].Cells[0].Value.ToString());
            NameTb.Text = MDGV.SelectedRows[0].Cells[1].Value.ToString();
            PhoneTb.Text = MDGV.SelectedRows[0].Cells[2].Value.ToString();
            AgeTb.Text = MDGV.SelectedRows[0].Cells[3].Value.ToString();
            GenderCb.Text = MDGV.SelectedRows[0].Cells[4].Value.ToString();
            AmountTb.Text = MDGV.SelectedRows[0].Cells[5].Value.ToString();
            TimingCb.Text = MDGV.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            GenderCb.Text = "";
            AmountTb.Text = "";
            TimingCb.Text = "";
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" || TimingCb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else if (PhoneTb.TextLength < 10)
            {
                MessageBox.Show("Enter valid Phone Number");
            }
            else
            {
                try
                {
                        con.Open();
                        String querry = "update MemberTable set MName='" + NameTb.Text + "', MPhone='" + PhoneTb.Text + "', MAge='" + AgeTb.Text + "', MGen='" + GenderCb.Text + "', MAmount='" + AmountTb.Text + "', MTiming='" + TimingCb.Text + "' where MId='" + key + "'";
                        SqlCommand cmd = new SqlCommand(querry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Upadated Successfully");
                        con.Close();
                        populate();
                        NameTb.Text = "";
                        PhoneTb.Text = "";
                        AgeTb.Text = "";
                        GenderCb.Text = "";
                        AmountTb.Text = "";
                        TimingCb.Text = "";

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Enter valid Inputs", ex.Message);
                    }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
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

        private void GenderCb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TimingCb_KeyPress(object sender, KeyPressEventArgs e)
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
