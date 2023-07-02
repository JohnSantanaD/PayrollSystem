namespace PayrollSystem.Forms.Departments
{
    partial class FrmDepartments
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
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            TxtSearch = new TextBox();
            BtnNewDepartment = new FontAwesome.Sharp.IconButton();
            BtnDeleteDepartments = new FontAwesome.Sharp.IconButton();
            ChkDelete = new CheckBox();
            LabelTotalDepartment = new Label();
            DataList = new DataGridView();
            Delete = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DataList).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(238, 38);
            label1.TabIndex = 1;
            label1.Text = "Departments";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 116);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(90, 138);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 5;
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.White;
            TxtSearch.BorderStyle = BorderStyle.None;
            TxtSearch.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            TxtSearch.ForeColor = Color.Black;
            TxtSearch.Location = new Point(90, 107);
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(250, 30);
            TxtSearch.TabIndex = 4;
            TxtSearch.TextChanged += TxtSearch_TextChanged;
            TxtSearch.KeyPress += TxtSearch_KeyPress;
            // 
            // BtnNewDepartment
            // 
            BtnNewDepartment.BackColor = Color.White;
            BtnNewDepartment.FlatAppearance.BorderSize = 0;
            BtnNewDepartment.FlatStyle = FlatStyle.Flat;
            BtnNewDepartment.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNewDepartment.ForeColor = Color.Black;
            BtnNewDepartment.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            BtnNewDepartment.IconColor = Color.YellowGreen;
            BtnNewDepartment.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnNewDepartment.IconSize = 29;
            BtnNewDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNewDepartment.Location = new Point(380, 116);
            BtnNewDepartment.Name = "BtnNewDepartment";
            BtnNewDepartment.Size = new Size(114, 30);
            BtnNewDepartment.TabIndex = 10;
            BtnNewDepartment.Text = "New";
            BtnNewDepartment.UseVisualStyleBackColor = false;
            BtnNewDepartment.Click += BtnNewDepartments_Click;
            // 
            // BtnDeleteDepartments
            // 
            BtnDeleteDepartments.BackColor = Color.White;
            BtnDeleteDepartments.FlatAppearance.BorderSize = 0;
            BtnDeleteDepartments.FlatStyle = FlatStyle.Flat;
            BtnDeleteDepartments.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeleteDepartments.ForeColor = Color.Black;
            BtnDeleteDepartments.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            BtnDeleteDepartments.IconColor = Color.Red;
            BtnDeleteDepartments.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDeleteDepartments.IconSize = 29;
            BtnDeleteDepartments.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteDepartments.Location = new Point(527, 116);
            BtnDeleteDepartments.Name = "BtnDeleteDepartments";
            BtnDeleteDepartments.Size = new Size(147, 30);
            BtnDeleteDepartments.TabIndex = 11;
            BtnDeleteDepartments.Text = "Delete";
            BtnDeleteDepartments.UseVisualStyleBackColor = false;
            BtnDeleteDepartments.Click += BtnDeleteDepartments_Click;
            // 
            // ChkDelete
            // 
            ChkDelete.AutoSize = true;
            ChkDelete.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ChkDelete.Location = new Point(21, 193);
            ChkDelete.Name = "ChkDelete";
            ChkDelete.Size = new Size(89, 28);
            ChkDelete.TabIndex = 12;
            ChkDelete.Text = "Delete";
            ChkDelete.UseVisualStyleBackColor = true;
            ChkDelete.CheckedChanged += ChkDelete_CheckedChanged;
            // 
            // LabelTotalDepartment
            // 
            LabelTotalDepartment.AutoSize = true;
            LabelTotalDepartment.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotalDepartment.Location = new Point(280, 192);
            LabelTotalDepartment.Name = "LabelTotalDepartment";
            LabelTotalDepartment.Size = new Size(60, 25);
            LabelTotalDepartment.TabIndex = 13;
            LabelTotalDepartment.Text = "Total";
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
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
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
            DataList.TabIndex = 14;
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
            // FrmDepartments
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 590);
            Controls.Add(DataList);
            Controls.Add(LabelTotalDepartment);
            Controls.Add(ChkDelete);
            Controls.Add(BtnDeleteDepartments);
            Controls.Add(BtnNewDepartment);
            Controls.Add(panel3);
            Controls.Add(TxtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmDepartments";
            Text = "FrmRoles";
            Load += FrmDepartments_Load;
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox TxtSearch;
        private FontAwesome.Sharp.IconButton BtnNewDepartment;
        private FontAwesome.Sharp.IconButton BtnDeleteDepartments;
        private CheckBox ChkDelete;
        private Label LabelTotalDepartment;
        private DataGridViewCheckBoxColumn Delete;
        public DataGridView DataList;
    }
}