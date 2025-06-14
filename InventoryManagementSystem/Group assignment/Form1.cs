namespace Group_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // Hide all special fields first when the form loads
            laptopGpu.Visible = false;
            laptopRam.Visible = false;
            laptopScreen.Visible = false;
            laptopGpuytext.Visible = false;
            laptopScreentext.Visible = false;
            laptoRam.Visible = false;
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
            MessageBox.Show("E");
            laptopGpu.Visible = false;
            laptopRam.Visible = false;
            laptopScreen.Visible = false;
            laptopGpuytext.Visible = false;
            laptopScreentext.Visible = false;
            laptoRam.Visible = false;
            string selectedItem = dropdown.SelectedItem.ToString();
            MessageBox.Show(selectedItem);
            if (dropdown.SelectedItem != null)
            {
                //string selectedItem = dropdown.SelectedItem.ToString();

                if (selectedItem == "Laptop")
                {
                    // Show Laptop-specific fields
                    laptopGpu.Visible = true;
                    laptopRam.Visible = true;
                    laptopScreen.Visible = true;
                    laptopGpuytext.Visible = true;
                    laptopScreentext.Visible = true;
                    laptoRam.Visible = true;

                }
                else if (selectedItem == "Phone")
                {
                    // You can make phone-specific fields visible here
                }
                // else if smartwatch, headphone, etc.
            }

        }
    }
}
