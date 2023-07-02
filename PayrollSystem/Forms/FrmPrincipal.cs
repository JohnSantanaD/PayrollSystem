using PayrollSystem.Forms.Departments;
using PayrollSystem.Forms.Employees;
using PayrollSystem.Forms.Payrolls;
using PayrollSystem.Forms.Status;
using SystemSale.Forms.Users;

namespace PayrollSystem.Forms
{
    public partial class FrmPrincipal : Form
    {
        //Variables MouseMouve
        int x = 0;//Horizontal
        int y = 0;//Vertical
        public string? NameEmployee { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }

        public FrmPrincipal()
        {
            InitializeComponent();
            HidePanel();
            BtnBackcolor(BtnHome);
            HidePanel();
            //GetForm(new FrmHome());
        }

        #region Methods Form Launch

        private void HidePanel()
        {
            //PanelArticles.Visible = false;
            //PanelWarehouse.Visible = false;
            //PanelTrade.Visible = false;
            PanelMaintenance.Visible = false;
            //PanelPayroll.Visible = false;
        }

        private void HideSubMenu()
        {
            //if (PanelPayroll.Visible == true)
            //     PanelPayroll.Visible = false;
            //if (PanelWarehouse.Visible == true)
            //    PanelWarehouse.Visible = false;
            //if (PanelTrade.Visible == true)
            //    PanelTrade.Visible = false;
            if (PanelMaintenance.Visible == true)
                PanelMaintenance.Visible = false;
            //if (PanelArticles.Visible == true)
            //    PanelArticles.Visible = false;
        }

        private void ShowSubMenu(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideSubMenu();
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        public void GetForm(Form form)
        {
            if (PanelContainer.Controls.Count > 0)
            {
                PanelContainer.Controls.RemoveAt(0);
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(form);
                form.Show();
            }
            else
            {
                form.TopLevel = false;
                form.FormBorderStyle = FormBorderStyle.None;
                form.Dock = DockStyle.Fill;
                PanelContainer.Controls.Add(form);
                form.Show();
            }
        }

        private void BtnBackcolor(Button button)
        {
            if (button.BackColor == Color.Transparent)
            {
                BtnPayroll.BackColor = Color.Transparent;
                //BtnArticles.BackColor = Color.Transparent;
                BtnHome.BackColor = Color.Transparent;
                BtnMaintenance.BackColor = Color.Transparent;
                //BtnTrade.BackColor = Color.Transparent;
                //BtnWarehouse.BackColor = Color.Transparent;

                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Transparent;
            }
        }

        private void MouseMoves(MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                x = e.X;
                y = e.Y;
            }
            else
            {
                Top += e.Y - y;
                Left += e.X - x;
            }
        }

        #endregion

        #region Events Form Launch

        private void BtnClose_Click(object sender, EventArgs e)
        {
            DialogResult option;
            option = MessageBox.Show("You Want to Close Session", "SytemSale", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (option == DialogResult.Yes)
            {
                this.Close();
                FrmLogin login = new();
                login.Show();
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnMaximize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            BtnRestore.Visible = true;
            BtnMaximize.Visible = false;
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BtnMaximize.Visible = true;
            BtnRestore.Visible = false;
        }

        private void BtnMaintenance_Click(object sender, EventArgs e)
        {
            ShowSubMenu(PanelMaintenance);
            BtnBackcolor(BtnMaintenance);
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            BtnBackcolor(BtnHome);
            HidePanel();
            FrmHome frmHome = new FrmHome();

            frmHome.LblRole.Text = Role;
            frmHome.LblName.Text = NameEmployee;
            frmHome.LblLastName.Text = LastName;
            frmHome.LblEmail.Text = Email;
            GetForm(frmHome);
        }

        private void BtnRoles_Click(object sender, EventArgs e)
        {
            HidePanel();
            BtnBackcolor(BtnMaintenance);
            GetForm(new Roles.FrmRoles());
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            HidePanel();
            BtnBackcolor(BtnMaintenance);
            GetForm(new FrmUsers());
        }

        private void BtnEmployees_Click(object sender, EventArgs e)
        {
            HidePanel();
            BtnBackcolor(BtnMaintenance);
            GetForm(new FrmEmployees());
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            HidePanel();
            BtnBackcolor(BtnMaintenance);
            GetForm(new FrmDepartments());
        }

        private void BtnStatus_Click(object sender, EventArgs e)
        {
            HidePanel();
            BtnBackcolor(BtnMaintenance);
            GetForm(new FrmStatus());
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LabelDate.Text = DateTime.Now.ToLongDateString();
            LabelTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void PanelControlsPrincipal_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoves(e);
        }

        #endregion



        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            //ShowSubMenu(PanelPayroll);
            HidePanel();
            BtnBackcolor(BtnPayroll);
            GetForm(new FrmPayroll());
        }
    }
}
