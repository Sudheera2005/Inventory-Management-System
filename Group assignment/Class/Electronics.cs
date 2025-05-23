using System;

namespace InventoryManagementSystem.Classes
{
<<<<<<< HEAD
    // Base class for all electronic items
    public abstract class Electronics
    {
        //attributes
=======
    public abstract class Electronics
    {
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
        private string model;
        private string itemType;
        private int quantity;
        private double price;
        private string manufacturingDate;
        private int warrantyPeriodInMonths;
        private string batchNumber;
        private string brand;

        protected Electronics(string model, string itemType, int quantity, double price,
                             string manufacturingDate, int warrantyPeriodInMonths,
                             string batchNumber, string brand)
        {
            Model = model;
            ItemType = itemType;
            Quantity = quantity;
            Price = price;
            ManufacturingDate = manufacturingDate;
            WarrantyPeriodInMonths = warrantyPeriodInMonths;
            BatchNumber = batchNumber;
            Brand = brand;
        }
<<<<<<< HEAD
        //geters and seters
=======

>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
        public string Model { get => model; set => model = value; }
        public string ItemType { get => itemType; set => itemType = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Price { get => price; set => price = value; }
        public string ManufacturingDate { get => manufacturingDate; set => manufacturingDate = value; }
        public int WarrantyPeriodInMonths { get => warrantyPeriodInMonths; set => warrantyPeriodInMonths = value; }
        public string BatchNumber { get => batchNumber; set => batchNumber = value; }
        public string Brand { get => brand; set => brand = value; }
    }
}