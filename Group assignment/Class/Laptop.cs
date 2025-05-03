using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_assignment.Class
{
    class Laptop:Electronics
    {
        private string ram;
        private string gpu;
        private string screenSize;
       
        public Laptop(string model,string ram, string gpu,string screenSize, string item, int quantity, double price, string manufacturingDate, int warrantyPeriodInMonths, string batchNumber, string brand) : base(model, item, quantity, price, manufacturingDate, warrantyPeriodInMonths, batchNumber, brand)
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
