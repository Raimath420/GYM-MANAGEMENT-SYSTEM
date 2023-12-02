namespace GymFitnessCenter
{
    partial class Update
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Update));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            TimingCb = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            AmountTb = new TextBox();
            GenderCb = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            AgeTb = new TextBox();
            label5 = new Label();
            PhoneTb = new TextBox();
            label4 = new Label();
            NameTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label10 = new Label();
            MDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)MDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.BackColor = Color.Crimson;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.Crimson;
            button3.FlatAppearance.BorderSize = 2;
            button3.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(472, 602);
            button3.Name = "button3";
            button3.Size = new Size(146, 36);
            button3.TabIndex = 37;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Crimson;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.Crimson;
            button2.FlatAppearance.BorderSize = 2;
            button2.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(253, 602);
            button2.Name = "button2";
            button2.Size = new Size(146, 36);
            button2.TabIndex = 36;
            button2.Text = "Clear";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Crimson;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.Crimson;
            button1.FlatAppearance.BorderSize = 2;
            button1.FlatAppearance.MouseDownBackColor = Color.Crimson;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(152, 3, 33);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(26, 602);
            button1.Name = "button1";
            button1.Size = new Size(146, 36);
            button1.TabIndex = 35;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TimingCb
            // 
            TimingCb.BackColor = Color.AliceBlue;
            TimingCb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            TimingCb.ForeColor = Color.Crimson;
            TimingCb.FormattingEnabled = true;
            TimingCb.Items.AddRange(new object[] { "6Am - 8Am", "8Am - 10Am", "6Pm - 8Pm", "8Pm - 10Pm" });
            TimingCb.Location = new Point(26, 532);
            TimingCb.Name = "TimingCb";
            TimingCb.Size = new Size(166, 29);
            TimingCb.TabIndex = 34;
            TimingCb.KeyPress += TimingCb_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.MediumBlue;
            label9.Location = new Point(26, 506);
            label9.Name = "label9";
            label9.Size = new Size(72, 23);
            label9.TabIndex = 33;
            label9.Text = "Timing";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.MediumBlue;
            label8.Location = new Point(26, 433);
            label8.Name = "label8";
            label8.Size = new Size(171, 23);
            label8.TabIndex = 32;
            label8.Text = "Monthly Amount";
            // 
            // AmountTb
            // 
            AmountTb.BackColor = Color.AliceBlue;
            AmountTb.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AmountTb.ForeColor = Color.Crimson;
            AmountTb.Location = new Point(26, 459);
            AmountTb.MaxLength = 5;
            AmountTb.Name = "AmountTb";
            AmountTb.PlaceholderText = "Enter Amount";
            AmountTb.Size = new Size(171, 28);
            AmountTb.TabIndex = 31;
            AmountTb.KeyPress += AmountTb_KeyPress;
            // 
            // GenderCb
            // 
            GenderCb.BackColor = Color.AliceBlue;
            GenderCb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            GenderCb.ForeColor = Color.Crimson;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(26, 382);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(166, 29);
            GenderCb.TabIndex = 30;
            GenderCb.KeyPress += GenderCb_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.MediumBlue;
            label7.Location = new Point(26, 356);
            label7.Name = "label7";
            label7.Size = new Size(84, 23);
            label7.TabIndex = 29;
            label7.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.MediumBlue;
            label6.Location = new Point(26, 280);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 28;
            label6.Text = "Age";
            // 
            // AgeTb
            // 
            AgeTb.BackColor = Color.AliceBlue;
            AgeTb.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            AgeTb.ForeColor = Color.Crimson;
            AgeTb.Location = new Point(26, 306);
            AgeTb.MaxLength = 3;
            AgeTb.Name = "AgeTb";
            AgeTb.PlaceholderText = "Enter Age";
            AgeTb.Size = new Size(166, 28);
            AgeTb.TabIndex = 27;
            AgeTb.KeyPress += AgeTb_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.MediumBlue;
            label5.Location = new Point(26, 205);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 26;
            label5.Text = "Phone No";
            // 
            // PhoneTb
            // 
            PhoneTb.BackColor = Color.AliceBlue;
            PhoneTb.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            PhoneTb.ForeColor = Color.Crimson;
            PhoneTb.Location = new Point(26, 231);
            PhoneTb.MaxLength = 12;
            PhoneTb.Name = "PhoneTb";
            PhoneTb.PlaceholderText = "Enter Phone Number";
            PhoneTb.Size = new Size(166, 28);
            PhoneTb.TabIndex = 25;
            PhoneTb.KeyPress += PhoneTb_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.MediumBlue;
            label4.Location = new Point(26, 125);
            label4.Name = "label4";
            label4.Size = new Size(158, 23);
            label4.TabIndex = 24;
            label4.Text = "Member Name";
            // 
            // NameTb
            // 
            NameTb.BackColor = Color.AliceBlue;
            NameTb.Font = new Font("Constantia", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            NameTb.ForeColor = Color.Crimson;
            NameTb.Location = new Point(26, 151);
            NameTb.Name = "NameTb";
            NameTb.PlaceholderText = "Enter Name";
            NameTb.Size = new Size(166, 28);
            NameTb.TabIndex = 23;
            NameTb.KeyPress += NameTb_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(1155, 3);
            label3.Name = "label3";
            label3.Size = new Size(37, 37);
            label3.TabIndex = 22;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(431, 68);
            label2.Name = "label2";
            label2.Size = new Size(343, 37);
            label2.TabIndex = 21;
            label2.Text = "UPDATE/EDIT MEMBER";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(470, 15);
            label1.Name = "label1";
            label1.Size = new Size(237, 37);
            label1.TabIndex = 20;
            label1.Text = "FITNESS CENTER";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Constantia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Crimson;
            label10.Location = new Point(470, 125);
            label10.Name = "label10";
            label10.Size = new Size(272, 24);
            label10.TabIndex = 39;
            label10.Text = "Click On The Member To Edit";
            // 
            // MDGV
            // 
            MDGV.AllowUserToAddRows = false;
            MDGV.AllowUserToDeleteRows = false;
            MDGV.AllowUserToOrderColumns = true;
            MDGV.AllowUserToResizeColumns = false;
            MDGV.AllowUserToResizeRows = false;
            MDGV.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MDGV.DefaultCellStyle = dataGridViewCellStyle2;
            MDGV.GridColor = Color.Blue;
            MDGV.Location = new Point(239, 174);
            MDGV.MultiSelect = false;
            MDGV.Name = "MDGV";
            MDGV.ReadOnly = true;
            MDGV.RowHeadersWidth = 51;
            MDGV.RowTemplate.DividerHeight = 2;
            MDGV.RowTemplate.Height = 29;
            MDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MDGV.Size = new Size(930, 387);
            MDGV.TabIndex = 40;
            MDGV.CellContentClick += MDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(257, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(168, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1196, 691);
            Controls.Add(pictureBox1);
            Controls.Add(MDGV);
            Controls.Add(label10);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TimingCb);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(AmountTb);
            Controls.Add(GenderCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(AgeTb);
            Controls.Add(label5);
            Controls.Add(PhoneTb);
            Controls.Add(label4);
            Controls.Add(NameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update";
            Load += Update_Load;
            ((System.ComponentModel.ISupportInitialize)MDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private ComboBox TimingCb;
        private Label label9;
        private Label label8;
        private TextBox AmountTb;
        private ComboBox GenderCb;
        private Label label7;
        private Label label6;
        private TextBox AgeTb;
        private Label label5;
        private TextBox PhoneTb;
        private Label label4;
        private TextBox NameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label10;
        private DataGridView MDGV;
        private PictureBox pictureBox1;
    }
}