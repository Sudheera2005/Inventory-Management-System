namespace Group_assignment
{
    partial class item
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
<<<<<<< HEAD
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            comboBox1 = new ComboBox();
            button4 = new Button();
            lblStatus = new TextBox();
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 109);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(754, 188);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
<<<<<<< HEAD
            button1.Location = new Point(34, 370);
=======
            button1.Location = new Point(58, 321);
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            button1.Name = "button1";
            button1.Size = new Size(180, 45);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Cyan;
<<<<<<< HEAD
            button2.Location = new Point(323, 370);
=======
            button2.Location = new Point(330, 321);
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            button2.Name = "button2";
            button2.Size = new Size(180, 45);
            button2.TabIndex = 2;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
<<<<<<< HEAD
            button3.Location = new Point(591, 370);
=======
            button3.Location = new Point(590, 321);
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            button3.Name = "button3";
            button3.Size = new Size(180, 45);
            button3.TabIndex = 3;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
<<<<<<< HEAD
            label1.Location = new Point(381, 18);
=======
            label1.Location = new Point(367, 51);
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 4;
            label1.Text = "Products";
            // 
<<<<<<< HEAD
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(34, 51);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button4
            // 
            button4.Location = new Point(677, 312);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 6;
            button4.Text = "Refresh";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(217, 52);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(571, 27);
            lblStatus.TabIndex = 7;
            // 
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            // item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
<<<<<<< HEAD
            Controls.Add(lblStatus);
            Controls.Add(button4);
            Controls.Add(comboBox1);
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "item";
            Text = "item";
            Load += item_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
<<<<<<< HEAD
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private ComboBox comboBox1;
        private Button button4;
        private TextBox lblStatus;
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
    }
}