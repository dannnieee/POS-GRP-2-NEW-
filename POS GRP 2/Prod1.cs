using System;
using System.Windows.Forms;

namespace POS_GRP_2
{
    public partial class Prod1 : UserControl
    {
        private int quantity = 0;
        private decimal price = 59m;

        public event EventHandler QuantityChanged;

        public string ProductName => "Chocolate Chip Cookie";

        public int Quantity
        {
            get => quantity;
            private set
            {
                quantity = value;
                lblQuantity.Text = quantity.ToString();
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public decimal TotalPrice => price * Quantity;

        public Prod1()
        {
            InitializeComponent();
            lblQuantity.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e) => Quantity++;
        private void btnSubtract_Click(object sender, EventArgs e) { if (Quantity > 0) Quantity--; }
        public void ResetQuantity() => Quantity = 0;
    }
}