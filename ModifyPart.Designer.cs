namespace Christopher_Whaley_InventorySystem_PA
{
    partial class ModifyPart
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
            ModifyPartLabel = new TextBox();
            inHouseRadio = new RadioButton();
            outsourcedRadio = new RadioButton();
            partMinTextBox = new TextBox();
            partMin = new TextBox();
            partMaxTextBox = new TextBox();
            partPriceTextBox = new TextBox();
            partInventoryTextBox = new TextBox();
            partNameTextBox = new TextBox();
            partIDTextBox = new TextBox();
            partMax = new TextBox();
            partPrice = new TextBox();
            partInventroy = new TextBox();
            partName = new TextBox();
            partID = new TextBox();
            machineIDTextBox = new TextBox();
            machineIDText = new TextBox();
            cancelBtn = new Button();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // ModifyPartLabel
            // 
            ModifyPartLabel.BackColor = SystemColors.Control;
            ModifyPartLabel.BorderStyle = BorderStyle.None;
            ModifyPartLabel.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ModifyPartLabel.Location = new Point(8, 7);
            ModifyPartLabel.Name = "ModifyPartLabel";
            ModifyPartLabel.Size = new Size(92, 18);
            ModifyPartLabel.TabIndex = 0;
            ModifyPartLabel.Text = "Modify Part";
            ModifyPartLabel.Click += ModifyPartLabel_Click;
            // 
            // inHouseRadio
            // 
            inHouseRadio.AutoSize = true;
            inHouseRadio.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            inHouseRadio.Location = new Point(147, 25);
            inHouseRadio.Name = "inHouseRadio";
            inHouseRadio.Size = new Size(74, 19);
            inHouseRadio.TabIndex = 1;
            inHouseRadio.Text = "In-House";
            inHouseRadio.UseVisualStyleBackColor = true;
            inHouseRadio.CheckedChanged += inHouseRadio_CheckedChanged;
            // 
            // outsourcedRadio
            // 
            outsourcedRadio.AutoSize = true;
            outsourcedRadio.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outsourcedRadio.Location = new Point(270, 25);
            outsourcedRadio.Name = "outsourcedRadio";
            outsourcedRadio.Size = new Size(87, 19);
            outsourcedRadio.TabIndex = 2;
            outsourcedRadio.Text = "Outsourced";
            outsourcedRadio.UseVisualStyleBackColor = true;
            outsourcedRadio.CheckedChanged += outsourcedRadio_CheckedChanged;
            // 
            // partMinTextBox
            // 
            partMinTextBox.BorderStyle = BorderStyle.FixedSingle;
            partMinTextBox.Location = new Point(304, 275);
            partMinTextBox.Name = "partMinTextBox";
            partMinTextBox.Size = new Size(89, 23);
            partMinTextBox.TabIndex = 24;
            partMinTextBox.TextChanged += partMinTextBox_TextChanged;
            // 
            // partMin
            // 
            partMin.BackColor = SystemColors.Control;
            partMin.BorderStyle = BorderStyle.None;
            partMin.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partMin.Location = new Point(263, 278);
            partMin.Name = "partMin";
            partMin.Size = new Size(35, 20);
            partMin.TabIndex = 23;
            partMin.Text = "Min";
            partMin.Click += partMin_Click;
            // 
            // partMaxTextBox
            // 
            partMaxTextBox.BorderStyle = BorderStyle.FixedSingle;
            partMaxTextBox.Location = new Point(143, 275);
            partMaxTextBox.Name = "partMaxTextBox";
            partMaxTextBox.Size = new Size(89, 23);
            partMaxTextBox.TabIndex = 22;
            partMaxTextBox.TextChanged += partMaxTextBox_TextChanged;
            // 
            // partPriceTextBox
            // 
            partPriceTextBox.BorderStyle = BorderStyle.FixedSingle;
            partPriceTextBox.Location = new Point(163, 230);
            partPriceTextBox.Name = "partPriceTextBox";
            partPriceTextBox.Size = new Size(211, 23);
            partPriceTextBox.TabIndex = 21;
            partPriceTextBox.TextChanged += partPriceTextBox_TextChanged;
            // 
            // partInventoryTextBox
            // 
            partInventoryTextBox.BorderStyle = BorderStyle.FixedSingle;
            partInventoryTextBox.Location = new Point(163, 177);
            partInventoryTextBox.Name = "partInventoryTextBox";
            partInventoryTextBox.Size = new Size(211, 23);
            partInventoryTextBox.TabIndex = 20;
            partInventoryTextBox.TextChanged += partInventoryTextBox_TextChanged;
            // 
            // partNameTextBox
            // 
            partNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            partNameTextBox.Location = new Point(163, 130);
            partNameTextBox.Name = "partNameTextBox";
            partNameTextBox.Size = new Size(211, 23);
            partNameTextBox.TabIndex = 19;
            partNameTextBox.TextChanged += partNameTextBox_TextChanged;
            // 
            // partIDTextBox
            // 
            partIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            partIDTextBox.Location = new Point(163, 83);
            partIDTextBox.Name = "partIDTextBox";
            partIDTextBox.Size = new Size(211, 23);
            partIDTextBox.TabIndex = 18;
            partIDTextBox.TextChanged += partIDTextBox_TextChanged;
            // 
            // partMax
            // 
            partMax.BackColor = SystemColors.Control;
            partMax.BorderStyle = BorderStyle.None;
            partMax.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partMax.Location = new Point(62, 278);
            partMax.Name = "partMax";
            partMax.Size = new Size(64, 20);
            partMax.TabIndex = 17;
            partMax.Text = "Max";
            partMax.Click += partMax_Click;
            // 
            // partPrice
            // 
            partPrice.BackColor = SystemColors.Control;
            partPrice.BorderStyle = BorderStyle.None;
            partPrice.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partPrice.Location = new Point(62, 228);
            partPrice.Name = "partPrice";
            partPrice.Size = new Size(84, 20);
            partPrice.TabIndex = 16;
            partPrice.Text = "Price / Cost";
            partPrice.Click += partPrice_Click;
            // 
            // partInventroy
            // 
            partInventroy.BackColor = SystemColors.Control;
            partInventroy.BorderStyle = BorderStyle.None;
            partInventroy.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partInventroy.Location = new Point(62, 175);
            partInventroy.Name = "partInventroy";
            partInventroy.Size = new Size(64, 20);
            partInventroy.TabIndex = 15;
            partInventroy.Text = "Inventory";
            partInventroy.Click += partInventory_Click;
            // 
            // partName
            // 
            partName.BackColor = SystemColors.Control;
            partName.BorderStyle = BorderStyle.None;
            partName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partName.Location = new Point(62, 128);
            partName.Name = "partName";
            partName.Size = new Size(64, 20);
            partName.TabIndex = 14;
            partName.Text = "Name";
            partName.Click += partName_Click;
            // 
            // partID
            // 
            partID.BackColor = SystemColors.Control;
            partID.BorderStyle = BorderStyle.None;
            partID.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            partID.Location = new Point(62, 81);
            partID.Name = "partID";
            partID.Size = new Size(27, 20);
            partID.TabIndex = 13;
            partID.Text = "ID";
            partID.Click += partID_Click;
            // 
            // machineIDTextBox
            // 
            machineIDTextBox.BorderStyle = BorderStyle.FixedSingle;
            machineIDTextBox.Location = new Point(209, 322);
            machineIDTextBox.Name = "machineIDTextBox";
            machineIDTextBox.Size = new Size(184, 23);
            machineIDTextBox.TabIndex = 26;
            machineIDTextBox.TextChanged += machineIDTextBox_TextChanged;
            // 
            // machineIDText
            // 
            machineIDText.BackColor = SystemColors.Control;
            machineIDText.BorderStyle = BorderStyle.None;
            machineIDText.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            machineIDText.Location = new Point(62, 325);
            machineIDText.Name = "machineIDText";
            machineIDText.Size = new Size(141, 20);
            machineIDText.TabIndex = 25;
            machineIDText.Text = "Machine ID";
            machineIDText.Click += machineIDText_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ControlLightLight;
            cancelBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(370, 404);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(74, 33);
            cancelBtn.TabIndex = 46;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ControlLightLight;
            saveBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ControlText;
            saveBtn.Location = new Point(270, 404);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(74, 33);
            saveBtn.TabIndex = 45;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // ModifyPart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(456, 449);
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
            Controls.Add(partInventroy);
            Controls.Add(partName);
            Controls.Add(partID);
            Controls.Add(outsourcedRadio);
            Controls.Add(inHouseRadio);
            Controls.Add(ModifyPartLabel);
            Name = "ModifyPart";
            Text = "Part";
            Load += ModifyPart_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void PartInventoryTextBox_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private TextBox ModifyPartLabel;
        private RadioButton inHouseRadio;
        private RadioButton outsourcedRadio;
        private TextBox partMinTextBox;
        private TextBox partMin;
        private TextBox partMaxTextBox;
        private TextBox partPriceTextBox;
        private TextBox partInventoryTextBox;
        private TextBox partNameTextBox;
        private TextBox partIDTextBox;
        private TextBox partMax;
        private TextBox partPrice;
        private TextBox partInventroy;
        private TextBox partName;
        private TextBox partID;
        private TextBox machineIDTextBox;
        private TextBox machineIDText;
        private Button cancelBtn;
        private Button saveBtn;
    }
}