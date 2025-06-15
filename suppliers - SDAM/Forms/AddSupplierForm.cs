using suppliers___SDAM.Classes;
using suppliers___SDAM.Controller;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace suppliers___SDAM.Forms
{
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Supplier name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("Phone number is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(address))
            {
                MessageBox.Show("Address is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var supplier = new Supplier
                {
                    SupplierName = name,
                    Phone = phone,
                    Email = email,
                    Address = address
                };

                bool success = SupplierController.AddSupplier(supplier);

                if (success)
                {
                    MessageBox.Show("Supplier added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Failed to add supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnManageSuppliers_Click(object sender, EventArgs e)
        {
            ManageSupplierForm manageForm = new ManageSupplierForm();
            manageForm.ShowDialog();
        }

        private void btnAssignSupplier_Click(object sender, EventArgs e)
        {
            // For now, a simple prompt to get product ID and supplier ID
            // You can replace this with a proper form or dropdowns for better UX

            string productIdStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Product ID:", "Assign Supplier to Product");
            string supplierIdStr = Microsoft.VisualBasic.Interaction.InputBox("Enter Supplier ID:", "Assign Supplier to Product");

            if (!int.TryParse(productIdStr, out int productId))
            {
                MessageBox.Show("Invalid Product ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(supplierIdStr, out int supplierId))
            {
                MessageBox.Show("Invalid Supplier ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool assigned = SupplierController.AssignSupplierToProduct(productId, supplierId);
                if (assigned)
                {
                    MessageBox.Show("Supplier assigned to product successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to assign supplier to product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning supplier: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
                return false;

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        private void ClearForm()
        {
            txtSupplierName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSupplierName.Focus();
        }
    }
}
