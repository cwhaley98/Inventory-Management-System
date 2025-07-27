using System.ComponentModel;
using System.Data;
using System.Drawing.Text;

namespace Christopher_Whaley_InventorySystem_PA
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            // Initialize the Inventory object
            Inventory inventory = new Inventory();

            // Set the DataSource for the PartsDataGridView to the Parts list in Inventory
            Inventory.SelectedPartIdx = -1; // Initialize selected part index
            PartsGridView.DataSource = Inventory.Parts;

            // Set the DataSource for the ProductsDataGridView to the Products list in Inventory
            Inventory.SelectedProductIdx = -1; // Initialize selected product index
            ProductGridView.DataSource = Inventory.Products;


            //Default invenotry parts and products
            if (!Inventory.Parts.Any() && !Inventory.Products.Any())
            {
                InitializeDefaultInventory();
            }
        }

        public static void InitializeDefaultInventory()
        {
            // Add parts to the inventory
            Inventory.AddPart(new InHouse("Wheel", 15, 12.11m, 5, 25, 110));
            Inventory.AddPart(new InHouse("Pedal", 11, 8.22m, 5, 25, 120));
            Inventory.AddPart(new Outsourced("Chain", 12, 8.33m, 5, 25, "BikeParts Co."));
            Inventory.AddPart(new Outsourced("Seat", 8, 4.55m, 2, 15, "Comfort Seats Inc."));
            // Add products to the inventory
            Inventory.AddProduct(new Product("Red Bicycle", 20, 10.99m, 1, 25));
            Inventory.AddProduct(new Product("Yellow Bicycle", 15, 9.66m, 1, 20));
            Inventory.AddProduct(new Product("Blue Bicycle", 12, 12.77m, 1, 25));
            // Associate parts with products
            AssociatePartsWithProducts();
        }
        public static void AssociatePartsWithProducts()
        {
            // Associate parts with products
            Inventory.Products[0].AddAssociatedPart(Inventory.Parts[0]); // Red Bicycle with Wheel
            Inventory.Products[0].AddAssociatedPart(Inventory.Parts[1]); // Red Bicycle with Pedal
            Inventory.Products[0].AddAssociatedPart(Inventory.Parts[2]); // Red Bicycle with Chain
            Inventory.Products[0].AddAssociatedPart(Inventory.Parts[3]); // Red Bicycle with Seat
            Inventory.Products[1].AddAssociatedPart(Inventory.Parts[0]); // Yellow Bicycle with Wheel
            Inventory.Products[1].AddAssociatedPart(Inventory.Parts[1]); // Yellow Bicycle with Pedal
            Inventory.Products[1].AddAssociatedPart(Inventory.Parts[2]); // Yellow Bicycle with Chain
            Inventory.Products[1].AddAssociatedPart(Inventory.Parts[3]); // Yellow Bicycle with Seat
            Inventory.Products[2].AddAssociatedPart(Inventory.Parts[0]); // Blue Bicycle with Wheel
            Inventory.Products[2].AddAssociatedPart(Inventory.Parts[1]); // Blue Bicycle with Pedal
            Inventory.Products[2].AddAssociatedPart(Inventory.Parts[2]); // Blue Bicycle with Chain
            Inventory.Products[2].AddAssociatedPart(Inventory.Parts[3]); // Blue Bicycle with Seat

        }
        private void MainScreen_Load(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = PartsGridView.SelectedCells;
            PartsGridView.ClearSelection();
            ProductGridView.ClearSelection();
        }

        private void PartsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSelectedPartIdx();
            // Handle cell content click event for PartsGridView if needed
            PartsGridView.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            PartsGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void ProductGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetSelectedProductIdx();
            // Handle cell content click event for ProductGridView if needed
            ProductGridView.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            ProductGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            // Close the application when the Exit button is clicked
            Application.Exit();
        }

        private void SetSelectedPartIdx()
        {
            // Set the selected part index based on the selected row in PartsGridView
            if (PartsGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = PartsGridView.SelectedRows[0];
                Inventory.SelectedPartIdx = row.Index;
            }
            else
            {
                Inventory.SelectedPartIdx = -1;
            }
        }

        private void SetSelectedProductIdx()
        {
            // Set the selected product index based on the selected row in ProductGridView
            if (ProductGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = ProductGridView.SelectedRows[0];
                Inventory.SelectedProductIdx = row.Index;
            }
            else
            {
                Inventory.SelectedProductIdx = -1;
            }
        }

        private void addPartBtn_Click(object sender, EventArgs e)
        {
            // Open the AddPartForm to add a new part
            Inventory.SelectedPart = null; // Use default instead of null for non-nullable reference type
            AddPart addPartForm = new AddPart();
            addPartForm.ShowDialog();

            // Refresh grid after dialog closes
            PartsGridView.DataSource = null;
            PartsGridView.DataSource = Inventory.Parts;
            PartsGridView.ClearSelection();
            Inventory.SelectedPartIdx = -1;
        }

        private void modifyPartBtn_Click(object sender, EventArgs e)
        {
            // Check if a part is selected in the PartsGridView before attempting to modify.
            // Inventory.SelectedPartIdx is set by the CellContentClick event of PartsGridView.
            SetSelectedPartIdx(); // Ensure the selected part index is set before proceeding
            if (PartsGridView.SelectedRows.Count > 0 && Inventory.SelectedPartIdx >= 0)
            {
                // Set the selected part for modification.
                Inventory.SelectedPart = Inventory.Parts[Inventory.SelectedPartIdx];

                // Create the ModifyPart form instance.
                if (Inventory.SelectedPart != null)
                {
                    ModifyPart modifyPartForm = new ModifyPart();
                    modifyPartForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No part selected for modification.");
                }

                // After modifyPartForm closes, control returns here.
                // Refresh the DataGridView to reflect any potential changes.
                PartsGridView.DataSource = null;
                PartsGridView.DataSource = Inventory.Parts; // Rebind to refresh

                // Clear selection for a clean UI after the dialog closes.
                PartsGridView.ClearSelection();
                Inventory.SelectedPartIdx = -1; // Reset the selected index
            }
            else
            {
                MessageBox.Show("Please select a part to modify.");
            }
        }

        private void deletePartBtn_Click(object sender, EventArgs e)
        {
            // Check if a part is selected before deleting
            if (Inventory.SelectedPartIdx >= 0 && Inventory.SelectedPartIdx < Inventory.Parts.Count)
            {
                // Get the selected part
                Part selectedPart = Inventory.Parts[Inventory.SelectedPartIdx];

                // *** Check if the part is associated with any product ***
                bool isAssociated = false;
                foreach (Product p in Inventory.Products)
                {
                    if (p.AssociatedParts.Any(ap => ap.PartID == selectedPart.PartID))
                    {
                        isAssociated = true;
                        break; // Found an association, no need to check further
                    }
                }

                if (isAssociated)
                {
                    MessageBox.Show("Cannot delete part: It is associated with one or more products. Please remove the part from all products first.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop deletion
                }
                // Confirm deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the part: {selectedPart.Name}? This cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (Inventory.DeletePart(selectedPart))
                    {
                        MessageBox.Show("Part deleted successfully.");
                        // Refresh grid after deletion
                        PartsGridView.DataSource = null;
                        PartsGridView.DataSource = Inventory.Parts;
                        PartsGridView.ClearSelection(); // Clear selection after deletion
                        Inventory.SelectedPartIdx = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete part. Part not found in inventory.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a part to delete.");
            }
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            // Open the AddProductForm to add a new product
            AddProduct addProductForm = new AddProduct();
            addProductForm.ShowDialog();

            // Refresh grid after dialog closes
            ProductGridView.DataSource = null;
            ProductGridView.DataSource = Inventory.Products;
            ProductGridView.ClearSelection();
            Inventory.SelectedProductIdx = -1;
        }

        private void modifyProductBtn_Click(object sender, EventArgs e)
        {
            // Check if a product is selected before modifying
            SetSelectedProductIdx(); // Ensure the selected product index is set before proceeding
            if (Inventory.SelectedProductIdx >= 0 && Inventory.SelectedProductIdx < Inventory.Products.Count)
            {
                // Open the ModifyProductForm to modify the selected product
                Inventory.SelectedProduct = Inventory.Products[Inventory.SelectedProductIdx]; // Set the selected product for modification
                ModifyProduct modifyProductForm = new ModifyProduct();
                modifyProductForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a product to modify.");
            }

            // After modifyProductForm closes, refresh the DataGridView
            ProductGridView.DataSource = null;
            ProductGridView.DataSource = Inventory.Products;

            // Clear selection for a clean UI
            ProductGridView.ClearSelection();
            Inventory.SelectedProductIdx = -1;

        }

        private void deleteProductBtn_Click(object sender, EventArgs e)
        {
            // Check if a product is selected before deleting
            if (Inventory.SelectedProductIdx >= 0 && Inventory.SelectedProductIdx < Inventory.Products.Count)
            {
                // Get the selected product
                Product selectedProduct = Inventory.Products[Inventory.SelectedProductIdx];

                // *** Check if the product has associated parts ***
                if (selectedProduct.AssociatedParts.Any()) // Using .Any() from System.Linq
                {
                    MessageBox.Show("Cannot delete product: It has associated parts. Please remove all associated parts from this product first.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Stop deletion
                }
                // Confirm deletion
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the product: {selectedProduct.Name}? This cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (Inventory.DeleteProduct(selectedProduct))
                    {
                        MessageBox.Show("Product deleted successfully.");
                        // Refresh grid after deletion
                        ProductGridView.DataSource = null;
                        ProductGridView.DataSource = Inventory.Products;
                        ProductGridView.ClearSelection(); // Clear selection after deletion
                        Inventory.SelectedProductIdx = -1;
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete product. Product not found in inventory.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a product to delete.");
            }
        }

        private void searchPartsBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = partsSearchTxtBox.Text.ToLower();
            BindingList<Part> filteredParts = new BindingList<Part>();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                PartsGridView.DataSource = Inventory.Parts; // Show all parts if search box is empty
            }
            else
            {
                foreach (Part part in Inventory.Parts)
                {
                    if (part.Name.ToLower().Contains(searchTerm) || part.PartID.ToString().Contains(searchTerm))
                    {
                        filteredParts.Add(part);
                    }
                }

                PartsGridView.DataSource = filteredParts; // Update the data source with filtered results

                if (filteredParts.Count == 0)
                {
                    MessageBox.Show("No parts found matching the search criteria.");
                }
            }
        }

        private void partsSearchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchProductsBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = productSearchTxtBox.Text.ToLower();
            BindingList<Product> filteredProducts = new BindingList<Product>();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                ProductGridView.DataSource = Inventory.Products; // Show all products if search box is empty
            }
            else
            {
                foreach (Product product in Inventory.Products)
                {
                    if (product.Name.ToLower().Contains(searchTerm) || product.ProductID.ToString().Contains(searchTerm))
                    {
                        filteredProducts.Add(product);
                    }
                }

                ProductGridView.DataSource = filteredProducts; // Update the data source with filtered results

                if (filteredProducts.Count == 0)
                {
                    MessageBox.Show("No products found matching the search criteria.");
                }
            }
        }

        private void productSearchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
