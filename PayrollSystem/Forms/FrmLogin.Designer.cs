namespace PayrollSystem.Forms
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            PanelLogin = new Panel();
            label2 = new Label();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            PanelButtonLogin = new Panel();
            label1 = new Label();
            BtnMinimizeLogin = new FontAwesome.Sharp.IconButton();
            BtnCloseLogin = new FontAwesome.Sharp.IconButton();
            txtUserLogin = new TextBox();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            txtPasswordLogin = new TextBox();
            BtnLogin = new FontAwesome.Sharp.IconButton();
            PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            PanelButtonLogin.SuspendLayout();
            SuspendLayout();
            // 
            // PanelLogin
            // 
            PanelLogin.BackColor = SystemColors.MenuHighlight;
            PanelLogin.Controls.Add(label2);
            PanelLogin.Controls.Add(iconPictureBox1);
            PanelLogin.Dock = DockStyle.Left;
            PanelLogin.Location = new Point(0, 0);
            PanelLogin.Name = "PanelLogin";
            PanelLogin.Size = new Size(209, 329);
            PanelLogin.TabIndex = 0;
            PanelLogin.MouseMove += PanelLogin_MouseMove;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Unicode", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(-5, 244);
            label2.Name = "label2";
            label2.Size = new Size(219, 34);
            label2.TabIndex = 4;
            label2.Text = "Payroll System";
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.Transparent;
            iconPictureBox1.ForeColor = Color.Black;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserLock;
            iconPictureBox1.IconColor = Color.Black;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 170;
            iconPictureBox1.Location = new Point(12, 44);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(176, 170);
            iconPictureBox1.TabIndex = 0;
            iconPictureBox1.TabStop = false;
            // 
            // PanelButtonLogin
            // 
            PanelButtonLogin.BackColor = Color.White;
            PanelButtonLogin.Controls.Add(label1);
            PanelButtonLogin.Controls.Add(BtnMinimizeLogin);
            PanelButtonLogin.Controls.Add(BtnCloseLogin);
            PanelButtonLogin.Dock = DockStyle.Top;
            PanelButtonLogin.Location = new Point(209, 0);
            PanelButtonLogin.Name = "PanelButtonLogin";
            PanelButtonLogin.Size = new Size(393, 37);
            PanelButtonLogin.TabIndex = 1;
            PanelButtonLogin.MouseMove += PanelButtonLogin_MouseMove;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(159, 9);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 3;
            label1.Text = "LOGIN";
            // 
            // BtnMinimizeLogin
            // 
            BtnMinimizeLogin.Dock = DockStyle.Right;
            BtnMinimizeLogin.FlatAppearance.BorderSize = 0;
            BtnMinimizeLogin.FlatStyle = FlatStyle.Flat;
            BtnMinimizeLogin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            BtnMinimizeLogin.IconColor = Color.Black;
            BtnMinimizeLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnMinimizeLogin.IconSize = 40;
            BtnMinimizeLogin.Location = new Point(330, 0);
            BtnMinimizeLogin.Name = "BtnMinimizeLogin";
            BtnMinimizeLogin.Size = new Size(31, 37);
            BtnMinimizeLogin.TabIndex = 2;
            BtnMinimizeLogin.UseVisualStyleBackColor = true;
            BtnMinimizeLogin.Click += BtnMinimizeLogin_Click;
            // 
            // BtnCloseLogin
            // 
            BtnCloseLogin.Dock = DockStyle.Right;
            BtnCloseLogin.FlatAppearance.BorderSize = 0;
            BtnCloseLogin.FlatAppearance.MouseDownBackColor = Color.Red;
            BtnCloseLogin.FlatAppearance.MouseOverBackColor = Color.Red;
            BtnCloseLogin.FlatStyle = FlatStyle.Flat;
            BtnCloseLogin.IconChar = FontAwesome.Sharp.IconChar.TimesSquare;
            BtnCloseLogin.IconColor = Color.Black;
            BtnCloseLogin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            BtnCloseLogin.IconSize = 40;
            BtnCloseLogin.Location = new Point(361, 0);
            BtnCloseLogin.Name = "BtnCloseLogin";
            BtnCloseLogin.Size = new Size(32, 37);
            BtnCloseLogin.TabIndex = 0;
            BtnCloseLogin.UseVisualStyleBackColor = true;
            BtnCloseLogin.Click += BtnCloseLogin_Click;
            // 
            // txtUserLogin
            // 
            txtUserLogin.BackColor = Color.White;
            txtUserLogin.BorderStyle = BorderStyle.None;
            txtUserLogin.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserLogin.ForeColor = Color.Black;
            txtUserLogin.Location = new Point(340, 95);
            txtUserLogin.Name = "txtUserLogin";
            txtUserLogin.Size = new Size(250, 30);
            txtUserLogin.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(340, 126);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(209, 103);
            label3.Name = "label3";
            label3.Size = new Size(66, 25);
            label3.TabIndex = 4;
            label3.Text = "USER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(209, 168);
            label4.Name = "label4";
            label4.Size = new Size(131, 25);
            label4.TabIndex = 5;
            label4.Text = "PASSWORD";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(340, 191);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 2);
            panel4.TabIndex = 7;
            // 
            // txtPasswordLogin
            // 
            txtPasswordLogin.BackColor = Color.White;
            txtPasswordLogin.BorderStyle = BorderStyle.None;
            txtPasswordLogin.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            txtPasswordLogin.ForeColor = Color.Black;
            txtPasswordLogin.Location = new Point(340, 160);
            txtPasswordLogin.Name = "txtPasswordLogin";
            txtPasswordLogin.PasswordChar = '*';
            txtPasswordLogin.Size = new Size(250, 30);
            txtPasswordLogin.TabIndex = 6;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = Color.White;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Lucida Sans Unicode", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = Color.Black;
            BtnLogin.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnLogin.IconColor = Color.Black;
            BtnLogin.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            BtnLogin.Location = new Point(318, 244);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(223, 44);
            BtnLogin.TabIndex = 8;
            BtnLogin.Text = "Log in";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += BtnLogin_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(602, 329);
            Controls.Add(BtnLogin);
            Controls.Add(panel4);
            Controls.Add(txtPasswordLogin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(txtUserLogin);
            Controls.Add(PanelButtonLogin);
            Controls.Add(PanelLogin);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmLogin";
            Opacity = 0.82D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLogin";
            MouseMove += FrmLogin_MouseMove;
            PanelLogin.ResumeLayout(false);
            PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            PanelButtonLogin.ResumeLayout(false);
            PanelButtonLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanelLogin;
        private Panel PanelButtonLogin;
        private FontAwesome.Sharp.IconButton BtnCloseLogin;
        private FontAwesome.Sharp.IconButton BtnMinimizeLogin;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtUserLogin;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Panel panel4;
        private TextBox txtPasswordLogin;
        private FontAwesome.Sharp.IconButton BtnLogin;
    }
}