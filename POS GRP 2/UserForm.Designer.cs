namespace POS_GRP_2
{
    partial class UserForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTotalPrice = new Label();
            label5 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            btnFrappuccino = new Button();
            label6 = new Label();
            label7 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(lblTotalPrice);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(417, 881);
            panel1.TabIndex = 0;
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.AutoSize = true;
            lblTotalPrice.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalPrice.ForeColor = Color.Maroon;
            lblTotalPrice.Location = new Point(354, 559);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(15, 17);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(12, 555);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 1;
            label5.Text = "Total : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Sitka Heading", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Maroon;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 30);
            label4.TabIndex = 0;
            label4.Text = "Order Summary";
            // 
            // panel2
            // 
            panel2.BackColor = Color.OldLace;
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(417, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(567, 881);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnFrappuccino);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(254, 54);
            panel4.Name = "panel4";
            panel4.Size = new Size(208, 208);
            panel4.TabIndex = 11;
            // 
            // btnFrappuccino
            // 
            btnFrappuccino.BackColor = Color.LightBlue;
            btnFrappuccino.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFrappuccino.Location = new Point(138, 162);
            btnFrappuccino.Name = "btnFrappuccino";
            btnFrappuccino.Size = new Size(48, 27);
            btnFrappuccino.TabIndex = 3;
            btnFrappuccino.Text = "Add";
            btnFrappuccino.UseVisualStyleBackColor = false;
            btnFrappuccino.Click += button2_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Brown;
            label6.Location = new Point(13, 168);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 2;
            label6.Text = "₱ 99";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Brown;
            label7.Location = new Point(13, 142);
            label7.Name = "label7";
            label7.Size = new Size(132, 15);
            label7.TabIndex = 1;
            label7.Text = "Chocolate Frappuccino";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._151Iced_Coffee_With_Ice_Cream_Recipe_maker;
            pictureBox2.Location = new Point(13, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(185, 115);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Heading", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(26, 9);
            label3.Name = "label3";
            label3.Size = new Size(65, 30);
            label3.TabIndex = 10;
            label3.Text = "Menu";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(26, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(208, 208);
            panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.One_Bowl_Toffee_Bar_Chocolate_Chip_Cookies_1_2;
            pictureBox1.Location = new Point(13, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(140, 162);
            button1.Name = "button1";
            button1.Size = new Size(48, 27);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Brown;
            label1.Location = new Point(13, 142);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 1;
            label1.Text = "Chocolate Chip Cookie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Brown;
            label2.Location = new Point(13, 168);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = " ₱ 59";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 881);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UserForm";
            Text = "UserForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotalPrice;
        private Label label5;
        private Panel panel4;
        private Button btnFrappuccino;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox2;
       
        }
    }
