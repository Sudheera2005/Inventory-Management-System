namespace inventory
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(69, 119);
            button1.Name = "button1";
            button1.Size = new Size(148, 70);
            button1.TabIndex = 0;
            button1.Text = "Product";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(318, 128);
            button2.Name = "button2";
            button2.Size = new Size(148, 70);
            button2.TabIndex = 1;
            button2.Text = "Suppliers";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(567, 128);
            button3.Name = "button3";
            button3.Size = new Size(148, 70);
            button3.TabIndex = 2;
            button3.Text = "Stock Movements";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(69, 283);
            button4.Name = "button4";
            button4.Size = new Size(148, 70);
            button4.TabIndex = 3;
            button4.Text = "Orders";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(318, 283);
            button5.Name = "button5";
            button5.Size = new Size(148, 70);
            button5.TabIndex = 4;
            button5.Text = "Report ";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(567, 283);
            button6.Name = "button6";
            button6.Size = new Size(148, 70);
            button6.TabIndex = 5;
            button6.Text = "Admin";
            button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(43, 32);
            label1.Name = "label1";
            label1.Size = new Size(709, 62);
            label1.TabIndex = 6;
            label1.Text = "Inventory management system";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label1;
    }
}