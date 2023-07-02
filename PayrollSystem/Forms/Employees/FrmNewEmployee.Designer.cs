namespace PayrollSystem.Forms.Employees
{
    partial class FrmNewEmployee
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
            TxtNameEmployee = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            TxtIdEmployee = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            TxtLastName = new TextBox();
            label4 = new Label();
            panel6 = new Panel();
            TxtEmail = new TextBox();
            label6 = new Label();
            panel7 = new Panel();
            TxtPhone = new TextBox();
            label7 = new Label();
            panel8 = new Panel();
            TxtNumberDocument = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            CbxSex = new ComboBox();
            DtpDateBirth = new DateTimePicker();
            panel5 = new Panel();
            TxtAdress = new TextBox();
            label5 = new Label();
            CbxRole = new ComboBox();
            label11 = new Label();
            CbxStatus = new ComboBox();
            label14 = new Label();
            PbxImage = new PictureBox();
            BtnSearchImage = new FontAwesome.Sharp.IconButton();
            BtnCleanImage = new FontAwesome.Sharp.IconButton();
            CbxDepartments = new ComboBox();
            label12 = new Label();
            DtpDateAdmission = new DateTimePicker();
            label13 = new Label();
            panel9 = new Panel();
            TxtSalary = new TextBox();
            label15 = new Label();
            PanelControlsLaunch.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PbxImage).BeginInit();
            SuspendLayout();
            // 
            // PanelControlsLaunch
            // 
            PanelControlsLaunch.BackColor = SystemColors.MenuHighlight;
            PanelControlsLaunch.Controls.Add(label1);
            PanelControlsLaunch.Dock = DockStyle.Top;
            PanelControlsLaunch.Location = new Point(0, 0);
            PanelControlsLaunch.Name = "PanelControlsLaunch";
            PanelControlsLaunch.Size = new Size(734, 36);
            PanelControlsLaunch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 4);
            label1.Name = "label1";
            label1.Size = new Size(338, 31);
            label1.TabIndex = 4;
            label1.Text = "Employee Registration";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 530);
            panel1.Name = "panel1";
            panel1.Size = new Size(734, 46);
            panel1.TabIndex = 16;
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
            BtnCancel.Location = new Point(597, 0);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(137, 46);
            BtnCancel.TabIndex = 13;
            BtnCancel.Text = "Cancel";
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
            BtnEdit.Location = new Point(114, 0);
            BtnEdit.Name = "BtnEdit";
            BtnEdit.Size = new Size(114, 46);
            BtnEdit.TabIndex = 12;
            BtnEdit.Text = "Edit";
            BtnEdit.UseVisualStyleBackColor = false;
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
            BtnSave.Size = new Size(114, 46);
            BtnSave.TabIndex = 11;
            BtnSave.Text = "Save";
            BtnSave.UseVisualStyleBackColor = false;
            BtnSave.Click += BtnSave_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(147, 128);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 2);
            panel2.TabIndex = 22;
            // 
            // TxtNameEmployee
            // 
            TxtNameEmployee.BackColor = Color.White;
            TxtNameEmployee.BorderStyle = BorderStyle.None;
            TxtNameEmployee.ForeColor = Color.Black;
            TxtNameEmployee.Location = new Point(147, 110);
            TxtNameEmployee.Name = "TxtNameEmployee";
            TxtNameEmployee.Size = new Size(181, 16);
            TxtNameEmployee.TabIndex = 21;
            TxtNameEmployee.KeyPress += TxtNameEmployee_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 108);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 20;
            label3.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(147, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 2);
            panel3.TabIndex = 19;
            // 
            // TxtIdEmployee
            // 
            TxtIdEmployee.BackColor = Color.White;
            TxtIdEmployee.BorderStyle = BorderStyle.None;
            TxtIdEmployee.Enabled = false;
            TxtIdEmployee.ForeColor = Color.Black;
            TxtIdEmployee.Location = new Point(147, 64);
            TxtIdEmployee.Name = "TxtIdEmployee";
            TxtIdEmployee.Size = new Size(181, 16);
            TxtIdEmployee.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 62);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 17;
            label2.Text = "ID :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(147, 175);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 2);
            panel4.TabIndex = 25;
            // 
            // TxtLastName
            // 
            TxtLastName.BackColor = Color.White;
            TxtLastName.BorderStyle = BorderStyle.None;
            TxtLastName.ForeColor = Color.Black;
            TxtLastName.Location = new Point(147, 157);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(181, 16);
            TxtLastName.TabIndex = 24;
            TxtLastName.KeyPress += TxtLastName_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-3, 155);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 23;
            label4.Text = "LastName:";
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Location = new Point(531, 292);
            panel6.Name = "panel6";
            panel6.Size = new Size(181, 2);
            panel6.TabIndex = 28;
            // 
            // TxtEmail
            // 
            TxtEmail.BackColor = Color.White;
            TxtEmail.BorderStyle = BorderStyle.None;
            TxtEmail.ForeColor = Color.Black;
            TxtEmail.Location = new Point(531, 274);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(181, 16);
            TxtEmail.TabIndex = 27;
            TxtEmail.KeyPress += TxtEmail_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(386, 272);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 26;
            label6.Text = "Email:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(531, 249);
            panel7.Name = "panel7";
            panel7.Size = new Size(181, 2);
            panel7.TabIndex = 37;
            // 
            // TxtPhone
            // 
            TxtPhone.BackColor = Color.White;
            TxtPhone.BorderStyle = BorderStyle.None;
            TxtPhone.ForeColor = Color.Black;
            TxtPhone.Location = new Point(531, 231);
            TxtPhone.MaxLength = 11;
            TxtPhone.Name = "TxtPhone";
            TxtPhone.Size = new Size(181, 16);
            TxtPhone.TabIndex = 36;
            TxtPhone.KeyPress += TxtPhone_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(382, 229);
            label7.Name = "label7";
            label7.Size = new Size(80, 25);
            label7.TabIndex = 35;
            label7.Text = "Phone:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Location = new Point(147, 314);
            panel8.Name = "panel8";
            panel8.Size = new Size(181, 2);
            panel8.TabIndex = 34;
            // 
            // TxtNumberDocument
            // 
            TxtNumberDocument.BackColor = Color.White;
            TxtNumberDocument.BorderStyle = BorderStyle.None;
            TxtNumberDocument.ForeColor = Color.Black;
            TxtNumberDocument.Location = new Point(147, 296);
            TxtNumberDocument.MaxLength = 11;
            TxtNumberDocument.Name = "TxtNumberDocument";
            TxtNumberDocument.Size = new Size(181, 16);
            TxtNumberDocument.TabIndex = 33;
            TxtNumberDocument.KeyPress += TxtNumberDocument_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(-2, 294);
            label8.Name = "label8";
            label8.Size = new Size(148, 25);
            label8.TabIndex = 32;
            label8.Text = "No.Document:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(1, 245);
            label9.Name = "label9";
            label9.Size = new Size(107, 25);
            label9.TabIndex = 39;
            label9.Text = "DateBirth:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(3, 201);
            label10.Name = "label10";
            label10.Size = new Size(55, 25);
            label10.TabIndex = 38;
            label10.Text = "Sex:";
            // 
            // CbxSex
            // 
            CbxSex.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CbxSex.FormattingEnabled = true;
            CbxSex.Items.AddRange(new object[] { "M", "F" });
            CbxSex.Location = new Point(147, 201);
            CbxSex.Name = "CbxSex";
            CbxSex.Size = new Size(57, 23);
            CbxSex.TabIndex = 40;
            CbxSex.Text = "F";
            // 
            // DtpDateBirth
            // 
            DtpDateBirth.Location = new Point(143, 245);
            DtpDateBirth.Name = "DtpDateBirth";
            DtpDateBirth.Size = new Size(189, 23);
            DtpDateBirth.TabIndex = 41;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(143, 398);
            panel5.Name = "panel5";
            panel5.Size = new Size(191, 2);
            panel5.TabIndex = 44;
            // 
            // TxtAdress
            // 
            TxtAdress.BackColor = Color.White;
            TxtAdress.BorderStyle = BorderStyle.None;
            TxtAdress.ForeColor = Color.Black;
            TxtAdress.Location = new Point(143, 347);
            TxtAdress.Multiline = true;
            TxtAdress.Name = "TxtAdress";
            TxtAdress.Size = new Size(191, 61);
            TxtAdress.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(0, 358);
            label5.Name = "label5";
            label5.Size = new Size(85, 25);
            label5.TabIndex = 42;
            label5.Text = "Adress:";
            // 
            // CbxRole
            // 
            CbxRole.FormattingEnabled = true;
            CbxRole.Location = new Point(532, 371);
            CbxRole.Name = "CbxRole";
            CbxRole.Size = new Size(180, 23);
            CbxRole.TabIndex = 52;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(386, 371);
            label11.Name = "label11";
            label11.Size = new Size(62, 25);
            label11.TabIndex = 51;
            label11.Text = "Role:";
            // 
            // CbxStatus
            // 
            CbxStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CbxStatus.FormattingEnabled = true;
            CbxStatus.Items.AddRange(new object[] { "Inactive", "Active" });
            CbxStatus.Location = new Point(532, 324);
            CbxStatus.Name = "CbxStatus";
            CbxStatus.Size = new Size(180, 23);
            CbxStatus.TabIndex = 54;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(386, 324);
            label14.Name = "label14";
            label14.Size = new Size(79, 25);
            label14.TabIndex = 53;
            label14.Text = "Status:";
            // 
            // PbxImage
            // 
            PbxImage.Image = Properties.Resources.user;
            PbxImage.Location = new Point(561, 42);
            PbxImage.Name = "PbxImage";
            PbxImage.Size = new Size(162, 166);
            PbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImage.TabIndex = 58;
            PbxImage.TabStop = false;
            // 
            // BtnSearchImage
            // 
            BtnSearchImage.BackColor = Color.White;
            BtnSearchImage.FlatAppearance.BorderSize = 0;
            BtnSearchImage.FlatStyle = FlatStyle.Flat;
            BtnSearchImage.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSearchImage.ForeColor = Color.Black;
            BtnSearchImage.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BtnSearchImage.IconColor = Color.BlueViolet;
            BtnSearchImage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnSearchImage.IconSize = 29;
            BtnSearchImage.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSearchImage.Location = new Point(401, 61);
            BtnSearchImage.Name = "BtnSearchImage";
            BtnSearchImage.Size = new Size(137, 46);
            BtnSearchImage.TabIndex = 59;
            BtnSearchImage.Text = "Search";
            BtnSearchImage.UseVisualStyleBackColor = false;
            BtnSearchImage.Click += BtnSearchImage_Click;
            // 
            // BtnCleanImage
            // 
            BtnCleanImage.BackColor = Color.White;
            BtnCleanImage.FlatAppearance.BorderSize = 0;
            BtnCleanImage.FlatStyle = FlatStyle.Flat;
            BtnCleanImage.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCleanImage.ForeColor = Color.Black;
            BtnCleanImage.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnCleanImage.IconColor = Color.Red;
            BtnCleanImage.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnCleanImage.IconSize = 29;
            BtnCleanImage.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCleanImage.Location = new Point(401, 131);
            BtnCleanImage.Name = "BtnCleanImage";
            BtnCleanImage.Size = new Size(137, 46);
            BtnCleanImage.TabIndex = 60;
            BtnCleanImage.Text = "Clean";
            BtnCleanImage.UseVisualStyleBackColor = false;
            BtnCleanImage.Click += BtnCleanImage_Click;
            // 
            // CbxDepartments
            // 
            CbxDepartments.FormattingEnabled = true;
            CbxDepartments.Location = new Point(532, 419);
            CbxDepartments.MaxDropDownItems = 20;
            CbxDepartments.Name = "CbxDepartments";
            CbxDepartments.Size = new Size(180, 23);
            CbxDepartments.TabIndex = 62;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(386, 419);
            label12.Name = "label12";
            label12.Size = new Size(129, 25);
            label12.TabIndex = 61;
            label12.Text = "Department:";
            // 
            // DtpDateAdmission
            // 
            DtpDateAdmission.Location = new Point(160, 490);
            DtpDateAdmission.Name = "DtpDateAdmission";
            DtpDateAdmission.Size = new Size(189, 23);
            DtpDateAdmission.TabIndex = 64;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(3, 488);
            label13.Name = "label13";
            label13.Size = new Size(162, 25);
            label13.TabIndex = 63;
            label13.Text = "DateAdmission:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Location = new Point(142, 450);
            panel9.Name = "panel9";
            panel9.Size = new Size(181, 2);
            panel9.TabIndex = 67;
            // 
            // TxtSalary
            // 
            TxtSalary.BackColor = Color.White;
            TxtSalary.BorderStyle = BorderStyle.None;
            TxtSalary.ForeColor = Color.Black;
            TxtSalary.Location = new Point(142, 432);
            TxtSalary.MaxLength = 20;
            TxtSalary.Name = "TxtSalary";
            TxtSalary.Size = new Size(181, 16);
            TxtSalary.TabIndex = 66;
            TxtSalary.KeyPress += TxtSalary_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(4, 430);
            label15.Name = "label15";
            label15.Size = new Size(79, 25);
            label15.TabIndex = 65;
            label15.Text = "Salary:";
            // 
            // FrmNewEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(734, 576);
            Controls.Add(panel9);
            Controls.Add(TxtSalary);
            Controls.Add(label15);
            Controls.Add(DtpDateAdmission);
            Controls.Add(label13);
            Controls.Add(CbxDepartments);
            Controls.Add(label12);
            Controls.Add(BtnCleanImage);
            Controls.Add(BtnSearchImage);
            Controls.Add(PbxImage);
            Controls.Add(CbxStatus);
            Controls.Add(label14);
            Controls.Add(CbxRole);
            Controls.Add(label11);
            Controls.Add(panel5);
            Controls.Add(TxtAdress);
            Controls.Add(label5);
            Controls.Add(DtpDateBirth);
            Controls.Add(CbxSex);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(panel7);
            Controls.Add(TxtPhone);
            Controls.Add(label7);
            Controls.Add(panel8);
            Controls.Add(TxtNumberDocument);
            Controls.Add(label8);
            Controls.Add(panel6);
            Controls.Add(TxtEmail);
            Controls.Add(label6);
            Controls.Add(panel4);
            Controls.Add(TxtLastName);
            Controls.Add(label4);
            Controls.Add(PanelControlsLaunch);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(TxtNameEmployee);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(TxtIdEmployee);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNewEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNewEmployee";
            PanelControlsLaunch.ResumeLayout(false);
            PanelControlsLaunch.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PbxImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelControlsLaunch;
        private Label label1;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton BtnCancel;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private Panel panel6;
        private Label label6;
        private Panel panel7;
        private Label label7;
        private Panel panel8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel5;
        public TextBox TxtAdress;
        private Label label5;
        private Label label11;
        private Label label14;
        private FontAwesome.Sharp.IconButton BtnSearchImage;
        private FontAwesome.Sharp.IconButton BtnCleanImage;
        public TextBox TxtLastName;
        public TextBox TxtEmail;
        public TextBox TxtPhone;
        public TextBox TxtNumberDocument;
        public ComboBox CbxSex;
        public DateTimePicker DtpDateBirth;
        public ComboBox CbxRole;
        public ComboBox CbxStatus;
        public PictureBox PbxImage;
        public FontAwesome.Sharp.IconButton BtnEdit;
        public FontAwesome.Sharp.IconButton BtnSave;
        public TextBox TxtNameEmployee;
        public TextBox TxtIdEmployee;
        public ComboBox CbxDepartments;
        private Label label12;
        public DateTimePicker DtpDateAdmission;
        private Label label13;
        private Panel panel9;
        public TextBox TxtSalary;
        private Label label15;
    }
}