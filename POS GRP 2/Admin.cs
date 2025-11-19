using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS_GRP_2
{
    public partial class Admin : Form
    {
        private DataTable productsTable = new DataTable();
        private string selectedImagePath = "";
        private Dictionary<string, Image> productImages = new Dictionary<string, Image>();

        public Admin()
        {
            InitializeComponent();
            InitializeDataTable();
            BindDataGridView();

            // Hook button events
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnRemove.Click += BtnRemove_Click;
            btnReset.Click += BtnReset_Click;
            btnSelectProduct.Click += BtnSelectProduct_Click;
        }

        // --------------------------
        // Initialize DataTable
        // --------------------------
        private void InitializeDataTable()
        {
            productsTable.Columns.Add("ID");
            productsTable.Columns.Add("Name");
            productsTable.Columns.Add("Price");
            productsTable.Columns.Add("Stock");
            // No ImagePath column for DataGridView
        }

        // --------------------------
        // Bind DataGridView
        // --------------------------
        private void BindDataGridView()
        {
            dataProducts.DataSource = productsTable;
            dataProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataProducts.MultiSelect = false;
            dataProducts.ReadOnly = true;
            dataProducts.AllowUserToAddRows = false;
            dataProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataProducts.CellClick += DataProducts_CellClick;
        }

        // --------------------------
        // Add Product
        // --------------------------
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtStock.Text))
            {
                MessageBox.Show("Please fill all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            productsTable.Rows.Add(txtID.Text, txtName.Text, txtPrice.Text, txtStock.Text);

            // Store image in dictionary
            if (picProduct.Image != null)
            {
                productImages[txtID.Text] = picProduct.Image;
            }

            ResetFields();
        }


        // --------------------------
        // Update Product
        // --------------------------
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count == 0)
                return;

            DataGridViewRow row = dataProducts.SelectedRows[0];
            row.Cells["ID"].Value = txtID.Text;
            row.Cells["Name"].Value = txtName.Text;
            row.Cells["Price"].Value = txtPrice.Text;
            row.Cells["Stock"].Value = txtStock.Text;

            ResetFields();
        }

        // --------------------------
        // Remove Product
        // --------------------------
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            if (dataProducts.SelectedRows.Count == 0)
                return;

            dataProducts.Rows.Remove(dataProducts.SelectedRows[0]);
            ResetFields();
        }

        // --------------------------
        // Reset Fields
        // --------------------------
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        private void ResetFields()
        {
            txtID.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
            picProduct.Image = null;
            selectedImagePath = "";
            dataProducts.ClearSelection();
        }

        // --------------------------
        // Select Product Image
        // --------------------------
        private void BtnSelectProduct_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePath = dialog.FileName;
                    picProduct.Image = Image.FromFile(selectedImagePath);
                }
            }
        }

        // --------------------------
        // Load selected product into fields
        // --------------------------
        private void DataProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dataProducts.Rows[e.RowIndex];
            txtID.Text = row.Cells["ID"].Value?.ToString();
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtPrice.Text = row.Cells["Price"].Value?.ToString();
            txtStock.Text = row.Cells["Stock"].Value?.ToString();

            // Image is not stored in DataGridView, so just keep the last selected image
            // If you want, you can load a default image or leave it blank
            //picProduct.Image = selectedImagePath != "" && System.IO.File.Exists(selectedImagePath)
            //     ? Image.FromFile(selectedImagePath)
            //     : null;
        }


    }
}
