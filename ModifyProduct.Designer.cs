namespace Christopher_Whaley_InventorySystem_PA
{
    partial class ModifyProduct
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
            addProductTitle = new TextBox();
            productID = new TextBox();
            productName = new TextBox();
            productInventory = new TextBox();
            productPrice = new TextBox();
            productMax = new TextBox();
            productIDText = new TextBox();
            productNameText = new TextBox();
            productInvText = new TextBox();
            productPriceText = new TextBox();
            productMaxText = new TextBox();
            productMin = new TextBox();
            productMinText = new TextBox();
            searchParts = new Button();
            productSearch = new TextBox();
            productCandidateGrid = new DataGridView();
            productAssocGrid = new DataGridView();
            AllParts = new TextBox();
            AssocParts = new TextBox();
            addBtn = new Button();
            saveBtn = new Button();
            cancelBtn = new Button();
            deleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)productCandidateGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productAssocGrid).BeginInit();
            SuspendLayout();
            // 
            // addProductTitle
            // 
            addProductTitle.BackColor = SystemColors.Control;
            addProductTitle.BorderStyle = BorderStyle.None;
            addProductTitle.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductTitle.Location = new Point(12, 12);
            addProductTitle.Name = "addProductTitle";
            addProductTitle.Size = new Size(115, 20);
            addProductTitle.TabIndex = 0;
            addProductTitle.Text = "Modify Product";
            // 
            // productID
            // 
            productID.BackColor = SystemColors.Control;
            productID.BorderStyle = BorderStyle.None;
            productID.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productID.Location = new Point(82, 297);
            productID.Name = "productID";
            productID.Size = new Size(27, 20);
            productID.TabIndex = 1;
            productID.Text = "ID";
            productID.Click += productID_Click;
            // 
            // productName
            // 
            productName.BackColor = SystemColors.Control;
            productName.BorderStyle = BorderStyle.None;
            productName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productName.Location = new Point(82, 343);
            productName.Name = "productName";
            productName.Size = new Size(64, 20);
            productName.TabIndex = 2;
            productName.Text = "Name";
            productName.Click += productName_Click;
            // 
            // productInventory
            // 
            productInventory.BackColor = SystemColors.Control;
            productInventory.BorderStyle = BorderStyle.None;
            productInventory.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productInventory.Location = new Point(82, 390);
            productInventory.Name = "productInventory";
            productInventory.Size = new Size(64, 20);
            productInventory.TabIndex = 3;
            productInventory.Text = "Inventory";
            productInventory.Click += productInventory_Click;
            // 
            // productPrice
            // 
            productPrice.BackColor = SystemColors.Control;
            productPrice.BorderStyle = BorderStyle.None;
            productPrice.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(82, 443);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(64, 20);
            productPrice.TabIndex = 4;
            productPrice.Text = "Price";
            productPrice.Click += productPrice_Click;
            // 
            // productMax
            // 
            productMax.BackColor = SystemColors.Control;
            productMax.BorderStyle = BorderStyle.None;
            productMax.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productMax.Location = new Point(82, 493);
            productMax.Name = "productMax";
            productMax.Size = new Size(64, 20);
            productMax.TabIndex = 5;
            productMax.Text = "Max";
            productMax.Click += productMax_Click;
            // 
            // productIDText
            // 
            productIDText.BorderStyle = BorderStyle.FixedSingle;
            productIDText.Location = new Point(172, 298);
            productIDText.Name = "productIDText";
            productIDText.Size = new Size(211, 23);
            productIDText.TabIndex = 6;
            productIDText.TextChanged += productIDText_TextChanged;
            // 
            // productNameText
            // 
            productNameText.BorderStyle = BorderStyle.FixedSingle;
            productNameText.Location = new Point(172, 345);
            productNameText.Name = "productNameText";
            productNameText.Size = new Size(211, 23);
            productNameText.TabIndex = 7;
            productNameText.TextChanged += productNameText_TextChanged;
            // 
            // productInvText
            // 
            productInvText.BorderStyle = BorderStyle.FixedSingle;
            productInvText.Location = new Point(172, 392);
            productInvText.Name = "productInvText";
            productInvText.Size = new Size(211, 23);
            productInvText.TabIndex = 8;
            productInvText.TextChanged += productInvText_TextChanged;
            // 
            // productPriceText
            // 
            productPriceText.BorderStyle = BorderStyle.FixedSingle;
            productPriceText.Location = new Point(172, 445);
            productPriceText.Name = "productPriceText";
            productPriceText.Size = new Size(211, 23);
            productPriceText.TabIndex = 9;
            productPriceText.TextChanged += productPriceText_TextChanged;
            // 
            // productMaxText
            // 
            productMaxText.BorderStyle = BorderStyle.FixedSingle;
            productMaxText.Location = new Point(138, 493);
            productMaxText.Name = "productMaxText";
            productMaxText.Size = new Size(89, 23);
            productMaxText.TabIndex = 10;
            productMaxText.TextChanged += productMaxText_TextChanged;
            // 
            // productMin
            // 
            productMin.BackColor = SystemColors.Control;
            productMin.BorderStyle = BorderStyle.None;
            productMin.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productMin.Location = new Point(269, 493);
            productMin.Name = "productMin";
            productMin.Size = new Size(35, 20);
            productMin.TabIndex = 11;
            productMin.Text = "Min";
            productMin.Click += productMin_Click;
            // 
            // productMinText
            // 
            productMinText.BorderStyle = BorderStyle.FixedSingle;
            productMinText.Location = new Point(322, 493);
            productMinText.Name = "productMinText";
            productMinText.Size = new Size(89, 23);
            productMinText.TabIndex = 12;
            productMinText.TextChanged += productMinText_TextChanged;
            // 
            // searchParts
            // 
            searchParts.BackColor = SystemColors.ControlLightLight;
            searchParts.Location = new Point(867, 40);
            searchParts.Name = "searchParts";
            searchParts.Size = new Size(67, 24);
            searchParts.TabIndex = 13;
            searchParts.Text = "Search";
            searchParts.UseVisualStyleBackColor = false;
            searchParts.Click += searchParts_Click;
            // 
            // productSearch
            // 
            productSearch.BorderStyle = BorderStyle.FixedSingle;
            productSearch.Location = new Point(955, 43);
            productSearch.Name = "productSearch";
            productSearch.Size = new Size(211, 23);
            productSearch.TabIndex = 14;
            productSearch.TextChanged += productSearch_TextChanged;
            // 
            // productCandidateGrid
            // 
            productCandidateGrid.AllowUserToAddRows = false;
            productCandidateGrid.AllowUserToDeleteRows = false;
            productCandidateGrid.AllowUserToResizeColumns = false;
            productCandidateGrid.AllowUserToResizeRows = false;
            productCandidateGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productCandidateGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            productCandidateGrid.Location = new Point(569, 86);
            productCandidateGrid.Name = "productCandidateGrid";
            productCandidateGrid.RowHeadersVisible = false;
            productCandidateGrid.ScrollBars = ScrollBars.Vertical;
            productCandidateGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productCandidateGrid.Size = new Size(673, 220);
            productCandidateGrid.TabIndex = 15;
            productCandidateGrid.CellContentClick += productCandidateGrid_CellContentClick;
            // 
            // productAssocGrid
            // 
            productAssocGrid.AllowUserToAddRows = false;
            productAssocGrid.AllowUserToDeleteRows = false;
            productAssocGrid.AllowUserToResizeColumns = false;
            productAssocGrid.AllowUserToResizeRows = false;
            productAssocGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productAssocGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            productAssocGrid.Location = new Point(569, 419);
            productAssocGrid.MultiSelect = false;
            productAssocGrid.Name = "productAssocGrid";
            productAssocGrid.RowHeadersVisible = false;
            productAssocGrid.ScrollBars = ScrollBars.Vertical;
            productAssocGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productAssocGrid.Size = new Size(673, 220);
            productAssocGrid.TabIndex = 16;
            productAssocGrid.CellContentClick += productAssocGrid_CellContentClick;
            // 
            // AllParts
            // 
            AllParts.BackColor = SystemColors.Control;
            AllParts.BorderStyle = BorderStyle.None;
            AllParts.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AllParts.Location = new Point(569, 64);
            AllParts.Name = "AllParts";
            AllParts.Size = new Size(262, 18);
            AllParts.TabIndex = 17;
            AllParts.Text = "All Candidate Parts";
            // 
            // AssocParts
            // 
            AssocParts.BackColor = SystemColors.Control;
            AssocParts.BorderStyle = BorderStyle.None;
            AssocParts.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AssocParts.Location = new Point(569, 397);
            AssocParts.Name = "AssocParts";
            AssocParts.Size = new Size(210, 18);
            AssocParts.TabIndex = 18;
            AssocParts.Text = "Parts Associated with this Product";
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ControlLightLight;
            addBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = SystemColors.ControlText;
            addBtn.Location = new Point(1140, 330);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(74, 33);
            addBtn.TabIndex = 19;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ControlLightLight;
            saveBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ControlText;
            saveBtn.Location = new Point(1040, 732);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(74, 33);
            saveBtn.TabIndex = 20;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ControlLightLight;
            cancelBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(1140, 732);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(74, 33);
            cancelBtn.TabIndex = 21;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.ControlLightLight;
            deleteBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = SystemColors.ControlText;
            deleteBtn.Location = new Point(1140, 661);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(74, 33);
            deleteBtn.TabIndex = 22;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // ModifyProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 786);
            Controls.Add(deleteBtn);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(addBtn);
            Controls.Add(AssocParts);
            Controls.Add(AllParts);
            Controls.Add(productAssocGrid);
            Controls.Add(productCandidateGrid);
            Controls.Add(productSearch);
            Controls.Add(searchParts);
            Controls.Add(productMinText);
            Controls.Add(productMin);
            Controls.Add(productMaxText);
            Controls.Add(productPriceText);
            Controls.Add(productInvText);
            Controls.Add(productNameText);
            Controls.Add(productIDText);
            Controls.Add(productMax);
            Controls.Add(productPrice);
            Controls.Add(productInventory);
            Controls.Add(productName);
            Controls.Add(productID);
            Controls.Add(addProductTitle);
            Name = "ModifyProduct";
            Text = " Product";
            Load += ModifyProduct_Load;
            ((System.ComponentModel.ISupportInitialize)productCandidateGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productAssocGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addProductTitle;
        private TextBox productID;
        private TextBox productName;
        private TextBox productInventory;
        private TextBox productPrice;
        private TextBox productMax;
        private TextBox productIDText;
        private TextBox productNameText;
        private TextBox productInvText;
        private TextBox productPriceText;
        private TextBox productMaxText;
        private TextBox productMin;
        private TextBox productMinText;
        private Button searchParts;
        private TextBox productSearch;
        private DataGridView productCandidateGrid;
        private DataGridView productAssocGrid;
        private TextBox AllParts;
        private TextBox AssocParts;
        private Button addBtn;
        private Button saveBtn;
        private Button cancelBtn;
        private Button deleteBtn;
    }
}