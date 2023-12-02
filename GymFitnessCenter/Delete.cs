
using System.Data;
using System.Data.SqlClient;


namespace GymFitnessCenter
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
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
        private void Delete_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            NameTb.Text = "";
            PhoneTb.Text = "";
            AgeTb.Text = "";
            GenderCb.Text = "";
            AmountTb.Text = "";
            TimingCb.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            home.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AmountTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" || TimingCb.Text == "")
            {
                MessageBox.Show("Select Member To Be Deleted");
            }
            else
            {
                DialogResult m = MessageBox.Show("Are You Sure You Want To Delete This Item", "Delete", MessageBoxButtons.YesNo);
                if (m == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        String querry = "delete from MemberTable where MId='" + key + "'";
                        SqlCommand cmd = new SqlCommand(querry, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Deleted Successfully");
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

        }

        private void NameTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
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
