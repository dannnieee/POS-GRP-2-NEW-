namespace POS_GRP_2
{
    partial class Prod2
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
            panel1 = new Panel();
            btnAdd = new Button();
            lblQuantity = new Label();
            btnMinus = new Button();
            lblUnitPrice = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(lblQuantity);
            panel1.Controls.Add(btnMinus);
            panel1.Controls.Add(lblUnitPrice);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(12, 17);
            panel1.Name = "panel1";
            panel1.Size = new Size(208, 208);
            panel1.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.WhiteSmoke;
            btnAdd.Location = new Point(152, 178);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(30, 28);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(133, 185);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(13, 15);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "0";
            // 
            // btnMinus
            // 
            btnMinus.BackColor = Color.Gainsboro;
            btnMinus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinus.Location = new Point(97, 178);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(30, 28);
            btnMinus.TabIndex = 3;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = false;
            btnMinus.Click += btnMinus_Click;
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUnitPrice.ForeColor = Color.Brown;
            lblUnitPrice.Location = new Point(13, 181);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(31, 15);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "₱ 99";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(13, 154);
            label1.Name = "label1";
            label1.Size = new Size(132, 15);
            label1.TabIndex = 1;
            label1.Text = "Chocolate Frappuccino";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._151Iced_Coffee_With_Ice_Cream_Recipe_maker;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 131);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Prod2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "Prod2";
            Size = new Size(232, 249);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label lblUnitPrice;
        private Button btnMinus;
        private Label lblQuantity;
        private Button btnAdd;
    }
}
