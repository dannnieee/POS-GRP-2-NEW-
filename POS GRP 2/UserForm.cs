using System;
using System.Linq;
using System.Windows.Forms;
using POS_GRP_2; // Make sure this is included

namespace POS_GRP_2
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
            InitializePlaceOrderButton();
        }

        // Add "Place Order" button to panel1
        private void InitializePlaceOrderButton()
        {
            Button btnPlaceOrder = new Button();
            btnPlaceOrder.Text = "Place Order";
            btnPlaceOrder.BackColor = System.Drawing.Color.LightGreen;
            btnPlaceOrder.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnPlaceOrder.Size = new System.Drawing.Size(120, 40);
            btnPlaceOrder.Location = new System.Drawing.Point(12, 600); // adjust as needed
            btnPlaceOrder.Click += BtnPlaceOrder_Click;
            panel1.Controls.Add(btnPlaceOrder);
        }

        // Place Order click handler
        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
            var prod1Controls = panel1.Controls.OfType<Prod1>().Where(p => p.Quantity > 0);
            var prod2Controls = panel1.Controls.OfType<Prod2>().Where(p => p.Quantity > 0);

            if (!prod1Controls.Any() && !prod2Controls.Any())
            {
                MessageBox.Show("No items in the order.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string summary = "";
            summary += "                   CAFE DOS\n";
            summary += "-----------------------------------------\n";
            summary += "Order Summary:\n";

            decimal total = 0;

            // Helper: Clean alignment for each line
            string MakeLine(string name, int qty, decimal price)
            {
                string item = $" • {name} (x{qty})";
                string spaces = new string('.', Math.Max(1, 40 - item.Length));
                return $"{item} {spaces} ₱{price}";
            }

            foreach (var prod1 in prod1Controls)
            {
                summary += MakeLine(prod1.ProductName, prod1.Quantity, prod1.TotalPrice) + "\n";
                total += prod1.TotalPrice;
            }

            foreach (var prod2 in prod2Controls)
            {
                summary += MakeLine(prod2.ProductName, prod2.Quantity, prod2.TotalPrice) + "\n";
                total += prod2.TotalPrice;
            }

            summary += "--------------------------------------------------\n";
            summary += $"TOTAL PAYMENT:{new string(' ', 29)}₱{total}\n";
            summary += $"Generated on: {DateTime.Now:MMMM dd, yyyy}\n";


            // Show receipt form with Print button
            ReceiptForm receiptForm = new ReceiptForm(summary);
            receiptForm.ShowDialog();

            // Reset quantities
            foreach (var prod1 in prod1Controls) prod1.ResetQuantity();
            foreach (var prod2 in prod2Controls) prod2.ResetQuantity();

            UpdateOverallTotal();
        }


        private void UpdateOverallTotal()
        {
            decimal total = 0;

            foreach (var prod1 in panel1.Controls.OfType<Prod1>())
                total += prod1.TotalPrice;

            foreach (var prod2 in panel1.Controls.OfType<Prod2>())
                total += prod2.TotalPrice;

            lblTotalPrice.Text = $"₱ {total}";
        }

        private void Prod_QuantityChanged(object sender, EventArgs e)
        {
            UpdateOverallTotal();
        }

        // Add Prod1 control (Chocolate Chip Cookie)
        private void button1_Click(object sender, EventArgs e)
        {
            Prod1 prod1 = new Prod1();
            prod1.QuantityChanged += Prod_QuantityChanged;
            panel1.Controls.Add(prod1);
            prod1.Dock = DockStyle.Top;
            UpdateOverallTotal();
        }

        // Add Prod2 control (Chocolate Frappuccino)
        private void button2_Click(object sender, EventArgs e)
        {
            Prod2 prod2 = new Prod2();
            prod2.QuantityChanged += Prod_QuantityChanged;
            panel1.Controls.Add(prod2);
            prod2.Dock = DockStyle.Top;
            UpdateOverallTotal();
        }
    }
}
