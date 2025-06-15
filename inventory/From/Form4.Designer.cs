namespace Stocks
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        public void AddStock(string name, int qty, double price)
        {
            this.NameTbl.Items.Add(name);
            this.QtyTbl.Items.Add(qty);
            this.CostTbl.Items.Add(price);
        }

        public int getIndex(string name)
        {
            return this.NameTbl.Items.IndexOf(name);
        }
        public void UpdateStock(string name, int qty, double price)
        {
            int index = this.NameTbl.Items.IndexOf(name);
            this.NameTbl.Items[index] = name;
            this.QtyTbl.Items[index] = qty;
            this.CostTbl.Items[index] = price;
        }

        public void AddToAlert(string name)
        {
            int index = this.LowStockList.Items.IndexOf(name);
            if (index != -1)
            {
                return;
            }
            this.LowStockList.Items.Add(name);
        }
        public void RemoveAlert(string name)
        {
            int index = this.LowStockList.Items.IndexOf(name);
            if (index == -1)
            {
                return;
            }
            this.LowStockList.Items.RemoveAt(index);
        }
        public void RemoveStock(string name)
        {
            int index = this.NameTbl.Items.IndexOf(name);
            if (index == -1)
            {
                return;
            }
            this.NameTbl.Items.RemoveAt(index);
            this.CostTbl.Items.RemoveAt(index);
            this.QtyTbl.Items.RemoveAt(index);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            AddStockBtn = new Button();
            NameLabel = new TextBox();
            NameTbl = new ListBox();
            QtyTbl = new ListBox();
            CostTbl = new ListBox();
            LowStockList = new ListBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(137, 89);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 0;
            label1.Text = "Stocks";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(472, 98);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 1;
            label2.Text = "Alerts";
            // 
            // AddStockBtn
            // 
            AddStockBtn.Location = new Point(156, 12);
            AddStockBtn.Name = "AddStockBtn";
            AddStockBtn.Size = new Size(109, 48);
            AddStockBtn.TabIndex = 2;
            AddStockBtn.Text = "Add Stock";
            AddStockBtn.UseVisualStyleBackColor = true;
            AddStockBtn.Click += AddStockBtn_Click;
            // 
            // NameLabel
            // 
            NameLabel.Location = new Point(12, 26);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(125, 23);
            NameLabel.TabIndex = 3;
            // 
            // NameTbl
            // 
            NameTbl.FormattingEnabled = true;
            NameTbl.ItemHeight = 15;
            NameTbl.Location = new Point(2, 131);
            NameTbl.Name = "NameTbl";
            NameTbl.Size = new Size(98, 289);
            NameTbl.TabIndex = 4;
            // 
            // QtyTbl
            // 
            QtyTbl.FormattingEnabled = true;
            QtyTbl.ItemHeight = 15;
            QtyTbl.Location = new Point(106, 131);
            QtyTbl.Name = "QtyTbl";
            QtyTbl.Size = new Size(98, 289);
            QtyTbl.TabIndex = 5;
            // 
            // CostTbl
            // 
            CostTbl.FormattingEnabled = true;
            CostTbl.ItemHeight = 15;
            CostTbl.Location = new Point(210, 131);
            CostTbl.Name = "CostTbl";
            CostTbl.Size = new Size(98, 289);
            CostTbl.TabIndex = 6;
            // 
            // LowStockList
            // 
            LowStockList.FormattingEnabled = true;
            LowStockList.ItemHeight = 15;
            LowStockList.Location = new Point(400, 127);
            LowStockList.Name = "LowStockList";
            LowStockList.Size = new Size(172, 274);
            LowStockList.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(234, 113);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 9;
            label4.Text = "Cost";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(137, 113);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.Yes;
            label5.Size = new Size(53, 15);
            label5.TabIndex = 10;
            label5.Text = "Quantity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 113);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.Yes;
            label6.Size = new Size(39, 15);
            label6.TabIndex = 11;
            label6.Text = "Name";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(LowStockList);
            Controls.Add(CostTbl);
            Controls.Add(QtyTbl);
            Controls.Add(NameTbl);
            Controls.Add(NameLabel);
            Controls.Add(AddStockBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button AddStockBtn;
        private TextBox NameLabel;
        private ListBox NameTbl;
        private ListBox QtyTbl;
        private ListBox CostTbl;
        private ListBox LowStockList;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}
