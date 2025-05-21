namespace Group_assignment
{
    partial class remove
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
            idTxt = new TextBox();
            label1 = new Label();
            delete = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // idTxt
            // 
            idTxt.Location = new Point(230, 118);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(125, 27);
            idTxt.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 180);
            label1.Name = "label1";
            label1.Size = new Size(273, 20);
            label1.TabIndex = 1;
            label1.Text = "Enter the id of item you what to remove";
            label1.Click += label1_Click;
            // 
            // delete
            // 
            delete.BackColor = Color.Red;
            delete.Location = new Point(397, 239);
            delete.Name = "delete";
            delete.Size = new Size(94, 29);
            delete.TabIndex = 2;
            delete.Text = "Delete";
            delete.UseVisualStyleBackColor = false;
            delete.Click += delete_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(103, 239);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Quit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // remove
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 293);
            Controls.Add(button1);
            Controls.Add(delete);
            Controls.Add(label1);
            Controls.Add(idTxt);
            Name = "remove";
            Text = "remove";
            Load += remove_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTxt;
        private Label label1;
        private Button delete;
        private Button button1;
    }
}