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

namespace inventory
{
    public partial class RemoveForm: Form
    {
        controller controller;
        public RemoveForm()
        {
            controller = new controller(this);
            InitializeComponent();
        }
        private void remove_Load(object sender, EventArgs e)
        {
            // Load any necessary data or perform initialization here
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inid.Text))
            {
                MessageBox.Show("Please enter a valid product ID.");
                return;
                
            }
            string resultMessage = controller.DeleteProduct(inid.Text.Trim());
            MessageBox.Show(resultMessage);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // Close the form
            this.Close();
        }
    }
}
