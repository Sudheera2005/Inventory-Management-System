using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace InventoryManagementSystem
{
    public class Order
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=inventory_management";

        public int OrderId { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public string Status { get; set; } = "Pending";

        public List<Order> GetAllOrders()
        {
            List<Order> orders = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT OrderID, ProductName, Quantity, TotalPrice, OrderDate, Status FROM Orders";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = Convert.ToInt32(reader["OrderID"]),
                            ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            Status = reader["Status"]?.ToString() ?? "Pending"
                        });
                    }
                }
            }

            return orders;
        }

        public void AddOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Orders (ProductName, Quantity, TotalPrice, OrderDate, Status) VALUES (@name, @qty, @price, @date, @status)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", order.ProductName);
                    cmd.Parameters.AddWithValue("@qty", order.Quantity);
                    cmd.Parameters.AddWithValue("@price", order.TotalPrice);
                    cmd.Parameters.AddWithValue("@date", order.OrderDate);
                    cmd.Parameters.AddWithValue("@status", order.Status);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateOrder(Order order)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Orders SET ProductName = @name, Quantity = @qty, TotalPrice = @price, OrderDate = @date, Status = @status WHERE OrderID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", order.ProductName);
                    cmd.Parameters.AddWithValue("@qty", order.Quantity);
                    cmd.Parameters.AddWithValue("@price", order.TotalPrice);
                    cmd.Parameters.AddWithValue("@date", order.OrderDate);
                    cmd.Parameters.AddWithValue("@status", order.Status);
                    cmd.Parameters.AddWithValue("@id", order.OrderId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteOrder(int orderId)
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Orders WHERE OrderID = @id";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Order> SearchOrders(string keyword)
        {
            List<Order> orders = new List<Order>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT OrderID, ProductName, Quantity, TotalPrice, OrderDate, Status FROM Orders WHERE LOWER(ProductName) LIKE @keyword";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@keyword", $"%{keyword.ToLower()}%");
                    MySqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            OrderId = Convert.ToInt32(reader["OrderID"]),
                            ProductName = reader["ProductName"]?.ToString() ?? string.Empty,
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            TotalPrice = Convert.ToDecimal(reader["TotalPrice"]),
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            Status = reader["Status"]?.ToString() ?? "Pending"
                        });
                    }
                }
            }

            return orders;
        }
    }
}
