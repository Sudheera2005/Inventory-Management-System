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
            if (string.IsNullOrWhiteSpace(idTxt.Text))
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
            }

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
