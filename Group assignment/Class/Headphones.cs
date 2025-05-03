using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.Devices;

namespace Group_assignment.Class
{
    class Headphones:Electronics
    {
        private bool wireless;
        private bool noiseCancellation;
        public Headphones(string model,bool wirless, bool noiseCancellation, string item, int quantity, double price, string manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand) : base(model, item, quantity, price, manufacturingDate, warrantyPeriodInMonths, batchNumber, brand)
        {
            NoiseCancellation = noiseCancellation;
            Wireless = wirless;
        }

        public bool Wireless { get => wireless; set => wireless = value; }
        public bool NoiseCancellation { get => noiseCancellation; set => noiseCancellation = value; }
    }
}
