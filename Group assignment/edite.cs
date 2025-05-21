using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_assignment.Class;

namespace Group_assignment
{
    public partial class edite : Form
    {
        Controller controller;
        private readonly Dictionary<string, object> _originalProduct;
        private readonly string _productId;

        public edite(Dictionary<string, object> product)
        {
            InitializeComponent();
            controller = new Controller(this);
            _originalProduct = product;
            _productId = product["id"].ToString();
            InitializeFormData();
            PopulateFormFields();
        }
        private void InitializeFormData()
        {
            // Initialize dropdown and other controls
            dropdown.Items.AddRange(new[] { "Laptop", "Smartphone", "Smartwatch", "Headphone" });
            dropdown.SelectedItem = _originalProduct["item_type"].ToString();
        }
        private void PopulateFormFields()
        {
            modeltext.Text = _originalProduct["model"].ToString();
            brandInput.Text = _originalProduct["brand"].ToString();
            priceInput.Text = _originalProduct["price"].ToString();
            manuInput.Text = _originalProduct["manufacturing_date"].ToString();
            warrInput.Text = _originalProduct["warranty_period"].ToString();
            quntityInput.Text = _originalProduct["quantity"].ToString();
            batchInput.Text = _originalProduct["batch_number"].ToString();

            // Populate category-specific fields
            switch (dropdown.SelectedItem.ToString())
            {
                case "Laptop":
                    option1.Text = _originalProduct["ram"].ToString();
                    option2.Text = _originalProduct["gpu"].ToString();
                    option3.Text = _originalProduct["screen_size"].ToString();
                    break;
                case "Smartphone":
                    option1.Text = _originalProduct["ram"].ToString();
                    option2.Text = _originalProduct["storage"].ToString();
                    break;
                case "Smartwatch":
                    option4.Checked = Convert.ToBoolean(_originalProduct["water_resistance"]);
                    break;
                case "Headphone":
                    wirelessclik.Checked = Convert.ToBoolean(_originalProduct["wireless"]);
                    option4.Checked = Convert.ToBoolean(_originalProduct["noise_cancellation"]);
                    break;
            }
        }
        private void HideAllSpecialFields()
        {
            // Hide all special fields
            Gpu.Visible = false;
            Ram.Visible = false;
            Screen.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            option1.Visible = false;
            storege.Visible = false;
            option4.Visible = false;
            headnoice.Visible = false;
            wireless.Visible = false;
            wirelessclik.Visible = false;
            smart.Visible = false;
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Always hide all special fields first
            HideAllSpecialFields();
            string selectedItem = dropdown.SelectedItem.ToString();

            switch (selectedItem)
            {
                case "Laptop":
                    Gpu.Visible = true;
                    Ram.Visible = true;
                    Screen.Visible = true;
                    option2.Visible = true;
                    option3.Visible = true;
                    option1.Visible = true;
                    option1.Text = "RAM (GB)";
                    option2.Text = "GPU";
                    option3.Text = "Screen Size";
                    break;

                case "Smartphone":
                    storege.Visible = true;
                    Ram.Visible = true;
                    option1.Visible = true;
                    option2.Visible = true;
                    option1.Text = "RAM (GB)";
                    option2.Text = "Storage (GB)";
                    break;

                case "Smartwatch":
                    option4.Visible = true;
                    smart.Visible = true;

                    break;

                case "Headphone":
                    option4.Visible = true;
                    headnoice.Visible = true;
                    wireless.Visible = true;
                    wirelessclik.Visible = true;

                    break;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var updates = new Dictionary<string, object>();

            // Collect updated values
            AddUpdateIfChanged(updates, "model", modeltext.Text);
            AddUpdateIfChanged(updates, "brand", brandInput.Text);
            AddUpdateIfChanged(updates, "price", priceInput.Text);
            AddUpdateIfChanged(updates, "manufacturing_date", manuInput.Text);
            AddUpdateIfChanged(updates, "warranty_period", warrInput.Text);
            AddUpdateIfChanged(updates, "quantity", quntityInput.Text);
            AddUpdateIfChanged(updates, "batch_number", batchInput.Text);

            // Handle category-specific fields
            switch (dropdown.SelectedItem.ToString())
            {
                case "Laptop":
                    AddUpdateIfChanged(updates, "ram", option1.Text);
                    AddUpdateIfChanged(updates, "gpu", option2.Text);
                    AddUpdateIfChanged(updates, "screen_size", option3.Text);
                    break;
                case "Smartphone":
                    AddUpdateIfChanged(updates, "ram", option1.Text);
                    AddUpdateIfChanged(updates, "storage", option2.Text);
                    break;
                case "Smartwatch":
                    updates["water_resistance"] = option4.Checked;
                    break;
                case "Headphone":
                    updates["wireless"] = wirelessclik.Checked;
                    updates["noise_cancellation"] = option4.Checked;
                    break;
            }

            if (updates.Count == 0)
            {
                MessageBox.Show("No changes detected.");
                return;
            }

            try
            {
                if (controller.UpdateProduct(updates, _productId))
                {
                    MessageBox.Show("Product updated successfully!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update product.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating product: {ex.Message}");
            }
        }

        private void AddUpdateIfChanged(Dictionary<string, object> updates, string field, string newValue)
        {
            if (newValue != _originalProduct[field].ToString())
            {
                updates[field] = newValue;
            }
        }
        
        
    }
}
