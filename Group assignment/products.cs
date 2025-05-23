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
    public partial class products : Form
    {
        private Controller _controller;
        private BindingSource _bindingSource = new BindingSource();
        public products()
        {
           
        }
        private void SetupDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = _bindingSource;
            dataGridView1.Columns.Clear();

            // Add columns with improved formatting
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "id",
                HeaderText = "ID",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "item_type",
                HeaderText = "Category",
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "brand",
                HeaderText = "Brand",
                Width = 120
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "model",
                HeaderText = "Model",
                Width = 200,
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "FormattedPrice",
                HeaderText = "Price",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight,
                    Format = "C2"
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "quantity",
                HeaderText = "Qty",
                Width = 60,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "warranty_period",
                HeaderText = "Warranty",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleRight
                }
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "manufacturing_date",
                HeaderText = "Mfg Date",
                Width = 100
            });

            // Enable sorting
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }
        }
        private void SetupSearchControls()
        {

        }
        private void UpdateSearchControlsVisibility()
        {

        }

        private void products_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            addItem addItem = new addItem();
            addItem.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            remove remove = new remove();
            remove.Show();
        }
    }
}
