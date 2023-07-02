namespace SystemSale.Forms.Users
{
    partial class FrmNewUser
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
            PanelControlsLaunch = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            BtnCancel = new FontAwesome.Sharp.IconButton();
            BtnEdit = new FontAwesome.Sharp.IconButton();
            BtnSave = new FontAwesome.Sharp.IconButton();
            panel2 = new Panel();
            TxtUser = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            TxtIdUser = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            TxtPassword = new TextBox();
            label4 = new Label();
            panel5 = new Panel();
            TxtConfirm = new TextBox();
            label5 = new Label();
            label11 = new Label();
            BtnShowPassword = new FontAwesome.Sharp.IconButton();
            BtnShowConfirm = new FontAwesome.Sharp.IconButton();
            BtnSearchEmployee = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            TxtEmployee = new TextBox();
            CbxStatus = new ComboBox();
            label14 = new Label();
            LblIdEmployee = new Label();
            PanelControlsLaunch.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // PanelControlsLaunch
            // 
            PanelControlsLaunch.BackColor = SystemColors.MenuHighlight;
            PanelControlsLaunch.Controls.Add(label1);
            PanelControlsLaunch.Dock = DockStyle.Top;
            PanelControlsLaunch.Location = new Point(0, 0);
            PanelControlsLaunch.Name = "PanelControlsLaunch";
            PanelControlsLaunch.Size = new Size(518, 36);
            PanelControlsLaunch.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(141, 4);
            label1.Name = "label1";
            label1.Size = new Size(263, 31);
            label1.TabIndex = 4;
            label1.Text = "User Registration";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 368);
            panel1.Name = "panel1";
            panel1.Size = new Size(518, 46);
            panel1.TabIndex = 27;
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = Color.White;
            BtnCancel.Dock = DockStyle.Right;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancel.ForeColor = Color.Black;
            BtnCancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            BtnCancel.IconColor = Color.Red;
            BtnCancel.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnCancel.IconSize = 29;
            BtnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancel.Location = new Point(396, 0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(122, 46);
            BtnCancel.TabIndex = 13;
            BtnCancel.Text = "Cancel";
            BtnCancel.TextAlign = ContentAlignment.MiddleRight;
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // BtnEdit
            // 
            BtnEdit.BackColor = Color.White;
            BtnEdit.Dock = DockStyle.Left;
            BtnEdit.FlatAppearance.BorderSize = 0;
            BtnEdit.FlatStyle = FlatStyle.Flat;
            BtnEdit.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEdit.ForeColor = Color.Black;
            BtnEdit.IconChar = FontAwesome.Sharp.IconChar.PencilAlt;
            BtnEdit.IconColor = Color.Blue;
            BtnEdit.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnEdit.IconSize = 29;
            BtnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEdit.Location = new Point(100, 0);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(92, 46);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "Edit";
            BtnEdit.TextAlign = ContentAlignment.MiddleRight;
            BtnEdit.UseVisualStyleBackColor = false;
            BtnEdit.Visible = false;
            BtnEdit.Click += BtnEdit_Click;
            // 
            // BtnSave
            // 
            BtnSave.BackColor = Color.White;
            BtnSave.Dock = DockStyle.Left;
            BtnSave.FlatAppearance.BorderSize = 0;
            BtnSave.FlatStyle = FlatStyle.Flat;
            BtnSave.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSave.ForeColor = Color.Black;
            BtnSave.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            BtnSave.IconColor = Color.Green;
            BtnSave.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnSave.IconSize = 29;
            BtnSave.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSave.Location = new Point(0, 0);
            BtnSave.Name = "BtnSave";
            BtnSave.Size = new Size(100, 46);
            BtnSave.TabIndex = 11;
            BtnSave.Text = "Save";
            BtnSave.TextAlign = ContentAlignment.MiddleRight;
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(124, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 2);
            panel2.TabIndex = 33;
            // 
            // TxtUser
            // 
            TxtUser.BackColor = Color.White;
            TxtUser.BorderStyle = BorderStyle.None;
            TxtUser.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtUser.ForeColor = Color.Black;
            TxtUser.Location = new Point(124, 99);
            TxtUser.Name = "TxtUser";
            TxtUser.Size = new Size(250, 24);
            TxtUser.TabIndex = 32;
            TxtUser.KeyPress += TxtUserName_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(5, 106);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 31;
            label3.Text = "User:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(124, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 30;
            // 
            // TxtIdUser
            // 
            TxtIdUser.BackColor = Color.White;
            TxtIdUser.BorderStyle = BorderStyle.None;
            TxtIdUser.Enabled = false;
            TxtIdUser.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIdUser.ForeColor = Color.Black;
            TxtIdUser.Location = new Point(124, 52);
            TxtIdUser.Name = "TxtIdUser";
            TxtIdUser.Size = new Size(250, 24);
            TxtIdUser.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(8, 59);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 28;
            label2.Text = "ID :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(124, 178);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 2);
            panel4.TabIndex = 36;
            // 
            // TxtPassword
            // 
            TxtPassword.BackColor = Color.White;
            TxtPassword.BorderStyle = BorderStyle.None;
            TxtPassword.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.Location = new Point(124, 151);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.Size = new Size(250, 24);
            TxtPassword.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(5, 158);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 34;
            label4.Text = "Password:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(124, 230);
            panel5.Name = "panel5";
            panel5.Size = new Size(250, 2);
            panel5.TabIndex = 39;
            // 
            // TxtConfirm
            // 
            TxtConfirm.BackColor = Color.White;
            TxtConfirm.BorderStyle = BorderStyle.None;
            TxtConfirm.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtConfirm.ForeColor = Color.Black;
            TxtConfirm.Location = new Point(124, 203);
            TxtConfirm.Name = "TxtConfirm";
            TxtConfirm.PasswordChar = '*';
            TxtConfirm.Size = new Size(250, 24);
            TxtConfirm.TabIndex = 38;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(5, 210);
            label5.Name = "label5";
            label5.Size = new Size(92, 25);
            label5.TabIndex = 37;
            label5.Text = "Confirm:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(6, 265);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 53;
            label11.Text = "Employee:";
            // 
            // BtnShowPassword
            // 
            BtnShowPassword.FlatAppearance.BorderSize = 0;
            BtnShowPassword.FlatStyle = FlatStyle.Flat;
            BtnShowPassword.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnShowPassword.IconColor = Color.Black;
            BtnShowPassword.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnShowPassword.IconSize = 30;
            BtnShowPassword.Location = new Point(396, 151);
            BtnShowPassword.Name = "BtnShowPassword";
            BtnShowPassword.Size = new Size(31, 32);
            BtnShowPassword.TabIndex = 55;
            BtnShowPassword.UseVisualStyleBackColor = true;
            BtnShowPassword.Click += BtnShowPassword_Click;
            // 
            // BtnShowConfirm
            // 
            BtnShowConfirm.FlatAppearance.BorderSize = 0;
            BtnShowConfirm.FlatStyle = FlatStyle.Flat;
            BtnShowConfirm.IconChar = FontAwesome.Sharp.IconChar.Eye;
            BtnShowConfirm.IconColor = Color.Black;
            BtnShowConfirm.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnShowConfirm.IconSize = 30;
            BtnShowConfirm.Location = new Point(396, 203);
            BtnShowConfirm.Name = "BtnShowConfirm";
            BtnShowConfirm.Size = new Size(31, 32);
            BtnShowConfirm.TabIndex = 56;
            BtnShowConfirm.UseVisualStyleBackColor = true;
            BtnShowConfirm.Click += BtnShowConfirm_Click;
            // 
            // BtnSearchEmployee
            // 
            BtnSearchEmployee.FlatAppearance.BorderSize = 0;
            BtnSearchEmployee.FlatStyle = FlatStyle.Flat;
            BtnSearchEmployee.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BtnSearchEmployee.IconColor = Color.Black;
            BtnSearchEmployee.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnSearchEmployee.IconSize = 30;
            BtnSearchEmployee.Location = new Point(396, 258);
            BtnSearchEmployee.Name = "BtnSearchEmployee";
            BtnSearchEmployee.Size = new Size(31, 32);
            BtnSearchEmployee.TabIndex = 59;
            BtnSearchEmployee.UseVisualStyleBackColor = true;
            BtnSearchEmployee.Click += BtnSearchEmployee_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(124, 285);
            panel6.Name = "panel6";
            panel6.Size = new Size(250, 2);
            panel6.TabIndex = 58;
            // 
            // TxtEmployee
            // 
            TxtEmployee.BackColor = Color.White;
            TxtEmployee.BorderStyle = BorderStyle.None;
            TxtEmployee.Enabled = false;
            TxtEmployee.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmployee.ForeColor = Color.Black;
            TxtEmployee.Location = new Point(124, 258);
            TxtEmployee.Name = "TxtEmployee";
            TxtEmployee.Size = new Size(250, 24);
            TxtEmployee.TabIndex = 57;
            // 
            // CbxStatus
            // 
            CbxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CbxStatus.FormattingEnabled = true;
            CbxStatus.Items.AddRange(new object[] { "Inactive", "Active" });
            CbxStatus.Location = new Point(124, 321);
            CbxStatus.Name = "CbxStatus";
            CbxStatus.Size = new Size(180, 23);
            CbxStatus.TabIndex = 61;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(5, 321);
            label14.Name = "label14";
            label14.Size = new Size(79, 25);
            label14.TabIndex = 60;
            label14.Text = "Status:";
            // 
            // LblIdEmployee
            // 
            LblIdEmployee.AutoSize = true;
            LblIdEmployee.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblIdEmployee.Location = new Point(446, 262);
            LblIdEmployee.Name = "LblIdEmployee";
            LblIdEmployee.Size = new Size(18, 25);
            LblIdEmployee.TabIndex = 62;
            LblIdEmployee.Text = ":";
            LblIdEmployee.Visible = false;
            // 
            // FrmNewUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            ClientSize = new Size(518, 414);
            Controls.Add(LblIdEmployee);
            Controls.Add(CbxStatus);
            Controls.Add(label14);
            Controls.Add(BtnSearchEmployee);
            Controls.Add(panel6);
            Controls.Add(TxtEmployee);
            Controls.Add(BtnShowConfirm);
            Controls.Add(BtnShowPassword);
            Controls.Add(label11);
            Controls.Add(panel5);
            Controls.Add(TxtConfirm);
            Controls.Add(label5);
            Controls.Add(panel4);
            Controls.Add(TxtPassword);
            Controls.Add(label4);
            Controls.Add(PanelControlsLaunch);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(TxtUser);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(TxtIdUser);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNewUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNewUser";
            PanelControlsLaunch.ResumeLayout(false);
            PanelControlsLaunch.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelControlsLaunch;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnCancel;
        public FontAwesome.Sharp.IconButton BtnEdit;
        public FontAwesome.Sharp.IconButton BtnSave;
        private Panel panel2;
        public TextBox TxtUser;
        private Label label3;
        private Panel panel3;
        public TextBox TxtIdUser;
        private Label label2;
        private Panel panel4;
        public TextBox TxtPassword;
        private Label label4;
        private Panel panel5;
        public TextBox TxtConfirm;
        private Label label5;
        private Label label11;
        private FontAwesome.Sharp.IconButton BtnShowPassword;
        private FontAwesome.Sharp.IconButton BtnShowConfirm;
        private FontAwesome.Sharp.IconButton BtnSearchEmployee;
        private Panel panel6;
        public TextBox TxtEmployee;
        public ComboBox CbxStatus;
        private Label label14;
        public Label LblIdEmployee;
    }
}