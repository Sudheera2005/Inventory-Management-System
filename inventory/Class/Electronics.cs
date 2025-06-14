using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace inventory.Class
{
    public abstract class Electronics
    {
        //attributes
        private string model;
        private string itemType;
        private int quantity;
        private double price;
        private string manufacturingDate;
        private int warrantyPeriodInMonths;
        private string batchNumber;
        private string brand;

        protected Electronics(string model, string itemType, int quantity, double price,
                             string manufacturingDate, int warrantyPeriodInMonths,
                             string batchNumber, string brand)
        {
            Model = model;
            ItemType = itemType;
            Quantity = quantity;
            Price = price;
            ManufacturingDate = manufacturingDate;
            WarrantyPeriodInMonths = warrantyPeriodInMonths;
            BatchNumber = batchNumber;
            Brand = brand;
        }
        //geters and seters
        public string Model { get => model; set => model = value; }
        public string ItemType { get => itemType; set => itemType = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public int WarrantyPeriodInMonths { get => warrantyPeriodInMonths; set => warrantyPeriodInMonths = value; }
        public string BatchNumber { get => batchNumber; set => batchNumber = value; }
        public string Brand { get => brand; set => brand = value; }

        // Abstract method to be implemented by derived classes
        public abstract bool Save(string connectionString);

        // Common method to execute SQL command
        protected bool ExecuteNonQuery(MySqlCommand cmd, string connectionString)
        {
            try
            {
                using (var connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    cmd.Connection = connection;
                    cmd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log the error or handle it appropriately
                Console.WriteLine("Error saving to database: " + ex.Message);
                return false;
            }
        }
    }
}
