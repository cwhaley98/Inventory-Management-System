using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christopher_Whaley_InventorySystem_PA
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; } // Property to hold the company name
        // Constructor to initialize an Outsourced part with its properties
        public Outsourced(string name, int inStock, decimal price, int min, int max, string companyName)
            : base(name, inStock, price, min, max)
        {
            CompanyName = companyName; // Assign the company name
        }
        // Constructor to initialize an Outsourced part with its properties including PartID
        public Outsourced(int partID, string name, decimal price, int inStock, int min, int max, string companyName)
            : base(partID, name, price, inStock, min, max)
        {
            CompanyName = companyName; // Assign the company name
        }

    }
}
