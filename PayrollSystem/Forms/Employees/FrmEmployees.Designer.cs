namespace PayrollSystem.Forms.Employees
{
    partial class FrmEmployees
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataList = new DataGridView();
            Delete = new DataGridViewCheckBoxColumn();
            LabelTotal = new Label();
            ChkDelete = new CheckBox();
            BtnDelete = new FontAwesome.Sharp.IconButton();
            BtnNew = new FontAwesome.Sharp.IconButton();
            panel3 = new Panel();
            TxtSearch = new TextBox();
            label1 = new Label();
            CbxSearch = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            SuspendLayout();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LimeGreen;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.LimeGreen;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            DataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            DataList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataList.Columns.AddRange(new DataGridViewColumn[] { Delete });
            DataList.Dock = DockStyle.Bottom;
            DataList.EnableHeadersVisualStyles = false;
            DataList.GridColor = Color.LightSeaGreen;
            DataList.Location = new Point(0, 220);
            DataList.MultiSelect = false;
            DataList.Name = "DataList";
            DataList.ReadOnly = true;
            DataList.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Green;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = Color.Green;
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            DataList.RowsDefaultCellStyle = dataGridViewCellStyle3;
            DataList.RowTemplate.Height = 25;
            DataList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DataList.Size = new Size(865, 370);
            DataList.TabIndex = 23;
            DataList.CellContentClick += DataList_CellContentClick;
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
            LabelTotal.Location = new Point(280, 188);
            LabelTotal.Name = "LabelTotal";
            LabelTotal.Size = new Size(60, 25);
            LabelTotal.TabIndex = 22;
            LabelTotal.Text = "Total";
            // 
            // ChkDelete
            // 
            ChkDelete.AutoSize = true;
            ChkDelete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChkDelete.Location = new Point(21, 189);
            ChkDelete.Name = "ChkDelete";
            ChkDelete.Size = new Size(89, 28);
            ChkDelete.TabIndex = 21;
            ChkDelete.Text = "Delete";
            ChkDelete.UseVisualStyleBackColor = true;
            ChkDelete.CheckedChanged += ChkDelete_CheckedChanged;
            // 
            // BtnDelete
            // 
            BtnDelete.BackColor = Color.White;
            BtnDelete.FlatAppearance.BorderSize = 0;
            BtnDelete.FlatStyle = FlatStyle.Flat;
            BtnDelete.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDelete.ForeColor = Color.Black;
            BtnDelete.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            BtnDelete.IconColor = Color.Red;
            BtnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDelete.IconSize = 29;
            BtnDelete.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDelete.Location = new Point(562, 112);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(147, 30);
            BtnDelete.TabIndex = 20;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Click += BtnDelete_Click;
            // 
            // BtnNew
            // 
            BtnNew.BackColor = Color.White;
            BtnNew.FlatAppearance.BorderSize = 0;
            BtnNew.FlatStyle = FlatStyle.Flat;
            BtnNew.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNew.ForeColor = Color.Black;
            BtnNew.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            BtnNew.IconColor = Color.YellowGreen;
            BtnNew.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnNew.IconSize = 29;
            BtnNew.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNew.Location = new Point(415, 112);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(114, 30);
            BtnNew.TabIndex = 19;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(136, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 18;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.White;
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSearch.ForeColor = Color.Black;
            TxtSearch.Location = new Point(136, 103);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(250, 30);
            TxtSearch.TabIndex = 17;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.KeyPress += TxtSearch_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(199, 38);
            label1.TabIndex = 15;
            label1.Text = "Employees";
            // 
            // CbxSearch
            // 
            CbxSearch.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            CbxSearch.FormattingEnabled = true;
            CbxSearch.Items.AddRange(new object[] { "Name", "Document" });
            CbxSearch.Location = new Point(5, 113);
            CbxSearch.Name = "CbxSearch";
            CbxSearch.Size = new Size(121, 28);
            CbxSearch.TabIndex = 24;
            CbxSearch.Text = "Name";
            // 
            // FrmEmployees
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(865, 590);
            Controls.Add(CbxSearch);
            Controls.Add(DataList);
            Controls.Add(LabelTotal);
            Controls.Add(ChkDelete);
            Controls.Add(BtnDelete);
            Controls.Add(BtnNew);
            Controls.Add(panel3);
            Controls.Add(TxtSearch);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmEmployees";
            Text = "FrmEmployees";
            Load += FrmEmployees_Load;
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView DataList;
        private DataGridViewCheckBoxColumn Delete;
        private Label LabelTotal;
        private CheckBox ChkDelete;
        private FontAwesome.Sharp.IconButton BtnDelete;
        private FontAwesome.Sharp.IconButton BtnNew;
        private Panel panel3;
        private TextBox TxtSearch;
        private Label label1;
        private ComboBox CbxSearch;
    }
}