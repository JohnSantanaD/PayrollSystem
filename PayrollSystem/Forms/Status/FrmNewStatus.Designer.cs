namespace PayrollSystem.Forms.Status
{
    partial class FrmNewStatus
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
            panel4 = new Panel();
            TxtDescriptionStatus = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            TxtNameStatus = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            TxtIdStatus = new TextBox();
            label2 = new Label();
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
            PanelControlsLaunch.Size = new Size(533, 36);
            PanelControlsLaunch.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(126, 3);
            label1.Name = "label1";
            label1.Size = new Size(285, 31);
            label1.TabIndex = 4;
            label1.Text = "Status Registration";
            // 
            // panel1
            // 
            panel1.Controls.Add(BtnCancel);
            panel1.Controls.Add(BtnEdit);
            panel1.Controls.Add(BtnSave);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 291);
            panel1.Name = "panel1";
            panel1.Size = new Size(533, 46);
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
            BtnCancel.Location = new Point(411, 0);
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
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(174, 256);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 2);
            panel4.TabIndex = 25;
            // 
            // TxtDescriptionStatus
            // 
            TxtDescriptionStatus.BackColor = Color.White;
            TxtDescriptionStatus.BorderStyle = BorderStyle.None;
            TxtDescriptionStatus.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtDescriptionStatus.ForeColor = Color.Black;
            TxtDescriptionStatus.Location = new Point(174, 196);
            TxtDescriptionStatus.Multiline = true;
            TxtDescriptionStatus.Name = "TxtDescriptionStatus";
            TxtDescriptionStatus.Size = new Size(250, 61);
            TxtDescriptionStatus.TabIndex = 24;
            TxtDescriptionStatus.KeyPress += TxtDescriptionStatusKeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 216);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 23;
            label4.Text = "Description :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(174, 165);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 2);
            panel2.TabIndex = 22;
            // 
            // TxtNameStatus
            // 
            TxtNameStatus.BackColor = Color.White;
            TxtNameStatus.BorderStyle = BorderStyle.None;
            TxtNameStatus.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtNameStatus.ForeColor = Color.Black;
            TxtNameStatus.Location = new Point(174, 138);
            TxtNameStatus.Name = "TxtNameStatus";
            TxtNameStatus.Size = new Size(250, 24);
            TxtNameStatus.TabIndex = 21;
            TxtNameStatus.KeyPress += TxtNameStatus_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 145);
            label3.Name = "label3";
            label3.Size = new Size(74, 25);
            label3.TabIndex = 20;
            label3.Text = "Name:";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(174, 95);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 2);
            panel3.TabIndex = 19;
            // 
            // TxtIdStatus
            // 
            TxtIdStatus.BackColor = Color.White;
            TxtIdStatus.BorderStyle = BorderStyle.None;
            TxtIdStatus.Enabled = false;
            TxtIdStatus.Font = new Font("MS Reference Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            TxtIdStatus.ForeColor = Color.Black;
            TxtIdStatus.Location = new Point(174, 68);
            TxtIdStatus.Name = "TxtIdStatus";
            TxtIdStatus.Size = new Size(250, 24);
            TxtIdStatus.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 75);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 17;
            label2.Text = "ID :";
            // 
            // FrmNewStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(533, 337);
            Controls.Add(PanelControlsLaunch);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(TxtDescriptionStatus);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(TxtNameStatus);
            Controls.Add(label3);
            Controls.Add(panel3);
            Controls.Add(TxtIdStatus);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmNewStatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmNewRole";
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
        private Panel panel4;
        private Label label4;
        private Panel panel2;
        private Label label3;
        private Panel panel3;
        private Label label2;
        public FontAwesome.Sharp.IconButton BtnEdit;
        public FontAwesome.Sharp.IconButton BtnSave;
        public TextBox TxtDescriptionStatus;
        public TextBox TxtNameStatus;
        public TextBox TxtIdStatus;
    }
}