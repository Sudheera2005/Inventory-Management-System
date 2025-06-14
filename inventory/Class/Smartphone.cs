using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace inventory.Class
{
    public class Smartphone : Electronics
    {
        //attributes
        private string ram;
        private string storage;

        public Smartphone(string model, string ram, string storage, string itemType,
                         int quantity, double price, string manufacturingDate,
                         int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            Ram = ram;
            Storage = storage;
        }

        public string Ram { get => ram; set => ram = value; }
        public string Storage { get => storage; set => storage = value; }
        public override bool Save(string connectionString)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, ram, storage) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @ram, @storage)";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@item_type", ItemType);
            cmd.Parameters.AddWithValue("@model", Model);
            cmd.Parameters.AddWithValue("@quantity", Quantity);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@manufacturing_date", ManufacturingDate);
            cmd.Parameters.AddWithValue("@warranty_period", WarrantyPeriodInMonths);
            cmd.Parameters.AddWithValue("@batch_number", BatchNumber);
            cmd.Parameters.AddWithValue("@brand", Brand);
            cmd.Parameters.AddWithValue("@ram", Ram);
            cmd.Parameters.AddWithValue("@storage", Storage);

            return ExecuteNonQuery(cmd, connectionString);
        }
    }
}
