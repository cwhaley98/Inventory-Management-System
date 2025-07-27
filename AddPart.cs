using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christopher_Whaley_InventorySystem_PA
{
    public partial class AddPart : Form
    {
        private bool isInHouse; // Flag to determine if the part is in-house or outsourced
        private Part part; // Variable to hold the part being edited or created

        private bool allowSave()
        {
            // Logic to determine if the part can be saved
            if (string.IsNullOrWhiteSpace(partNameTextBox.Text) ||
                    string.IsNullOrWhiteSpace(partPriceTextBox.Text) ||
                    string.IsNullOrWhiteSpace(partInventoryTextBox.Text) ||
                    string.IsNullOrWhiteSpace(partMinTextBox.Text) ||
                    string.IsNullOrWhiteSpace(partMaxTextBox.Text))
            {
                return false; // Return false if any required field is empty
            }
            // Validate numeric inputs
            if (!decimal.TryParse(partPriceTextBox.Text, out decimal price) || price < 0) return false;
            if (!int.TryParse(partInventoryTextBox.Text, out int inventory) || inventory < 0) return false;
            if (!int.TryParse(partMinTextBox.Text, out int min) || min < 0) return false;
            if (!int.TryParse(partMaxTextBox.Text, out int max) || max < 0) return false;

            // Validate min/max/inventory relationships
            if (min > max) return false;
            if (inventory < min || inventory > max) return false;

            // Validate machine ID/company name based on type
            if (isInHouse)
            {
                if (!int.TryParse(machineIDTextBox.Text, out int machineID) || machineID < 0) return false;
            }
            else // Outsourced
            {
                if (string.IsNullOrWhiteSpace(machineIDTextBox.Text)) return false;
            }

            return true; // All validations passed
        }
        public AddPart()
        {
            InitializeComponent();

            inHouseRadio.Checked = true; // Default to InHouse part
            machineIDText.Text = "Machine ID"; // Set label text for Machine ID
            partIDTextBox.ReadOnly = true; // Make Part ID read-only
            partIDTextBox.Text = (Part.NextPartID).ToString(); // Set Part ID to the next available ID
            saveBtn.Enabled = allowSave(); // Enable the save button based on validation

        }

        private void AddPart_Load(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (allowSave())
            {
                // Safely parse all values just before calling CreatePart
                string name = partNameTextBox.Text;
                decimal price = decimal.Parse(partPriceTextBox.Text); 
                int inStock = int.Parse(partInventoryTextBox.Text);   
                int min = int.Parse(partMinTextBox.Text);             
                int max = int.Parse(partMaxTextBox.Text);             

                // Pass these parsed values to CreatePart
                CreatePart(name, price, inStock, min, max); // New CreatePart signature

                MessageBox.Show("Part saved successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields correctly.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close the form without saving
        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Logic to handle when the InHouse radio button is checked
            isInHouse = true; // Set the flag for InHouse part
            machineIDText.Text = "Machine ID"; // Update label text for Machine ID
            machineIDTextBox.Visible = true; // Show the Machine ID text box

            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            // Logic to handle when the Outsourced radio button is checked
            isInHouse = false; // Set the flag for Outsourced part
            machineIDText.Text = "Company Name"; // Update label text for Company Name
            machineIDTextBox.Visible = true; // Show the Company Name text box

            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void partIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partNameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Logic to handle changes in the part name text box
            if (string.IsNullOrWhiteSpace(partNameTextBox.Text))
            {
               partNameTextBox.BackColor = Color.Salmon; // Highlight field with an error
            }
            else
            {
                partNameTextBox.BackColor = SystemColors.Window; // Reset field background color
            }

            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void partPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            // Logic to handle changes in the part price text box
            if (decimal.TryParse(partPriceTextBox.Text, out decimal price) && price >= 0)
            {
                partPriceTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                partPriceTextBox.BackColor = Color.Salmon; // Highlight the field with an error
            }

            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Logic to handle changes in the part inventory text box
            if (int.TryParse(partInventoryTextBox.Text, out int inventory) && inventory >= 0)
            {
                partInventoryTextBox.BackColor = SystemColors.Window;
            }
            else
            {
                partInventoryTextBox.BackColor = Color.Salmon; // Highlight the field with an error
            }

            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(partInventoryTextBox.Text, out int inventory) &&
            int.TryParse(partMinTextBox.Text, out int min) &&
            int.TryParse(partMaxTextBox.Text, out int max))
            {
                if (min < 0 || min > max || inventory < min)
                {
                    partMinTextBox.BackColor = Color.Salmon;
                }
                else
                {
                    partMinTextBox.BackColor = SystemColors.Window;
                }
            }
            else
            {
                partMinTextBox.BackColor = Color.Salmon;
            }
            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(partInventoryTextBox.Text, out int inventory) &&
           int.TryParse(partMinTextBox.Text, out int min) &&
           int.TryParse(partMaxTextBox.Text, out int max))
            {
                if (max < 0 || min > max || inventory > max)
                {
                    partMaxTextBox.BackColor = Color.Salmon;
                }
                else
                {
                    partMaxTextBox.BackColor = SystemColors.Window;
                }
            }
            else
            {
                partMaxTextBox.BackColor = Color.Salmon;
            }
            saveBtn.Enabled = allowSave(); // Enable or disable the save button based on validation
        }

        private void machineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isInHouse)
            {
                if (int.TryParse(machineIDTextBox.Text, out int machineID) && machineID >= 0)
                {
                    machineIDTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    machineIDTextBox.BackColor = Color.Salmon;
                }
            }
            else
            {
                if (!string.IsNullOrWhiteSpace(machineIDTextBox.Text))
                {
                    machineIDTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    machineIDTextBox.BackColor = Color.Salmon;
                }
            }
            saveBtn.Enabled = allowSave();
        }

        void CreatePart(string name, decimal price, int inStock, int min, int max)
        {
            if (isInHouse)
            {
                int machineID = int.Parse(machineIDTextBox.Text); // Guaranteed valid by allowSave()
                InHouse inHousePart = new InHouse(name, inStock, price, min, max, machineID);
                Inventory.AddPart(inHousePart);
            }
            else
            {
                string companyName = machineIDTextBox.Text; // Guaranteed valid by allowSave()
                Outsourced outsourcedPart = new Outsourced(name, inStock, price, min, max, companyName);
                Inventory.AddPart(outsourcedPart);
            }
        }

        private void partName_Click(object sender, EventArgs e)
        {

        }

        private void partPrice_Click(object sender, EventArgs e)
        {

        }

        private void partInventory_Click(object sender, EventArgs e)
        {

        }

        private void partMin_Click(object sender, EventArgs e)
        {

        }

        private void partMax_Click(object sender, EventArgs e)
        {

        }

        private void machineIDText_Click(object sender, EventArgs e)
        {

        }

        private void partID_Click(object sender, EventArgs e)
        {

        }

    }
}
