using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Group_assignment.Class;

namespace Group_assignment
{
    public partial class editid : Form
    {
        private Controller controller; // Move the field inside the class and make it private

        public editid()
        {
            InitializeComponent();
            controller = new Controller(this); // Initialize the field in the constructor
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(edittxt.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid numeric ID.");
                return;
            }

            var validationResult = controller.ValidateProductId(edittxt.Text.Trim());
            if (validationResult != "valid")
            {
                MessageBox.Show(validationResult);
                return;
            }

            var product = controller.GetProductById(edittxt.Text.Trim());
            if (product == null)
            {
                MessageBox.Show("Error loading product details.");
                return;
            }

            using (var editForm = new edite(product))
            {
                this.Hide();
                editForm.ShowDialog();
                this.Show();
            }
        }
    
    }
}
