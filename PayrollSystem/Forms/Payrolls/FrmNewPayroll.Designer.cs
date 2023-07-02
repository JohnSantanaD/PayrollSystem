namespace PayrollSystem.Forms.Payrolls
{
    partial class FrmNewPayroll
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
            TxtIdPayroll = new TextBox();
            label2 = new Label();
            panel4 = new Panel();
            TxtLastName = new TextBox();
            label4 = new Label();
            panel8 = new Panel();
            TxtRole = new TextBox();
            label8 = new Label();
            panel9 = new Panel();
            TxtSalary = new TextBox();
            label15 = new Label();
            LblIdEmployee = new Label();
            BtnSearchEmployee = new FontAwesome.Sharp.IconButton();
            panel6 = new Panel();
            TxtEmployee = new TextBox();
            label11 = new Label();
            panel5 = new Panel();
            TxtPriceOvertime = new TextBox();
            label5 = new Label();
            panel7 = new Panel();
            TxtExtraHours = new TextBox();
            label6 = new Label();
            panel10 = new Panel();
            TxtOvertimePayment = new TextBox();
            label7 = new Label();
            panel11 = new Panel();
            TxtBonuses = new TextBox();
            label9 = new Label();
            panel12 = new Panel();
            TxtSalaryAdvance = new TextBox();
            label10 = new Label();
            panel13 = new Panel();
            TxtSFS = new TextBox();
            label12 = new Label();
            panel14 = new Panel();
            TxtNetSalary = new TextBox();
            label13 = new Label();
            panel15 = new Panel();
            TxtTotalAssignments = new TextBox();
            label14 = new Label();
            panel16 = new Panel();
            TxtTotalDeductions = new TextBox();
            label16 = new Label();
            panel17 = new Panel();
            TxtAFP = new TextBox();
            label17 = new Label();
            panel18 = new Panel();
            TxtTSS = new TextBox();
            label18 = new Label();
            panel19 = new Panel();
            TxtISR = new TextBox();
            label19 = new Label();
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
            PanelControlsLaunch.Size = new Size(800, 36);
            PanelControlsLaunch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(215, 4);
            label1.Name = "label1";
            label1.Size = new Size(299, 31);
            label1.TabIndex = 4;
            label1.Text = "Payroll Registration";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 499);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 46);
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
            BtnCancel.Location = new Point(663, 0);
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
            panel2.Enabled = false;
            panel2.Location = new Point(151, 184);
            panel2.Name = "panel2";
            panel2.Size = new Size(181, 2);
            panel2.TabIndex = 22;
            // 
            // TxtNameEmployee
            // 
            TxtNameEmployee.BackColor = Color.White;
            TxtNameEmployee.BorderStyle = BorderStyle.None;
            TxtNameEmployee.Enabled = false;
            TxtNameEmployee.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNameEmployee.ForeColor = Color.Black;
            TxtNameEmployee.Location = new Point(151, 159);
            TxtNameEmployee.Name = "TxtNameEmployee";
            TxtNameEmployee.Size = new Size(181, 24);
            TxtNameEmployee.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(1, 164);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 20;
            label3.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Enabled = false;
            panel3.Location = new Point(147, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(181, 2);
            panel3.TabIndex = 19;
            // 
            // TxtIdPayroll
            // 
            TxtIdPayroll.BackColor = Color.White;
            TxtIdPayroll.BorderStyle = BorderStyle.None;
            TxtIdPayroll.Enabled = false;
            TxtIdPayroll.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIdPayroll.ForeColor = Color.Black;
            TxtIdPayroll.Location = new Point(147, 57);
            TxtIdPayroll.Name = "TxtIdPayroll";
            TxtIdPayroll.Size = new Size(181, 24);
            TxtIdPayroll.TabIndex = 18;
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
            panel4.Enabled = false;
            panel4.Location = new Point(151, 231);
            panel4.Name = "panel4";
            panel4.Size = new Size(181, 2);
            panel4.TabIndex = 25;
            // 
            // TxtLastName
            // 
            TxtLastName.BackColor = Color.White;
            TxtLastName.BorderStyle = BorderStyle.None;
            TxtLastName.Enabled = false;
            TxtLastName.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtLastName.ForeColor = Color.Black;
            TxtLastName.Location = new Point(151, 206);
            TxtLastName.Name = "TxtLastName";
            TxtLastName.Size = new Size(181, 24);
            TxtLastName.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(-1, 211);
            label4.Name = "label4";
            label4.Size = new Size(115, 25);
            label4.TabIndex = 23;
            label4.Text = "LastName:";
            // 
            // panel8
            // 
            panel8.BackColor = Color.Black;
            panel8.Enabled = false;
            panel8.Location = new Point(150, 278);
            panel8.Name = "panel8";
            panel8.Size = new Size(181, 2);
            panel8.TabIndex = 34;
            // 
            // TxtRole
            // 
            TxtRole.BackColor = Color.White;
            TxtRole.BorderStyle = BorderStyle.None;
            TxtRole.Enabled = false;
            TxtRole.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtRole.ForeColor = Color.Black;
            TxtRole.Location = new Point(150, 253);
            TxtRole.MaxLength = 11;
            TxtRole.Name = "TxtRole";
            TxtRole.Size = new Size(181, 24);
            TxtRole.TabIndex = 33;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(1, 258);
            label8.Name = "label8";
            label8.Size = new Size(50, 25);
            label8.TabIndex = 32;
            label8.Text = "Rol:";
            // 
            // panel9
            // 
            panel9.BackColor = Color.Black;
            panel9.Enabled = false;
            panel9.Location = new Point(148, 328);
            panel9.Name = "panel9";
            panel9.Size = new Size(181, 2);
            panel9.TabIndex = 67;
            // 
            // TxtSalary
            // 
            TxtSalary.BackColor = Color.White;
            TxtSalary.BorderStyle = BorderStyle.None;
            TxtSalary.Enabled = false;
            TxtSalary.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalary.ForeColor = Color.Black;
            TxtSalary.Location = new Point(148, 303);
            TxtSalary.MaxLength = 20;
            TxtSalary.Name = "TxtSalary";
            TxtSalary.Size = new Size(181, 24);
            TxtSalary.TabIndex = 66;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(-1, 308);
            label15.Name = "label15";
            label15.Size = new Size(79, 25);
            label15.TabIndex = 65;
            label15.Text = "Salary:";
            // 
            // LblIdEmployee
            // 
            LblIdEmployee.AutoSize = true;
            LblIdEmployee.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            LblIdEmployee.Location = new Point(338, 112);
            LblIdEmployee.Name = "LblIdEmployee";
            LblIdEmployee.Size = new Size(18, 25);
            LblIdEmployee.TabIndex = 72;
            LblIdEmployee.Text = ":";
            LblIdEmployee.Visible = false;
            // 
            // BtnSearchEmployee
            // 
            BtnSearchEmployee.FlatAppearance.BorderSize = 0;
            BtnSearchEmployee.FlatStyle = FlatStyle.Flat;
            BtnSearchEmployee.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            BtnSearchEmployee.IconColor = Color.Black;
            BtnSearchEmployee.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnSearchEmployee.IconSize = 30;
            BtnSearchEmployee.Location = new Point(357, 105);
            BtnSearchEmployee.Name = "BtnSearchEmployee";
            BtnSearchEmployee.Size = new Size(31, 32);
            BtnSearchEmployee.TabIndex = 71;
            BtnSearchEmployee.UseVisualStyleBackColor = true;
            BtnSearchEmployee.Click += BtnSearchEmployee_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Black;
            panel6.Enabled = false;
            panel6.Location = new Point(147, 133);
            panel6.Name = "panel6";
            panel6.Size = new Size(185, 2);
            panel6.TabIndex = 70;
            // 
            // TxtEmployee
            // 
            TxtEmployee.BackColor = Color.White;
            TxtEmployee.BorderStyle = BorderStyle.None;
            TxtEmployee.Enabled = false;
            TxtEmployee.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtEmployee.ForeColor = Color.Black;
            TxtEmployee.Location = new Point(147, 108);
            TxtEmployee.Name = "TxtEmployee";
            TxtEmployee.Size = new Size(185, 24);
            TxtEmployee.TabIndex = 69;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1, 112);
            label11.Name = "label11";
            label11.Size = new Size(113, 25);
            label11.TabIndex = 68;
            label11.Text = "Employee:";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Black;
            panel5.Location = new Point(151, 426);
            panel5.Name = "panel5";
            panel5.Size = new Size(181, 2);
            panel5.TabIndex = 78;
            // 
            // TxtPriceOvertime
            // 
            TxtPriceOvertime.BackColor = Color.White;
            TxtPriceOvertime.BorderStyle = BorderStyle.None;
            TxtPriceOvertime.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtPriceOvertime.ForeColor = Color.Black;
            TxtPriceOvertime.Location = new Point(151, 401);
            TxtPriceOvertime.MaxLength = 20;
            TxtPriceOvertime.Name = "TxtPriceOvertime";
            TxtPriceOvertime.Size = new Size(181, 24);
            TxtPriceOvertime.TabIndex = 77;
            TxtPriceOvertime.TextChanged += TxtPriceOvertime_TextChanged;
            TxtPriceOvertime.KeyPress += TxtPriceOvertime_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(-3, 406);
            label5.Name = "label5";
            label5.Size = new Size(159, 25);
            label5.TabIndex = 76;
            label5.Text = "Price Overtime:";
            // 
            // panel7
            // 
            panel7.BackColor = Color.Black;
            panel7.Location = new Point(151, 378);
            panel7.Name = "panel7";
            panel7.Size = new Size(181, 2);
            panel7.TabIndex = 75;
            // 
            // TxtExtraHours
            // 
            TxtExtraHours.BackColor = Color.White;
            TxtExtraHours.BorderStyle = BorderStyle.None;
            TxtExtraHours.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtExtraHours.ForeColor = Color.Black;
            TxtExtraHours.Location = new Point(151, 353);
            TxtExtraHours.MaxLength = 11;
            TxtExtraHours.Name = "TxtExtraHours";
            TxtExtraHours.Size = new Size(181, 24);
            TxtExtraHours.TabIndex = 74;
            TxtExtraHours.TextChanged += TxtExtraHours_TextChanged;
            TxtExtraHours.KeyPress += TxtExtraHours_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(-2, 358);
            label6.Name = "label6";
            label6.Size = new Size(131, 25);
            label6.TabIndex = 73;
            label6.Text = "Extra Hours:";
            // 
            // panel10
            // 
            panel10.BackColor = Color.Black;
            panel10.Enabled = false;
            panel10.Location = new Point(150, 474);
            panel10.Name = "panel10";
            panel10.Size = new Size(181, 2);
            panel10.TabIndex = 81;
            // 
            // TxtOvertimePayment
            // 
            TxtOvertimePayment.BackColor = Color.White;
            TxtOvertimePayment.BorderStyle = BorderStyle.None;
            TxtOvertimePayment.Enabled = false;
            TxtOvertimePayment.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtOvertimePayment.ForeColor = Color.Black;
            TxtOvertimePayment.Location = new Point(150, 449);
            TxtOvertimePayment.MaxLength = 20;
            TxtOvertimePayment.Name = "TxtOvertimePayment";
            TxtOvertimePayment.Size = new Size(181, 24);
            TxtOvertimePayment.TabIndex = 80;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(-4, 454);
            label7.Name = "label7";
            label7.Size = new Size(155, 25);
            label7.TabIndex = 79;
            label7.Text = "Time Payment:";
            // 
            // panel11
            // 
            panel11.BackColor = Color.Black;
            panel11.Location = new Point(613, 82);
            panel11.Name = "panel11";
            panel11.Size = new Size(181, 2);
            panel11.TabIndex = 84;
            // 
            // TxtBonuses
            // 
            TxtBonuses.BackColor = Color.White;
            TxtBonuses.BorderStyle = BorderStyle.None;
            TxtBonuses.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtBonuses.ForeColor = Color.Black;
            TxtBonuses.Location = new Point(613, 57);
            TxtBonuses.MaxLength = 11;
            TxtBonuses.Name = "TxtBonuses";
            TxtBonuses.Size = new Size(181, 24);
            TxtBonuses.TabIndex = 83;
            TxtBonuses.TextChanged += TxtTransportVouchers_TextChanged;
            TxtBonuses.KeyPress += TxtTransportVouchers_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(460, 62);
            label9.Name = "label9";
            label9.Size = new Size(102, 25);
            label9.TabIndex = 82;
            label9.Text = "Bonuses:";
            // 
            // panel12
            // 
            panel12.BackColor = Color.Black;
            panel12.Location = new Point(614, 369);
            panel12.Name = "panel12";
            panel12.Size = new Size(181, 2);
            panel12.TabIndex = 90;
            // 
            // TxtSalaryAdvance
            // 
            TxtSalaryAdvance.BackColor = Color.White;
            TxtSalaryAdvance.BorderStyle = BorderStyle.None;
            TxtSalaryAdvance.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSalaryAdvance.ForeColor = Color.Black;
            TxtSalaryAdvance.Location = new Point(614, 344);
            TxtSalaryAdvance.MaxLength = 11;
            TxtSalaryAdvance.Name = "TxtSalaryAdvance";
            TxtSalaryAdvance.Size = new Size(181, 24);
            TxtSalaryAdvance.TabIndex = 89;
            TxtSalaryAdvance.TextChanged += TxtSalaryAdvance_TextChanged;
            TxtSalaryAdvance.KeyPress += TxtSalaryAdvance_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(435, 349);
            label10.Name = "label10";
            label10.Size = new Size(169, 25);
            label10.TabIndex = 88;
            label10.Text = "Salary Advance:";
            // 
            // panel13
            // 
            panel13.BackColor = Color.Black;
            panel13.Enabled = false;
            panel13.Location = new Point(611, 190);
            panel13.Name = "panel13";
            panel13.Size = new Size(181, 2);
            panel13.TabIndex = 87;
            // 
            // TxtSFS
            // 
            TxtSFS.BackColor = Color.White;
            TxtSFS.BorderStyle = BorderStyle.None;
            TxtSFS.Enabled = false;
            TxtSFS.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtSFS.ForeColor = Color.Black;
            TxtSFS.Location = new Point(611, 165);
            TxtSFS.MaxLength = 20;
            TxtSFS.Name = "TxtSFS";
            TxtSFS.Size = new Size(181, 24);
            TxtSFS.TabIndex = 86;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(472, 167);
            label12.Name = "label12";
            label12.Size = new Size(59, 25);
            label12.TabIndex = 85;
            label12.Text = "SFS:";
            // 
            // panel14
            // 
            panel14.BackColor = Color.Black;
            panel14.Enabled = false;
            panel14.Location = new Point(608, 480);
            panel14.Name = "panel14";
            panel14.Size = new Size(181, 2);
            panel14.TabIndex = 93;
            // 
            // TxtNetSalary
            // 
            TxtNetSalary.BackColor = Color.White;
            TxtNetSalary.BorderStyle = BorderStyle.None;
            TxtNetSalary.Enabled = false;
            TxtNetSalary.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNetSalary.ForeColor = Color.Black;
            TxtNetSalary.Location = new Point(608, 455);
            TxtNetSalary.MaxLength = 20;
            TxtNetSalary.Name = "TxtNetSalary";
            TxtNetSalary.Size = new Size(181, 24);
            TxtNetSalary.TabIndex = 92;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(459, 460);
            label13.Name = "label13";
            label13.Size = new Size(118, 25);
            label13.TabIndex = 91;
            label13.Text = "Net Salary:";
            // 
            // panel15
            // 
            panel15.BackColor = Color.Black;
            panel15.Enabled = false;
            panel15.Location = new Point(617, 138);
            panel15.Name = "panel15";
            panel15.Size = new Size(181, 2);
            panel15.TabIndex = 96;
            // 
            // TxtTotalAssignments
            // 
            TxtTotalAssignments.BackColor = Color.White;
            TxtTotalAssignments.BorderStyle = BorderStyle.None;
            TxtTotalAssignments.Enabled = false;
            TxtTotalAssignments.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotalAssignments.ForeColor = Color.Black;
            TxtTotalAssignments.Location = new Point(617, 113);
            TxtTotalAssignments.MaxLength = 20;
            TxtTotalAssignments.Name = "TxtTotalAssignments";
            TxtTotalAssignments.Size = new Size(181, 24);
            TxtTotalAssignments.TabIndex = 95;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(416, 118);
            label14.Name = "label14";
            label14.Size = new Size(195, 25);
            label14.TabIndex = 94;
            label14.Text = "Total Assignments:";
            // 
            // panel16
            // 
            panel16.BackColor = Color.Black;
            panel16.Enabled = false;
            panel16.Location = new Point(608, 423);
            panel16.Name = "panel16";
            panel16.Size = new Size(181, 2);
            panel16.TabIndex = 99;
            // 
            // TxtTotalDeductions
            // 
            TxtTotalDeductions.BackColor = Color.White;
            TxtTotalDeductions.BorderStyle = BorderStyle.None;
            TxtTotalDeductions.Enabled = false;
            TxtTotalDeductions.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTotalDeductions.ForeColor = Color.Black;
            TxtTotalDeductions.Location = new Point(608, 398);
            TxtTotalDeductions.MaxLength = 20;
            TxtTotalDeductions.Name = "TxtTotalDeductions";
            TxtTotalDeductions.Size = new Size(181, 24);
            TxtTotalDeductions.TabIndex = 98;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(428, 403);
            label16.Name = "label16";
            label16.Size = new Size(180, 25);
            label16.TabIndex = 97;
            label16.Text = "Total Deductions:";
            // 
            // panel17
            // 
            panel17.BackColor = Color.Black;
            panel17.Enabled = false;
            panel17.Location = new Point(613, 237);
            panel17.Name = "panel17";
            panel17.Size = new Size(181, 2);
            panel17.TabIndex = 102;
            // 
            // TxtAFP
            // 
            TxtAFP.BackColor = Color.White;
            TxtAFP.BorderStyle = BorderStyle.None;
            TxtAFP.Enabled = false;
            TxtAFP.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtAFP.ForeColor = Color.Black;
            TxtAFP.Location = new Point(613, 212);
            TxtAFP.MaxLength = 20;
            TxtAFP.Name = "TxtAFP";
            TxtAFP.Size = new Size(181, 24);
            TxtAFP.TabIndex = 101;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(474, 214);
            label17.Name = "label17";
            label17.Size = new Size(59, 25);
            label17.TabIndex = 100;
            label17.Text = "AFP:";
            // 
            // panel18
            // 
            panel18.BackColor = Color.Black;
            panel18.Enabled = false;
            panel18.Location = new Point(613, 284);
            panel18.Name = "panel18";
            panel18.Size = new Size(181, 2);
            panel18.TabIndex = 105;
            // 
            // TxtTSS
            // 
            TxtTSS.BackColor = Color.White;
            TxtTSS.BorderStyle = BorderStyle.None;
            TxtTSS.Enabled = false;
            TxtTSS.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtTSS.ForeColor = Color.Black;
            TxtTSS.Location = new Point(613, 259);
            TxtTSS.MaxLength = 20;
            TxtTSS.Name = "TxtTSS";
            TxtTSS.Size = new Size(181, 24);
            TxtTSS.TabIndex = 104;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(474, 261);
            label18.Name = "label18";
            label18.Size = new Size(113, 25);
            label18.TabIndex = 103;
            label18.Text = "Total TSS:";
            // 
            // panel19
            // 
            panel19.BackColor = Color.Black;
            panel19.Enabled = false;
            panel19.Location = new Point(613, 330);
            panel19.Name = "panel19";
            panel19.Size = new Size(181, 2);
            panel19.TabIndex = 108;
            // 
            // TxtISR
            // 
            TxtISR.BackColor = Color.White;
            TxtISR.BorderStyle = BorderStyle.None;
            TxtISR.Enabled = false;
            TxtISR.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtISR.ForeColor = Color.Black;
            TxtISR.Location = new Point(613, 300);
            TxtISR.MaxLength = 20;
            TxtISR.Name = "TxtISR";
            TxtISR.Size = new Size(181, 24);
            TxtISR.TabIndex = 107;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(474, 307);
            label19.Name = "label19";
            label19.Size = new Size(52, 25);
            label19.TabIndex = 106;
            label19.Text = "ISR:";
            // 
            // FrmNewPayroll
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 545);
            Controls.Add(panel19);
            Controls.Add(TxtISR);
            Controls.Add(label19);
            Controls.Add(panel18);
            Controls.Add(TxtTSS);
            Controls.Add(label18);
            Controls.Add(panel17);
            Controls.Add(TxtAFP);
            Controls.Add(label17);
            Controls.Add(panel16);
            Controls.Add(TxtTotalDeductions);
            Controls.Add(label16);
            Controls.Add(panel15);
            Controls.Add(TxtTotalAssignments);
            Controls.Add(label14);
            Controls.Add(panel14);
            Controls.Add(TxtNetSalary);
            Controls.Add(label13);
            Controls.Add(panel12);
            Controls.Add(TxtSalaryAdvance);
            Controls.Add(label10);
            Controls.Add(panel13);
            Controls.Add(TxtSFS);
            Controls.Add(label12);
            Controls.Add(panel11);
            Controls.Add(TxtBonuses);
            Controls.Add(label9);
            Controls.Add(panel10);
            Controls.Add(TxtOvertimePayment);
            Controls.Add(label7);
            Controls.Add(panel5);
            Controls.Add(TxtPriceOvertime);
            Controls.Add(label5);
            Controls.Add(panel7);
            Controls.Add(TxtExtraHours);
            Controls.Add(label6);
            Controls.Add(LblIdEmployee);
            Controls.Add(BtnSearchEmployee);
            Controls.Add(panel6);
            Controls.Add(TxtEmployee);
            Controls.Add(label11);
            Controls.Add(panel9);
            Controls.Add(TxtSalary);
            Controls.Add(label15);
            Controls.Add(panel8);
            Controls.Add(TxtRole);
            Controls.Add(label8);
            Controls.Add(panel4);
            Controls.Add(TxtLastName);
            Controls.Add(label4);
            Controls.Add(PanelControlsLaunch);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(TxtNameEmployee);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(TxtIdPayroll);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNewPayroll";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNewEmployee";
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
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        private Panel panel4;
        private Label label4;
        private Panel panel8;
        private Label label8;
        public TextBox TxtLastName;
        public TextBox TxtRole;
        public FontAwesome.Sharp.IconButton BtnEdit;
        public FontAwesome.Sharp.IconButton BtnSave;
        public TextBox TxtNameEmployee;
        public TextBox TxtIdPayroll;
        private Panel panel9;
        public TextBox TxtSalary;
        private Label label15;
        public Label LblIdEmployee;
        private FontAwesome.Sharp.IconButton BtnSearchEmployee;
        private Panel panel6;
        public TextBox TxtEmployee;
        private Label label11;
        private Panel panel5;
        public TextBox TxtPriceOvertime;
        private Label label5;
        private Panel panel7;
        public TextBox TxtExtraHours;
        private Label label6;
        private Panel panel10;
        public TextBox TxtOvertimePayment;
        private Label label7;
        private Panel panel11;
        public TextBox TxtBonuses;
        private Label label9;
        private Panel panel12;
        public TextBox TxtSalaryAdvance;
        private Label label10;
        private Panel panel13;
        public TextBox TxtSFS;
        private Label label12;
        private Panel panel14;
        public TextBox TxtNetSalary;
        private Label label13;
        private Panel panel15;
        public TextBox TxtTotalAssignments;
        private Label label14;
        private Panel panel16;
        public TextBox TxtTotalDeductions;
        private Label label16;
        private Panel panel17;
        public TextBox TxtAFP;
        private Label label17;
        private Panel panel18;
        public TextBox TxtTSS;
        private Label label18;
        private Panel panel19;
        public TextBox TxtISR;
        private Label label19;
    }
}