namespace suppliers___SDAM.Forms
{
    partial class AssignSupplierForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblProductId;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.ComboBox cbSuppliers;
        private System.Windows.Forms.Button btnAssign;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblProductId = new System.Windows.Forms.Label();
            lblSupplier = new System.Windows.Forms.Label();
            txtProductId = new System.Windows.Forms.TextBox();
            cbSuppliers = new System.Windows.Forms.ComboBox();
            btnAssign = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new System.Drawing.Point(40, 40);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new System.Drawing.Size(80, 20);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product ID:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new System.Drawing.Point(150, 37);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new System.Drawing.Size(200, 27);
            txtProductId.TabIndex = 1;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new System.Drawing.Point(40, 85);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new System.Drawing.Size(105, 20);
            lblSupplier.TabIndex = 2;
            lblSupplier.Text = "Select Supplier:";
            // 
            // cbSuppliers
            // 
            cbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbSuppliers.Location = new System.Drawing.Point(150, 82);
            cbSuppliers.Name = "cbSuppliers";
            cbSuppliers.Size = new System.Drawing.Size(200, 28);
            cbSuppliers.TabIndex = 3;
            // 
            // btnAssign
            // 
            btnAssign.Location = new System.Drawing.Point(150, 130);
            btnAssign.Name = "btnAssign";
            btnAssign.Size = new System.Drawing.Size(150, 35);
            btnAssign.TabIndex = 4;
            btnAssign.Text = "Assign Supplier";
            btnAssign.UseVisualStyleBackColor = true;
            btnAssign.Click += new System.EventHandler(btnAssign_Click);
            // 
            // AssignSupplierForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(420, 200);
            Controls.Add(lblProductId);
            Controls.Add(txtProductId);
            Controls.Add(lblSupplier);
            Controls.Add(cbSuppliers);
            Controls.Add(btnAssign);
            Name = "AssignSupplierForm";
            Text = "Assign Supplier to Product";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
