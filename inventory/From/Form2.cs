using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing; // Ensure this namespace is included for Point and Size
using System.Windows.Forms;

namespace InventoryManagementSystem
{
    public partial class Form1 : Form
    {
        private Label lblTotalPrice; // Declare lblTotalPrice as a private field
        private Guna2NumericUpDown numericUpDownPrice; // Declare numericUpDownPrice as a private field
        private Order orderManager = new Order();
        private List<Order> orders = new List<Order>();
        private int currentOrderId = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeControls();
            InitializeDataGridView();
            comboBox1.SelectedIndex = 0; // Set default selection to first item
            LoadOrdersToGrid();
            UpdateTotalPrice();
        }

        private void InitializeControls()
        {
            numericUpDownPrice = new Guna2NumericUpDown // Initialize numericUpDownPrice
            {
                Minimum = 0,
                Maximum = 1000000,
                DecimalPlaces = 2,
                Value = 0,
                Increment = 0.01M, // Add small increment for precise price entry
                Location = new Point(150, 100), // Adjust location as needed
                Size = new Size(120, 30) // Adjust size as needed
            };
            numericUpDownPrice.ValueChanged += numericUpDownPrice_ValueChanged; // Add event handler
            this.Controls.Add(numericUpDownPrice); // Add the control to the form

            lblTotalPrice = new Label // Initialize lblTotalPrice
            {
                Text = "Total Price: $0.00",
                Location = new Point(150, 140), // Adjust location as needed
                Size = new Size(200, 30) // Adjust size as needed
            };
            this.Controls.Add(lblTotalPrice); // Add the label to the form
        }

        private void InitializeDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[0].Name = "OrderID";
            dataGridView1.Columns[0].HeaderText = "Order ID";
            dataGridView1.Columns[0].DataPropertyName = "OrderID";

            dataGridView1.Columns[1].Name = "ProductName";
            dataGridView1.Columns[1].HeaderText = "Product Name";
            dataGridView1.Columns[1].DataPropertyName = "ProductName";

            dataGridView1.Columns[2].Name = "Quantity";
            dataGridView1.Columns[2].HeaderText = "Quantity";
            dataGridView1.Columns[2].DataPropertyName = "Quantity";

            dataGridView1.Columns[3].Name = "TotalPrice";
            dataGridView1.Columns[3].HeaderText = "Total Price";
            dataGridView1.Columns[3].DataPropertyName = "TotalPrice";

            dataGridView1.Columns[4].Name = "OrderDate";
            dataGridView1.Columns[4].HeaderText = "Order Date";
            dataGridView1.Columns[4].DataPropertyName = "OrderDate";

            dataGridView1.Columns[5].Name = "Status";
            dataGridView1.Columns[5].HeaderText = "Status";
            dataGridView1.Columns[5].DataPropertyName = "Status";
        }

        private void LoadOrdersToGrid()
        {
            orders = orderManager.GetAllOrders();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = orders;
        }

        private void ClearForm()
        {
            textBox1.Clear();
            numericUpDown1.Value = 1;
            numericUpDownPrice.Value = 0; // Reset unit price
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = 0;
            currentOrderId = 0;
            UpdateTotalPrice(); // Reset total price display
        }

        private void UpdateTotalPrice()
        {
            decimal quantity = numericUpDown1.Value;
            decimal unitPrice = numericUpDownPrice.Value;
            decimal totalPrice = quantity * unitPrice;
            lblTotalPrice.Text = $"Total Price: ${totalPrice:N2}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Validate product name
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Product name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate status
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select an order status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var newOrder = new Order
                {
                    ProductName = textBox1.Text.Trim(),
                    Quantity = (int)numericUpDown1.Value,
                    TotalPrice = numericUpDown1.Value * numericUpDownPrice.Value,
                    OrderDate = dateTimePicker1.Value,
                    Status = comboBox1.SelectedItem?.ToString() ?? "Pending"
                };

                orderManager.AddOrder(newOrder);
                LoadOrdersToGrid();
                ClearForm();
                MessageBox.Show("Order added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (currentOrderId == 0)
            {
                MessageBox.Show("Please select an order to edit.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numericUpDownPrice.Value <= 0)
            {
                MessageBox.Show("Please enter a valid unit price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var editedOrder = new Order
            {
                OrderId = currentOrderId,
                ProductName = textBox1.Text.Trim(),
                Quantity = (int)numericUpDown1.Value,
                TotalPrice = numericUpDown1.Value * numericUpDownPrice.Value,
                OrderDate = dateTimePicker1.Value,
                Status = comboBox1.SelectedItem?.ToString() ?? "Pending"
            };

            orderManager.UpdateOrder(editedOrder);
            LoadOrdersToGrid();
            ClearForm();
            MessageBox.Show("Order updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (currentOrderId == 0)
            {
                MessageBox.Show("Please select an order to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this order?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                orderManager.DeleteOrder(currentOrderId);
                LoadOrdersToGrid();
                ClearForm();
                MessageBox.Show("Order deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            string keyword = textBox2.Text.Trim();
            var filteredOrders = orderManager.SearchOrders(keyword);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = filteredOrders;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                var selectedOrder = row.DataBoundItem as Order;

                if (selectedOrder != null)
                {
                    currentOrderId = selectedOrder.OrderId;
                    textBox1.Text = selectedOrder.ProductName;
                    numericUpDown1.Value = selectedOrder.Quantity;
                    numericUpDownPrice.Value = selectedOrder.TotalPrice / selectedOrder.Quantity; // Calculate unit price
                    dateTimePicker1.Value = selectedOrder.OrderDate;
                    comboBox1.SelectedItem = selectedOrder.Status;
                    UpdateTotalPrice();
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}