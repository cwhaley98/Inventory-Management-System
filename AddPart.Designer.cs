namespace Christopher_Whaley_InventorySystem_PA
{
    partial class AddPart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cancelBtn = new Button();
            saveBtn = new Button();
            machineIDTextBox = new TextBox();
            machineIDText = new TextBox();
            partMinTextBox = new TextBox();
            partMin = new TextBox();
            partMaxTextBox = new TextBox();
            partPriceTextBox = new TextBox();
            partInventoryTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partIDTextBox = new TextBox();
            partMax = new TextBox();
            partPrice = new TextBox();
            partInventory = new TextBox();
            partName = new TextBox();
            partID = new TextBox();
            outsourcedRadio = new RadioButton();
            inHouseRadio = new RadioButton();
            addPartTitle = new TextBox();
            SuspendLayout();
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ControlLightLight;
            cancelBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(368, 408);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(74, 33);
            cancelBtn.TabIndex = 65;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ControlLightLight;
            saveBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ControlText;
            saveBtn.Location = new Point(268, 408);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(74, 33);
            saveBtn.TabIndex = 64;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // machineIDTextBox
            // 
            machineIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            machineIDTextBox.Location = new Point(202, 326);
            machineIDTextBox.Name = "machineIDTextBox";
            machineIDTextBox.Size = new Size(198, 23);
            machineIDTextBox.TabIndex = 63;
            machineIDTextBox.TextChanged += machineIDTextBox_TextChanged;
            // 
            // machineIDText
            // 
            machineIDText.BackColor = SystemColors.Control;
            machineIDText.BorderStyle = BorderStyle.None;
            machineIDText.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineIDText.Location = new Point(63, 329);
            machineIDText.Name = "machineIDText";
            machineIDText.Size = new Size(133, 20);
            machineIDText.TabIndex = 62;
            machineIDText.Text = "Machine ID";
            machineIDText.Click += machineIDText_Click;
            // 
            // partMinTextBox
            // 
            partMinTextBox.BorderStyle = BorderStyle.FixedSingle;
            partMinTextBox.Location = new Point(302, 279);
            partMinTextBox.Name = "partMinTextBox";
            partMinTextBox.Size = new Size(89, 23);
            partMinTextBox.TabIndex = 61;
            partMinTextBox.TextChanged += partMinTextBox_TextChanged;
            // 
            // partMin
            // 
            partMin.BackColor = SystemColors.Control;
            partMin.BorderStyle = BorderStyle.None;
            partMin.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partMin.Location = new Point(261, 282);
            partMin.Name = "partMin";
            partMin.Size = new Size(35, 20);
            partMin.TabIndex = 60;
            partMin.Text = "Min";
            partMin.Click += partMin_Click;
            // 
            // partMaxTextBox
            // 
            partMaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            partMaxTextBox.Location = new Point(141, 279);
            partMaxTextBox.Name = "partMaxTextBox";
            partMaxTextBox.Size = new Size(89, 23);
            partMaxTextBox.TabIndex = 59;
            // 
            // partPriceTextBox
            // 
            partPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            partPriceTextBox.Location = new Point(161, 234);
            partPriceTextBox.Name = "partPriceTextBox";
            partPriceTextBox.Size = new Size(211, 23);
            partPriceTextBox.TabIndex = 58;
            partPriceTextBox.TextChanged += partPriceTextBox_TextChanged;
            // 
            // partInventoryTextBox
            // 
            partInventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            partInventoryTextBox.Location = new Point(161, 181);
            partInventoryTextBox.Name = "partInventoryTextBox";
            partInventoryTextBox.Size = new Size(211, 23);
            partInventoryTextBox.TabIndex = 57;
            partInventoryTextBox.TextChanged += partInventoryTextBox_TextChanged;
            // 
            // partNameTextBox
            // 
            partNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            partNameTextBox.Location = new Point(161, 134);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(211, 23);
            partNameTextBox.TabIndex = 56;
            partNameTextBox.TextChanged += partNameTextBox_TextChanged;
            // 
            // partIDTextBox
            // 
            partIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            partIDTextBox.Location = new Point(161, 87);
            partIDTextBox.Name = "partIDTextBox";
            partIDTextBox.Size = new Size(211, 23);
            partIDTextBox.TabIndex = 55;
            partIDTextBox.TextChanged += partIDTextBox_TextChanged;
            // 
            // partMax
            // 
            partMax.BackColor = SystemColors.Control;
            partMax.BorderStyle = BorderStyle.None;
            partMax.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partMax.Location = new Point(63, 282);
            partMax.Name = "partMax";
            partMax.Size = new Size(64, 20);
            partMax.TabIndex = 54;
            partMax.Text = "Max";
            partMax.Click += partMax_Click;
            // 
            // partPrice
            // 
            partPrice.BackColor = SystemColors.Control;
            partPrice.BorderStyle = BorderStyle.None;
            partPrice.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partPrice.Location = new Point(63, 232);
            partPrice.Name = "partPrice";
            partPrice.Size = new Size(84, 20);
            partPrice.TabIndex = 53;
            partPrice.Text = "Price / Cost";
            partPrice.Click += partPrice_Click;
            // 
            // partInventory
            // 
            partInventory.BackColor = SystemColors.Control;
            partInventory.BorderStyle = BorderStyle.None;
            partInventory.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partInventory.Location = new Point(63, 179);
            partInventory.Name = "partInventory";
            partInventory.Size = new Size(64, 20);
            partInventory.TabIndex = 52;
            partInventory.Text = "Inventory";
            partInventory.Click += partInventory_Click;
            // 
            // partName
            // 
            partName.BackColor = SystemColors.Control;
            partName.BorderStyle = BorderStyle.None;
            partName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partName.ForeColor = SystemColors.WindowText;
            partName.Location = new Point(63, 132);
            partName.Name = "partName";
            partName.Size = new Size(64, 20);
            partName.TabIndex = 51;
            partName.Text = "Name";
            partName.Click += partName_Click;
            // 
            // partID
            // 
            partID.BackColor = SystemColors.Control;
            partID.BorderStyle = BorderStyle.None;
            partID.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partID.Location = new Point(63, 85);
            partID.Name = "partID";
            partID.Size = new Size(27, 20);
            partID.TabIndex = 50;
            partID.Text = "ID";
            partID.Click += partID_Click;
            // 
            // outsourcedRadio
            // 
            outsourcedRadio.AutoSize = true;
            outsourcedRadio.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outsourcedRadio.Location = new Point(268, 29);
            outsourcedRadio.Name = "outsourcedRadio";
            outsourcedRadio.Size = new Size(87, 19);
            outsourcedRadio.TabIndex = 49;
            outsourcedRadio.Text = "Outsourced";
            outsourcedRadio.UseVisualStyleBackColor = true;
            outsourcedRadio.CheckedChanged += outsourcedRadio_CheckedChanged;
            // 
            // inHouseRadio
            // 
            inHouseRadio.AutoSize = true;
            inHouseRadio.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inHouseRadio.Location = new Point(145, 29);
            inHouseRadio.Name = "inHouseRadio";
            inHouseRadio.Size = new Size(74, 19);
            inHouseRadio.TabIndex = 48;
            inHouseRadio.Text = "In-House";
            inHouseRadio.UseVisualStyleBackColor = true;
            inHouseRadio.CheckedChanged += inHouseRadio_CheckedChanged;
            // 
            // addPartTitle
            // 
            addPartTitle.BackColor = SystemColors.Control;
            addPartTitle.BorderStyle = BorderStyle.None;
            addPartTitle.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addPartTitle.Location = new Point(6, 11);
            addPartTitle.Name = "addPartTitle";
            addPartTitle.Size = new Size(92, 18);
            addPartTitle.TabIndex = 47;
            addPartTitle.Text = "Add Part";
            // 
            // AddPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(466, 465);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(machineIDTextBox);
            Controls.Add(machineIDText);
            Controls.Add(partMinTextBox);
            Controls.Add(partMin);
            Controls.Add(partMaxTextBox);
            Controls.Add(partPriceTextBox);
            Controls.Add(partInventoryTextBox);
            Controls.Add(partNameTextBox);
            Controls.Add(partIDTextBox);
            Controls.Add(partMax);
            Controls.Add(partPrice);
            Controls.Add(partInventory);
            Controls.Add(partName);
            Controls.Add(partID);
            Controls.Add(outsourcedRadio);
            Controls.Add(inHouseRadio);
            Controls.Add(addPartTitle);
            Name = "AddPart";
            Text = "Part";
            Load += AddPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelBtn;
        private Button saveBtn;
        private TextBox machineIDTextBox;
        private TextBox machineIDText;
        private TextBox partMinTextBox;
        private TextBox partMin;
        private TextBox partMaxTextBox;
        private TextBox partPriceTextBox;
        private TextBox partInventoryTextBox;
        private TextBox partNameTextBox;
        private TextBox partIDTextBox;
        private TextBox partMax;
        private TextBox partPrice;
        private TextBox partInventory;
        private TextBox partName;
        private TextBox partID;
        private RadioButton outsourcedRadio;
        private RadioButton inHouseRadio;
        private TextBox addPartTitle;
    }
}