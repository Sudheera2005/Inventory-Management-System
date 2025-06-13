using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory.Class
{
    public class Smart__Watch : Electronics
    {
        //attributes
        private bool waterResistance;

        public Smart__Watch(string model, bool waterResistance, string itemType,
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
