using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace suppliers___SDAM.Classes
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        // Optional constructor
        public Supplier() { }

        public Supplier(int id, string name, string phone, string email, string address)
        {
            SupplierID = id;
            SupplierName = name;
            Phone = phone;
            Email = email;
            Address = address;
        }

        // Optional: override ToString for dropdowns or logs
        public override string ToString()
        {
            return $"{SupplierID} - {SupplierName}";
        }
    }
}
