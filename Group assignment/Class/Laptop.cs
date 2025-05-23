namespace InventoryManagementSystem.Classes
{
    // Derived class for Laptop
    public class Laptop : Electronics
    {
        //attributes
        private string ram;
        private string gpu;
        private string screenSize;

        public Laptop(string model, string ram, string gpu, string screenSize, string itemType,
                     int quantity, double price, string manufacturingDate,
                     int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            Ram = ram;
            Gpu = gpu;
            ScreenSize = screenSize;
        }

        public string Ram { get => ram; set => ram = value; }
        public string Gpu { get => gpu; set => gpu = value; }
        public string ScreenSize { get => screenSize; set => screenSize = value; }
    }
}