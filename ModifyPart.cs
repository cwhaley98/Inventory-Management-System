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
    public partial class ModifyPart : Form
    {
        private bool isInHouse; // Flag to determine if the part is InHouse or Outsourced

        private Part part { get; set; } // Property to hold the part being modified, now nullable

        private bool allowSave()
        {
            // Check for empty fields
            if (string.IsNullOrWhiteSpace(partNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(partPriceTextBox.Text) ||
                string.IsNullOrWhiteSpace(partInventoryTextBox.Text) ||
                string.IsNullOrWhiteSpace(partMinTextBox.Text) ||
                string.IsNullOrWhiteSpace(partMaxTextBox.Text))
            {
                return false;
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

        public ModifyPart()
        {
            InitializeComponent();

            this.part = Inventory.SelectedPart; // Get the selected part from the inventory

            if (this.part == null)
            {
                MessageBox.Show("No part selected for modification.");
                this.Close(); // Close the form early if no part is selected
                return;
            }

            // Initialize the form or perform any necessary setup when the form loads
            if (part != null)
            {
                // Populate the form fields with the selected part's data
                partIDTextBox.Text = part.PartID.ToString();
                partNameTextBox.Text = part.Name;
                partPriceTextBox.Text = part.Price.ToString();
                partInventoryTextBox.Text = part.InStock.ToString();
                partMinTextBox.Text = part.Min.ToString();
                partMaxTextBox.Text = part.Max.ToString();


                if (part is InHouse)
                {
                    InHouse i = (InHouse)part;
                    machineIDTextBox.Text = i.MachineID.ToString();
                    isInHouse = true;
                    inHouseRadio.Checked = true;
                    machineIDText.Text = "Machine ID"; // Set label text correctly

                }
                else
                {
                    Outsourced o = (Outsourced)part;
                    machineIDTextBox.Text = o.CompanyName; // FIX: Set the text of the TEXTBOX, not the LABEL
                    isInHouse = false;
                    outsourcedRadio.Checked = true;
                    machineIDText.Text = "Company Name"; // Set label text correctly
                }

                saveBtn.Enabled = allowSave(); // Enable the save button based on initial validation
            }
        }

        private void ModifyPart_Load(object sender, EventArgs e)
        {
            // Any additional setup when the form loads can be done here
        }

        private void partIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void inHouseRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (inHouseRadio.Checked)
            {
                isInHouse = true; // Set the flag for InHouse part
                machineIDText.Text = "Machine ID"; // Update label text
                machineIDTextBox.Visible = true; // Show Machine ID text box
            }

            saveBtn.Enabled = allowSave(); // Enable the save button when InHouse is selected
        }

        private void outsourcedRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (outsourcedRadio.Checked)
            {
                isInHouse = false; // Set the flag for Outsourced part
                machineIDText.Text = "Company Name"; // Update label text
                machineIDTextBox.Visible = true; // Show Company Name text box
            }

            saveBtn.Enabled = allowSave(); // Enable the save button when Outsourced is selected
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (allowSave()) // This still checks all validations
            {
                // Safely parse all values just before calling UpdatePart
                // This ensures we have valid numbers at the point of update
                string name = partNameTextBox.Text;
                decimal price = decimal.Parse(partPriceTextBox.Text); // Parse, now guaranteed valid by allowSave()
                int inStock = int.Parse(partInventoryTextBox.Text);   // Parse, now guaranteed valid by allowSave()
                int min = int.Parse(partMinTextBox.Text);             // Parse, now guaranteed valid by allowSave()
                int max = int.Parse(partMaxTextBox.Text);             // Parse, now guaranteed valid by allowSave()

                // Pass these parsed values to UpdatePart
                UpdatePart(name, price, inStock, min, max); // New UpdatePart signature

                MessageBox.Show("Part updated successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Please fill in all required fields correctly.");
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the form without saving changes
            this.Close();
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
            // Handle changes to the Part Price text box
            if (decimal.TryParse(partPriceTextBox.Text, out decimal price) && price >= 0)
            {
                partPriceTextBox.BackColor = SystemColors.Window; // Reset field background color
            }
            else
            {
                partPriceTextBox.BackColor = Color.Salmon; // Highlight the field with an error
            }
            saveBtn.Enabled = allowSave(); // Enable the save button when the part price is changed

        }

        private void partInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Handle changes to the Part Inventory text box
            if (int.TryParse(partInventoryTextBox.Text, out int inventory) && inventory >= 0)
            {
                partInventoryTextBox.BackColor = SystemColors.Window; // Set the field to partInventoryTextBox
            }
            else
            {
                partInventoryTextBox.BackColor = Color.Salmon; // Set the field to partInventoryTextBox
            }
            saveBtn.Enabled = allowSave(); // Enable the save button when the part inventory is changed
        }

        private void partMinTextBox_TextChanged(object sender, EventArgs e)
        {
            // Safely parse all three relevant values at once
            if (int.TryParse(partInventoryTextBox.Text, out int inventory) &&
                int.TryParse(partMinTextBox.Text, out int min) &&
                int.TryParse(partMaxTextBox.Text, out int max))
            {
                // Now that we have valid integers, perform the logical checks
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
                // If any parse failed, the input is invalid
                partMinTextBox.BackColor = Color.Salmon;
            }
            saveBtn.Enabled = allowSave(); // Enable the save button when the part minimum is changed
        }

        private void partMaxTextBox_TextChanged(object sender, EventArgs e)
        {
            // Safely parse all three relevant values at once
            if (int.TryParse(partInventoryTextBox.Text, out int inventory) &&
                int.TryParse(partMinTextBox.Text, out int min) &&
                int.TryParse(partMaxTextBox.Text, out int max))
            {
                // Now that we have valid integers, perform the logical checks
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
                // If any parse failed, the input is invalid
                partMaxTextBox.BackColor = Color.Salmon;
            }
            saveBtn.Enabled = allowSave(); // Enable the save button when the part maximum is changed
        }

        void UpdatePart(string name, decimal price, int inStock, int min, int max)
        {
            // Update the properties of the existing 'part' object
            part.Name = name;
            part.InStock = inStock;
            part.Price = price;
            part.Min = min;
            part.Max = max;

            // Safely parse MachineID/CompanyName if needed
            if (isInHouse)
            {
                int machineID = int.Parse(machineIDTextBox.Text); // Guaranteed valid by allowSave()
                if (!(part is InHouse))
                {
                    InHouse newInHousePart = new InHouse(part.PartID, name, price, inStock, min, max, machineID);
                    Inventory.Swap(newInHousePart);
                }
                else
                {
                    ((InHouse)part).MachineID = machineID;
                }
            }
            else // Outsourced
            {
                string companyName = machineIDTextBox.Text; // Guaranteed valid by allowSave()
                if (!(part is Outsourced))
                {
                    Outsourced newOutsourcedPart = new Outsourced(part.PartID, name, price, inStock, min, max, companyName);
                    Inventory.Swap(newOutsourcedPart);
                }
                else
                {
                    ((Outsourced)part).CompanyName = companyName;
                }
            }
        }

        private void partID_Click(object sender, EventArgs e)
        {

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

        private void machineIDTextBox_TextChanged(object sender, EventArgs e)
        {
            if (isInHouse)
            {
                // Use TryParse for machine ID
                if (int.TryParse(machineIDTextBox.Text, out int machineID) && machineID >= 0)
                {
                    machineIDTextBox.BackColor = SystemColors.Window;
                }
                else
                {
                    machineIDTextBox.BackColor = Color.Salmon;
                }
            }
            else // Outsourced
            {
                // Use IsNullOrWhiteSpace for company name string
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

        private void ModifyPartLabel_Click(object sender, EventArgs e)
        {
            // Handle click event for the Modify Part label if needed

        }
    }
}
