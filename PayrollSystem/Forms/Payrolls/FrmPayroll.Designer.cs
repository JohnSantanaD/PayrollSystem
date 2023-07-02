namespace PayrollSystem.Forms.Payrolls
{
    partial class FrmPayroll
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
            label1 = new Label();
            DtpDesde = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            DtpHasta = new DateTimePicker();
            BtnSearchPayroll = new FontAwesome.Sharp.IconButton();
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
            DataList.Size = new Size(900, 370);
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
            ChkDelete.Visible = false;
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
            BtnDelete.Location = new Point(743, 108);
            BtnDelete.Name = "BtnDelete";
            BtnDelete.Size = new Size(133, 30);
            BtnDelete.TabIndex = 20;
            BtnDelete.Text = "Delete";
            BtnDelete.UseVisualStyleBackColor = false;
            BtnDelete.Visible = false;
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
            BtnNew.Location = new Point(609, 108);
            BtnNew.Name = "BtnNew";
            BtnNew.Size = new Size(108, 30);
            BtnNew.TabIndex = 19;
            BtnNew.Text = "New";
            BtnNew.UseVisualStyleBackColor = false;
            BtnNew.Click += BtnNew_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(135, 38);
            label1.TabIndex = 15;
            label1.Text = "Payroll";
            // 
            // DtpDesde
            // 
            DtpDesde.Location = new Point(86, 113);
            DtpDesde.Name = "DtpDesde";
            DtpDesde.Size = new Size(188, 23);
            DtpDesde.TabIndex = 24;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(5, 111);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 26;
            label2.Text = "Desde:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(289, 111);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 27;
            label3.Text = "Hasta:";
            // 
            // DtpHasta
            // 
            DtpHasta.Location = new Point(361, 111);
            DtpHasta.Name = "DtpHasta";
            DtpHasta.Size = new Size(188, 23);
            DtpHasta.TabIndex = 28;
            // 
            // BtnSearchPayroll
            // 
            BtnSearchPayroll.FlatAppearance.BorderSize = 0;
            BtnSearchPayroll.FlatStyle = FlatStyle.Flat;
            BtnSearchPayroll.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BtnSearchPayroll.IconColor = Color.Black;
            BtnSearchPayroll.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnSearchPayroll.IconSize = 30;
            BtnSearchPayroll.Location = new Point(561, 106);
            BtnSearchPayroll.Name = "BtnSearchPayroll";
            BtnSearchPayroll.Size = new Size(31, 32);
            BtnSearchPayroll.TabIndex = 60;
            BtnSearchPayroll.UseVisualStyleBackColor = true;
            BtnSearchPayroll.Click += BtnSearchPayroll_Click;
            // 
            // FrmPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(900, 590);
            Controls.Add(BtnSearchPayroll);
            Controls.Add(DtpHasta);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(DtpDesde);
            Controls.Add(DataList);
            Controls.Add(LabelTotal);
            Controls.Add(ChkDelete);
            Controls.Add(BtnDelete);
            Controls.Add(BtnNew);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPayroll";
            Text = "FrmEmployees";
            Load += FrmPayrolls_Load;
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
        private Label label1;
        private DateTimePicker DtpDesde;
        private Label label2;
        private Label label3;
        private DateTimePicker DtpHasta;
        private FontAwesome.Sharp.IconButton BtnSearchPayroll;
    }
}