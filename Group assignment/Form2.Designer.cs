namespace Group_assignment
{
    partial class Form2
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
            panel1 = new Panel();
            productsbutton = new Button();
            panel3 = new Panel();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(productsbutton);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 772);
            panel1.TabIndex = 0;
            // 
            // productsbutton
            // 
            productsbutton.Location = new Point(3, 177);
            productsbutton.Name = "productsbutton";
            productsbutton.Size = new Size(239, 55);
            productsbutton.TabIndex = 0;
            productsbutton.Text = "Products";
            productsbutton.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(button1);
            panel3.Controls.Add(dataGridView1);
            panel3.Location = new Point(249, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(1242, 641);
            panel3.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(835, 638);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(45, 355);
            button1.Name = "button1";
            button1.Size = new Size(262, 52);
            button1.TabIndex = 1;
            button1.Text = "Add Iterm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1488, 767);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button productsbutton;
        private Panel panel3;
        private Button button1;
        private DataGridView dataGridView1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}