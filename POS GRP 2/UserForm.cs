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
    public partial class UserForm : Form
    {

        public UserForm()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Prod1 prod1 = new Prod1();
            prod1.QuantityChanged += Prod_QuantityChanged;
            panel1.Controls.Add(prod1);
            UpdateOverallTotal();
        }

        // Add Chocolate Frappuccino (Prod2)
        private void button2_Click(object sender, EventArgs e)
        {
            Prod2 prod2 = new Prod2();
            prod2.QuantityChanged += Prod_QuantityChanged;
            panel1.Controls.Add(prod2);
            prod2.Dock = DockStyle.Top;
            UpdateOverallTotal();
        }
        private void Prod_QuantityChanged(object sender, EventArgs e)
        {
            UpdateOverallTotal();
        }

        private void UpdateOverallTotal()
        {
            decimal total = 0;
            foreach (Control ctrl in panel1.Controls)
            {
                if (ctrl is Prod1 prod1)
                    total += prod1.TotalPrice;
                else if (ctrl is Prod2 prod2)
                    total += prod2.TotalPrice;
            }
            lblTotalPrice.Text = $"₱ {total}";
        }
    }
}



