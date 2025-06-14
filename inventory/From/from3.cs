using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mysqlx.Notice;
using MySql.Data.MySqlClient;

namespace inventory
{
    public partial class from3 : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=inventory_management";
        public from3()
        {
            InitializeComponent();
            //passowd.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.username.Text.Trim();
            string password = this.password.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (CheckCredentials(username, password))
                {
                    MessageBox.Show("Login successful", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Open main form
                    //From1 mainForm = new From1();
                    //mainForm.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void from3_Load(object sender, EventArgs e)
        {
            // Initialize the form or perform any necessary setup  
        }

        private void from3_Load_1(object sender, EventArgs e)
        {
            username.Focus();
        }
        private bool CheckCredentials(string username, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM userses WHERE username = @username AND password = @password";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count > 0;
            }
        }

        

       
    }
}
