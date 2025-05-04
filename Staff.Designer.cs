namespace EDP
{
    partial class Staff
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
            staffLabel = new Label();
            staffGridView = new DataGridView();
            AddStaffBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)staffGridView).BeginInit();
            SuspendLayout();
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.BackColor = Color.Transparent;
            staffLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            staffLabel.ForeColor = Color.White;
            staffLabel.Location = new Point(27, 97);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(64, 32);
            staffLabel.TabIndex = 9;
            staffLabel.Text = "Staff";
            // 
            // staffGridView
            // 
            staffGridView.AllowUserToAddRows = false;
            staffGridView.AllowUserToDeleteRows = false;
            staffGridView.AllowUserToResizeColumns = false;
            staffGridView.AllowUserToResizeRows = false;
            staffGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            staffGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            staffGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            staffGridView.BackgroundColor = Color.WhiteSmoke;
            staffGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            staffGridView.Location = new Point(27, 142);
            staffGridView.Name = "staffGridView";
            staffGridView.ReadOnly = true;
            staffGridView.RowHeadersVisible = false;
            staffGridView.Size = new Size(740, 151);
            staffGridView.TabIndex = 8;
            // 
            // AddStaffBtn
            // 
            AddStaffBtn.BackColor = Color.Teal;
            AddStaffBtn.FlatAppearance.BorderSize = 0;
            AddStaffBtn.FlatStyle = FlatStyle.Flat;
            AddStaffBtn.ForeColor = Color.WhiteSmoke;
            AddStaffBtn.Location = new Point(657, 106);
            AddStaffBtn.Name = "AddStaffBtn";
            AddStaffBtn.Padding = new Padding(1);
            AddStaffBtn.Size = new Size(110, 30);
            AddStaffBtn.TabIndex = 12;
            AddStaffBtn.Text = "Add Staff";
            AddStaffBtn.UseVisualStyleBackColor = false;
            AddStaffBtn.Click += AddStaffBtn_Click;
            // 
            // Staff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 64);
            ClientSize = new Size(820, 640);
            ControlBox = false;
            Controls.Add(AddStaffBtn);
            Controls.Add(staffLabel);
            Controls.Add(staffGridView);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Staff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff";
            Load += Staff_Load;
            ((System.ComponentModel.ISupportInitialize)staffGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label staffLabel;
        private DataGridView staffGridView;
        private Button AddStaffBtn;
    }
}