using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using inventory.Controllers;

namespace inventory
{
    public partial class SystemReport : Form
    {
        private controller Controller; // Correctly instantiated as a field  

        public SystemReport()
        {
            InitializeComponent();
            Controller = new controller(this); // Ensure the instance is assigned  
            LoadData();
        }

        private void LoadData()
        {
            // Load and display products  
            DataTable products = Controller.GetProducts(); // Use the correct instance 'Controller'  
            dataGridView1.DataSource = products;
            FormatProductGrid();

            // Load and display users  
            DataTable users = Controller.GetUsers(); // Use the correct instance 'Controller'  
            dataGridView2.DataSource = users;
            lblUserCount.Text = $"Total Users: {users.Rows.Count}";
        }

        private void FormatProductGrid()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

            // Hide quantity column (used only for highlighting)  
            dataGridView1.Columns["quantity"].Visible = false;

            // Format price column  
            dataGridView1.Columns["Price"].DefaultCellStyle.Format = "C2";
            dataGridView1.Columns["Price"].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleRight;

            // Highlight low stock items (quantity < 10)  
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["quantity"].Value != null &&
                    Convert.ToInt32(row.Cells["quantity"].Value) < 10)
                {
                    row.DefaultCellStyle.BackColor = Color.LightCoral;
                    row.DefaultCellStyle.Font = new Font(dataGridView1.Font, FontStyle.Bold);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void SystemReport_Load(object sender, EventArgs e)
        {

        }
    }
}
