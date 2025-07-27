using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Christopher_Whaley_InventorySystem_PA
{
    public partial class ModifyProduct : Form
    {
        private Product product;
        // Change the declaration of tempPartsList to be nullable to resolve CS8618
        private BindingList<Part>? tempPartsList = new BindingList<Part>();

        public ModifyProduct()
        {
            InitializeComponent();

            this.product = Inventory.SelectedProduct;

            // Safeguard: If no product was selected (should be handled by MainScreen, but defensive)
            if (this.product == null)
            {
                MessageBox.Show("No product selected for modification. Closing form.");
                this.Close(); // Close the form immediately
                return;       // Exit the constructor
            }

            // Populate the text boxes with the selected product's data
            productIDText.Text = product.ProductID.ToString();
            productNameText.Text = product.Name; // Corrected from .ToString() if Name is already string
            productInvText.Text = product.InStock.ToString();
            productPriceText.Text = product.Price.ToString();
            productMaxText.Text = product.Max.ToString();
            productMinText.Text = product.Min.ToString();

            // Initialize tempPartsList with a COPY of the associated parts for potential cancellation
            // This allows changes to be reverted if the user clicks Cancel.
            tempPartsList = new BindingList<Part>(product.AssociatedParts.ToList());

            // Bind the candidate parts grid to all available parts in inventory
            productCandidateGrid.DataSource = Inventory.Parts;
            // Bind the associated parts grid to the product's actual AssociatedParts list
            productAssocGrid.DataSource = product.AssociatedParts;


            // Set initial state of the save button
            saveBtn.Enabled = allowSave();

            // Make Product ID read-only
            productIDText.ReadOnly = true;
        }

        private bool allowSave()
        {
            // Ensure all numeric parses are successful and values are non-negative
            if (!int.TryParse(productInvText.Text, out int inv) || inv < 0) return false;
            if (!decimal.TryParse(productPriceText.Text, out decimal price) || price < 0) return false;
            if (!int.TryParse(productMaxText.Text, out int max) || max < 0) return false;
            if (!int.TryParse(productMinText.Text, out int min) || min < 0) return false;

            // Check for empty name
            if (string.IsNullOrWhiteSpace(productNameText.Text)) return false;

            // Inventory between min and max
            if (inv < min || inv > max) return false;
            if (min > max) return false; // Also ensure min is not greater than max

            // Additional check if needed: Product must have at least one associated part
            // if (product.AssociatedParts.Count == 0) return false;


            return true;
        }

        private void ModifyProduct_Load(object sender, EventArgs e)
        {

            DataGridViewSelectedCellCollection selectedCells = productCandidateGrid.SelectedCells;
            productCandidateGrid.ClearSelection();
            productAssocGrid.ClearSelection();

        }

        private void SetProductCandidateGridIndex()
        {
            if (productCandidateGrid.SelectedRows.Count > 0)
            {
                Inventory.SelectedPartIdx = productCandidateGrid.SelectedRows[0].Index;
            }
            else
            {
                Inventory.SelectedPartIdx = -1;
            }
        }

        private void SetProductAssocGridIndex()
        {
            if (productAssocGrid.SelectedRows.Count > 0)
            {
                Inventory.SelectedPartIdx = productAssocGrid.SelectedRows[0].Index;
            }
            else
            {
                Inventory.SelectedPartIdx = -1;
            }
        }

        private void ModifySelectedProduct(string name, int inStock, decimal price, int min, int max)
        {
            // Update the properties of the existing 'product' object with parsed values
            product.Name = name;
            product.InStock = inStock;
            product.Price = price;
            product.Max = max;
            product.Min = min;
        }

        private void productCandidateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetProductCandidateGridIndex();
            productCandidateGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            productCandidateGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void productAssocGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetProductAssocGridIndex();
            productAssocGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            productAssocGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (allowSave()) // Validation check
            {
                // Safely parse values (guaranteed to be valid by allowSave())
                string name = productNameText.Text;
                int inStock = int.Parse(productInvText.Text);
                decimal price = decimal.Parse(productPriceText.Text);
                int min = int.Parse(productMinText.Text);
                int max = int.Parse(productMaxText.Text);

                // Call the method to update the product with parsed values
                ModifySelectedProduct(name, inStock, price, min, max);

                MessageBox.Show("Product updated successfully!");
                this.Close(); // Close the form after saving
            }
            else
            {
                MessageBox.Show("Please fill out all fields correctly.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Revert associated parts to the original state if the user cancels
            if (product != null && tempPartsList != null)
            {
                product.AssociatedParts.Clear(); // Clear current associated parts
                foreach (var part in tempPartsList)
                {
                    product.AssociatedParts.Add(part); // Add back the original parts
                }
            }
            this.Close(); // Close the form without saving
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SetProductAssocGridIndex();
            if (Inventory.SelectedPartIdx >= 0 && product.AssociatedParts.Any() && Inventory.SelectedPartIdx < product.AssociatedParts.Count)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part from the product?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    // Remove directly from product.AssociatedParts as that's what's bound
                    product.AssociatedParts.RemoveAt(Inventory.SelectedPartIdx);
                }
            }
            else
            {
                MessageBox.Show("No part selected to delete.");
            }
            saveBtn.Enabled = allowSave(); // Re-evaluate save button state after deletion
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            SetProductCandidateGridIndex();
            if (Inventory.SelectedPartIdx >= 0)
            {
                Inventory.SelectedPart = Inventory.Parts[Inventory.SelectedPartIdx];
                if (!product.AssociatedParts.Contains(Inventory.SelectedPart))
                {
                    product.AssociatedParts.Add(Inventory.SelectedPart);
                }
                else
                {
                    MessageBox.Show("This part is already associated with the product.");
                }
            }
            else
            {
                MessageBox.Show("No part selected to add.");
            }
            saveBtn.Enabled = allowSave();
        }

        private void productSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchParts_Click(object sender, EventArgs e)
        {
            string searchText = productSearch.Text.ToLower();
            BindingList<Part> filteredParts = new BindingList<Part>();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                productCandidateGrid.DataSource = Inventory.Parts; // Show all parts if search box is empty
            }
            else
            {
                foreach (Part part in Inventory.Parts)
                {
                    if (part.Name.ToLower().Contains(searchText) || part.PartID.ToString().Contains(searchText))
                    {
                        filteredParts.Add(part);
                    }
                }
                productCandidateGrid.DataSource = filteredParts;

                if (filteredParts.Count == 0)
                {
                    MessageBox.Show("No parts found matching the search criteria.");
                }
            }
        }

        private void productID_Click(object sender, EventArgs e)
        {

        }

        private void productName_Click(object sender, EventArgs e)
        {

        }

        private void productPrice_Click(object sender, EventArgs e)
        {

        }

        private void productInventory_Click(object sender, EventArgs e)
        {

        }

        private void productMax_Click(object sender, EventArgs e)
        {

        }

        private void productMin_Click(object sender, EventArgs e)
        {

        }

        private void productNameText_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(productNameText.Text))
            {
                productNameText.BackColor = Color.Salmon;
            }
            else
            {
                productNameText.BackColor = SystemColors.Window;
            }
            saveBtn.Enabled = allowSave();
        }

        private void productInvText_TextChanged(object sender, EventArgs e)
        {
            // Use TryParse for direct validation in TextChanged
            if (int.TryParse(productInvText.Text, out int inventory) && inventory >= 0)
            {
                // Also parse min/max for real-time validation feedback on inventory range
                if (int.TryParse(productMinText.Text, out int min) && int.TryParse(productMaxText.Text, out int max))
                {
                    if (inventory >= min && inventory <= max)
                    {
                        productInvText.BackColor = SystemColors.Window;
                    }
                    else
                    {
                        productInvText.BackColor = Color.Salmon; // Inventory out of range
                    }
                }
                else
                {
                    productInvText.BackColor = SystemColors.Window; // Valid number, but min/max might be invalid or empty
                }
            }
            else
            {
                productInvText.BackColor = Color.Salmon; // Invalid non-numeric input or negative
            }
            saveBtn.Enabled = allowSave();
        }

        private void productPriceText_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(productPriceText.Text, out decimal price) && price >= 0)
            {
                productPriceText.BackColor = SystemColors.Window;
            }
            else
            {
                productPriceText.BackColor = Color.Salmon;
            }
            saveBtn.Enabled = allowSave();
        }

        private void productMaxText_TextChanged(object sender, EventArgs e)
        {
            // Use TryParse for all relevant fields for comprehensive validation feedback
            if (int.TryParse(productInvText.Text, out int inventory) &&
                int.TryParse(productMinText.Text, out int min) &&
                int.TryParse(productMaxText.Text, out int max))
            {
                if (max < 0 || min > max || inventory > max) // Check max against 0, min, and inventory
                {
                    productMaxText.BackColor = Color.Salmon;
                }
                else
                {
                    productMaxText.BackColor = SystemColors.Window;
                }
            }
            else
            {
                productMaxText.BackColor = Color.Salmon; // Invalid input or related fields unparseable
            }
            saveBtn.Enabled = allowSave();
        }

        private void productMinText_TextChanged(object sender, EventArgs e)
        {
            // Use TryParse for all relevant fields for comprehensive validation feedback
            if (int.TryParse(productInvText.Text, out int inventory) &&
                int.TryParse(productMinText.Text, out int min) &&
                int.TryParse(productMaxText.Text, out int max))
            {
                if (min < 0 || min > max || inventory < min) // Check min against 0, max, and inventory
                {
                    productMinText.BackColor = Color.Salmon;
                }
                else
                {
                    productMinText.BackColor = SystemColors.Window;
                }
            }
            else
            {
                productMinText.BackColor = Color.Salmon; // Invalid input or related fields unparseable
            }
            saveBtn.Enabled = allowSave();
        }

        private void productIDText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

