using Group_assignment.Class;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Group_assignment
{
    public partial class addItem : Form
    {
        //connection the controller to the addItem form
        Controller controller;
        public addItem()
        {
            InitializeComponent();
            controller = new Controller(this);

            
            // Hide all special fields initially
            HideAllSpecialFields();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HideAllSpecialFields();
            
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

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void laptopGpuytext_TextChanged(object sender, EventArgs e)
        {
            // You can add functionality here if you need to handle text change events
        }

        private void dropdown_SelectedIndexChanged_1(object sender, EventArgs e)
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
            if (dropdown.SelectedItem == null)
            {
                MessageBox.Show("Please select an item type first.");
                return;
            }

            try
            {
                string selectedItem = dropdown.SelectedItem.ToString();
                string model = modeltext.Text;
                string brand = brandInput.Text;
                double price = double.Parse(priceInput.Text);
                string manufacturingDate = manuInput.Text;
                int warrantyPeriod = int.Parse(warrInput.Text);
                int quantity = int.Parse(quntityInput.Text);
                string batchNumber = batchInput.Text;

                bool success = false;

                switch (selectedItem)
                {
                    case "Laptop":
                        string ram = option1.Text;
                        string gpu = option2.Text;
                        string screenSize = option3.Text;
                        success = controller.AddLaptop(
                            model, ram, gpu, screenSize, "Laptop",
                            quantity, price, manufacturingDate,
                            warrantyPeriod, batchNumber, brand
                        );
                        break;

                    case "Smartphone":
                        string phoneRam = option1.Text;
                        string storage = option2.Text;
                        success = controller.AddSmartphone(
                            model, phoneRam, storage, "Smartphone",
                            quantity, price, manufacturingDate,
                            warrantyPeriod, batchNumber, brand
                        );
                        break;

                    case "Smartwatch":
                        bool waterResistant = option4.Checked;
                        success = controller.AddSmartWatch(
                            model,
                            waterResistant,
                            "Smartwatch",
                            quantity, price, manufacturingDate,
                            warrantyPeriod, batchNumber, brand
                        );
                        break;

                    case "Headphone":
                        bool wireless = wirelessclik.Checked;
                        bool noiseCancellation = option4.Checked;
                        success = controller.AddHeadphones(
                            model, wireless, noiseCancellation, "Headphone",
                            quantity, price, manufacturingDate,
                            warrantyPeriod, batchNumber, brand
                        );
                        break;
                }

                if (success)
                {
                    MessageBox.Show($"{selectedItem} added successfully!");
                    ClearForm();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers for quantity, price, and warranty period.");
            }
            catch (Exception ex)
            {
               
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
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


        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
