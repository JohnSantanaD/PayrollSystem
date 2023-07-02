namespace PayrollSystem.Forms.Users
{
    partial class FrmViewEmployees
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            CbxSearch = new ComboBox();
            DataList = new DataGridView();
            Delete = new DataGridViewCheckBoxColumn();
            LabelTotal = new Label();
            panel3 = new Panel();
            TxtSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            SuspendLayout();
            // 
            // CbxSearch
            // 
            CbxSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CbxSearch.FormattingEnabled = true;
            CbxSearch.Items.AddRange(new object[] { "Name", "Document" });
            CbxSearch.Location = new Point(5, 110);
            CbxSearch.Name = "CbxSearch";
            CbxSearch.Size = new Size(121, 28);
            CbxSearch.TabIndex = 30;
            CbxSearch.Text = "Name";
            // 
            // DataList
            // 
            DataList.AllowUserToAddRows = false;
            DataList.AllowUserToDeleteRows = false;
            DataList.AllowUserToOrderColumns = true;
            DataList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DataList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DataList.BackgroundColor = Color.MintCream;
            DataList.BorderStyle = BorderStyle.None;
            DataList.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DataList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.LimeGreen;
            dataGridViewCellStyle10.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.LimeGreen;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            DataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            DataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataList.Columns.AddRange(new DataGridViewColumn[] { Delete });
            DataList.Dock = DockStyle.Bottom;
            DataList.EnableHeadersVisualStyles = false;
            DataList.GridColor = Color.LightSeaGreen;
            DataList.Location = new Point(0, 174);
            DataList.MultiSelect = false;
            DataList.Name = "DataList";
            DataList.ReadOnly = true;
            DataList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.Green;
            dataGridViewCellStyle11.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            DataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewCellStyle12.BackColor = Color.Green;
            dataGridViewCellStyle12.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle12.ForeColor = Color.White;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle12.SelectionForeColor = Color.White;
            DataList.RowsDefaultCellStyle = dataGridViewCellStyle12;
            DataList.RowTemplate.Height = 25;
            DataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataList.Size = new Size(905, 377);
            DataList.TabIndex = 29;
            DataList.DoubleClick += DataList_DoubleClick;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            Delete.Width = 57;
            // 
            // LabelTotal
            // 
            LabelTotal.AutoSize = true;
            LabelTotal.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotal.Location = new Point(446, 110);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(60, 25);
            LabelTotal.TabIndex = 28;
            LabelTotal.Text = "Total";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(136, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 27;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.White;
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSearch.ForeColor = Color.Black;
            TxtSearch.Location = new Point(136, 100);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(250, 30);
            TxtSearch.TabIndex = 26;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.KeyPress += TxtSearch_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(5, 0);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 25;
            label1.Text = "Employees";
            // 
            // FrmViewEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(905, 551);
            Controls.Add(CbxSearch);
            Controls.Add(DataList);
            Controls.Add(LabelTotal);
            Controls.Add(panel3);
            Controls.Add(TxtSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "FrmViewEmployees";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += FrmViewEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CbxSearch;
        public DataGridView DataList;
        private DataGridViewCheckBoxColumn Delete;
        private Label LabelTotal;
        private Panel panel3;
        private TextBox TxtSearch;
        private Label label1;
    }
}