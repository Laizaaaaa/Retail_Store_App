namespace EDP
{
    partial class GenerateReport
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
            addProductForm = new Panel();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            endDateLabel = new Label();
            generateBtn = new Button();
            startDateLabel = new Label();
            generateLabel = new Label();
            reportGridView = new DataGridView();
            exportCsvBtn = new Button();
            exportPdfBtn = new Button();
            addProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reportGridView).BeginInit();
            SuspendLayout();
            // 
            // addProductForm
            // 
            addProductForm.BackColor = SystemColors.Desktop;
            addProductForm.Controls.Add(endDatePicker);
            addProductForm.Controls.Add(startDatePicker);
            addProductForm.Controls.Add(endDateLabel);
            addProductForm.Controls.Add(generateBtn);
            addProductForm.Controls.Add(startDateLabel);
            addProductForm.Controls.Add(generateLabel);
            addProductForm.Location = new Point(104, 60);
            addProductForm.Name = "addProductForm";
            addProductForm.Size = new Size(609, 146);
            addProductForm.TabIndex = 3;
            // 
            // endDatePicker
            // 
            endDatePicker.Location = new Point(246, 105);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(200, 23);
            endDatePicker.TabIndex = 19;
            // 
            // startDatePicker
            // 
            startDatePicker.Location = new Point(33, 105);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(200, 23);
            startDatePicker.TabIndex = 18;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.ForeColor = Color.WhiteSmoke;
            endDateLabel.Location = new Point(246, 80);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(54, 15);
            endDateLabel.TabIndex = 17;
            endDateLabel.Text = "End Date";
            // 
            // generateBtn
            // 
            generateBtn.BackColor = Color.Teal;
            generateBtn.FlatAppearance.BorderSize = 0;
            generateBtn.FlatStyle = FlatStyle.Flat;
            generateBtn.ForeColor = Color.WhiteSmoke;
            generateBtn.Location = new Point(469, 97);
            generateBtn.Name = "generateBtn";
            generateBtn.Padding = new Padding(2);
            generateBtn.Size = new Size(115, 31);
            generateBtn.TabIndex = 15;
            generateBtn.Text = "Generate";
            generateBtn.UseVisualStyleBackColor = false;
            generateBtn.Click += generateBtn_Click;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.ForeColor = Color.WhiteSmoke;
            startDateLabel.Location = new Point(33, 80);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(58, 15);
            startDateLabel.TabIndex = 2;
            startDateLabel.Text = "Start Date";
            // 
            // generateLabel
            // 
            generateLabel.AutoSize = true;
            generateLabel.BackColor = Color.Transparent;
            generateLabel.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            generateLabel.ForeColor = Color.WhiteSmoke;
            generateLabel.Location = new Point(227, 29);
            generateLabel.Name = "generateLabel";
            generateLabel.Size = new Size(153, 25);
            generateLabel.TabIndex = 0;
            generateLabel.Text = "Generate Report";
            // 
            // reportGridView
            // 
            reportGridView.AllowUserToAddRows = false;
            reportGridView.AllowUserToDeleteRows = false;
            reportGridView.AllowUserToResizeColumns = false;
            reportGridView.AllowUserToResizeRows = false;
            reportGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            reportGridView.BorderStyle = BorderStyle.None;
            reportGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            reportGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            reportGridView.EnableHeadersVisualStyles = false;
            reportGridView.Location = new Point(104, 238);
            reportGridView.Name = "reportGridView";
            reportGridView.ReadOnly = true;
            reportGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            reportGridView.ScrollBars = ScrollBars.Vertical;
            reportGridView.ShowCellToolTips = false;
            reportGridView.ShowEditingIcon = false;
            reportGridView.Size = new Size(609, 150);
            reportGridView.TabIndex = 4;
            reportGridView.Visible = false;
            // 
            // exportCsvBtn
            // 
            exportCsvBtn.BackColor = Color.Teal;
            exportCsvBtn.FlatAppearance.BorderSize = 0;
            exportCsvBtn.FlatStyle = FlatStyle.Flat;
            exportCsvBtn.ForeColor = Color.WhiteSmoke;
            exportCsvBtn.Location = new Point(612, 404);
            exportCsvBtn.Name = "exportCsvBtn";
            exportCsvBtn.Padding = new Padding(2);
            exportCsvBtn.Size = new Size(101, 31);
            exportCsvBtn.TabIndex = 20;
            exportCsvBtn.Text = "Export CSV";
            exportCsvBtn.UseVisualStyleBackColor = false;
            exportCsvBtn.Visible = false;
            exportCsvBtn.Click += exportCsvBtn_Click;
            // 
            // exportPdfBtn
            // 
            exportPdfBtn.BackColor = Color.Teal;
            exportPdfBtn.FlatAppearance.BorderSize = 0;
            exportPdfBtn.FlatStyle = FlatStyle.Flat;
            exportPdfBtn.ForeColor = Color.WhiteSmoke;
            exportPdfBtn.Location = new Point(505, 404);
            exportPdfBtn.Name = "exportPdfBtn";
            exportPdfBtn.Padding = new Padding(2);
            exportPdfBtn.Size = new Size(101, 31);
            exportPdfBtn.TabIndex = 21;
            exportPdfBtn.Text = "Export PDF";
            exportPdfBtn.UseVisualStyleBackColor = false;
            exportPdfBtn.Visible = false;
            exportPdfBtn.Click += exportPdfBtn_Click;
            // 
            // GenerateReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(exportPdfBtn);
            Controls.Add(exportCsvBtn);
            Controls.Add(reportGridView);
            Controls.Add(addProductForm);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GenerateReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GenerateReport";
            addProductForm.ResumeLayout(false);
            addProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reportGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel addProductForm;
        private Label endDateLabel;
        private TextBox endDateTxtbox;
        private Button generateBtn;
        private Label startDateLabel;
        private TextBox startDateTxtbox;
        private Label generateLabel;
        private DataGridView reportGridView;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Button exportCsvBtn;
        private Button exportPdfBtn;
    }
}