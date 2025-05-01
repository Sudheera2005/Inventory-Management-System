namespace Group_assignment
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            quntityInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            priceInput = new TextBox();
            manuInput = new TextBox();
            warrInput = new TextBox();
            batchInput = new TextBox();
            brandInput = new TextBox();
            dropdown = new ComboBox();
            laptopRam = new Label();
            laptopGpu = new Label();
            laptopScreen = new Label();
            smwatch = new Label();
            laptoRam = new TextBox();
            laptopScreentext = new TextBox();
            laptopGpuytext = new TextBox();
            RamPhone = new TextBox();
            smatwatch = new CheckBox();
            head = new Label();
            headnoice = new Label();
            lphone = new Label();
            lstoragephone = new Label();
            headnoce = new CheckBox();
            storagePhonetext = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 294);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantity";
            // 
            // quntityInput
            // 
            quntityInput.Location = new Point(196, 294);
            quntityInput.Name = "quntityInput";
            quntityInput.Size = new Size(125, 27);
            quntityInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 187);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 3;
            label3.Text = "Manufacturing Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 243);
            label4.Name = "label4";
            label4.Size = new Size(177, 20);
            label4.TabIndex = 4;
            label4.Text = "Warranty Period (Months)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(416, 89);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 5;
            label5.Text = "Batch Number";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 89);
            label6.Name = "label6";
            label6.Size = new Size(48, 20);
            label6.TabIndex = 6;
            label6.Text = "Brand";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(196, 133);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(125, 27);
            priceInput.TabIndex = 7;
            // 
            // manuInput
            // 
            manuInput.Location = new Point(196, 184);
            manuInput.Name = "manuInput";
            manuInput.Size = new Size(125, 27);
            manuInput.TabIndex = 8;
            // 
            // warrInput
            // 
            warrInput.Location = new Point(196, 240);
            warrInput.Name = "warrInput";
            warrInput.Size = new Size(125, 27);
            warrInput.TabIndex = 9;
            // 
            // batchInput
            // 
            batchInput.Location = new Point(555, 82);
            batchInput.Name = "batchInput";
            batchInput.Size = new Size(125, 27);
            batchInput.TabIndex = 10;
            // 
            // brandInput
            // 
            brandInput.Location = new Point(196, 86);
            brandInput.Name = "brandInput";
            brandInput.Size = new Size(125, 27);
            brandInput.TabIndex = 11;
            // 
            // dropdown
            // 
            dropdown.FormattingEnabled = true;
            dropdown.Items.AddRange(new object[] { "Smartphone", "Laptop", "Headphone", "Smartwatch" });
            dropdown.Location = new Point(16, 24);
            dropdown.Name = "dropdown";
            dropdown.Size = new Size(151, 28);
            dropdown.TabIndex = 12;
            dropdown.SelectedIndexChanged += dropdown_SelectedIndexChanged_1;
            // 
            // laptopRam
            // 
            laptopRam.AutoSize = true;
            laptopRam.Location = new Point(416, 133);
            laptopRam.Name = "laptopRam";
            laptopRam.Size = new Size(39, 20);
            laptopRam.TabIndex = 13;
            laptopRam.Text = "Ram";
            // 
            // laptopGpu
            // 
            laptopGpu.AutoSize = true;
            laptopGpu.Location = new Point(416, 184);
            laptopGpu.Name = "laptopGpu";
            laptopGpu.Size = new Size(36, 20);
            laptopGpu.TabIndex = 14;
            laptopGpu.Text = "Gpu";
            // 
            // laptopScreen
            // 
            laptopScreen.AutoSize = true;
            laptopScreen.Location = new Point(416, 240);
            laptopScreen.Name = "laptopScreen";
            laptopScreen.Size = new Size(84, 20);
            laptopScreen.TabIndex = 15;
            laptopScreen.Text = "Screen Size";
            // 
            // smwatch
            // 
            smwatch.AutoSize = true;
            smwatch.Location = new Point(411, 409);
            smwatch.Name = "smwatch";
            smwatch.Size = new Size(121, 20);
            smwatch.TabIndex = 16;
            smwatch.Text = "Water Resistance";
            // 
            // laptoRam
            // 
            laptoRam.Location = new Point(555, 130);
            laptoRam.Name = "laptoRam";
            laptoRam.Size = new Size(125, 27);
            laptoRam.TabIndex = 17;
            // 
            // laptopScreentext
            // 
            laptopScreentext.Location = new Point(556, 236);
            laptopScreentext.Name = "laptopScreentext";
            laptopScreentext.Size = new Size(125, 27);
            laptopScreentext.TabIndex = 19;
            // 
            // laptopGpuytext
            // 
            laptopGpuytext.Location = new Point(555, 181);
            laptopGpuytext.Name = "laptopGpuytext";
            laptopGpuytext.Size = new Size(125, 27);
            laptopGpuytext.TabIndex = 20;
            laptopGpuytext.TextChanged += laptopGpuytext_TextChanged;
            // 
            // RamPhone
            // 
            RamPhone.Location = new Point(558, 317);
            RamPhone.Name = "RamPhone";
            RamPhone.Size = new Size(125, 27);
            RamPhone.TabIndex = 21;
            // 
            // smatwatch
            // 
            smatwatch.AutoSize = true;
            smatwatch.Location = new Point(196, 412);
            smatwatch.Name = "smatwatch";
            smatwatch.Size = new Size(18, 17);
            smatwatch.TabIndex = 22;
            smatwatch.UseVisualStyleBackColor = true;
            // 
            // head
            // 
            head.AutoSize = true;
            head.Location = new Point(16, 409);
            head.Name = "head";
            head.Size = new Size(64, 20);
            head.TabIndex = 23;
            head.Text = "Wireless";
            // 
            // headnoice
            // 
            headnoice.AutoSize = true;
            headnoice.Location = new Point(12, 372);
            headnoice.Name = "headnoice";
            headnoice.Size = new Size(133, 20);
            headnoice.TabIndex = 24;
            headnoice.Text = "Noise Cancellation";
            // 
            // lphone
            // 
            lphone.AutoSize = true;
            lphone.Location = new Point(411, 324);
            lphone.Name = "lphone";
            lphone.Size = new Size(41, 20);
            lphone.TabIndex = 25;
            lphone.Text = "RAM";
            // 
            // lstoragephone
            // 
            lstoragephone.AutoSize = true;
            lstoragephone.Location = new Point(411, 372);
            lstoragephone.Name = "lstoragephone";
            lstoragephone.Size = new Size(61, 20);
            lstoragephone.TabIndex = 26;
            lstoragephone.Text = "Storage";
            // 
            // headnoce
            // 
            headnoce.AutoSize = true;
            headnoce.Location = new Point(196, 382);
            headnoce.Name = "headnoce";
            headnoce.Size = new Size(18, 17);
            headnoce.TabIndex = 27;
            headnoce.UseVisualStyleBackColor = true;
            // 
            // storagePhonetext
            // 
            storagePhonetext.Location = new Point(558, 372);
            storagePhonetext.Name = "storagePhonetext";
            storagePhonetext.Size = new Size(125, 27);
            storagePhonetext.TabIndex = 28;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 438);
            Controls.Add(storagePhonetext);
            Controls.Add(headnoce);
            Controls.Add(lstoragephone);
            Controls.Add(lphone);
            Controls.Add(headnoice);
            Controls.Add(head);
            Controls.Add(smatwatch);
            Controls.Add(RamPhone);
            Controls.Add(laptopGpuytext);
            Controls.Add(laptopScreentext);
            Controls.Add(laptoRam);
            Controls.Add(smwatch);
            Controls.Add(laptopScreen);
            Controls.Add(laptopGpu);
            Controls.Add(laptopRam);
            Controls.Add(dropdown);
            Controls.Add(brandInput);
            Controls.Add(batchInput);
            Controls.Add(warrInput);
            Controls.Add(manuInput);
            Controls.Add(priceInput);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(quntityInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox quntityInput;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox priceInput;
        private TextBox manuInput;
        private TextBox warrInput;
        private TextBox batchInput;
        private TextBox brandInput;
        private ComboBox dropdown;
        private Label laptopRam;
        private Label laptopGpu;
        private Label laptopScreen;
        private Label smwatch;
        private TextBox laptoRam;
        private TextBox laptopScreentext;
        private TextBox laptopGpuytext;
        private TextBox RamPhone;
        private CheckBox smatwatch;
        private Label head;
        private Label headnoice;
        private Label lphone;
        private Label lstoragephone;
        private CheckBox headnoce;
        private TextBox storagePhonetext;
    }
}
