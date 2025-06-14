using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace inventory.Class
{
    public class Headphones : Electronics
    {
        //attributes
        private bool wireless;
        private bool noiseCancellation;

        public Headphones(string model, bool wireless, bool noiseCancellation, string itemType,
                         int quantity, double price, string manufacturingDate,
                         int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            Wireless = wireless;
            NoiseCancellation = noiseCancellation;
        }

        public bool Wireless { get => wireless; set => wireless = value; }
        public bool NoiseCancellation { get => noiseCancellation; set => noiseCancellation = value; }
        public override bool Save(string connectionString)
        {
            string query = @"INSERT INTO items_products 
                            (item_type, model, quantity, price, manufacturing_date, 
                             warranty_period, batch_number, brand, wireless, noise_cancellation) 
                            VALUES 
                            (@item_type, @model, @quantity, @price, @manufacturing_date, 
                             @warranty_period, @batch_number, @brand, @wireless, @noise_cancellation)";

            MySqlCommand cmd = new MySqlCommand(query);
            cmd.Parameters.AddWithValue("@item_type", ItemType);
            cmd.Parameters.AddWithValue("@model", Model);
            cmd.Parameters.AddWithValue("@quantity", Quantity);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@manufacturing_date", ManufacturingDate);
            cmd.Parameters.AddWithValue("@warranty_period", WarrantyPeriodInMonths);
            cmd.Parameters.AddWithValue("@batch_number", BatchNumber);
            cmd.Parameters.AddWithValue("@brand", Brand);
            cmd.Parameters.AddWithValue("@wireless", Wireless);
            cmd.Parameters.AddWithValue("@noise_cancellation", NoiseCancellation);

            return ExecuteNonQuery(cmd, connectionString);
        }
    }
}
