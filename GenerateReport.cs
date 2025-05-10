using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using ClosedXML.Excel;

namespace EDP
{
    public partial class GenerateReport : Form
    {
        private Home homeForm;
        private string currentReportType = "Detailed";

        public GenerateReport(Home home)
        {
            InitializeComponent();
        }

        private void generateBtn_Click(object sender, EventArgs e)
        {
            currentReportType = "Detailed";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string procName = "generate_detailed_sales_report";
                using (MySqlCommand cmd = new MySqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@start_date", startDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@end_date", endDatePicker.Value.Date);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable reportTable = new DataTable();
                        adapter.Fill(reportTable);
                        reportGridView.DataSource = reportTable;

                        // Resize DataGridView height based on number of rows
                        int rowHeight = reportGridView.RowTemplate.Height;
                        int headerHeight = reportGridView.ColumnHeadersHeight;
                        int totalHeight = headerHeight + (reportGridView.Rows.Count * rowHeight);
                        int maxHeight = 400;
                        reportGridView.Height = Math.Min(totalHeight + 2, maxHeight);

                        // Show the grid and buttons
                        reportGridView.Visible = true;

                        // Reposition export buttons
                        int spacing = 10;
                        exportPdfBtn.Top = reportGridView.Bottom + spacing;
                        exportPdfBtn.Left = reportGridView.Left;

                        //exportCsvBtn.Top = reportGridView.Bottom + spacing;
                        //exportCsvBtn.Left = exportPdfBtn.Right + spacing;

                        exportExcelBtn.Top = reportGridView.Bottom + spacing;
                        exportExcelBtn.Left = exportPdfBtn.Right + spacing;

                        exportPdfBtn.Visible = true;
                        //exportCsvBtn.Visible = true;
                        exportExcelBtn.Visible = true;

                    }
                }
            }
        }


        private void generateSummaryReportBtn_Click(object sender, EventArgs e)
        {
            currentReportType = "Summary";

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                string procName = "generate_sales_summary_report";
                using (MySqlCommand cmd = new MySqlCommand(procName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@start_date", startDatePicker.Value.Date);
                    cmd.Parameters.AddWithValue("@end_date", endDatePicker.Value.Date);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable reportTable = new DataTable();
                        adapter.Fill(reportTable);
                        reportGridView.DataSource = reportTable;

                        // Resize DataGridView height based on number of rows
                        int rowHeight = reportGridView.RowTemplate.Height;
                        int headerHeight = reportGridView.ColumnHeadersHeight;
                        int totalHeight = headerHeight + (reportGridView.Rows.Count * rowHeight);
                        int maxHeight = 400;
                        reportGridView.Height = Math.Min(totalHeight + 2, maxHeight);

                        // Show the grid and buttons
                        reportGridView.Visible = true;

                        // Reposition export buttons
                        int spacing = 10;
                        exportPdfBtn.Top = reportGridView.Bottom + spacing;
                        exportPdfBtn.Left = reportGridView.Left;

                        //exportCsvBtn.Top = reportGridView.Bottom + spacing;
                        //exportCsvBtn.Left = exportPdfBtn.Right + spacing;

                        exportExcelBtn.Top = reportGridView.Bottom + spacing;
                        exportExcelBtn.Left = exportPdfBtn.Right + spacing;

                        exportPdfBtn.Visible = true;
                        //exportCsvBtn.Visible = true;
                        exportExcelBtn.Visible = true;

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

            string startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = endDatePicker.Value.ToString("yyyy-MM-dd");
            string defaultFileName = $"{currentReportType}_Sales_Report_{startDate}_to_{endDate}.pdf";

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.Title = "Save as PDF";
            saveFileDialog.FileName = defaultFileName;

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A4, 36f, 36f, 36f, 36f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();

                // Light green background for title row
                PdfPTable titleTable = new PdfPTable(1);
                titleTable.WidthPercentage = 100;

                PdfPCell titleCell = new PdfPCell(new Phrase("JFKL Sari-sari Store Sales Report",
                    FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14, BaseColor.WHITE)))
                {
                    BackgroundColor = new BaseColor(144, 238, 144), // Light green
                    HorizontalAlignment = Element.ALIGN_CENTER,
                    Padding = 8,
                    Border = iTextSharp.text.Rectangle.NO_BORDER
                };
                titleTable.AddCell(titleCell);
                pdfDoc.Add(titleTable);

                // Date range below title
                Paragraph dateRangePara = new Paragraph($"Date Range: {startDate} to {endDate}",
                    FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 11, BaseColor.BLACK))
                {
                    Alignment = Element.ALIGN_CENTER,
                    SpacingAfter = 10f
                };
                pdfDoc.Add(dateRangePara);

                // Main table for data
                PdfPTable table = new PdfPTable(reportGridView.Columns.Count)
                {
                    WidthPercentage = 100,
                    SpacingBefore = 10f
                };

                // Set column widths equally
                float[] widths = Enumerable.Repeat(1f, reportGridView.Columns.Count).ToArray();
                table.SetWidths(widths);

                // Header style
                var headerFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                var headerBackground = new BaseColor(224, 224, 224); // Light gray

                foreach (DataGridViewColumn column in reportGridView.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText, headerFont))
                    {
                        BackgroundColor = headerBackground,
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        Padding = 5
                    };
                    table.AddCell(headerCell);
                }

                // Cell font
                var cellFont = FontFactory.GetFont(FontFactory.HELVETICA, 10);

                foreach (DataGridViewRow row in reportGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string cellText = cell.Value?.ToString() ?? "";
                            PdfPCell dataCell = new PdfPCell(new Phrase(cellText, cellFont))
                            {
                                Padding = 4,
                                HorizontalAlignment = Element.ALIGN_CENTER
                            };
                            table.AddCell(dataCell);
                        }
                    }
                }

                pdfDoc.Add(table);

                // Footer
                var footerFont = FontFactory.GetFont(FontFactory.HELVETICA_OBLIQUE, 9);
                var footer = new Paragraph("\nGenerated by EDP System", footerFont)
                {
                    Alignment = Element.ALIGN_RIGHT
                };
                pdfDoc.Add(footer);

                pdfDoc.Close();
                stream.Close();
            }

            MessageBox.Show("PDF exported successfully.");
        }



        //private void exportCsvBtn_Click(object sender, EventArgs e)
        //{
        //    if (reportGridView.DataSource == null)
        //    {
        //        MessageBox.Show("Generate a report first.");
        //        return;
        //    }

        //    string startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
        //    string endDate = endDatePicker.Value.ToString("yyyy-MM-dd");
        //    string defaultFileName = $"Sales_Report_{startDate}_to_{endDate}.csv";

        //    SaveFileDialog saveFileDialog = new SaveFileDialog();
        //    saveFileDialog.Filter = "CSV Files|*.csv";
        //    saveFileDialog.Title = "Save as CSV";
        //    saveFileDialog.FileName = defaultFileName;

        //    if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

        //    try
        //    {
        //        using (StreamWriter sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8))
        //        {
        //            // Write the report title and date range
        //            sw.WriteLine($"Sales Report from {startDate} to {endDate}");
        //            sw.WriteLine();

        //            // Write headers
        //            List<string> headers = new List<string>();
        //            foreach (DataGridViewColumn column in reportGridView.Columns)
        //            {
        //                headers.Add($"\"{column.HeaderText}\"");
        //            }
        //            sw.WriteLine(string.Join(",", headers));

        //            // Write data rows
        //            foreach (DataGridViewRow row in reportGridView.Rows)
        //            {
        //                if (!row.IsNewRow)
        //                {
        //                    List<string> cells = new List<string>();
        //                    foreach (DataGridViewCell cell in row.Cells)
        //                    {
        //                        string value = cell.Value?.ToString() ?? string.Empty;
        //                        value = value.Replace("\"", "\"\""); // Escape quotes
        //                        cells.Add($"\"{value}\"");           // Wrap each cell in quotes
        //                    }
        //                    sw.WriteLine(string.Join(",", cells));
        //                }
        //            }

        //            sw.WriteLine();
        //            sw.WriteLine("Generated by EDP System");
        //        }

        //        MessageBox.Show("CSV exported successfully.");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error exporting CSV: " + ex.Message);
        //    }
        //}

        private void exportExcelBtn_Click(object sender, EventArgs e)
        {
            if (reportGridView.DataSource == null || reportGridView.Rows.Count == 0)
            {
                MessageBox.Show("Generate a report first.");
                return;
            }

            string startDate = startDatePicker.Value.ToString("yyyy-MM-dd");
            string endDate = endDatePicker.Value.ToString("yyyy-MM-dd");
            string defaultFileName = $"{currentReportType}_Sales_Report_{startDate}_to_{endDate}.xlsx";
            
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel Workbook|*.xlsx";
                saveFileDialog.Title = "Save as Excel";
                saveFileDialog.FileName = defaultFileName;

                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Sales Report");

                        // Title and date range
                        worksheet.Cell(1, 1).Value = "JFKL Sari-sari Store Sales Report";
                        worksheet.Cell(2, 1).Value = $"Date Range: {startDate} to {endDate}";

                        // Merge and style the title
                        var titleRange = worksheet.Range("A1:E1");
                        titleRange.Merge();
                        titleRange.Style.Font.Bold = true;
                        titleRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        titleRange.Style.Fill.BackgroundColor = XLColor.LightGreen;

                        // Merge and style the date range
                        var dateRange = worksheet.Range("A2:E2");
                        dateRange.Merge();
                        dateRange.Style.Font.Italic = true;
                        dateRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;


                        // Column headers
                        int headerRow = 4;
                        int colIndex = 1;
                        foreach (DataGridViewColumn column in reportGridView.Columns)
                        {
                            if (column.Visible)
                            {
                                worksheet.Cell(headerRow, colIndex).Value = column.HeaderText;
                                worksheet.Cell(headerRow, colIndex).Style.Font.Bold = true;
                                colIndex++;
                            }
                        }

                        // Data rows
                        int dataRow = headerRow + 1;
                        foreach (DataGridViewRow row in reportGridView.Rows)
                        {
                            if (row.IsNewRow) continue;

                            colIndex = 1;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.OwningColumn.Visible)
                                {
                                    object value = cell.Value;
                                    if (value is int || value is decimal || value is double || value is float)
                                    {
                                        worksheet.Cell(dataRow, colIndex).Value = Convert.ToDouble(value);
                                    }
                                    else
                                    {
                                        worksheet.Cell(dataRow, colIndex).Value = value?.ToString() ?? "";
                                    }

                                    colIndex++;
                                }
                            }
                            dataRow++;
                        }

                        // Auto adjust column widths
                        worksheet.Columns().AdjustToContents();

                        // Enable filter
                        worksheet.Range(headerRow, 1, headerRow, colIndex - 1).SetAutoFilter();

                        // Save to file
                        workbook.SaveAs(saveFileDialog.FileName);
                    }

                    MessageBox.Show("Excel exported successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error exporting Excel:\n" + ex.Message, "Export Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
