namespace suppliers___SDAM.Forms
{
    partial class AddSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnManageSuppliers;
        private System.Windows.Forms.Button btnAssignSupplier;  // new button

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSupplierName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            txtSupplierName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            btnSubmit = new Button();
            btnManageSuppliers = new Button();
            btnAssignSupplier = new Button();
            SuspendLayout();
            // 
            // lblSupplierName
            // 
            lblSupplierName.AutoSize = true;
            lblSupplierName.Location = new Point(101, 90);
            lblSupplierName.Name = "lblSupplierName";
            lblSupplierName.Size = new Size(111, 20);
            lblSupplierName.TabIndex = 0;
            lblSupplierName.Text = "Supplier Name:";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(101, 135);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(53, 20);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(101, 180);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(101, 225);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address:";
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(255, 83);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(200, 27);
            txtSupplierName.TabIndex = 4;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(255, 128);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(200, 27);
            txtPhone.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(255, 173);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(200, 27);
            txtEmail.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(255, 218);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(200, 27);
            txtAddress.TabIndex = 7;
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(255, 261);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 30);
            btnSubmit.TabIndex = 8;
            btnSubmit.Text = "Add Supplier";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnManageSuppliers
            // 
            btnManageSuppliers.Location = new Point(365, 261);
            btnManageSuppliers.Name = "btnManageSuppliers";
            btnManageSuppliers.Size = new Size(140, 30);
            btnManageSuppliers.TabIndex = 9;
            btnManageSuppliers.Text = "Manage Suppliers";
            btnManageSuppliers.UseVisualStyleBackColor = true;
            btnManageSuppliers.Click += btnManageSuppliers_Click;
            // 
            // btnAssignSupplier
            // 
            btnAssignSupplier.Location = new Point(255, 307);
            btnAssignSupplier.Name = "btnAssignSupplier";
            btnAssignSupplier.Size = new Size(250, 30);
            btnAssignSupplier.TabIndex = 10;
            btnAssignSupplier.Text = "Assign Supplier to Product";
            btnAssignSupplier.UseVisualStyleBackColor = true;
            btnAssignSupplier.Click += btnAssignSupplier_Click;
            // 
            // AddSupplierForm
            // 
            ClientSize = new Size(686, 370);
            Controls.Add(btnAssignSupplier);
            Controls.Add(btnManageSuppliers);
            Controls.Add(btnSubmit);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtSupplierName);
            Controls.Add(lblAddress);
            Controls.Add(lblEmail);
            Controls.Add(lblPhone);
            Controls.Add(lblSupplierName);
            Name = "AddSupplierForm";
            Text = "Add Supplier";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
