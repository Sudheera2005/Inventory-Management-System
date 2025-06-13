using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stocks
{
    internal class Stocks
    {
        public struct Template
        {
            public int quantity;
            public double price;
        }
        private static Dictionary<string, Template> StockList = new Dictionary<string, Template>();

        public static void AddStock(string name, int qty, double price)
        {
            Template stock = new Template();
            stock.quantity = qty;
            stock.price = price;
            if (StockList.ContainsKey(name))
            {
                StockList[name] = stock;
                return;
            }
            StockList.Add(name, stock);
        }
        public void AddAlert(string name)
        {
            StockController.StockListPage.AddToAlert(name);
        }

        public void RemoveAlert(string name)
        {
            StockController.StockListPage.RemoveAlert(name);
        }
        public static void RemoveStock(string name)
        {
            StockList.Remove(name);
        }

        public static void UpdateStock(string name, int qty, double price)
        {
            Template currentStock = StockList[name];
            currentStock.quantity = qty;
            currentStock.price = price;
        }

        public static Template GetStock(string name)
        {
            Template stock = new Template();
            stock.price = -1;
            stock.quantity = -1;
            if (StockList.ContainsKey(name))
            {
                stock.quantity = StockList[name].quantity;
                stock.price = StockList[name].price;
            }
            return stock;
        }
    }
}
