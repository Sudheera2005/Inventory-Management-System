namespace inventory
{
    partial class addiem
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
            dropdown = new ComboBox();
            modeltext = new TextBox();
            label1 = new Label();
            label2 = new Label();
            batchInput = new TextBox();
            Brand = new Label();
            brandInput = new TextBox();
            label4 = new Label();
            priceInput = new TextBox();
            label5 = new Label();
            manuInput = new TextBox();
            Warranty = new Label();
            warrInput = new TextBox();
            label7 = new Label();
            quntityInput = new TextBox();
            ID = new Label();
            idinput = new TextBox();
            Gpu = new Label();
            option2 = new TextBox();
            Ram = new Label();
            option1 = new TextBox();
            Screen = new Label();
            option3 = new TextBox();
            storege = new Label();
            smart = new Label();
            wireless = new Label();
            headnoice = new Label();
            option4 = new CheckBox();
            wirelessclik = new CheckBox();
            Add = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // dropdown
            // 
            dropdown.FormattingEnabled = true;
            dropdown.Location = new Point(34, 44);
            dropdown.Name = "dropdown";
            dropdown.Size = new Size(151, 28);
            dropdown.TabIndex = 0;
            dropdown.SelectedIndexChanged += SelectedItem_SelectedIndexChanged;
            // 
            // modeltext
            // 
            modeltext.Location = new Point(173, 105);
            modeltext.Name = "modeltext";
            modeltext.Size = new Size(125, 27);
            modeltext.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 112);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 2;
            label1.Text = "Model";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(409, 115);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 4;
            label2.Text = "Batch Number";
            // 
            // batchInput
            // 
            batchInput.Location = new Point(572, 112);
            batchInput.Name = "batchInput";
            batchInput.Size = new Size(125, 27);
            batchInput.TabIndex = 3;
            // 
            // Brand
            // 
            Brand.AutoSize = true;
            Brand.Location = new Point(34, 191);
            Brand.Name = "Brand";
            Brand.Size = new Size(48, 20);
            Brand.TabIndex = 6;
            Brand.Text = "Brand";
            // 
            // brandInput
            // 
            brandInput.Location = new Point(173, 191);
            brandInput.Name = "brandInput";
            brandInput.Size = new Size(125, 27);
            brandInput.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 244);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // priceInput
            // 
            priceInput.Location = new Point(173, 241);
            priceInput.Name = "priceInput";
            priceInput.Size = new Size(125, 27);
            priceInput.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 297);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 10;
            label5.Text = "Manufacturing Year";
            // 
            // manuInput
            // 
            manuInput.Location = new Point(173, 290);
            manuInput.Name = "manuInput";
            manuInput.Size = new Size(125, 27);
            manuInput.TabIndex = 9;
            manuInput.TextChanged += manuInput_TextChanged;
            // 
            // Warranty
            // 
            Warranty.AutoSize = true;
            Warranty.Location = new Point(34, 352);
            Warranty.Name = "Warranty";
            Warranty.Size = new Size(114, 20);
            Warranty.TabIndex = 12;
            Warranty.Text = "Warranty Period";
            Warranty.Click += Warranty_Click;
            // 
            // warrInput
            // 
            warrInput.Location = new Point(173, 345);
            warrInput.Name = "warrInput";
            warrInput.Size = new Size(125, 27);
            warrInput.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(448, 161);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 14;
            label7.Text = "Quantity";
            // 
            // quntityInput
            // 
            quntityInput.Location = new Point(572, 154);
            quntityInput.Name = "quntityInput";
            quntityInput.Size = new Size(125, 27);
            quntityInput.TabIndex = 13;
            // 
            // ID
            // 
            ID.AutoSize = true;
            ID.Location = new Point(34, 158);
            ID.Name = "ID";
            ID.Size = new Size(24, 20);
            ID.TabIndex = 16;
            ID.Text = "ID";
            // 
            // idinput
            // 
            idinput.Location = new Point(173, 151);
            idinput.Name = "idinput";
            idinput.Size = new Size(125, 27);
            idinput.TabIndex = 15;
            // 
            // Gpu
            // 
            Gpu.AutoSize = true;
            Gpu.Location = new Point(409, 251);
            Gpu.Name = "Gpu";
            Gpu.Size = new Size(37, 20);
            Gpu.TabIndex = 18;
            Gpu.Text = "GPU";
            // 
            // option2
            // 
            option2.Location = new Point(572, 244);
            option2.Name = "option2";
            option2.Size = new Size(125, 27);
            option2.TabIndex = 17;
            // 
            // Ram
            // 
            Ram.AutoSize = true;
            Ram.Location = new Point(450, 201);
            Ram.Name = "Ram";
            Ram.Size = new Size(41, 20);
            Ram.TabIndex = 20;
            Ram.Text = "RAM";
            // 
            // option1
            // 
            option1.Location = new Point(572, 194);
            option1.Name = "option1";
            option1.Size = new Size(125, 27);
            option1.TabIndex = 19;
            // 
            // Screen
            // 
            Screen.AutoSize = true;
            Screen.Location = new Point(409, 293);
            Screen.Name = "Screen";
            Screen.Size = new Size(84, 20);
            Screen.TabIndex = 22;
            Screen.Text = "Screen Size";
            // 
            // option3
            // 
            option3.Location = new Point(572, 286);
            option3.Name = "option3";
            option3.Size = new Size(125, 27);
            option3.TabIndex = 21;
            // 
            // storege
            // 
            storege.AutoSize = true;
            storege.Location = new Point(404, 251);
            storege.Name = "storege";
            storege.Size = new Size(94, 20);
            storege.TabIndex = 23;
            storege.Text = "Storege (GB)";
            // 
            // smart
            // 
            smart.AutoSize = true;
            smart.Location = new Point(404, 197);
            smart.Name = "smart";
            smart.Size = new Size(111, 20);
            smart.TabIndex = 24;
            smart.Text = "Water Resistant";
            // 
            // wireless
            // 
            wireless.AutoSize = true;
            wireless.Location = new Point(409, 254);
            wireless.Name = "wireless";
            wireless.Size = new Size(64, 20);
            wireless.TabIndex = 25;
            wireless.Text = "Wireless";
            // 
            // headnoice
            // 
            headnoice.AutoSize = true;
            headnoice.Location = new Point(409, 197);
            headnoice.Name = "headnoice";
            headnoice.Size = new Size(133, 20);
            headnoice.TabIndex = 26;
            headnoice.Text = "Noise Cancellation";
            // 
            // option4
            // 
            option4.AutoSize = true;
            option4.Location = new Point(572, 201);
            option4.Name = "option4";
            option4.Size = new Size(18, 17);
            option4.TabIndex = 27;
            option4.UseVisualStyleBackColor = true;
            // 
            // wirelessclik
            // 
            wirelessclik.AutoSize = true;
            wirelessclik.Location = new Point(572, 254);
            wirelessclik.Name = "wirelessclik";
            wirelessclik.Size = new Size(18, 17);
            wirelessclik.TabIndex = 28;
            wirelessclik.UseVisualStyleBackColor = true;
            // 
            // Add
            // 
            Add.Location = new Point(473, 399);
            Add.Name = "Add";
            Add.Size = new Size(224, 39);
            Add.TabIndex = 29;
            Add.Text = "ADD";
            Add.UseVisualStyleBackColor = true;
            Add.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(10, 10);
            button1.TabIndex = 30;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(190, 406);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 31;
            button2.Text = "Quit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // addiem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 477);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Add);
            Controls.Add(wirelessclik);
            Controls.Add(option4);
            Controls.Add(headnoice);
            Controls.Add(wireless);
            Controls.Add(smart);
            Controls.Add(storege);
            Controls.Add(Screen);
            Controls.Add(option3);
            Controls.Add(Ram);
            Controls.Add(option1);
            Controls.Add(Gpu);
            Controls.Add(option2);
            Controls.Add(ID);
            Controls.Add(idinput);
            Controls.Add(label7);
            Controls.Add(quntityInput);
            Controls.Add(Warranty);
            Controls.Add(warrInput);
            Controls.Add(label5);
            Controls.Add(manuInput);
            Controls.Add(label4);
            Controls.Add(priceInput);
            Controls.Add(Brand);
            Controls.Add(brandInput);
            Controls.Add(label2);
            Controls.Add(batchInput);
            Controls.Add(label1);
            Controls.Add(modeltext);
            Controls.Add(dropdown);
            Name = "addiem";
            Text = "addiem";
            Load += addiem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox dropdown;
        private TextBox modeltext;
        private Label label1;
        private Label label2;
        private TextBox batchInput;
        private Label Brand;
        private TextBox brandInput;
        private Label label4;
        private TextBox priceInput;
        private Label label5;
        private TextBox manuInput;
        private Label Warranty;
        private TextBox warrInput;
        private Label label7;
        private TextBox quntityInput;
        private Label ID;
        private TextBox idinput;
        private Label Gpu;
        private TextBox option2;
        private Label Ram;
        private TextBox option1;
        private Label Screen;
        private TextBox option3;
        private Label storege;
        private Label smart;
        private Label wireless;
        private Label headnoice;
        private CheckBox option4;
        private CheckBox wirelessclik;
        private Button Add;
        private Button button1;
        private Button button2;
    }
}