namespace POS_GRP_2
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProd1 = new System.Windows.Forms.Button();
            this.btnAddProd2 = new System.Windows.Forms.Button();
            this.picProd1 = new System.Windows.Forms.PictureBox();
            this.picProd2 = new System.Windows.Forms.PictureBox();
            this.labelProd1Name = new System.Windows.Forms.Label();
            this.labelProd1Price = new System.Windows.Forms.Label();
            this.labelProd2Name = new System.Windows.Forms.Label();
            this.labelProd2Price = new System.Windows.Forms.Label();

            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProd1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProd2)).BeginInit();
            this.SuspendLayout();

            // 
            // panel1 (Order Summary)
            // 
            this.panel1.BackColor = System.Drawing.Color.FloralWhite;
            this.panel1.Controls.Add(this.lblTotalPrice);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Size = new System.Drawing.Size(417, 881);

            // 
            // label4 - Order Summary Title
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Text = "Order Summary";

            // 
            // label5 - Total Label
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(12, 555);
            this.label5.Text = "Total : ";

            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotalPrice.Location = new System.Drawing.Point(354, 559);
            this.lblTotalPrice.Text = "₱ 0";

            // 
            // panel2 (Menu)
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.picProd1);
            this.panel2.Controls.Add(this.labelProd1Name);
            this.panel2.Controls.Add(this.labelProd1Price);
            this.panel2.Controls.Add(this.btnAddProd1);
            this.panel2.Controls.Add(this.picProd2);
            this.panel2.Controls.Add(this.labelProd2Name);
            this.panel2.Controls.Add(this.labelProd2Price);
            this.panel2.Controls.Add(this.btnAddProd2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Size = new System.Drawing.Size(567, 881);

            // 
            // label3 - Menu title
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(26, 9);
            this.label3.Text = "Menu";

            // 
            // picProd1 - Chocolate Chip Cookie
            // 
            this.picProd1.Image = Properties.Resources.One_Bowl_Toffee_Bar_Chocolate_Chip_Cookies_1_2;
            this.picProd1.Location = new System.Drawing.Point(26, 54);
            this.picProd1.Size = new System.Drawing.Size(185, 115);
            this.picProd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // labelProd1Name
            // 
            this.labelProd1Name.AutoSize = true;
            this.labelProd1Name.ForeColor = System.Drawing.Color.Brown;
            this.labelProd1Name.Location = new System.Drawing.Point(26, 172);
            this.labelProd1Name.Text = "Chocolate Chip Cookie";

            // 
            // labelProd1Price
            // 
            this.labelProd1Price.AutoSize = true;
            this.labelProd1Price.ForeColor = System.Drawing.Color.Brown;
            this.labelProd1Price.Location = new System.Drawing.Point(26, 192);
            this.labelProd1Price.Text = "₱ 59";

            // 
            // btnAddProd1
            // 
            this.btnAddProd1.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddProd1.Location = new System.Drawing.Point(140, 190);
            this.btnAddProd1.Size = new System.Drawing.Size(48, 27);
            this.btnAddProd1.Text = "Add";
            this.btnAddProd1.Click += new System.EventHandler(this.button1_Click);

            // 
            // picProd2 - Chocolate Frappuccino
            // 
            this.picProd2.Image = Properties.Resources._151Iced_Coffee_With_Ice_Cream_Recipe_maker;
            this.picProd2.Location = new System.Drawing.Point(254, 54);
            this.picProd2.Size = new System.Drawing.Size(185, 115);
            this.picProd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // 
            // labelProd2Name
            // 
            this.labelProd2Name.AutoSize = true;
            this.labelProd2Name.ForeColor = System.Drawing.Color.Brown;
            this.labelProd2Name.Location = new System.Drawing.Point(254, 172);
            this.labelProd2Name.Text = "Chocolate Frappuccino";

            // 
            // labelProd2Price
            // 
            this.labelProd2Price.AutoSize = true;
            this.labelProd2Price.ForeColor = System.Drawing.Color.Brown;
            this.labelProd2Price.Location = new System.Drawing.Point(254, 192);
            this.labelProd2Price.Text = "₱ 99";

            // 
            // btnAddProd2
            // 
            this.btnAddProd2.BackColor = System.Drawing.Color.LightBlue;
            this.btnAddProd2.Location = new System.Drawing.Point(378, 190);
            this.btnAddProd2.Size = new System.Drawing.Size(48, 27);
            this.btnAddProd2.Text = "Add";
            this.btnAddProd2.Click += new System.EventHandler(this.button2_Click);

            // 
            // UserForm
            // 
            this.ClientSize = new System.Drawing.Size(984, 881);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Text = "UserForm";

            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProd1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProd2)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.PictureBox picProd1;
        private System.Windows.Forms.PictureBox picProd2;
        private System.Windows.Forms.Label labelProd1Name;
        private System.Windows.Forms.Label labelProd1Price;
        private System.Windows.Forms.Label labelProd2Name;
        private System.Windows.Forms.Label labelProd2Price;
        private System.Windows.Forms.Button btnAddProd1;
        private System.Windows.Forms.Button btnAddProd2;
    }
}
