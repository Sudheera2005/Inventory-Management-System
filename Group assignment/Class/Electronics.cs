using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_assignment.Class
{
    internal abstract class Electronics
    {
        private string item;
        private string id;
        private int quantity;
        private int price;
        private DateTime manufacturingDate;
        private int WarrantyPeriodInMonths;
        private string batchNumber;
        private string brand;

        protected Electronics(string item, string id, int quantity, int price, DateTime manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand)
        {
            this.item = item;
            this.id = id;
            this.quantity = quantity;
            this.price = price;
            this.manufacturingDate = manufacturingDate;
            WarrantyPeriodInMonths = warrantyPeriodInMonths;
            this.batchNumber = batchNumber;
            this.brand = brand;
        }

        public string Item { get => item; set => item = value; }
        public string Id { get => id; set => id = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
        public DateTime ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public int WarrantyPeriodInMonths1 { get => WarrantyPeriodInMonths; set => WarrantyPeriodInMonths = value; }
        public string BatchNumber { get => batchNumber; set => batchNumber = value; }
        public string Brand { get => brand; set => brand = value; }
    }
}
