using System;
using System.Collections.Generic;
using System.Windows.Forms;
using suppliers___SDAM.Classes;
using suppliers___SDAM.Controller;

namespace suppliers___SDAM.Forms
{
    public partial class ManageSupplierForm : Form
    {
        public ManageSupplierForm()
        {
            InitializeComponent();
        }

        private void ManageSupplierForm_Load(object sender, EventArgs e)
        {
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            dgvSuppliers.DataSource = null;
            List<Supplier> suppliers = SupplierController.GetAllSuppliers();
            dgvSuppliers.DataSource = suppliers;

            // No need to hide created_at or updated_at since they're not part of Supplier class
            ClearForm();
        }

        private void ClearForm()
        {
            txtSupplierID.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";
            txtAddress.Text = "";
        }

        private void dgvSuppliers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvSuppliers.Rows.Count)
            {
                var selectedRow = dgvSuppliers.Rows[e.RowIndex];

                if (selectedRow.Cells["SupplierID"].Value != null)
                    txtSupplierID.Text = selectedRow.Cells["SupplierID"].Value.ToString();

                if (selectedRow.Cells["SupplierName"].Value != null)
                    txtName.Text = selectedRow.Cells["SupplierName"].Value.ToString();

                txtEmail.Text = selectedRow.Cells["Email"].Value?.ToString() ?? "";
                txtPhone.Text = selectedRow.Cells["Phone"].Value?.ToString() ?? "";
                txtAddress.Text = selectedRow.Cells["Address"].Value?.ToString() ?? "";
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Supplier name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // You can add more validation here (email format, phone format, etc.)
            return true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            if (int.TryParse(txtSupplierID.Text, out int supplierId))
            {
                Supplier supplier = new Supplier
                {
                    SupplierID = supplierId,
                    SupplierName = txtName.Text.Trim(),
                    Email = string.IsNullOrWhiteSpace(txtEmail.Text) ? null : txtEmail.Text.Trim(),
                    Phone = string.IsNullOrWhiteSpace(txtPhone.Text) ? null : txtPhone.Text.Trim(),
                    Address = string.IsNullOrWhiteSpace(txtAddress.Text) ? null : txtAddress.Text.Trim(),
                };

                bool success = SupplierController.UpdateSupplier(supplier);
                if (success)
                {
                    MessageBox.Show("Supplier updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadSuppliers();
                }
                else
                {
                    MessageBox.Show("Failed to update supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSupplierID.Text, out int supplierId))
            {
                var confirmResult = MessageBox.Show("Are you sure to delete this supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    bool success = SupplierController.DeleteSupplier(supplierId);
                    if (success)
                    {
                        MessageBox.Show("Supplier deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadSuppliers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete supplier.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSuppliers();
        }
    }
}
