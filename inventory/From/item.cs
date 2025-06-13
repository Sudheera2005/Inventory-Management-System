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
using Org.BouncyCastle.Asn1.Cmp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory.From
{
    public partial class item : Form
    {
        controller controller;
        private DataTable productsData;
        public item()
        {
            InitializeComponent();
            controller = new controller(this);
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;

            // Set up ComboBox  
            comboBox1.Items.AddRange(new object[] { "All", "Laptop", "Smartphone", "Smartwatch", "Headphone" });
            comboBox1.SelectedIndex = 0;

            // Load initial data  
            RefreshData();
        }
        private void RefreshData()
        {
            try
            {
                string selectedCategory = comboBox1.SelectedItem.ToString();

                if (selectedCategory == "All")
                {
                    productsData = controller.GetAllitem();
                }
                else
                {
                    productsData = controller.GetProductsByCategory(selectedCategory);
                }

                dataGridView1.DataSource = productsData;
                lblStatus.Text = $"Showing {productsData.Rows.Count} products";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            // Set up auto-refresh timer (optional)  
            System.Windows.Forms.Timer refreshTimer = new System.Windows.Forms.Timer
            {
                Interval = 180000 // 3 minutes  
            };
            refreshTimer.Tick += (s, args) => RefreshData();
            refreshTimer.Start();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addiem addItemForm = new addiem();
            addItemForm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            editeid editIdForm = new editeid();
            editIdForm.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            RemoveForm removeForm = new RemoveForm();
            removeForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RefreshData();
        }
    }
}
