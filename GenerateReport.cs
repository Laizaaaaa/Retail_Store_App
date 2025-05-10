using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace EDP
{
    public partial class GenerateReport : Form
    {
        private Home homeForm;

        public GenerateReport(Home home)
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string procName = "generate_sales_report";
                using (MySqlCommand cmd = new MySqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@start_date", startDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@end_date", endDatePicker.Value.Date);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable reportTable = new DataTable();
                        adapter.Fill(reportTable);
                        // Set the data source
                        reportGridView.DataSource = reportTable;

                        // Resize DataGridView height based on number of rows
                        int rowHeight = reportGridView.RowTemplate.Height;
                        int headerHeight = reportGridView.ColumnHeadersHeight;
                        int totalHeight = headerHeight + (reportGridView.Rows.Count * rowHeight);

                        // Optional max height
                        int maxHeight = 400;
                        reportGridView.Height = Math.Min(totalHeight + 2, maxHeight);

                        // Show the grid
                        reportGridView.Visible = true;

                        // Dynamically position export buttons below the DataGridView
                        int buttonSpacing = 10;
                        exportPdfBtn.Top = reportGridView.Bottom + buttonSpacing;
                        exportCsvBtn.Top = reportGridView.Bottom + buttonSpacing;

                        // Optional: position side by side
                        exportPdfBtn.Left = reportGridView.Left;
                        exportCsvBtn.Left = exportPdfBtn.Right + 10;

                        // Show the buttons
                        exportPdfBtn.Visible = true;
                        exportCsvBtn.Visible = true;
                    }
                }
            }
        }
        private void exportPdfBtn_Click(object sender, EventArgs e)
        {
            if (reportGridView.DataSource == null)
            {
                MessageBox.Show("Generate a report first.");
                return;
            }

            // Use the selected date range in the file name
            string startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = endDatePicker.Value.ToString("yyyy-MM-dd");
            string defaultFileName = $"Sales_Report_{startDate}_to_{endDate}.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = defaultFileName;

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 20f, 20f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                // Add Title with Date Range
                var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                pdfDoc.Add(new Paragraph($"JFKL Sari-sari Store", titleFont));
                pdfDoc.Add(new Paragraph($"Sales Report: {startDate} to {endDate}", titleFont));
                pdfDoc.Add(new Paragraph("\n"));

                // Add Table with Column Headers
                PdfPTable table = new PdfPTable(reportGridView.Columns.Count)
                {
                    WidthPercentage = 100
                };

                // Adding headers
                foreach (DataGridViewColumn column in reportGridView.Columns)
                {
                    table.AddCell(new Phrase(column.HeaderText, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12)));
                }

                // Adding data rows
                foreach (DataGridViewRow row in reportGridView.Rows)
                {
                    if (!row.IsNewRow) // Ignore the empty row at the end
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            table.AddCell(new Phrase(cell.Value?.ToString() ?? string.Empty, FontFactory.GetFont(FontFactory.HELVETICA, 10)));
                        }
                    }
                }

                pdfDoc.Add(table);

                // Add Footer
                var footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 10);
                pdfDoc.Add(new Paragraph("\n\nGenerated by EDP System", footerFont));

                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("PDF exported successfully.");
        }


        private void exportCsvBtn_Click(object sender, EventArgs e)
        {
            if (reportGridView.DataSource == null)
            {
                MessageBox.Show("Generate a report first.");
                return;
            }

            string startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = endDatePicker.Value.ToString("yyyy-MM-dd");
            string defaultFileName = $"Sales_Report_{startDate}_to_{endDate}.csv";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV Files|*.csv";
            saveFileDialog.Title = "Save as CSV";
            saveFileDialog.FileName = defaultFileName;

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            try
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
                {
                    // Write the report title and date range
                    sw.WriteLine($"Sales Report from {startDate} to {endDate}");
                    sw.WriteLine();

                    // Write headers
                    List<string> headers = new List<string>();
                    foreach (DataGridViewColumn column in reportGridView.Columns)
                    {
                        headers.Add($"\"{column.HeaderText}\"");
                    }
                    sw.WriteLine(string.Join(",", headers));

                    // Write data rows
                    foreach (DataGridViewRow row in reportGridView.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            List<string> cells = new List<string>();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                string value = cell.Value?.ToString() ?? string.Empty;
                                value = value.Replace("\"", "\"\""); // Escape quotes
                                cells.Add($"\"{value}\"");           // Wrap each cell in quotes
                            }
                            sw.WriteLine(string.Join(",", cells));
                        }
                    }

                    sw.WriteLine();
                    sw.WriteLine("Generated by EDP System");
                }

                MessageBox.Show("CSV exported successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting CSV: " + ex.Message);
            }
        }

    }
}
