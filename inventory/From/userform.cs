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
using Org.BouncyCastle.Asn1.Cmp;

namespace inventory
{
    public partial class userform : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=inventory_management";
        public userform()
        {
            InitializeComponent();
            LoadUserData();
        }
        private void LoadUserData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT id, username, password, created_at FROM userses";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;

                    // Format the grid
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridView1.Columns["id"].HeaderText = "ID";
                    dataGridView1.Columns["username"].HeaderText = "Username";
                    dataGridView1.Columns["password"].HeaderText = "Password";
                    dataGridView1.Columns["created_at"].HeaderText = "Created At";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void userform_lode(object sender, EventArgs e)
        {

        }
        private void refresh_Click(object sender, EventArgs e)
        {
            LoadUserData();
            lable.Text = "Last refreshed: " + DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userform_Load(object sender, EventArgs e)
        {

        }
    }
}
