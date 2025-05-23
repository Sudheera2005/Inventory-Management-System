namespace InventoryManagementSystem.Classes
{
<<<<<<< HEAD
    // Derived class for Smartphone
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
    public class Smartphone : Electronics
    {
        //attributes
        private string ram;
        private string storage;

        public Smartphone(string model, string ram, string storage, string itemType,
                         int quantity, double price, string manufacturingDate,
                         int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            Ram = ram;
            Storage = storage;
        }

        public string Ram { get => ram; set => ram = value; }
        public string Storage { get => storage; set => storage = value; }
    }
}