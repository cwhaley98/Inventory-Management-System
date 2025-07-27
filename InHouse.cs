using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christopher_Whaley_InventorySystem_PA
{
    public class InHouse : Part
    {
        public int MachineID { get; set; } // Property to hold the Machine ID

        // Default constructor
        public InHouse(string name, int inStock, decimal price, int min, int max, int machineID) : base(name, inStock, price, min, max)
        {
           
            MachineID = machineID; // Initialize MachineID
        }

        public InHouse(int partID, string name, decimal price, int inStock, int min, int max, int machineID) : base(partID, name, price, inStock, min, max)
        {
            MachineID = machineID; // Initialize MachineID
        }

    }
}
