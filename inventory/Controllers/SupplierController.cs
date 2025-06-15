using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using suppliers___SDAM.Classes;

namespace suppliers___SDAM.Controller
{
    public class SupplierController
    {
        private static string connectionString = "server=localhost;uid=root;pwd=;database=inventory_management";

        // Add a new supplier to the DB
        public static bool AddSupplier(Supplier supplier)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO suppliers (name, phone, email, address) VALUES (@name, @phone, @email, @address)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@email", supplier.Email);
                cmd.Parameters.AddWithValue("@address", supplier.Address);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0; // true if insert successful
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error adding supplier: " + ex.Message);
                    return false;
                }
            }
        }

        // Get all suppliers from DB
        public static List<Supplier> GetAllSuppliers()
        {
            List<Supplier> suppliers = new List<Supplier>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM suppliers";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                try
                {
                    conn.Open();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            suppliers.Add(new Supplier
                            {
                                SupplierID = reader.GetInt32("supplier_id"),
                                SupplierName = reader.GetString("name"),
                                Phone = reader.GetString("phone"),
                                Email = reader.GetString("email"),
                                Address = reader.GetString("address")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error fetching suppliers: " + ex.Message);
                }
            }

            return suppliers;
        }

        // Update supplier
        public static bool UpdateSupplier(Supplier supplier)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "UPDATE suppliers SET name = @name, phone = @phone, email = @email, address = @address WHERE supplier_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@phone", supplier.Phone);
                cmd.Parameters.AddWithValue("@email", supplier.Email);
                cmd.Parameters.AddWithValue("@address", supplier.Address);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierID);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error updating supplier: " + ex.Message);
                    return false;
                }
            }
        }

        // Delete supplier
        public static bool DeleteSupplier(int supplierID)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM suppliers WHERE supplier_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", supplierID);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error deleting supplier: " + ex.Message);
                    return false;
                }
            }
        }

        public static void TestConnection()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("✅ Connection successful.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("❌ Connection failed: " + ex.Message);
                }
            }
        }
        public static bool AssignSupplierToProduct(int productId, int supplierId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO product_supplier (product_id, supplier_id) VALUES (@productId, @supplierId)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@productId", productId);
                cmd.Parameters.AddWithValue("@supplierId", supplierId);

                try
                {
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error assigning supplier to product: " + ex.Message);
                    return false;
                }
            }
        }
    }
}
