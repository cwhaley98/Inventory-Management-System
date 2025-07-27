using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christopher_Whaley_InventorySystem_PA
{
    public partial class AddProduct : Form
    {
        private Product product;
        private BindingList<Part>? TempPartsList = new BindingList<Part>();

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

            return true;
        }

        public AddProduct()
        {
            InitializeComponent();

            product = new Product("New Product", 0, 0.00m, 0, 0);
            product.AssociatedParts = new BindingList<Part>();

            productCandidateGrid.DataSource = Inventory.Parts;

            TempPartsList = new BindingList<Part>();
            productAssocGrid.DataSource = TempPartsList;

            saveBtn.Enabled = allowSave();

        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            DataGridViewSelectedCellCollection selectedCells = productCandidateGrid.SelectedCells;
            productCandidateGrid.ClearSelection();
            productAssocGrid.ClearSelection();
        }

        private void SetproductCandidateGridIndex()
        {
            if (productCandidateGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = productCandidateGrid.SelectedRows[0];
                Inventory.SelectedPartIdx = row.Index;
            }
            else
            {
                Inventory.SelectedPartIdx = -1; // No row selected
            }
        }

        private void SetproductAssocGridIndex()
        {
            if (productAssocGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow row = productAssocGrid.SelectedRows[0];
                Inventory.SelectedPartIdx = row.Index;
            }
            else
            {
                Inventory.SelectedPartIdx = -1; // No row selected
            }
        }

        private void productCandidateGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetproductCandidateGridIndex();
            productCandidateGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            productCandidateGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void productAssocGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SetproductAssocGridIndex();
            productAssocGrid.DefaultCellStyle.SelectionBackColor = Color.LightBlue;
            productAssocGrid.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (allowSave())
            {
                // Safely parse all values just before calling CreatePart
                string name = productNameText.Text;
                decimal price = decimal.Parse(productPriceText.Text); 
                int inStock = int.Parse(productInvText.Text);   
                int min = int.Parse(productMinText.Text);             
                int max = int.Parse(productMaxText.Text);

                //Create a new Product instance with the provided values
                Product newProduct = new Product(name, inStock, price, min, max);
                newProduct.AssociatedParts = TempPartsList;

                Inventory.AddProduct(newProduct);

                MessageBox.Show("Product saved successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields correctly.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            SetproductAssocGridIndex();
            if (Inventory.SelectedPartIdx >= 0 && TempPartsList != null && Inventory.SelectedPartIdx < TempPartsList.Count)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this part from the product?", "Delete Part", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TempPartsList.RemoveAt(Inventory.SelectedPartIdx);
                }
            }
            else
            {
                MessageBox.Show("No part selected to delete.");
            }
            saveBtn.Enabled = allowSave(); // Re-evaluate save button state
        }

        private void addBtn_Click(Object sender, EventArgs e)
        {
            SetproductCandidateGridIndex();
            if (Inventory.SelectedPartIdx >= 0 && Inventory.SelectedPartIdx < Inventory.Parts.Count)
            {
                Part selectedPart = Inventory.Parts[Inventory.SelectedPartIdx];
                if (!product.AssociatedParts.Contains(selectedPart))
                {
                    product.AssociatedParts.Add(selectedPart);
                    TempPartsList.Add(selectedPart);
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

        private void productIDText_TextChanged(object sender, EventArgs e)
        {
            // This method is intentionally left empty.
            // The product ID is set in the constructor and does not need to be changed here.
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

        private void productName_Click(object sender, EventArgs e)
        {

        }

        private void productInvText_TextChanged(object sender, EventArgs e)
        {
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

        private void productInventory_Click(object sender, EventArgs e)
        {

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

        private void productPrice_Click(object sender, EventArgs e)
        {

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

        private void productMin_Click(object sender, EventArgs e)
        {

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

        private void productMax_Click(object sender, EventArgs e)
        {

        }

        private void productID_Click(object sender, EventArgs e)
        {
            // This method is intentionally left empty.
            // The product ID is set in the constructor and does not need to be changed here.
        }
    }
}
