
using System.Data;
using System.Data.SqlClient;


namespace GymFitnessCenter
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\DELL\Documents\GymDb.mdf;Integrated Security=True;Connect Timeout=30");
       /* public int duplicate()
        {
            string sql1 = "select * from MemberTable WHERE MName = '" + searchtb.Text + "'";
            SqlCommand cmd = new SqlCommand(sql1, con);
            con.Open();
            int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            con.Close();
            return temp;
        }
       */
        /*private void filter()
        {
            con.Open();
            String querry = "select * from MemberTable where MName='" + searchtb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MDGV.DataSource = ds.Tables[0];
            con.Close();
        }
        */
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

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void View_Load(object sender, EventArgs e)
        {
            populate();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 loggin = new Form1();
            loggin.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((DataTable)MDGV.DataSource).DefaultView.RowFilter = string.Format("MName like'%" + searchtb.Text + "%'");
            if (MDGV.Rows.Count == 0)
            {
                DialogResult m = MessageBox.Show("No Data Found with this Name");
                if(m==DialogResult.OK)
                {
                    populate();
                    searchtb.Text = "";
                }
            }
            else if (searchtb.Text == "")
            {
                    MessageBox.Show("Enter Valid Name");
            }
            else
            {
                //filter();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            populate();
            searchtb.Text = "";
        }

        private void MDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchtb_TextChanged(object sender, EventArgs e)
        {
            
            ((DataTable)MDGV.DataSource).DefaultView.RowFilter = string.Format("MName like'%" + searchtb.Text + "%'");

        }
    }
}
