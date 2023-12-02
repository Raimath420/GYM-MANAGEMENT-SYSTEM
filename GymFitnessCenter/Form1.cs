namespace GymFitnessCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddmemForm addmem = new AddmemForm();
            addmem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            View view = new View();
            view.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            update.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Delete delete = new Delete();
            delete.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Are You Sure You Want To Loggout", "Loggout", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                Loggin loggin = new Loggin();
                loggin.Show();
                this.Hide();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Contact delete = new Contact();
            delete.Show();
            
        }
    }
}