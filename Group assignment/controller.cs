using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Group_assignment.Class
{
    public class Controller
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=inventory_management";
        private MySqlConnection connection;

        public Controller(addItem form)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }
        public Controller(remove remove)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }
        public Controller(item item)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }
        public Controller(editid editid)
        {
            connection = new MySqlConnection(connectionString);
            InitializeDatabase();
        }
        public Controller(edite edite)
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
        

        // Add methods for all product types
        public bool AddLaptop(string model, string ram, string gpu, string screenSize,
                            string itemType, int quantity, double price, string manufacturingDate,
                            int warrantyPeriod, string batchNumber, string brand)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, ram, gpu, screen_size) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @ram, @gpu, @screen_size)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@item_type", itemType);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@manufacturing_date", manufacturingDate);
                    cmd.Parameters.AddWithValue("@warranty_period", warrantyPeriod);
                    cmd.Parameters.AddWithValue("@batch_number", batchNumber);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@ram", ram);
                    cmd.Parameters.AddWithValue("@gpu", gpu);
                    cmd.Parameters.AddWithValue("@screen_size", screenSize);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding laptop: " + ex.Message);
                return false;
            }
        }

        public bool AddSmartphone(string model, string ram, string storage, string itemType,
                                int quantity, double price, string manufacturingDate,
                                int warrantyPeriod, string batchNumber, string brand)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, ram, storage) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @ram, @storage)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@item_type", itemType);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@manufacturing_date", manufacturingDate);
                    cmd.Parameters.AddWithValue("@warranty_period", warrantyPeriod);
                    cmd.Parameters.AddWithValue("@batch_number", batchNumber);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@ram", ram);
                    cmd.Parameters.AddWithValue("@storage", storage);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding smartphone: " + ex.Message);
                return false;
            }
        }

        public bool AddSmartWatch(string model, bool waterResistance, string itemType,
                                int quantity, double price, string manufacturingDate,
                                int warrantyPeriod, string batchNumber, string brand)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, water_resistance) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @water_resistance)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@item_type", itemType);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@manufacturing_date", manufacturingDate);
                    cmd.Parameters.AddWithValue("@warranty_period", warrantyPeriod);
                    cmd.Parameters.AddWithValue("@batch_number", batchNumber);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@water_resistance", waterResistance);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding smartwatch: " + ex.Message);
                return false;
            }
        }

        public bool AddHeadphones(string model, bool wireless, bool noiseCancellation,
                                string itemType, int quantity, double price,
                                string manufacturingDate, int warrantyPeriod,
                                string batchNumber, string brand)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, wireless, noise_cancellation) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @wireless, @noise_cancellation)";

            try
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@item_type", itemType);
                    cmd.Parameters.AddWithValue("@model", model);
                    cmd.Parameters.AddWithValue("@quantity", quantity);
                    cmd.Parameters.AddWithValue("@price", price);
                    cmd.Parameters.AddWithValue("@manufacturing_date", manufacturingDate);
                    cmd.Parameters.AddWithValue("@warranty_period", warrantyPeriod);
                    cmd.Parameters.AddWithValue("@batch_number", batchNumber);
                    cmd.Parameters.AddWithValue("@brand", brand);
                    cmd.Parameters.AddWithValue("@wireless", wireless);
                    cmd.Parameters.AddWithValue("@noise_cancellation", noiseCancellation);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding headphones: " + ex.Message);
                return false;
            }
        }

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
        //Delete iterm
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
        // In Controller class
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







    }
}