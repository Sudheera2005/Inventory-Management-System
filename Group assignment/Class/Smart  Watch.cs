namespace InventoryManagementSystem.Classes
{
<<<<<<< HEAD
    // Derived class for SmartWatch
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
    public class SmartWatch : Electronics
    {
        //attributes
        private bool waterResistance;

        public SmartWatch(string model, bool waterResistance, string itemType,
                         int quantity, double price, string manufacturingDate,
                         int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            WaterResistance = waterResistance;
        }

        public bool WaterResistance { get => waterResistance; set => waterResistance = value; }
    }
}