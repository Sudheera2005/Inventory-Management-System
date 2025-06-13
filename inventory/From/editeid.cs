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

namespace inventory
{
    public partial class editeid : Form
    {
        controller controller;
        public editeid()
        {
            controller = new controller(this);
            InitializeComponent();
        }

        private void editeid_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //input validation
            if (!int.TryParse(idInput.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            var validationResult = controller.ValidateProductId(idInput.Text.Trim());
            if (validationResult != "valid")
            {
                MessageBox.Show(validationResult);
                return;
            }

            var product = controller.GetProductById(idInput.Text.Trim());
            if (product == null)
            {
                MessageBox.Show("Error loading product details.");
                return;
            }

            using (var editForm = new EditForm(product))
            {
                //open edit form and pass the product details and close this form
                this.Hide();
                editForm.ShowDialog();
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
