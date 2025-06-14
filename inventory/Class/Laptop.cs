using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace inventory.Class
{
    public class Laptop : Electronics
    {

        //attributes
        private string ram;
        private string gpu;
        private string screenSize;

        public Laptop(string model, string ram, string gpu, string screenSize, string itemType,
                     int quantity, double price, string manufacturingDate,
                     int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            Ram = ram;
            Gpu = gpu;
            ScreenSize = screenSize;
        }

        public string Ram { get => ram; set => ram = value; }
        public string Gpu { get => gpu; set => gpu = value; }
        public string ScreenSize { get => screenSize; set => screenSize = value; }

        public override bool Save(string connectionString)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, ram, gpu, screen_size) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @ram, @gpu, @screen_size)";

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
            cmd.Parameters.AddWithValue("@gpu", Gpu);
            cmd.Parameters.AddWithValue("@screen_size", ScreenSize);

            return ExecuteNonQuery(cmd, connectionString);
        }
    }
}
