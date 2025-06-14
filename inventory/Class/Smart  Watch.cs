using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace inventory.Class
{
    public class Smart__Watch : Electronics
    {
        //attributes
        private bool waterResistance;

        public Smart__Watch(string model, bool waterResistance, string itemType,
                         int quantity, double price, string manufacturingDate,
                         int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            WaterResistance = waterResistance;
        }

        public bool WaterResistance { get => waterResistance; set => waterResistance = value; }
        public override bool Save(string connectionString)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, water_resistance) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @water_resistance)";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@item_type", ItemType);
            cmd.Parameters.AddWithValue("@model", Model);
            cmd.Parameters.AddWithValue("@quantity", Quantity);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@manufacturing_date", ManufacturingDate);
            cmd.Parameters.AddWithValue("@warranty_period", WarrantyPeriodInMonths);
            cmd.Parameters.AddWithValue("@batch_number", BatchNumber);
            cmd.Parameters.AddWithValue("@brand", Brand);
            cmd.Parameters.AddWithValue("@water_resistance", WaterResistance);

            return ExecuteNonQuery(cmd, connectionString);
        }
    }
}
