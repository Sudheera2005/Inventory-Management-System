using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_assignment.Class
{
    public class controller
    {
        private List<Headphones> Headphones;
        private List<Laptop> laptops;
        private List<Smartphone> smartphones;
        private List<Smart__Watch> smartwatches;

        private string connectionString = "";

        public controller(Form1 form1)
        {
            Headphones = new List<Headphones>();
            laptops = new List<Laptop>();
            smartphones = new List<Smartphone>();
            smartwatches = new List<Smart__Watch>();
        }
        public void AddSmartphone(string model, string ram, string storage, string item, int quantity, int price, string manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand)
        {
            // Updated to include all required parameters for the Smartphone constructor
            Smartphone newPhone = new Smartphone(ram, storage, model, item, quantity, price, manufacturingDate, warrantyPeriodInMonths, batchNumber, brand);
            smartphones.Add(newPhone);

            //SaveSmartphoneToDatabase(newPhone);
        }

        //private void SaveSmartphoneToDatabase(Smartphone phone)
        //{
        //    using (SqlConnection conn = new SqlConnection(connectionString))
        //    {
        //        string query = "INSERT INTO Smartphones (Brand, Model, StorageGB, Price) VALUES (@Brand, @Model, @StorageGB, @Price)";
        //        SqlCommand cmd = new SqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("@Brand", phone.Brand);
        //        cmd.Parameters.AddWithValue("@Model", phone.Model);
        //        cmd.Parameters.AddWithValue("@StorageGB", phone.StorageGB);
        //        cmd.Parameters.AddWithValue("@Price", phone.Price);

        //        try
        //        {
        //            conn.Open();
        //            cmd.ExecuteNonQuery();
        //            MessageBox.Show("Smartphone saved to database.");
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error saving smartphone: " + ex.Message);
        //        }
        //    }
        //}
    }
}
