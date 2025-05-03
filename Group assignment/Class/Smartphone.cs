using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_assignment.Class
{
    class Smartphone:Electronics
    {
        private string ram;
        private string storage;

        public Smartphone(string model, string ram, string storage, string item, int quantity, double price, string manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand) : base(model, item, quantity, price, manufacturingDate, warrantyPeriodInMonths, batchNumber, brand)
        {
            Ram = ram;
            Storage = storage;
        }

        public string Ram { get => ram; set => ram = value; }
        public string Storage { get => storage; set => storage = value; }
    }
}
