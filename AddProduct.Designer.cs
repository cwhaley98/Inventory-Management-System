namespace Christopher_Whaley_InventorySystem_PA
{
    partial class AddProduct
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
            deleteBtn = new Button();
            cancelBtn = new Button();
            saveBtn = new Button();
            addBtn = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            productAssocGrid = new DataGridView();
            productCandidateGrid = new DataGridView();
            productSearch = new TextBox();
            searchParts = new Button();
            productMinText = new TextBox();
            productMin = new TextBox();
            productMaxText = new TextBox();
            productPriceText = new TextBox();
            productInvText = new TextBox();
            productNameText = new TextBox();
            productIDText = new TextBox();
            productMax = new TextBox();
            productPrice = new TextBox();
            productInventory = new TextBox();
            productName = new TextBox();
            productID = new TextBox();
            addProductTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)productAssocGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productCandidateGrid).BeginInit();
            SuspendLayout();
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = SystemColors.ControlLightLight;
            deleteBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = SystemColors.ControlText;
            deleteBtn.Location = new Point(1148, 666);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(74, 33);
            deleteBtn.TabIndex = 45;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.BackColor = SystemColors.ControlLightLight;
            cancelBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancelBtn.ForeColor = SystemColors.ControlText;
            cancelBtn.Location = new Point(1148, 737);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(74, 33);
            cancelBtn.TabIndex = 44;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = false;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.BackColor = SystemColors.ControlLightLight;
            saveBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            saveBtn.ForeColor = SystemColors.ControlText;
            saveBtn.Location = new Point(1048, 737);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(74, 33);
            saveBtn.TabIndex = 43;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = false;
            saveBtn.Click += saveBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.ControlLightLight;
            addBtn.Font = new Font("Nirmala UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addBtn.ForeColor = SystemColors.ControlText;
            addBtn.Location = new Point(1148, 335);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(74, 33);
            addBtn.TabIndex = 42;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Control;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(577, 402);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 18);
            textBox2.TabIndex = 41;
            textBox2.Text = "Parts Associated with this Product";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Control;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Nirmala UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(577, 69);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(262, 18);
            textBox1.TabIndex = 40;
            textBox1.Text = "All Candidate Parts";
            // 
            // productAssocGrid
            // 
            productAssocGrid.AllowUserToAddRows = false;
            productAssocGrid.AllowUserToDeleteRows = false;
            productAssocGrid.AllowUserToResizeColumns = false;
            productAssocGrid.AllowUserToResizeRows = false;
            productAssocGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productAssocGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            productAssocGrid.Location = new Point(577, 424);
            productAssocGrid.MultiSelect = false;
            productAssocGrid.Name = "productAssocGrid";
            productAssocGrid.RowHeadersVisible = false;
            productAssocGrid.ScrollBars = ScrollBars.Vertical;
            productAssocGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productAssocGrid.Size = new Size(673, 220);
            productAssocGrid.TabIndex = 39;
            productAssocGrid.CellContentClick += productAssocGrid_CellContentClick;
            // 
            // productCandidateGrid
            // 
            productCandidateGrid.AllowUserToAddRows = false;
            productCandidateGrid.AllowUserToDeleteRows = false;
            productCandidateGrid.AllowUserToResizeColumns = false;
            productCandidateGrid.AllowUserToResizeRows = false;
            productCandidateGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productCandidateGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            productCandidateGrid.Location = new Point(577, 91);
            productCandidateGrid.Name = "productCandidateGrid";
            productCandidateGrid.RowHeadersVisible = false;
            productCandidateGrid.ScrollBars = ScrollBars.Vertical;
            productCandidateGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productCandidateGrid.Size = new Size(673, 220);
            productCandidateGrid.TabIndex = 38;
            productCandidateGrid.CellContentClick += productCandidateGrid_CellContentClick;
            // 
            // productSearch
            // 
            productSearch.BorderStyle = BorderStyle.FixedSingle;
            productSearch.Location = new Point(963, 48);
            productSearch.Name = "productSearch";
            productSearch.Size = new Size(211, 23);
            productSearch.TabIndex = 37;
            productSearch.TextChanged += productSearch_TextChanged;
            // 
            // searchParts
            // 
            searchParts.BackColor = SystemColors.ControlLightLight;
            searchParts.Location = new Point(875, 45);
            searchParts.Name = "searchParts";
            searchParts.Size = new Size(67, 24);
            searchParts.TabIndex = 36;
            searchParts.Text = "Search";
            searchParts.UseVisualStyleBackColor = false;
            searchParts.Click += searchParts_Click;
            // 
            // productMinText
            // 
            productMinText.BorderStyle = BorderStyle.FixedSingle;
            productMinText.Location = new Point(330, 498);
            productMinText.Name = "productMinText";
            productMinText.Size = new Size(89, 23);
            productMinText.TabIndex = 35;
            productMinText.TextChanged += productMinText_TextChanged;
            // 
            // productMin
            // 
            productMin.BackColor = SystemColors.Control;
            productMin.BorderStyle = BorderStyle.None;
            productMin.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productMin.Location = new Point(277, 498);
            productMin.Name = "productMin";
            productMin.Size = new Size(35, 20);
            productMin.TabIndex = 34;
            productMin.Text = "Min";
            productMin.Click += productMin_Click;
            // 
            // productMaxText
            // 
            productMaxText.BorderStyle = BorderStyle.FixedSingle;
            productMaxText.Location = new Point(146, 498);
            productMaxText.Name = "productMaxText";
            productMaxText.Size = new Size(89, 23);
            productMaxText.TabIndex = 33;
            productMaxText.TextChanged += productMaxText_TextChanged;
            // 
            // productPriceText
            // 
            productPriceText.BorderStyle = BorderStyle.FixedSingle;
            productPriceText.Location = new Point(180, 450);
            productPriceText.Name = "productPriceText";
            productPriceText.Size = new Size(211, 23);
            productPriceText.TabIndex = 32;
            productPriceText.TextChanged += productPriceText_TextChanged;
            // 
            // productInvText
            // 
            productInvText.BorderStyle = BorderStyle.FixedSingle;
            productInvText.Location = new Point(180, 397);
            productInvText.Name = "productInvText";
            productInvText.Size = new Size(211, 23);
            productInvText.TabIndex = 31;
            productInvText.TextChanged += productInvText_TextChanged;
            // 
            // productNameText
            // 
            productNameText.BorderStyle = BorderStyle.FixedSingle;
            productNameText.Location = new Point(180, 350);
            productNameText.Name = "productNameText";
            productNameText.Size = new Size(211, 23);
            productNameText.TabIndex = 30;
            productNameText.TextChanged += productNameText_TextChanged;
            // 
            // productIDText
            // 
            productIDText.BorderStyle = BorderStyle.FixedSingle;
            productIDText.Location = new Point(180, 303);
            productIDText.Name = "productIDText";
            productIDText.Size = new Size(211, 23);
            productIDText.TabIndex = 29;
            productIDText.TextChanged += productIDText_TextChanged;
            // 
            // productMax
            // 
            productMax.BackColor = SystemColors.Control;
            productMax.BorderStyle = BorderStyle.None;
            productMax.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productMax.Location = new Point(90, 498);
            productMax.Name = "productMax";
            productMax.Size = new Size(64, 20);
            productMax.TabIndex = 28;
            productMax.Text = "Max";
            productMax.Click += productMax_Click;
            // 
            // productPrice
            // 
            productPrice.BackColor = SystemColors.Control;
            productPrice.BorderStyle = BorderStyle.None;
            productPrice.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productPrice.Location = new Point(90, 448);
            productPrice.Name = "productPrice";
            productPrice.Size = new Size(64, 20);
            productPrice.TabIndex = 27;
            productPrice.Text = "Price";
            productPrice.Click += productPrice_Click;
            // 
            // productInventory
            // 
            productInventory.BackColor = SystemColors.Control;
            productInventory.BorderStyle = BorderStyle.None;
            productInventory.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productInventory.Location = new Point(90, 395);
            productInventory.Name = "productInventory";
            productInventory.Size = new Size(64, 20);
            productInventory.TabIndex = 26;
            productInventory.Text = "Inventory";
            productInventory.Click += productInventory_Click;
            // 
            // productName
            // 
            productName.BackColor = SystemColors.Control;
            productName.BorderStyle = BorderStyle.None;
            productName.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productName.Location = new Point(90, 348);
            productName.Name = "productName";
            productName.Size = new Size(64, 20);
            productName.TabIndex = 25;
            productName.Text = "Name";
            productName.Click += productName_Click;
            // 
            // productID
            // 
            productID.BackColor = SystemColors.Control;
            productID.BorderStyle = BorderStyle.None;
            productID.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productID.Location = new Point(90, 302);
            productID.Name = "productID";
            productID.Size = new Size(27, 20);
            productID.TabIndex = 24;
            productID.Text = "ID";
            productID.Click += productID_Click;
            // 
            // addProductTitle
            // 
            addProductTitle.BackColor = SystemColors.Control;
            addProductTitle.BorderStyle = BorderStyle.None;
            addProductTitle.Font = new Font("Nirmala UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductTitle.Location = new Point(20, 17);
            addProductTitle.Name = "addProductTitle";
            addProductTitle.Size = new Size(115, 20);
            addProductTitle.TabIndex = 23;
            addProductTitle.Text = "Add Product";
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1270, 786);
            Controls.Add(deleteBtn);
            Controls.Add(cancelBtn);
            Controls.Add(saveBtn);
            Controls.Add(addBtn);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            Name = "AddProduct";
            Text = "Product";
            Load += new EventHandler(AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)productAssocGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productCandidateGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ProductIDText_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button deleteBtn;
        private Button cancelBtn;
        private Button saveBtn;
        private Button addBtn;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView productAssocGrid;
        private DataGridView productCandidateGrid;
        private TextBox productSearch;
        private Button searchParts;
        private TextBox productMinText;
        private TextBox productMin;
        private TextBox productMaxText;
        private TextBox productPriceText;
        private TextBox productInvText;
        private TextBox productNameText;
        private TextBox productIDText;
        private TextBox productMax;
        private TextBox productPrice;
        private TextBox productInventory;
        private TextBox productName;
        private TextBox productID;
        private TextBox addProductTitle;
    }
}