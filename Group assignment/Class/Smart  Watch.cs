namespace InventoryManagementSystem.Classes
{
    public class SmartWatch : Electronics
    {
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