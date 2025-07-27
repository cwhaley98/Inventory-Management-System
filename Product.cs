using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christopher_Whaley_InventorySystem_PA

{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>(); // Initialize the AssociatedParts list to prevent null reference exceptions
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        public static int NextProductID = 1; // Static variable to keep track of the next ProductID

        // Default constructor
        public Product(string name, int inStock, decimal price, int min, int max)
        {
            ProductID = NextProductID++; // Assign the current value of NextProductID and then increment it
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        // Constructor to initialize a Product with its properties
        public Product(int productID, string name, decimal price, int inStock, int min, int max)
        {
            ProductID = productID;
            Name = name;
            Price = price;
            InStock = inStock;
            Min = min;
            Max = max;
        }

        public void AddAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool RemoveAssociatedPart(Part part)
        {
            // Check if the part exists in the AssociatedParts list before attempting to remove it
            if (part == null || !AssociatedParts.Contains(part))
            {
                return false; // Return false if the part is null or not found
            }
            return AssociatedParts.Remove(part);
        }

        public Part LookupAssociatedPart(int partID)
        {
            var part = AssociatedParts.FirstOrDefault(p => p.PartID == partID);
            if (part != null) // Check if a part was found
            {
                return part;
            }
            else
            {
                throw new ArgumentException($"Part with ID {partID} not found in associated parts.");
            }
        }
    }
}
