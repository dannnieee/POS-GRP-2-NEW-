namespace POS_GRP_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 116);
            label1.Name = "label1";
            label1.Size = new Size(421, 64);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Cafe Dos";
            // 
            // button1
            // 
            button1.BackColor = Color.Wheat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(285, 351);
            button1.Name = "button1";
            button1.Size = new Size(196, 77);
            button1.TabIndex = 1;
            button1.Text = "Take Order";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightBlue;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(513, 351);
            button2.Name = "button2";
            button2.Size = new Size(219, 77);
            button2.TabIndex = 2;
            button2.Text = "Admin";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(373, 195);
            label2.Name = "label2";
            label2.Size = new Size(204, 23);
            label2.TabIndex = 3;
            label2.Text = "Your dosage of Sweetness";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OldLace;
            ClientSize = new Size(984, 881);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
