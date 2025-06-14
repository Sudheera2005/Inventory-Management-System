namespace inventory
{
    partial class from3
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
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(88, 200);
            username.Name = "username";
            username.Size = new Size(200, 27);
            username.TabIndex = 0;
            // 
            // password
            // 
            password.Location = new Point(88, 285);
            password.Name = "password";
            password.Size = new Size(200, 27);
            password.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(88, 376);
            button1.Name = "button1";
            button1.Size = new Size(200, 29);
            button1.TabIndex = 2;
            button1.Text = "LogIn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(127, 101);
            label1.Name = "label1";
            label1.Size = new Size(120, 50);
            label1.TabIndex = 3;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(88, 177);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 4;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(88, 262);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // from3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 548);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(username);
            Name = "from3";
            Text = "from3";
            Load += from3_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private TextBox password;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}