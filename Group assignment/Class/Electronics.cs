using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_assignment.Class
{
    internal abstract class Electronics
    {
        private string Model;
        private int nextId = 1; // Static variable to keep track of the next ID  
        private string item;
        private int id; // Field for ID  
        private int quantity;
        private double price;
        private string manufacturingDate;
        private int WarrantyPeriodInMonths;
        private string batchNumber;
        private string brand;

        protected Electronics(string model, string item, int quantity, double price, string manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand)
        {
            this.item = item;
            id = nextId++;
            this.quantity = quantity;
            this.price = price;
            this.manufacturingDate = manufacturingDate;
            WarrantyPeriodInMonths = warrantyPeriodInMonths;
            this.batchNumber = batchNumber;
            this.brand = brand;
            this.Model = model;
        }

        public string Item { get => item; set => item = value; }
        public int Id { get => id; } // Renamed property to 'Id' to fix naming rule violation and conflict  
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public int WarrantyPeriodInMonths1 { get => WarrantyPeriodInMonths; set => WarrantyPeriodInMonths = value; }
        public string BatchNumber { get => batchNumber; set => batchNumber = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Model1 { get => Model; set => Model = value; }
    }
}
