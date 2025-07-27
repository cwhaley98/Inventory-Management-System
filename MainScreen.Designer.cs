namespace Christopher_Whaley_InventorySystem_PA
{
     partial class MainScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textbox1 = new TextBox();
            PartsGridView = new DataGridView();
            ProductGridView = new DataGridView();
            addPartBtn = new Button();
            modifyPartBtn = new Button();
            deletePartBtn = new Button();
            deleteProductBtn = new Button();
            modifyProductBtn = new Button();
            addProductBtn = new Button();
            searchPartsBtn = new Button();
            searchProductsBtn = new Button();
            partsSearchTxtBox = new TextBox();
            productSearchTxtBox = new TextBox();
            titleParts = new TextBox();
            titleProducts = new TextBox();
            exitBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)PartsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).BeginInit();
            SuspendLayout();
            // 
            // textbox1
            // 
            textbox1.BackColor = SystemColors.Control;
            textbox1.BorderStyle = BorderStyle.None;
            textbox1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textbox1.Location = new Point(12, 12);
            textbox1.Name = "textbox1";
            textbox1.Size = new Size(315, 28);
            textbox1.TabIndex = 0;
            textbox1.Text = "Inventory Management System";
            // 
            // PartsGridView
            // 
            PartsGridView.AllowUserToAddRows = false;
            PartsGridView.AllowUserToDeleteRows = false;
            PartsGridView.AllowUserToResizeColumns = false;
            PartsGridView.AllowUserToResizeRows = false;
            PartsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PartsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PartsGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            PartsGridView.Location = new Point(12, 107);
            PartsGridView.MultiSelect = false;
            PartsGridView.Name = "PartsGridView";
            PartsGridView.RowHeadersVisible = false;
            PartsGridView.ScrollBars = ScrollBars.Vertical;
            PartsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PartsGridView.Size = new Size(666, 396);
            PartsGridView.TabIndex = 1;
            PartsGridView.CellClick += PartsGridView_CellClick;
            // 
            // ProductGridView
            // 
            ProductGridView.AllowUserToAddRows = false;
            ProductGridView.AllowUserToDeleteRows = false;
            ProductGridView.AllowUserToResizeColumns = false;
            ProductGridView.AllowUserToResizeRows = false;
            ProductGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ProductGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
            ProductGridView.Location = new Point(743, 107);
            ProductGridView.MultiSelect = false;
            ProductGridView.Name = "ProductGridView";
            ProductGridView.RowHeadersVisible = false;
            ProductGridView.ScrollBars = ScrollBars.Vertical;
            ProductGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductGridView.Size = new Size(666, 396);
            ProductGridView.TabIndex = 2;
            ProductGridView.CellClick += ProductGridView_CellClick;
            // 
            // addPartBtn
            // 
            addPartBtn.BackColor = SystemColors.ControlLightLight;
            addPartBtn.ForeColor = SystemColors.ControlText;
            addPartBtn.Location = new Point(432, 509);
            addPartBtn.Name = "addPartBtn";
            addPartBtn.Size = new Size(74, 33);
            addPartBtn.TabIndex = 3;
            addPartBtn.Text = "Add";
            addPartBtn.UseVisualStyleBackColor = false;
            addPartBtn.Click += addPartBtn_Click;
            // 
            // modifyPartBtn
            // 
            modifyPartBtn.BackColor = SystemColors.ControlLightLight;
            modifyPartBtn.ForeColor = SystemColors.ControlText;
            modifyPartBtn.Location = new Point(512, 509);
            modifyPartBtn.Name = "modifyPartBtn";
            modifyPartBtn.Size = new Size(74, 33);
            modifyPartBtn.TabIndex = 4;
            modifyPartBtn.Text = "Modify";
            modifyPartBtn.UseVisualStyleBackColor = false;
            modifyPartBtn.Click += modifyPartBtn_Click;
            // 
            // deletePartBtn
            // 
            deletePartBtn.BackColor = SystemColors.ControlLightLight;
            deletePartBtn.ForeColor = SystemColors.ControlText;
            deletePartBtn.Location = new Point(592, 509);
            deletePartBtn.Name = "deletePartBtn";
            deletePartBtn.Size = new Size(74, 33);
            deletePartBtn.TabIndex = 5;
            deletePartBtn.Text = "Delete";
            deletePartBtn.UseVisualStyleBackColor = false;
            deletePartBtn.Click += deletePartBtn_Click;
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.BackColor = SystemColors.ControlLightLight;
            deleteProductBtn.ForeColor = SystemColors.ControlText;
            deleteProductBtn.Location = new Point(1316, 509);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new Size(74, 33);
            deleteProductBtn.TabIndex = 8;
            deleteProductBtn.Text = "Delete";
            deleteProductBtn.UseVisualStyleBackColor = false;
            deleteProductBtn.Click += deleteProductBtn_Click;
            // 
            // modifyProductBtn
            // 
            modifyProductBtn.BackColor = SystemColors.ControlLightLight;
            modifyProductBtn.ForeColor = SystemColors.ControlText;
            modifyProductBtn.Location = new Point(1236, 509);
            modifyProductBtn.Name = "modifyProductBtn";
            modifyProductBtn.Size = new Size(74, 33);
            modifyProductBtn.TabIndex = 7;
            modifyProductBtn.Text = "Modify";
            modifyProductBtn.UseVisualStyleBackColor = false;
            modifyProductBtn.Click += modifyProductBtn_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.BackColor = SystemColors.ControlLightLight;
            addProductBtn.ForeColor = SystemColors.ControlText;
            addProductBtn.Location = new Point(1156, 509);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.Size = new Size(74, 33);
            addProductBtn.TabIndex = 6;
            addProductBtn.Text = "Add";
            addProductBtn.UseVisualStyleBackColor = false;
            addProductBtn.Click += addProductBtn_Click;
            // 
            // searchPartsBtn
            // 
            searchPartsBtn.BackColor = SystemColors.ControlLightLight;
            searchPartsBtn.Location = new Point(408, 63);
            searchPartsBtn.Name = "searchPartsBtn";
            searchPartsBtn.Size = new Size(67, 24);
            searchPartsBtn.TabIndex = 9;
            searchPartsBtn.Text = "Search";
            searchPartsBtn.UseVisualStyleBackColor = false;
            searchPartsBtn.Click += searchPartsBtn_Click;
            // 
            // searchProductsBtn
            // 
            searchProductsBtn.BackColor = SystemColors.ControlLightLight;
            searchProductsBtn.Location = new Point(1143, 60);
            searchProductsBtn.Name = "searchProductsBtn";
            searchProductsBtn.Size = new Size(67, 24);
            searchProductsBtn.TabIndex = 10;
            searchProductsBtn.Text = "Search";
            searchProductsBtn.UseVisualStyleBackColor = false;
            searchProductsBtn.Click += searchProductsBtn_Click;
            // 
            // partsSearchTxtBox
            // 
            partsSearchTxtBox.BorderStyle = BorderStyle.FixedSingle;
            partsSearchTxtBox.Location = new Point(485, 65);
            partsSearchTxtBox.Name = "partsSearchTxtBox";
            partsSearchTxtBox.Size = new Size(193, 23);
            partsSearchTxtBox.TabIndex = 11;
            partsSearchTxtBox.TextChanged += partsSearchTxtBox_TextChanged;
            // 
            // productSearchTxtBox
            // 
            productSearchTxtBox.BorderStyle = BorderStyle.FixedSingle;
            productSearchTxtBox.Location = new Point(1216, 63);
            productSearchTxtBox.Name = "productSearchTxtBox";
            productSearchTxtBox.Size = new Size(193, 23);
            productSearchTxtBox.TabIndex = 12;
            productSearchTxtBox.TextChanged += productSearchTxtBox_TextChanged;
            // 
            // titleParts
            // 
            titleParts.BackColor = SystemColors.Control;
            titleParts.BorderStyle = BorderStyle.None;
            titleParts.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleParts.Location = new Point(12, 69);
            titleParts.Name = "titleParts";
            titleParts.Size = new Size(109, 28);
            titleParts.TabIndex = 13;
            titleParts.Text = "Parts";
            // 
            // titleProducts
            // 
            titleProducts.BackColor = SystemColors.Control;
            titleProducts.BorderStyle = BorderStyle.None;
            titleProducts.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleProducts.Location = new Point(743, 69);
            titleProducts.Name = "titleProducts";
            titleProducts.Size = new Size(109, 28);
            titleProducts.TabIndex = 14;
            titleProducts.Text = "Products";
            // 
            // exitBtn
            // 
            exitBtn.BackColor = SystemColors.ControlLightLight;
            exitBtn.ForeColor = SystemColors.ControlText;
            exitBtn.Location = new Point(1335, 598);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(74, 33);
            exitBtn.TabIndex = 15;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = false;
            exitBtn.Click += exitBtn_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1441, 643);
            Controls.Add(exitBtn);
            Controls.Add(titleProducts);
            Controls.Add(titleParts);
            Controls.Add(productSearchTxtBox);
            Controls.Add(partsSearchTxtBox);
            Controls.Add(searchProductsBtn);
            Controls.Add(searchPartsBtn);
            Controls.Add(deleteProductBtn);
            Controls.Add(modifyProductBtn);
            Controls.Add(addProductBtn);
            Controls.Add(deletePartBtn);
            Controls.Add(modifyPartBtn);
            Controls.Add(addPartBtn);
            Controls.Add(ProductGridView);
            Controls.Add(PartsGridView);
            Controls.Add(textbox1);
            Name = "MainScreen";
            Text = "Main";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)PartsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ProductGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textbox1;
        public DataGridView PartsGridView;
        public DataGridView ProductGridView;
        private Button addPartBtn;
        private Button modifyPartBtn;
        private Button deletePartBtn;
        private Button deleteProductBtn;
        private Button modifyProductBtn;
        private Button addProductBtn;
        private Button searchPartsBtn;
        private Button searchProductsBtn;
        private TextBox partsSearchTxtBox;
        private TextBox productSearchTxtBox;
        private TextBox titleParts;
        private TextBox titleProducts;
        private Button exitBtn;
    }
}
