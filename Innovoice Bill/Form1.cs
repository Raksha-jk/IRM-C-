using Innovoice_Bill.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Innovoice_Bill
{
    public partial class Form1 : Form
    {
        List<Product> products = new List<Product>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvItems.ColumnCount = 4;
            dgvItems.Columns[0].Name = "Item Name";
            dgvItems.Columns[1].Name = "Quantity";
            dgvItems.Columns[2].Name = "Price";
            dgvItems.Columns[3].Name = "Total";
            dgvItems.Columns[3].ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string item = txtItem.Text;
                int qty = int.Parse(txtQuantity.Text);
                decimal price = decimal.Parse(txtPrice.Text);
                decimal total = qty * price;
                Product p = new Product { Item = item, Quantity = qty, Price = price };
                products.Add(p);
                dgvItems.Rows.Add(p.Item, p.Quantity, p.Price,total);

                MessageBox.Show("Item Added!");
                txtItem.Clear();
                txtQuantity.Clear();
                txtPrice.Clear();
            }
            catch
            {
                MessageBox.Show("Please enter valid values.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
                saveFileDialog.Title = "Save Invoice as PDF";
                saveFileDialog.FileName = "Invoice.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Document doc = new Document(PageSize.A4);
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    Paragraph title = new Paragraph("Customer Invoice");
                    title.Alignment = Element.ALIGN_CENTER;
                    doc.Add(title);
                    doc.Add(new Paragraph("\n"));

                    doc.Add(new Paragraph("Customer Details:"));
                    doc.Add(new Paragraph("Name: " + txtCustomerName.Text));
                    doc.Add(new Paragraph("Phone: " + txtPhone.Text));
                    doc.Add(new Paragraph("Address: " + txtAddress.Text));
                    doc.Add(new Paragraph("\n"));

                    PdfPTable table = new PdfPTable(3);
                    table.WidthPercentage = 100;
                    table.AddCell("Item Name");
                    table.AddCell("Quantity");
                    table.AddCell("Price");
                    decimal grandTotal = 0;
                    foreach (DataGridViewRow row in dgvItems.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            table.AddCell(row.Cells[0].Value?.ToString());
                            table.AddCell(row.Cells[1].Value?.ToString());
                            table.AddCell(row.Cells[2].Value?.ToString());
                            table.AddCell(row.Cells[3].Value?.ToString());
                            grandTotal += Convert.ToDecimal(row.Cells[3].Value);
                        }
                    }

                    doc.Add(table);

                    doc.Add(new Paragraph("\nThank you for your purchase!"));
                    doc.Close();

                    MessageBox.Show("PDF Invoice Generated Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
 }

