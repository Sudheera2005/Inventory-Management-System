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
        public Smart__Watch(bool waterResistance, string item, string id, int quantity, int price, DateTime manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand) : base(item, id, quantity, price, manufacturingDate, warrantyPeriodInMonths, batchNumber, brand)
        {
            WaterResistance = waterResistance;
            
        }

        public bool WaterResistance { get => waterResistance; set => waterResistance = value; }
    }
}
