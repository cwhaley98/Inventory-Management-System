using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christopher_Whaley_InventorySystem_PA
{
    public abstract class Part
    {
        public static int NextPartID = 1; // Static variable to keep track of the next PartID
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public Part(string name, int inStock, decimal price, int min, int max)
        {
            PartID = NextPartID++; // Assign the current value of NextPartID and then increment it
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
        public Part(int partID, string name, decimal price, int inStock, int min, int max)
        {
            PartID = partID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }
    }
}
