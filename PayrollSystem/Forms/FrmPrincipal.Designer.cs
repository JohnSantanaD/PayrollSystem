namespace PayrollSystem.Forms
{
    partial class FrmPrincipal
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            PanelControlsPrincipal = new Panel();
            BtnMinimize = new FontAwesome.Sharp.IconButton();
            BtnMaximize = new FontAwesome.Sharp.IconButton();
            BtnRestore = new FontAwesome.Sharp.IconButton();
            BtnClose = new FontAwesome.Sharp.IconButton();
            PanelStatus = new Panel();
            LabelDate = new Label();
            LabelTime = new Label();
            PanelButtons = new Panel();
            PanelMaintenance = new Panel();
            BtnDepartment = new FontAwesome.Sharp.IconButton();
            BtnStatus = new FontAwesome.Sharp.IconButton();
            BtnUsers = new FontAwesome.Sharp.IconButton();
            BtnRoles = new FontAwesome.Sharp.IconButton();
            BtnEmployees = new FontAwesome.Sharp.IconButton();
            BtnMaintenance = new FontAwesome.Sharp.IconButton();
            BtnPayroll = new FontAwesome.Sharp.IconButton();
            BtnHome = new FontAwesome.Sharp.IconButton();
            PanelContainer = new Panel();
            Timer = new System.Windows.Forms.Timer(components);
            PanelControlsPrincipal.SuspendLayout();
            PanelStatus.SuspendLayout();
            PanelButtons.SuspendLayout();
            PanelMaintenance.SuspendLayout();
            SuspendLayout();
            // 
            // PanelControlsPrincipal
            // 
            PanelControlsPrincipal.BackColor = SystemColors.MenuHighlight;
            PanelControlsPrincipal.Controls.Add(BtnMinimize);
            PanelControlsPrincipal.Controls.Add(BtnMaximize);
            PanelControlsPrincipal.Controls.Add(BtnRestore);
            PanelControlsPrincipal.Controls.Add(BtnClose);
            PanelControlsPrincipal.Dock = DockStyle.Top;
            PanelControlsPrincipal.Location = new Point(0, 0);
            PanelControlsPrincipal.Name = "PanelControlsPrincipal";
            PanelControlsPrincipal.Size = new Size(1114, 32);
            PanelControlsPrincipal.TabIndex = 2;
            PanelControlsPrincipal.MouseMove += PanelControlsPrincipal_MouseMove;
            // 
            // BtnMinimize
            // 
            BtnMinimize.Dock = DockStyle.Right;
            BtnMinimize.FlatAppearance.BorderSize = 0;
            BtnMinimize.FlatStyle = FlatStyle.Flat;
            BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            BtnMinimize.IconColor = Color.Black;
            BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnMinimize.IconSize = 30;
            BtnMinimize.Location = new Point(989, 0);
            BtnMinimize.Name = "BtnMinimize";
            BtnMinimize.Size = new Size(31, 32);
            BtnMinimize.TabIndex = 2;
            BtnMinimize.UseVisualStyleBackColor = true;
            BtnMinimize.Click += BtnMinimize_Click;
            // 
            // BtnMaximize
            // 
            BtnMaximize.Dock = DockStyle.Right;
            BtnMaximize.FlatAppearance.BorderSize = 0;
            BtnMaximize.FlatStyle = FlatStyle.Flat;
            BtnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            BtnMaximize.IconColor = Color.Black;
            BtnMaximize.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnMaximize.IconSize = 30;
            BtnMaximize.Location = new Point(1020, 0);
            BtnMaximize.Name = "BtnMaximize";
            BtnMaximize.Size = new Size(31, 32);
            BtnMaximize.TabIndex = 3;
            BtnMaximize.UseVisualStyleBackColor = true;
            BtnMaximize.Click += BtnMaximize_Click;
            // 
            // BtnRestore
            // 
            BtnRestore.Dock = DockStyle.Right;
            BtnRestore.FlatAppearance.BorderSize = 0;
            BtnRestore.FlatStyle = FlatStyle.Flat;
            BtnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            BtnRestore.IconColor = Color.Black;
            BtnRestore.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnRestore.IconSize = 30;
            BtnRestore.Location = new Point(1051, 0);
            BtnRestore.Name = "BtnRestore";
            BtnRestore.Size = new Size(31, 32);
            BtnRestore.TabIndex = 4;
            BtnRestore.UseVisualStyleBackColor = true;
            BtnRestore.Visible = false;
            BtnRestore.Click += BtnRestore_Click;
            // 
            // BtnClose
            // 
            BtnClose.Dock = DockStyle.Right;
            BtnClose.FlatAppearance.BorderSize = 0;
            BtnClose.FlatAppearance.MouseDownBackColor = Color.Red;
            BtnClose.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnClose.FlatStyle = FlatStyle.Flat;
            BtnClose.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            BtnClose.IconColor = Color.Black;
            BtnClose.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnClose.IconSize = 30;
            BtnClose.Location = new Point(1082, 0);
            BtnClose.Name = "BtnClose";
            BtnClose.Size = new Size(32, 32);
            BtnClose.TabIndex = 0;
            BtnClose.UseVisualStyleBackColor = true;
            BtnClose.Click += BtnClose_Click;
            // 
            // PanelStatus
            // 
            PanelStatus.BackColor = SystemColors.MenuHighlight;
            PanelStatus.Controls.Add(LabelDate);
            PanelStatus.Controls.Add(LabelTime);
            PanelStatus.Dock = DockStyle.Bottom;
            PanelStatus.Location = new Point(0, 622);
            PanelStatus.Name = "PanelStatus";
            PanelStatus.Size = new Size(1114, 31);
            PanelStatus.TabIndex = 3;
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Dock = DockStyle.Right;
            LabelDate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelDate.ForeColor = Color.White;
            LabelDate.Location = new Point(1019, 0);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new Size(48, 20);
            LabelDate.TabIndex = 0;
            LabelDate.Text = "Date";
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Dock = DockStyle.Right;
            LabelTime.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTime.Location = new Point(1067, 0);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(47, 20);
            LabelTime.TabIndex = 1;
            LabelTime.Text = "Time";
            // 
            // PanelButtons
            // 
            PanelButtons.BackColor = Color.SteelBlue;
            PanelButtons.Controls.Add(PanelMaintenance);
            PanelButtons.Controls.Add(BtnMaintenance);
            PanelButtons.Controls.Add(BtnPayroll);
            PanelButtons.Controls.Add(BtnHome);
            PanelButtons.Dock = DockStyle.Left;
            PanelButtons.Location = new Point(0, 32);
            PanelButtons.Name = "PanelButtons";
            PanelButtons.Size = new Size(249, 590);
            PanelButtons.TabIndex = 4;
            // 
            // PanelMaintenance
            // 
            PanelMaintenance.BackColor = Color.DodgerBlue;
            PanelMaintenance.Controls.Add(BtnDepartment);
            PanelMaintenance.Controls.Add(BtnStatus);
            PanelMaintenance.Controls.Add(BtnUsers);
            PanelMaintenance.Controls.Add(BtnRoles);
            PanelMaintenance.Controls.Add(BtnEmployees);
            PanelMaintenance.Dock = DockStyle.Top;
            PanelMaintenance.Location = new Point(0, 90);
            PanelMaintenance.Name = "PanelMaintenance";
            PanelMaintenance.Size = new Size(249, 163);
            PanelMaintenance.TabIndex = 13;
            // 
            // BtnDepartment
            // 
            BtnDepartment.Dock = DockStyle.Top;
            BtnDepartment.FlatAppearance.BorderSize = 0;
            BtnDepartment.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnDepartment.FlatStyle = FlatStyle.Flat;
            BtnDepartment.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnDepartment.ForeColor = Color.White;
            BtnDepartment.IconChar = FontAwesome.Sharp.IconChar.BuildingUser;
            BtnDepartment.IconColor = Color.White;
            BtnDepartment.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnDepartment.IconSize = 30;
            BtnDepartment.ImageAlign = ContentAlignment.MiddleLeft;
            BtnDepartment.Location = new Point(0, 120);
            BtnDepartment.Name = "BtnDepartment";
            BtnDepartment.Size = new Size(249, 30);
            BtnDepartment.TabIndex = 8;
            BtnDepartment.Text = "Department";
            BtnDepartment.UseVisualStyleBackColor = true;
            BtnDepartment.Click += BtnDepartment_Click;
            // 
            // BtnStatus
            // 
            BtnStatus.Dock = DockStyle.Top;
            BtnStatus.FlatAppearance.BorderSize = 0;
            BtnStatus.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnStatus.FlatStyle = FlatStyle.Flat;
            BtnStatus.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnStatus.ForeColor = Color.White;
            BtnStatus.IconChar = FontAwesome.Sharp.IconChar.PersonCircleQuestion;
            BtnStatus.IconColor = Color.White;
            BtnStatus.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnStatus.IconSize = 30;
            BtnStatus.ImageAlign = ContentAlignment.MiddleLeft;
            BtnStatus.Location = new Point(0, 90);
            BtnStatus.Name = "BtnStatus";
            BtnStatus.Size = new Size(249, 30);
            BtnStatus.TabIndex = 7;
            BtnStatus.Text = "Status";
            BtnStatus.UseVisualStyleBackColor = true;
            BtnStatus.Click += BtnStatus_Click;
            // 
            // BtnUsers
            // 
            BtnUsers.Dock = DockStyle.Top;
            BtnUsers.FlatAppearance.BorderSize = 0;
            BtnUsers.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnUsers.FlatStyle = FlatStyle.Flat;
            BtnUsers.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUsers.ForeColor = Color.White;
            BtnUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            BtnUsers.IconColor = Color.White;
            BtnUsers.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnUsers.IconSize = 30;
            BtnUsers.ImageAlign = ContentAlignment.MiddleLeft;
            BtnUsers.Location = new Point(0, 60);
            BtnUsers.Name = "BtnUsers";
            BtnUsers.Size = new Size(249, 30);
            BtnUsers.TabIndex = 6;
            BtnUsers.Text = "Users";
            BtnUsers.UseVisualStyleBackColor = true;
            BtnUsers.Click += BtnUsers_Click;
            // 
            // BtnRoles
            // 
            BtnRoles.Dock = DockStyle.Top;
            BtnRoles.FlatAppearance.BorderSize = 0;
            BtnRoles.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnRoles.FlatStyle = FlatStyle.Flat;
            BtnRoles.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnRoles.ForeColor = Color.White;
            BtnRoles.IconChar = FontAwesome.Sharp.IconChar.UsersCog;
            BtnRoles.IconColor = Color.White;
            BtnRoles.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnRoles.IconSize = 30;
            BtnRoles.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRoles.Location = new Point(0, 30);
            BtnRoles.Name = "BtnRoles";
            BtnRoles.Size = new Size(249, 30);
            BtnRoles.TabIndex = 5;
            BtnRoles.Text = "Roles";
            BtnRoles.UseVisualStyleBackColor = true;
            BtnRoles.Click += BtnRoles_Click;
            // 
            // BtnEmployees
            // 
            BtnEmployees.Dock = DockStyle.Top;
            BtnEmployees.FlatAppearance.BorderSize = 0;
            BtnEmployees.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnEmployees.FlatStyle = FlatStyle.Flat;
            BtnEmployees.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnEmployees.ForeColor = Color.White;
            BtnEmployees.IconChar = FontAwesome.Sharp.IconChar.UserShield;
            BtnEmployees.IconColor = Color.White;
            BtnEmployees.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnEmployees.IconSize = 30;
            BtnEmployees.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEmployees.Location = new Point(0, 0);
            BtnEmployees.Name = "BtnEmployees";
            BtnEmployees.Size = new Size(249, 30);
            BtnEmployees.TabIndex = 4;
            BtnEmployees.Text = "Employees";
            BtnEmployees.UseVisualStyleBackColor = true;
            BtnEmployees.Click += BtnEmployees_Click;
            // 
            // BtnMaintenance
            // 
            BtnMaintenance.Dock = DockStyle.Top;
            BtnMaintenance.FlatAppearance.BorderSize = 0;
            BtnMaintenance.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnMaintenance.FlatStyle = FlatStyle.Flat;
            BtnMaintenance.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnMaintenance.ForeColor = Color.White;
            BtnMaintenance.IconChar = FontAwesome.Sharp.IconChar.Tools;
            BtnMaintenance.IconColor = Color.White;
            BtnMaintenance.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnMaintenance.IconSize = 30;
            BtnMaintenance.ImageAlign = ContentAlignment.MiddleLeft;
            BtnMaintenance.Location = new Point(0, 60);
            BtnMaintenance.Name = "BtnMaintenance";
            BtnMaintenance.Size = new Size(249, 30);
            BtnMaintenance.TabIndex = 12;
            BtnMaintenance.Text = "MAINTENANCE";
            BtnMaintenance.UseVisualStyleBackColor = true;
            BtnMaintenance.Click += BtnMaintenance_Click;
            // 
            // BtnPayroll
            // 
            BtnPayroll.Dock = DockStyle.Top;
            BtnPayroll.FlatAppearance.BorderSize = 0;
            BtnPayroll.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnPayroll.FlatStyle = FlatStyle.Flat;
            BtnPayroll.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPayroll.ForeColor = Color.White;
            BtnPayroll.IconChar = FontAwesome.Sharp.IconChar.FileInvoiceDollar;
            BtnPayroll.IconColor = Color.White;
            BtnPayroll.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnPayroll.IconSize = 30;
            BtnPayroll.ImageAlign = ContentAlignment.MiddleLeft;
            BtnPayroll.Location = new Point(0, 30);
            BtnPayroll.Name = "BtnPayroll";
            BtnPayroll.Size = new Size(249, 30);
            BtnPayroll.TabIndex = 10;
            BtnPayroll.Text = "PAYROLL";
            BtnPayroll.UseVisualStyleBackColor = true;
            BtnPayroll.Click += BtnPayroll_Click;
            // 
            // BtnHome
            // 
            BtnHome.BackColor = Color.DodgerBlue;
            BtnHome.Dock = DockStyle.Top;
            BtnHome.FlatAppearance.BorderSize = 0;
            BtnHome.FlatAppearance.MouseOverBackColor = Color.Cyan;
            BtnHome.FlatStyle = FlatStyle.Flat;
            BtnHome.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnHome.ForeColor = Color.RebeccaPurple;
            BtnHome.IconChar = FontAwesome.Sharp.IconChar.House;
            BtnHome.IconColor = Color.White;
            BtnHome.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnHome.IconSize = 30;
            BtnHome.ImageAlign = ContentAlignment.MiddleLeft;
            BtnHome.Location = new Point(0, 0);
            BtnHome.Name = "BtnHome";
            BtnHome.Size = new Size(249, 30);
            BtnHome.TabIndex = 3;
            BtnHome.Text = "HOME";
            BtnHome.UseVisualStyleBackColor = false;
            BtnHome.Click += BtnHome_Click;
            // 
            // PanelContainer
            // 
            PanelContainer.BackColor = Color.White;
            PanelContainer.Dock = DockStyle.Fill;
            PanelContainer.Location = new Point(249, 32);
            PanelContainer.Name = "PanelContainer";
            PanelContainer.Size = new Size(865, 590);
            PanelContainer.TabIndex = 5;
            // 
            // Timer
            // 
            Timer.Enabled = true;
            Timer.Interval = 1;
            Timer.Tick += Timer_Tick;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1114, 653);
            Controls.Add(PanelContainer);
            Controls.Add(PanelButtons);
            Controls.Add(PanelStatus);
            Controls.Add(PanelControlsPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            PanelControlsPrincipal.ResumeLayout(false);
            PanelStatus.ResumeLayout(false);
            PanelStatus.PerformLayout();
            PanelButtons.ResumeLayout(false);
            PanelMaintenance.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelControlsPrincipal;
        private FontAwesome.Sharp.IconButton BtnMinimize;
        private FontAwesome.Sharp.IconButton BtnMaximize;
        private FontAwesome.Sharp.IconButton BtnClose;
        private Panel PanelStatus;
        private Panel PanelButtons;
        private Panel PanelContainer;
        private FontAwesome.Sharp.IconButton BtnRestore;
        private FontAwesome.Sharp.IconButton BtnHome;
        private FontAwesome.Sharp.IconButton BtnPayroll;
        private Panel PanelMaintenance;
        private FontAwesome.Sharp.IconButton BtnRoles;
        private FontAwesome.Sharp.IconButton BtnEmployees;
        private FontAwesome.Sharp.IconButton BtnMaintenance;
        private Label LabelDate;
        private Label LabelTime;
        private System.Windows.Forms.Timer Timer;
        private FontAwesome.Sharp.IconButton BtnUsers;
        private FontAwesome.Sharp.IconButton BtnDepartment;
        private FontAwesome.Sharp.IconButton BtnStatus;
    }
}