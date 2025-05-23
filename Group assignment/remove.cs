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
    public partial class remove : Form
    {
<<<<<<< HEAD
        //connection the controller to the remove form
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
        Controller controller;
        public remove()
        {
            controller = new Controller(this); // Pass 'null' for 'addItem' parameter as it is not provided in the context  
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void delete_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            //input validation
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            if (string.IsNullOrWhiteSpace(idTxt.Text))
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
            }
<<<<<<< HEAD
            //pass the user input to the controller and get the output 
=======

>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
            string resultMessage = controller.DeleteProduct(idTxt.Text.Trim());
            MessageBox.Show(resultMessage);

        }

        private void remove_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
