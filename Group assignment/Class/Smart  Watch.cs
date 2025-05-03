using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_assignment.Class
{
    class Smart__Watch:Electronics
    {
        private bool waterResistance;
        public Smart__Watch(string model, bool waterResistance, string item, int quantity, double price, string manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand) : base(model,item, quantity, price, manufacturingDate, warrantyPeriodInMonths, batchNumber, brand)
        {
            WaterResistance = waterResistance;
            
        }

        public bool WaterResistance { get => waterResistance; set => waterResistance = value; }
    }
}
