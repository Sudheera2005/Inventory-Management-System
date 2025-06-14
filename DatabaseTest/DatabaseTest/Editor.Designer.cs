using System.Runtime.CompilerServices;

namespace Stocks
{
    partial class Editor
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

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            StockController.Save(this.Title.Text, this.qtyLabel.Text, this.costLabel.Text);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            StockController.Delete(this.Title.Text);
            this.Close();
        }

        public void changeTitle(string value)
        {
            this.Title.Text = value;
        }

        public void setPrice(double value)
        {
            this.costLabel.Text = Convert.ToString(value);
        }
        public void setQty(int value)
        {
            this.qtyLabel.Text = Convert.ToString(value);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            qtyLabel = new TextBox();
            costLabel = new TextBox();
            SaveBtn = new Button();
            CancelBtn = new Button();
            e = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(145, 24);
            Title.Name = "Title";
            Title.Size = new Size(38, 15);
            Title.TabIndex = 0;
            Title.Text = "label1";
            // 
            // qtyLabel
            // 
            qtyLabel.Location = new Point(98, 68);
            qtyLabel.Name = "qtyLabel";
            qtyLabel.Size = new Size(128, 23);
            qtyLabel.TabIndex = 1;
            // 
            // costLabel
            // 
            costLabel.Location = new Point(98, 110);
            costLabel.Name = "costLabel";
            costLabel.Size = new Size(128, 23);
            costLabel.TabIndex = 2;
            // 
            // SaveBtn
            // 
            SaveBtn.Location = new Point(188, 176);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(113, 52);
            SaveBtn.TabIndex = 3;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click_1;
            // 
            // CancelBtn
            // 
            CancelBtn.Location = new Point(69, 176);
            CancelBtn.Name = "CancelBtn";
            CancelBtn.Size = new Size(113, 52);
            CancelBtn.TabIndex = 4;
            CancelBtn.Text = "Cancel";
            CancelBtn.UseVisualStyleBackColor = true;
            CancelBtn.Click += CancelBtn_Click_1;
            // 
            // e
            // 
            e.AutoSize = true;
            e.Location = new Point(41, 71);
            e.Name = "e";
            e.Size = new Size(51, 15);
            e.TabIndex = 5;
            e.Text = "quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 113);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 6;
            label1.Text = "cost";
            // 
            // Editor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 285);
            Controls.Add(label1);
            Controls.Add(e);
            Controls.Add(CancelBtn);
            Controls.Add(SaveBtn);
            Controls.Add(costLabel);
            Controls.Add(qtyLabel);
            Controls.Add(Title);
            Name = "Editor";
            Text = "Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private TextBox qtyLabel;
        private TextBox costLabel;
        private Button SaveBtn;
        private Button CancelBtn;
        private Label e;
        private Label label1;
    }
}