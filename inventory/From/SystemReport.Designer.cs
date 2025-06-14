namespace inventory
{
    partial class SystemReport
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
            lblUserCount = new TextBox();
            dataGridView2 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(425, 276);
            dataGridView1.TabIndex = 0;
            // 
            // refresh
            // 
            refresh.Location = new Point(620, 391);
            refresh.Name = "refresh";
            refresh.Size = new Size(94, 29);
            refresh.TabIndex = 1;
            refresh.Text = "Refresh";
            refresh.UseVisualStyleBackColor = true;
            refresh.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(73, 378);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            // 
            // lblUserCount
            // 
            lblUserCount.Location = new Point(64, 19);
            lblUserCount.Name = "lblUserCount";
            lblUserCount.Size = new Size(341, 27);
            lblUserCount.TabIndex = 3;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(443, 65);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(171, 276);
            dataGridView2.TabIndex = 4;
            // 
            // SystemReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView2);
            Controls.Add(lblUserCount);
            Controls.Add(button2);
            Controls.Add(refresh);
            Controls.Add(dataGridView1);
            Name = "SystemReport";
            Text = "SystemReport";
            Load += SystemReport_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button refresh;
        private Button button2;
        private TextBox lblUserCount;
        private DataGridView dataGridView2;
    }
}