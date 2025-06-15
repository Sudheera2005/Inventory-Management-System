using System;
using System.Collections.Generic;
using System.Windows.Forms;
using suppliers___SDAM.Classes;
using suppliers___SDAM.Controller;

namespace suppliers___SDAM.Forms
{
    public partial class AssignSupplierForm : Form
    {
        public AssignSupplierForm()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void LoadSuppliers()
        {
            try
            {
                List<Supplier> suppliers = SupplierController.GetAllSuppliers();
                cbSuppliers.DataSource = suppliers;
                cbSuppliers.DisplayMember = "SupplierName";
                cbSuppliers.ValueMember = "SupplierID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
            }
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtProductId.Text.Trim(), out int productId))
            {
                MessageBox.Show("Invalid Product ID");
                return;
            }

            int supplierId = (int)cbSuppliers.SelectedValue;

            try
            {
                bool success = SupplierController.AssignSupplierToProduct(productId, supplierId);
                if (success)
                {
                    MessageBox.Show("Supplier assigned successfully!");
                    txtProductId.Clear();
                    cbSuppliers.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Failed to assign supplier.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
