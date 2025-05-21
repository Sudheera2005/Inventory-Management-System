namespace Group_assignment
{
    partial class editid
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
            edittxt = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // edittxt
            // 
            edittxt.Location = new Point(173, 106);
            edittxt.Name = "edittxt";
            edittxt.Size = new Size(125, 27);
            edittxt.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(53, 193);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Location = new Point(329, 193);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Edite";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 151);
            label1.Name = "label1";
            label1.Size = new Size(282, 20);
            label1.TabIndex = 3;
            label1.Text = "Enter the Id if the iterm you what to edite";
            // 
            // editid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(489, 263);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(edittxt);
            Name = "editid";
            Text = "editid";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox edittxt;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}