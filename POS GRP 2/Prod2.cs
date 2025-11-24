using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_GRP_2
{
    public partial class Prod2 : UserControl
    {
        private int quantity = 0;
        private decimal price = 99m;

        public event EventHandler QuantityChanged;

        public string ProductName => "Chocolate Frappuccino";

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

        public Prod2()
        {
            InitializeComponent();
            lblQuantity.Text = "0";
        }

        private void btnAdd_Click(object sender, EventArgs e) => Quantity++;
        private void btnSubtract_Click(object sender, EventArgs e) { if (Quantity > 0) Quantity--; }
        public void ResetQuantity() => Quantity = 0;
    }
}




