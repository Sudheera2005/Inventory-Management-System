namespace inventory
{
    partial class userform
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
            refresh = new Button();
            button2 = new Button();
            lable = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 94);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(722, 188);
            dataGridView1.TabIndex = 0;
            // 
            // refresh
            // 
            refresh.Location = new Point(506, 352);
            refresh.Name = "refresh";
            refresh.Size = new Size(249, 29);
            refresh.TabIndex = 1;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += refresh_Click;
            // 
            // button2
            // 
            button2.Location = new Point(33, 352);
            button2.Name = "button2";
            button2.Size = new Size(249, 29);
            button2.TabIndex = 2;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // lable
            // 
            lable.Location = new Point(33, 33);
            lable.Name = "lable";
            lable.Size = new Size(358, 27);
            lable.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(-2, -4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(10, 27);
            textBox2.TabIndex = 4;
            // 
            // userform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(lable);
            Controls.Add(button2);
            Controls.Add(refresh);
            Controls.Add(dataGridView1);
            Name = "userform";
            Text = "userform";
            Load += userform_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button refresh;
        private Button button2;
        private TextBox lable;
        private TextBox textBox2;
    }
}