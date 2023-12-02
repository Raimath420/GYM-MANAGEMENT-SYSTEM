namespace GymFitnessCenter
{
    partial class Loading
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            label3 = new Label();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            login = new Button();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(482, 8);
            label3.Name = "label3";
            label3.Size = new Size(32, 32);
            label3.TabIndex = 6;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(121, 10);
            label1.Name = "label1";
            label1.Size = new Size(251, 28);
            label1.TabIndex = 5;
            label1.Text = "GYM FITNESS CENTER";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(20, 85);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(149, 93);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // login
            // 
            login.BackColor = Color.Crimson;
            login.Cursor = Cursors.Hand;
            login.FlatAppearance.BorderColor = Color.Crimson;
            login.FlatAppearance.BorderSize = 2;
            login.FlatAppearance.MouseDownBackColor = Color.Crimson;
            login.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            login.FlatStyle = FlatStyle.Flat;
            login.Font = new Font("Cambria", 20F, FontStyle.Bold, GraphicsUnit.Point);
            login.ForeColor = SystemColors.ButtonHighlight;
            login.Location = new Point(226, 156);
            login.Margin = new Padding(3, 2, 3, 2);
            login.Name = "login";
            login.Size = new Size(172, 53);
            login.TabIndex = 19;
            login.Text = "Start";
            login.UseVisualStyleBackColor = false;
            login.Click += login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(278, 77);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(54, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.ForeColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(-1, 225);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(0, 0);
            panel1.TabIndex = 22;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Crimson;
            panel2.Location = new Point(518, -1);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 23;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(528, 236);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(login);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Loading";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loading";
            Load += Loading_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label1;
        private PictureBox pictureBox3;
        private Button login;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private Panel panel2;
    }
}