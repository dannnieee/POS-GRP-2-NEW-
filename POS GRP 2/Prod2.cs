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
        public decimal TotalPrice => unitPrice * quantity;
        decimal unitPrice = 99.00m;
        int quantity = 0;

        public event EventHandler QuantityChanged;

        public Prod2()
        {
            InitializeComponent();
            lblUnitPrice.Text = $"₱ {unitPrice}";
            UpdateQuantityDisplay();
           
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity > 0)
            {
                quantity--;
                UpdateQuantityDisplay();
                QuantityChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            quantity++;
            UpdateQuantityDisplay();
            QuantityChanged?.Invoke(this, EventArgs.Empty);
        }

        private void UpdateQuantityDisplay()
        {
            lblQuantity.Text = quantity.ToString();
        }
    }
}






