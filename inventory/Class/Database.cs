using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Stocks;

namespace DatabaseTest
{
    internal class Database
    {

        public static void SaveData(string stockName, int stockQty, double stockPrice)
        {
            string connectionString = "Server=localhost;Database=inventory_management;Uid=root;";


            string loadQuery = "SELECT * FROM items_products WHERE model = '" + stockName + "';";

            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand loadCommand = new MySqlCommand(loadQuery, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = loadCommand.ExecuteReader();
                MessageBox.Show("Query successful");

                if (myReader.HasRows)
                {
                    myReader.Read();
                    int id = myReader.GetInt32(0);
                    string category = myReader.GetString(1);
                    string name = myReader.GetString(2);
                    int qty = myReader.GetInt32(3);
                    double price = myReader.GetDouble(4);
                    string add = "(" + Convert.ToString(id) + "," + name + "," + Convert.ToString(qty) + "," + Convert.ToString(price) + ");";
                    string saveQuery = "INSERT INTO items_products (id, model, quantity, price) VALUES" + add;

                    MySqlCommand saveCommand = new MySqlCommand(saveQuery, conn);
                    MySqlDataReader myReader2 = saveCommand.ExecuteReader();
                    MessageBox.Show("Query successful");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


            
        }

        public static void LoadData() //Move all these code to the above and use this for loading all data
        {
            string connectionString = "Server=localhost;Database=inventory_management;Uid=root;";
            string query = "SELECT * FROM items_products";

            MySqlConnection conn = new MySqlConnection(connectionString);
            MySqlCommand sqlCommand = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                MySqlDataReader myReader = sqlCommand.ExecuteReader();
                MessageBox.Show("Query successful");

                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        int id = myReader.GetInt32(0);
                        string name = myReader.GetString(2);
                        int qty = myReader.GetInt32(3);
                        double price = myReader.GetDouble(4);
                        StockController.Save(name, Convert.ToString(qty), Convert.ToString(price));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
