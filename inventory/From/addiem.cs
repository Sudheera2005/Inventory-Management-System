using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory.Controllers;
using inventory.Class;
using System.Runtime.Intrinsics.Arm;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory
{
    public partial class addiem : Form
    {
        controller controller;
        private ErrorProvider errorProvider; // Add this field to define the ErrorProvider

        public addiem()
        {
            InitializeComponent();
            controller = new controller(this);
            dropdown.Items.AddRange(new object[] { "Laptop", "Smartphone", "Smartwatch", "Headphone" });
            HideAllSpecialFields(); // Hide all special fields initially

            errorProvider = new ErrorProvider(); // Initialize the ErrorProvider
        }

        // Hide all special fields initially
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

        private void addiem_Load(object sender, EventArgs e)
        {

        }

        private void SelectedItem_SelectedIndexChanged(object sender, EventArgs e)
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
            if (!ValidateInputs()) return;

            try
            {
                bool success = false;
                string selectedItem = dropdown.SelectedItem.ToString();

                switch (selectedItem)
                {
                    case "Laptop":
                        success = AddLaptopItem();
                        break;

                    case "Smartphone":
                        success = AddSmartphoneItem();
                        break;

                    case "Smartwatch":
                        success = AddSmartWatchItem();
                        break;

                    case "Headphone":
                        success = AddHeadphonesItem();
                        break;
                }

                if (success)
                {
                    MessageBox.Show($"{selectedItem} added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for quantity, price, and warranty period.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInputs()
        {
            // Clear previous errors
            errorProvider.Clear();

            if (dropdown.SelectedItem == null)
            {
                MessageBox.Show("Please select an item type first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate required fields
            if (string.IsNullOrWhiteSpace(modeltext.Text) ||
                string.IsNullOrWhiteSpace(brandInput.Text) ||
                string.IsNullOrWhiteSpace(priceInput.Text) ||
                string.IsNullOrWhiteSpace(manuInput.Text) ||
                string.IsNullOrWhiteSpace(warrInput.Text) ||
                string.IsNullOrWhiteSpace(quntityInput.Text) ||
                string.IsNullOrWhiteSpace(batchInput.Text) ||
                string.IsNullOrWhiteSpace(idinput.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Validate manufacturing year
            if (!int.TryParse(manuInput.Text, out int year) || manuInput.Text.Length != 4)
            {
                errorProvider.SetError(manuInput, "Please enter a valid 4-digit year.");
                return false;
            }

            if (year < 1900 || year > DateTime.Now.Year + 1)
            {
                errorProvider.SetError(manuInput, $"Year must be between 1900 and {DateTime.Now.Year + 1}");
                return false;
            }

            // Validate warranty
            if (!int.TryParse(warrInput.Text, out int warranty) || warranty < 0)
            {
                errorProvider.SetError(warrInput, "Please enter a positive number.");
                return false;
            }

            if (warranty > 32)
            {
                errorProvider.SetError(warrInput, "Warranty cannot exceed 3 years (36 months)");
                return false;
            }

            // Validate batch number
            if (batchInput.Text.Length != 3 || !int.TryParse(batchInput.Text, out _))
            {
                errorProvider.SetError(batchInput, "Batch must be exactly 3 digits.");
                return false;
            }

            // Validate ID
            if (idinput.Text.Length != 3 || !int.TryParse(idinput.Text, out _))
            {
                errorProvider.SetError(idinput, "ID must be exactly 3 digits.");
                return false;
            }

            // Validate price
            if (!double.TryParse(priceInput.Text, out double price) || price <= 0)
            {
                errorProvider.SetError(priceInput, "Please enter a valid positive price.");
                return false;
            }

            // Validate quantity
            if (!int.TryParse(quntityInput.Text, out int quantity) || quantity <= 0)
            {
                errorProvider.SetError(quntityInput, "Please enter a valid positive quantity.");
                return false;
            }

            return true;
        }

        private bool AddLaptopItem()
        {
            var laptop = new Laptop(
                model: modeltext.Text,
                ram: option1.Text,
                gpu: option2.Text,
                screenSize: option3.Text,
                itemType: "Laptop",
                quantity: int.Parse(quntityInput.Text),
                price: double.Parse(priceInput.Text),
                manufacturingDate: manuInput.Text,
                warrantyPeriodInMonths: int.Parse(warrInput.Text),
                batchNumber: batchInput.Text,
                brand: brandInput.Text
            );
            return controller.AddLaptop(laptop);
        }

        private bool AddSmartphoneItem()
        {
            var smartphone = new Smartphone(
                model: modeltext.Text,
                ram: option1.Text,
                storage: option2.Text,
                itemType: "Smartphone",
                quantity: int.Parse(quntityInput.Text),
                price: double.Parse(priceInput.Text),
                manufacturingDate: manuInput.Text,
                warrantyPeriodInMonths: int.Parse(warrInput.Text),
                batchNumber: batchInput.Text,
                brand: brandInput.Text
            );
            return controller.AddSmartphone(smartphone);
        }

        private bool AddSmartWatchItem()
        {
            var smartWatch = new Smart__Watch(
                model: modeltext.Text,
                waterResistance: option4.Checked,
                itemType: "Smartwatch",
                quantity: int.Parse(quntityInput.Text),
                price: double.Parse(priceInput.Text),
                manufacturingDate: manuInput.Text,
                warrantyPeriodInMonths: int.Parse(warrInput.Text),
                batchNumber: batchInput.Text,
                brand: brandInput.Text
            );
            return controller.AddSmartWatch(smartWatch);
        }

        private bool AddHeadphonesItem()
        {
            var headphones = new Headphones(
                model: modeltext.Text,
                wireless: wirelessclik.Checked,
                noiseCancellation: option4.Checked,
                itemType: "Headphone",
                quantity: int.Parse(quntityInput.Text),
                price: double.Parse(priceInput.Text),
                manufacturingDate: manuInput.Text,
                warrantyPeriodInMonths: int.Parse(warrInput.Text),
                batchNumber: batchInput.Text,
                brand: brandInput.Text
            );
            return controller.AddHeadphones(headphones);
        }

        // Remove the duplicate ClearForm method to resolve the CS0111 error.  
        // The second ClearForm method is redundant and can be safely removed.  

        private void ClearForm()
        {
            try
            {
                // Clear all input fields  
                if (modeltext != null) modeltext.Text = "";
                if (brandInput != null) brandInput.Text = "";
                if (priceInput != null) priceInput.Text = "";
                if (manuInput != null) manuInput.Text = "";
                if (warrInput != null) warrInput.Text = "";
                if (quntityInput != null) quntityInput.Text = "";
                if (batchInput != null) batchInput.Text = "";

                // Clear option fields if they exist  
                if (option1 != null) option1.Text = "";
                if (option2 != null) option2.Text = "";
                if (option3 != null) option3.Text = "";

                // Reset checkboxes if they exist  
                if (option4 != null) option4.Checked = false;
                if (wirelessclik != null) wirelessclik.Checked = false;

                // Reset dropdown if it exists  
                if (dropdown != null) dropdown.SelectedIndex = -1;

                // Hide all special fields  
                HideAllSpecialFields();
            }
            catch (Exception ex)
            {
                // Log or display the error without causing another exception  
                Debug.WriteLine("Error clearing form: " + ex.Message);
            }
        }

        

        private void manuInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Warranty_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
