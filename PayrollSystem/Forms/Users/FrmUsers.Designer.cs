namespace SystemSale.Forms.Users
{
    partial class FrmUsers
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
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            panel3 = new Panel();
            TxtSearch = new TextBox();
            BtnNewUser = new FontAwesome.Sharp.IconButton();
            BtnDeleteUsers = new FontAwesome.Sharp.IconButton();
            ChkDelete = new CheckBox();
            LabelTotalUsers = new Label();
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
            label1.Size = new Size(112, 38);
            label1.TabIndex = 1;
            label1.Text = "Users";
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
            // BtnNewUser
            // 
            BtnNewUser.BackColor = Color.White;
            BtnNewUser.FlatAppearance.BorderSize = 0;
            BtnNewUser.FlatStyle = FlatStyle.Flat;
            BtnNewUser.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnNewUser.ForeColor = Color.Black;
            BtnNewUser.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            BtnNewUser.IconColor = Color.YellowGreen;
            BtnNewUser.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnNewUser.IconSize = 29;
            BtnNewUser.ImageAlign = ContentAlignment.MiddleLeft;
            BtnNewUser.Location = new Point(380, 116);
            BtnNewUser.Name = "BtnNewUser";
            BtnNewUser.Size = new Size(114, 30);
            BtnNewUser.TabIndex = 10;
            BtnNewUser.Text = "New";
            BtnNewUser.UseVisualStyleBackColor = false;
            BtnNewUser.Click += BtnNewUser_Click;
            // 
            // BtnDeleteUsers
            // 
            BtnDeleteUsers.BackColor = Color.White;
            BtnDeleteUsers.FlatAppearance.BorderSize = 0;
            BtnDeleteUsers.FlatStyle = FlatStyle.Flat;
            BtnDeleteUsers.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDeleteUsers.ForeColor = Color.Black;
            BtnDeleteUsers.IconChar = FontAwesome.Sharp.IconChar.SquareMinus;
            BtnDeleteUsers.IconColor = Color.Red;
            BtnDeleteUsers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDeleteUsers.IconSize = 29;
            BtnDeleteUsers.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDeleteUsers.Location = new Point(527, 116);
            BtnDeleteUsers.Name = "BtnDeleteUsers";
            BtnDeleteUsers.Size = new Size(147, 30);
            BtnDeleteUsers.TabIndex = 11;
            BtnDeleteUsers.Text = "Delete";
            BtnDeleteUsers.UseVisualStyleBackColor = false;
            BtnDeleteUsers.Click += BtnDeleteUsers_Click;
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
            // LabelTotalUsers
            // 
            LabelTotalUsers.AutoSize = true;
            LabelTotalUsers.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LabelTotalUsers.Location = new Point(280, 192);
            LabelTotalUsers.Name = "LabelTotalUsers";
            LabelTotalUsers.Size = new Size(60, 25);
            LabelTotalUsers.TabIndex = 13;
            LabelTotalUsers.Text = "Total";
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
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.LimeGreen;
            dataGridViewCellStyle13.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            dataGridViewCellStyle13.ForeColor = Color.White;
            dataGridViewCellStyle13.SelectionBackColor = Color.LimeGreen;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.True;
            DataList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
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
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Green;
            dataGridViewCellStyle14.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle14.ForeColor = Color.White;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            DataList.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = Color.Green;
            dataGridViewCellStyle15.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle15.ForeColor = Color.White;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(0, 192, 192);
            dataGridViewCellStyle15.SelectionForeColor = Color.White;
            DataList.RowsDefaultCellStyle = dataGridViewCellStyle15;
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
            // FrmUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(865, 590);
            Controls.Add(DataList);
            Controls.Add(LabelTotalUsers);
            Controls.Add(ChkDelete);
            Controls.Add(BtnDeleteUsers);
            Controls.Add(BtnNewUser);
            Controls.Add(panel3);
            Controls.Add(TxtSearch);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmUsers";
            Text = "FrmRoles";
            Load += FrmUsers_Load;
            ((System.ComponentModel.ISupportInitialize)DataList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Panel panel3;
        private TextBox TxtSearch;
        private FontAwesome.Sharp.IconButton BtnNewUser;
        private FontAwesome.Sharp.IconButton BtnDeleteUsers;
        private CheckBox ChkDelete;
        private Label LabelTotalUsers;
        private DataGridViewCheckBoxColumn Delete;
        public DataGridView DataList;
    }
}