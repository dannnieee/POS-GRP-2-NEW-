namespace POS_GRP_2
{
    partial class Admin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnRemove = new Button();
            btnReset = new Button();
            grpProductInfo = new GroupBox();
            picProduct = new PictureBox();
            btnSelectProduct = new Button();
            grpProductList = new GroupBox();
            lblID = new Label();
            txtID = new TextBox();
            lblName = new Label();
            txtName = new TextBox();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblStock = new Label();
            txtStock = new TextBox();
            dataProducts = new DataGridView();
            label1 = new Label();
            grpProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picProduct).BeginInit();
            grpProductList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataProducts).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Sitka Heading", 20.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Maroon;
            lblTitle.Location = new Point(223, 53);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(144, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Hi, Admin";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FloralWhite;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Sitka Heading", 12.5F);
            btnAdd.Location = new Point(26, 107);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(166, 40);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FloralWhite;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Sitka Heading", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(26, 159);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(166, 40);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.FloralWhite;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Sitka Heading", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(26, 215);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(166, 40);
            btnRemove.TabIndex = 4;
            btnRemove.Text = "Remove Product";
            btnRemove.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FloralWhite;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Sitka Heading", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(26, 269);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(166, 40);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset Fields";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // grpProductInfo
            // 
            grpProductInfo.BackColor = Color.FloralWhite;
            grpProductInfo.Controls.Add(picProduct);
            grpProductInfo.Controls.Add(btnSelectProduct);
            grpProductInfo.Font = new Font("Sitka Heading", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProductInfo.Location = new Point(223, 107);
            grpProductInfo.Name = "grpProductInfo";
            grpProductInfo.Size = new Size(248, 213);
            grpProductInfo.TabIndex = 6;
            grpProductInfo.TabStop = false;
            grpProductInfo.Text = "Product Details";
            // 
            // picProduct
            // 
            picProduct.BackColor = Color.White;
            picProduct.BorderStyle = BorderStyle.FixedSingle;
            picProduct.Location = new Point(53, 35);
            picProduct.Name = "picProduct";
            picProduct.Size = new Size(150, 121);
            picProduct.SizeMode = PictureBoxSizeMode.Zoom;
            picProduct.TabIndex = 0;
            picProduct.TabStop = false;
            // 
            // btnSelectProduct
            // 
            btnSelectProduct.BackColor = Color.OldLace;
            btnSelectProduct.FlatStyle = FlatStyle.Flat;
            btnSelectProduct.Font = new Font("Sitka Heading", 11.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelectProduct.Location = new Point(53, 162);
            btnSelectProduct.Name = "btnSelectProduct";
            btnSelectProduct.Size = new Size(150, 35);
            btnSelectProduct.TabIndex = 1;
            btnSelectProduct.Text = "Select Product";
            btnSelectProduct.UseVisualStyleBackColor = false;
            // 
            // grpProductList
            // 
            grpProductList.BackColor = Color.FloralWhite;
            grpProductList.Controls.Add(lblID);
            grpProductList.Controls.Add(txtID);
            grpProductList.Controls.Add(lblName);
            grpProductList.Controls.Add(txtName);
            grpProductList.Controls.Add(lblPrice);
            grpProductList.Controls.Add(txtPrice);
            grpProductList.Controls.Add(lblStock);
            grpProductList.Controls.Add(txtStock);
            grpProductList.Font = new Font("Sitka Heading", 12.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpProductList.Location = new Point(477, 107);
            grpProductList.Name = "grpProductList";
            grpProductList.Size = new Size(473, 213);
            grpProductList.TabIndex = 7;
            grpProductList.TabStop = false;
            grpProductList.Text = "Product List";
            // 
            // lblID
            // 
            lblID.BackColor = Color.FloralWhite;
            lblID.Location = new Point(20, 40);
            lblID.Name = "lblID";
            lblID.Size = new Size(100, 23);
            lblID.TabIndex = 0;
            lblID.Text = "Product ID:";
            // 
            // txtID
            // 
            txtID.Location = new Point(130, 40);
            txtID.Name = "txtID";
            txtID.Size = new Size(312, 28);
            txtID.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Location = new Point(20, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Product Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(130, 80);
            txtName.Name = "txtName";
            txtName.Size = new Size(312, 28);
            txtName.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.Location = new Point(20, 120);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(100, 23);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(130, 120);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(312, 28);
            txtPrice.TabIndex = 5;
            // 
            // lblStock
            // 
            lblStock.Location = new Point(20, 160);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(100, 23);
            lblStock.TabIndex = 6;
            lblStock.Text = "Stock:";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(130, 160);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(312, 28);
            txtStock.TabIndex = 7;
            // 
            // dataProducts
            // 
            dataProducts.AllowUserToAddRows = false;
            dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataProducts.BackgroundColor = Color.White;
            dataProducts.Location = new Point(223, 340);
            dataProducts.MultiSelect = false;
            dataProducts.Name = "dataProducts";
            dataProducts.ReadOnly = true;
            dataProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProducts.Size = new Size(727, 213);
            dataProducts.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(26, 24);
            label1.Name = "label1";
            label1.Size = new Size(159, 54);
            label1.TabIndex = 9;
            label1.Text = "Cafe Dos";
            // 
            // Admin
            // 
            BackColor = Color.OldLace;
            ClientSize = new Size(997, 583);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnRemove);
            Controls.Add(btnReset);
            Controls.Add(grpProductInfo);
            Controls.Add(grpProductList);
            Controls.Add(dataProducts);
            Font = new Font("Segoe UI", 10F);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Panel";
            grpProductInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picProduct).EndInit();
            grpProductList.ResumeLayout(false);
            grpProductList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox picProfile;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReset;

        private System.Windows.Forms.GroupBox grpProductInfo;
        private System.Windows.Forms.PictureBox picProduct;
        private System.Windows.Forms.Button btnSelectProduct;

        private System.Windows.Forms.GroupBox grpProductList;

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtStock;

        private System.Windows.Forms.DataGridView dataProducts;
        private Label label1;
    }
}
