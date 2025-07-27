using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christopher_Whaley_InventorySystem_PA
{
    public class Inventory
    {

        //Properties to hold the lists of parts and products

        public static BindingList<Part> Parts { get; set; } = new BindingList<Part>();
        public static BindingList<Product> Products { get; set; } = new BindingList<Product>();
        public static bool partsCheck { get; set; }

        public static Part? SelectedPart { get; set; }
        public static int SelectedPartID { get; set; }
        public static int SelectedPartIdx { get; set; }

        public static Product? SelectedProduct { get; set; }
        public static int SelectedProductID { get; set; }
        public static int SelectedProductIdx { get; set; }

        internal static void Swap(Part part)
        {
            if (SelectedPartIdx >= 0 && SelectedPartIdx < Parts.Count)
            {
                Parts[SelectedPartIdx] = part; // Directly replace the part at the selected index
            }
            else
            {
                // Handle error, perhaps log or throw an exception if index is invalid
                System.Windows.Forms.MessageBox.Show("Error: Invalid index for part swap.");
            }
        }
        //Method to add a part to the inventory
        public static void AddPart(Part part)
        {
            if (part != null)
            {
                Parts.Add(part);
            }
            else
            {
                throw new ArgumentNullException(nameof(part), "Part cannot be null");
            }
        }

        //Method to delete a part by ID
        public static bool DeletePart(Part part)
        {
            if (part == null)
            {
                return false;
            }

            foreach (Part p in Parts)
            {
                if (p.PartID == part.PartID)
                {
                    Parts.Remove(p); // Remove the part if found
                    return true; // Return true if the part was successfully deleted
                }
            }
            return false; // Return false if the part was not found
        }

        //Method to look up a part by ID
        public static Part? LookupPart(int partID)
        {
            foreach (Part p in Parts)
            {
                if (p.PartID == partID)
                {
                    return p; // Return the part if found
                }
                // Removed the else block with MessageBox.Show as per the principle
            }
            return null; // Return null if the part is not found
        }

        //Method to update a part in the inventory
        public static void UpdatePart(int PartID, Part updatedPart)
        {
            if (updatedPart == null) // Check if the updatedPart object is null
            {
                throw new ArgumentNullException(nameof(updatedPart), "Updated part cannot be null."); // Throw exception if null
            }

            for (int i = 0; i < Parts.Count; i++)
            {
                if (Parts[i].PartID == PartID)
                {
                    Parts[i] = updatedPart; // Replace the old part with the updated one
                    return; // Exit the method after updating
                }
            }
            // If not found, throw an exception
            throw new ArgumentOutOfRangeException(nameof(PartID), $"Part with ID {PartID} not found for update."); // Throw exception if part not found
        }

        //Method to swap parts in the inventory

        public static void SwapPart(Part part, Part productPart)
        {
            if (SelectedProduct == null)
            {
                // Removed MessageBox.Show as per principle
                return;
            }

            int partID = part.PartID;
            int productPartID = productPart.PartID;

            string partName = part.Name;
            string productPartName = productPart.Name;

            decimal partPrice = part.Price;
            decimal productPartPrice = productPart.Price;

            int partInStock = part.InStock;
            int productPartInStock = productPart.InStock;

            int partMin = part.Min;
            int productPartMin = productPart.Min;

            int partMax = part.Max;
            int productPartMax = productPart.Max;

            if (partID == productPartID)
            {
                if ((partName == productPartName) || (partPrice == productPartPrice) || (partInStock == productPartInStock) || (partMin == productPartMin) || (partMax == productPartMax))
                {
                    SelectedProduct.AssociatedParts.Add(part);
                    SelectedProduct.AssociatedParts.Remove(productPart);
                    return; // Exit the method after swapping
                }
            }
        }

        //Method to add a product to the inventory

        public static void AddProduct(Product product)
        {
            if (product != null)
            {
                Products.Add(product); // Add the product to the Products list
            }
            else
            {
                throw new ArgumentNullException(nameof(product), "Product cannot be null");
            }
        }

        //Method to delete a product by ID
        public static bool DeleteProduct(Product product)
        {
            if (product == null) // Check if the product object passed is null
            {
                return false; // Return false if the product is null
            }

            int productID = product.ProductID; // Get the product ID from the product object
            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    Products.Remove(p); // Remove the product if found
                    return true; // Return true if the product was successfully deleted
                }
            }
            // Removed MessageBox.Show here, as per the principle
            return false; // Return false if the product was not found 
        }

        //Method to look up a product by ID
        public static Product? LookupProduct(Product product, int productID)
        {

            foreach (Product p in Products)
            {
                if (p.ProductID == productID)
                {
                    return p; // Return the product if found
                }
                // Removed the else block with MessageBox.Show as per the principle
            }
            return null; // Return null if the product is not found
        }

        //Method to update a product in the inventory

        public static void UpdateProduct(int ProductID, Product updatedProduct)
        {
            if (updatedProduct == null) // Check if the updatedProduct object is null
            {
                throw new ArgumentNullException(nameof(updatedProduct), "Updated product cannot be null."); // Throw exception if null
            }

            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i].ProductID == ProductID)
                {
                    Products[i] = updatedProduct; // Replace the old product with the updated one
                    return; // Exit the method after updating
                }
            }
            // If not found, throw an exception
            throw new ArgumentOutOfRangeException(nameof(ProductID), $"Product with ID {ProductID} not found for update."); // Throw exception if product not found
        }
    }
}
