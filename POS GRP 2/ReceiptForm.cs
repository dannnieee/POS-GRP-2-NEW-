using System;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace POS_GRP_2
{
    public partial class ReceiptForm : Form
    {
        private string receiptText;

        public ReceiptForm(string text)
        {
            InitializeComponent();
            receiptText = text;
            SetupUI();
        }

        private void SetupUI()
        {
            this.Text = "Receipt Preview";
            this.Size = new System.Drawing.Size(420, 600);

            TextBox txt = new TextBox();
            txt.Multiline = true;
            txt.ReadOnly = true;
            txt.ScrollBars = ScrollBars.Vertical;
            txt.Font = new System.Drawing.Font("Courier New", 11);
            txt.Dock = DockStyle.Top;
            txt.Height = 500;
            txt.Text = receiptText;
            this.Controls.Add(txt);

            Button btnSavePdf = new Button();
            btnSavePdf.Text = "Save as PDF";
            btnSavePdf.Dock = DockStyle.Bottom;
            btnSavePdf.Height = 40;
            btnSavePdf.Click += SavePdf_Click;
            this.Controls.Add(btnSavePdf);
        }

        private void SavePdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF File|*.pdf";
            saveFile.Title = "Save Receipt as PDF";
            saveFile.FileName = "Receipt.pdf";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(saveFile.FileName, FileMode.Create))
                {
                    Document doc = new Document(PageSize.A4, 40, 40, 40, 40);
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Monospaced font for clean alignment
                    var font = FontFactory.GetFont("CourierNew", 12, BaseColor.BLACK);

                    doc.Add(new Paragraph(receiptText, font));

                    doc.Close();
                    writer.Close();
                }

                MessageBox.Show("Receipt saved successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
