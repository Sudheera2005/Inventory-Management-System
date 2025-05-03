using Group_assignment.Class;

namespace Group_assignment
{
    public partial class Form1 : Form
    {
        controller controller;
        public Form1()
        {
            InitializeComponent();
            controller = new controller(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Hide all special fields first when the form loads
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
            string selectedItem = dropdown.SelectedItem.ToString();
            if (dropdown.SelectedItem != null)
            {
                //string selectedItem = dropdown.SelectedItem.ToString();

                if (selectedItem == "Laptop")
                {
                    // Show Laptop-specific fields
                    Gpu.Visible = true;
                    Ram.Visible = true;
                    Screen.Visible = true;
                    option2.Visible = true;
                    option3.Visible = true;
                    option1.Visible = true;

                }
                else if (selectedItem == "Smartphone")
                {
                    storege.Visible = true;
                    Ram.Visible = true;
                    option1.Visible = true;
                    option2.Visible = true;
                    // You can make phone-specific fields visible here
                }
                else if (selectedItem == "Smartwatch")
                {
                    // Show Smart Watch-specific fields
                    option4.Visible = true;
                    smart.Visible = true;
                    // You can make smartwatch-specific fields visible here
                }
                else if (selectedItem == "Headphone")
                {
                    option4.Visible = true;
                    headnoice.Visible = true;
                    wireless.Visible = true;
                    wirelessclik.Visible = true;
                    // You can make headphone-specific fields visible here
                }

                // else if smartwatch, headphone, etc.
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = dropdown.SelectedItem.ToString();
            if (dropdown.SelectedItem != null)
            {
                //string selectedItem = dropdown.SelectedItem.ToString();

                if (selectedItem == "Laptop")
                {


                }
                else if (selectedItem == "Smartphone")
                {
                    string item = "Smart phone";
                    string model = modeltext.Text;
                    string brand = brandInput.Text;
                    double price = double.Parse(priceInput.Text);
                    string manufacturingyear = manuInput.Text;
                    string warrantyPeriod = warrInput.Text;
                    int quantity = int.Parse(quntityInput.Text);
                    string batchNumber = batchInput.Text;
                    string ram = option1.Text;
                    string storage = option2.Text;
                    controller.AddSmartphone(
                        model,
                        ram,
                        storage,
                        item,
                        quantity,
                        (int)price,
                        manufacturingyear,
                        int.Parse(warrantyPeriod),
                        batchNumber,
                        brand
                    );
                    MessageBox.Show("Smartphone added successfully!");

                }
                else if (selectedItem == "Smartwatch")
                {

                }
                else if (selectedItem == "Headphone")
                {

                }
                

                // Fix for CS1011: Empty character literal
                // Replace the empty character literal '' with an empty string "".

                modeltext.Text = "";
                brandInput.Text = "";
                priceInput.Text = "";
                manuInput.Text = "";
                warrInput.Text = "";
                quntityInput.Text = "";
                batchInput.Text = "";
                option1.Text = "";
                option2.Text = "";
                
             


            }
        }

       
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();        // Show the next form
            this.Hide();
        }
    }
}
