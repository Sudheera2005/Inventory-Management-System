namespace InventoryManagementSystem.Classes
{
<<<<<<< HEAD
    // Derived class for Headphones
=======
>>>>>>> 4155c46fec52da7e2e554674b10ff94040e421a2
    public class Headphones : Electronics
    {
        //attributes
        private bool wireless;
        private bool noiseCancellation;

        public Headphones(string model, bool wireless, bool noiseCancellation, string itemType,
                         int quantity, double price, string manufacturingDate,
                         int warrantyPeriodInMonths, string batchNumber, string brand)
            : base(model, itemType, quantity, price, manufacturingDate,
                  warrantyPeriodInMonths, batchNumber, brand)
        {
            Wireless = wireless;
            NoiseCancellation = noiseCancellation;
        }

        public bool Wireless { get => wireless; set => wireless = value; }
        public bool NoiseCancellation { get => noiseCancellation; set => noiseCancellation = value; }
    }
}