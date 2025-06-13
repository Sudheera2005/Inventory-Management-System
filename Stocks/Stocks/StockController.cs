using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    internal class StockController
    {

        static Form1 stockListPage;

        public static Form1 StockListPage { get => stockListPage; set => stockListPage = value; }

        public static void Edit(string name)
        {
            //Validate Stock Name
            if (name == "") { MessageBox.Show("You forgot to enter the name!"); return; }
            //Open Editor
            Editor editor = new Editor();
            editor.Show();
            editor.changeTitle(name);
            //Check if details exists


            //Load the details(if it exists)
            int qty = Stocks.GetStock(name).quantity;
            double price = Stocks.GetStock(name).price;
            editor.setPrice(price);
            editor.setQty(qty);
        }

        public static void Save(string name, string qtyText, string costText)
        {
            int qty;
            double cost;
            //Check if data type is correct
            try
            {
                qty = Convert.ToInt32(qtyText);
                cost = Convert.ToDouble(costText);
            }
            catch
            {
                MessageBox.Show("You aren't entering numbers?! Why?");
                return;
            }
            //Check for impossible numbers
            if (qty < 0 || cost < 0)
            {
                MessageBox.Show("what kind of numbers are those?");
                return;
            }
            //Everything seems valid so add to stock
            Stocks.AddStock(name, qty, cost);
            //Add to the list
            if (stockListPage.getIndex(name) == -1)
            {
                StockListPage.AddStock(name, qty, cost);
            }
            else
            {
                StockListPage.UpdateStock(name, qty, cost);
            }

            //Checking if theres enough stock
            if (qty < 5)
            {
                stockListPage.AddToAlert(name);
            }
            else
            {
                stockListPage.RemoveAlert(name);
            }
        }
        public static void Delete(string name)
        {
            //Check if it exists 
            if (Stocks.GetStock(name).price == -1) { return; }
            //It exists
            stockListPage.RemoveAlert(name);
            Stocks.RemoveStock(name);
            StockController.StockListPage.RemoveStock(name);
        }
    }
}
