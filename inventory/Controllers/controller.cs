using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using inventory.From;
using inventory.Class;


namespace inventory.Controllers
{
    public class controller
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=inventory_management";
        private MySqlConnection connection;

        // Connecting models to the controller
        public bool AddLaptop(Laptop laptop)
        {
            return laptop.Save(connectionString);
        }

        public bool AddSmartphone(Smartphone smartphone)
        {
            return smartphone.Save(connectionString);
        }

        public bool AddSmartWatch(Smart__Watch smartWatch)
        {
            return smartWatch.Save(connectionString);
        }

        public bool AddHeadphones(Headphones headphones)
        {
            return headphones.Save(connectionString);
        }

        // Connecting the forms to the controller
        public controller(item item)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }

        public controller(addiem additem)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }

        public controller(editeid editid)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }

        public controller(EditForm edite)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }

        public controller(RemoveForm remove)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }
        public controller(SystemReport report)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }

        private void InitializeDatabase()
        {
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        // Removed duplicate definitions of AddLaptop, AddSmartphone, AddSmartWatch, and AddHeadphones methods
        // The duplicate methods were already defined earlier in the class, so they were safely removed.

        // Get all products
        public List<Dictionary<string, object>> GetAllProducts()
        {
            List<Dictionary<string, object>> products = new List<Dictionary<string, object>>();
            string query = "SELECT * FROM items_products";

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Dictionary<string, object> product = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                product.Add(reader.GetName(i), reader.GetValue(i));
                            }
                            products.Add(product);
                        }
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving products: " + ex.Message);
            }

            return products;
        }

        // Update product
        public bool UpdateProduct(int id, string field, object value)
        {
            string query = $"UPDATE items_products SET {field} = @value WHERE id = @id";

            try
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    cmd.Parameters.AddWithValue("@id", id);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    connection.Close();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
                return false;
            }
        }

        // Delete item
        public string DeleteProduct(string id)
        {
            string checkQuery = "SELECT COUNT(*) FROM items_products WHERE id = @id";
            string deleteQuery = "DELETE FROM items_products WHERE id = @id";

            try
            {
                connection.Open();

                // Check if item exists
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@id", id);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (count == 0)
                    {
                        return $"Item with ID {id} does not exist in the database.";
                    }
                }

                // If it exists, delete it
                using (MySqlCommand deleteCmd = new MySqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@id", id);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        return $"Item with ID {id} was successfully deleted.";
                    }
                    else
                    {
                        return $"Failed to delete item with ID {id}.";
                    }
                }
            }
            catch (Exception ex)
            {
                return "Error deleting product: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }

        // Get item by ID for editing
        public Dictionary<string, object> GetProductById(string id)
        {
            string query = "SELECT * FROM items_products WHERE id = @id";
            Dictionary<string, object> product = null;

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            product = new Dictionary<string, object>();
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                product.Add(reader.GetName(i), reader.GetValue(i));
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving product: " + ex.Message);
            }

            return product;
        }

        public string ValidateProductId(string id)
        {
            if (!int.TryParse(id, out _))
                return "Invalid ID format. Please enter a numeric ID.";

            string query = "SELECT COUNT(*) FROM items_products WHERE id = @id";

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    connection.Open();
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0 ? "valid" : $"Item with ID {id} not found.";
                }
            }
            catch (Exception ex)
            {
                return "Error validating product: " + ex.Message;
            }
        }

        public bool UpdateProduct(Dictionary<string, object> updates, string id)
        {
            if (updates.Count == 0) return false;

            var setClauses = new List<string>();
            var parameters = new List<MySqlParameter>();

            foreach (var kvp in updates)
            {
                setClauses.Add($"{kvp.Key} = @{kvp.Key}");
                parameters.Add(new MySqlParameter($"@{kvp.Key}", kvp.Value));
            }

            string query = $"UPDATE items_products SET {string.Join(", ", setClauses)} WHERE id = @id";
            parameters.Add(new MySqlParameter("@id", id));

            try
            {
                using (var connection = new MySqlConnection(connectionString))
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddRange(parameters.ToArray());
                    connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
                return false;
            }
        }

        // Grid display
        public DataTable GetAllitem()
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM items_products";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading products: " + ex.Message);
            }

            return dt;
        }

        public DataTable GetProductsByCategory(string category)
        {
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    string query = "SELECT * FROM items_products WHERE item_type = @category";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@category", category);
                    conn.Open();

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error filtering by category: " + ex.Message);
            }

            return dt;
        }

        //system report
        public DataTable GetProducts()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = @"SELECT 
                                item_type AS 'Type',
                                model AS 'Model',
                                brand AS 'Brand',
                                price AS 'Price',
                                quantity
                                FROM items_products
                                ORDER BY brand, model";

                new MySqlDataAdapter(query, conn).Fill(dt);
            }
            return dt;
        }

        public DataTable GetUsers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT username FROM userses ORDER BY username";
                new MySqlDataAdapter(query, conn).Fill(dt);
            }
            return dt;
        }
    }
}
