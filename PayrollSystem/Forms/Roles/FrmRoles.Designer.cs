namespace PayrollSystem.Forms.Roles
{
    partial class FrmRoles
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
            BtnNewRole = new FontAwesome.Sharp.IconButton();
            BtnDeleteRoles = new FontAwesome.Sharp.IconButton();
            ChkDelete = new CheckBox();
            LabelTotalRoles = new Label();
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
            label1.Size = new Size(109, 38);
            label1.TabIndex = 1;
            label1.Text = "Roles";
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
            // BtnNewRole
            // 
            BtnNewRole.BackColor = Color.White;
            BtnNewRole.FlatAppearance.BorderSize = 0;
            BtnNewRole.FlatStyle = FlatStyle.Flat;
            BtnNewRole.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNewRole.ForeColor = Color.Black;
            BtnNewRole.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            BtnNewRole.IconColor = Color.YellowGreen;
            BtnNewRole.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnNewRole.IconSize = 29;
            BtnNewRole.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNewRole.Location = new Point(380, 116);
            BtnNewRole.Name = "BtnNewRole";
            BtnNewRole.Size = new Size(114, 30);
            BtnNewRole.TabIndex = 10;
            BtnNewRole.Text = "New";
            BtnNewRole.UseVisualStyleBackColor = false;
            BtnNewRole.Click += BtnNewRole_Click;
            // 
            // BtnDeleteRoles
            // 
            BtnDeleteRoles.BackColor = Color.White;
            BtnDeleteRoles.FlatAppearance.BorderSize = 0;
            BtnDeleteRoles.FlatStyle = FlatStyle.Flat;
            BtnDeleteRoles.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeleteRoles.ForeColor = Color.Black;
            BtnDeleteRoles.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            BtnDeleteRoles.IconColor = Color.Red;
            BtnDeleteRoles.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDeleteRoles.IconSize = 29;
            BtnDeleteRoles.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteRoles.Location = new Point(527, 116);
            BtnDeleteRoles.Name = "BtnDeleteRoles";
            BtnDeleteRoles.Size = new Size(147, 30);
            BtnDeleteRoles.TabIndex = 11;
            BtnDeleteRoles.Text = "Delete";
            BtnDeleteRoles.UseVisualStyleBackColor = false;
            BtnDeleteRoles.Click += BtnDeleteRoles_Click;
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
            // LabelTotalRoles
            // 
            LabelTotalRoles.AutoSize = true;
            LabelTotalRoles.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotalRoles.Location = new Point(280, 192);
            LabelTotalRoles.Name = "LabelTotalRoles";
            LabelTotalRoles.Size = new Size(60, 25);
            LabelTotalRoles.TabIndex = 13;
            LabelTotalRoles.Text = "Total";
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
            // FrmRoles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 590);
            Controls.Add(DataList);
            Controls.Add(LabelTotalRoles);
            Controls.Add(ChkDelete);
            Controls.Add(BtnDeleteRoles);
            Controls.Add(BtnNewRole);
            Controls.Add(panel3);
            Controls.Add(TxtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmRoles";
            Text = "FrmRoles";
            Load += FrmRoles_Load;
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox TxtSearch;
        private FontAwesome.Sharp.IconButton BtnNewRole;
        private FontAwesome.Sharp.IconButton BtnDeleteRoles;
        private CheckBox ChkDelete;
        private Label LabelTotalRoles;
        private DataGridViewCheckBoxColumn Delete;
        public DataGridView DataList;
    }
}
