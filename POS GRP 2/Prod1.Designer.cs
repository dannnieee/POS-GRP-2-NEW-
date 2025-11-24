namespace POS_GRP_2
{
    partial class Prod1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblUnitPrice = new Label();
            btnLess = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnAdd = new Button();
            lblQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(13, 148);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 1;
            label1.Text = "Chocolate Chip Cookie";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.ForeColor = Color.Brown;
            lblUnitPrice.Location = new Point(13, 172);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(34, 15);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = " ₱ 59";
            // 
            // btnLess
            // 
            btnLess.BackColor = Color.Gainsboro;
            btnLess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLess.Location = new Point(83, 166);
            btnLess.Name = "btnLess";
            btnLess.Size = new Size(30, 28);
            btnLess.TabIndex = 4;
            btnLess.Text = "_";
            btnLess.UseVisualStyleBackColor = false;
        
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.One_Bowl_Toffee_Bar_Chocolate_Chip_Cookies_1_2;
            pictureBox1.Location = new Point(13, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(154, 107);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnLess);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUnitPrice);
            panel1.Location = new Point(9, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(180, 205);
            panel1.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(138, 166);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(29, 28);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(119, 174);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(13, 15);
            lblQuantity.TabIndex = 9;
            lblQuantity.Text = "0";
            // 
            // Prod1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(panel1);
            Name = "Prod1";
            Size = new Size(229, 248);
            
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lblUnitPrice;
        private Button btnLess;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnAdd;
        private Label lblQuantity;
    }
}
