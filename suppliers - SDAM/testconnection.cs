using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using suppliers___SDAM.Controller;

namespace suppliers___SDAM
{
    public partial class testconnection : Form
    {
        public testconnection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                suppliers___SDAM.Controller.SupplierController.TestConnection();
                MessageBox.Show("✅ Database connection successful.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Connection failed: " + ex.Message);
            }
        }
    }
}
