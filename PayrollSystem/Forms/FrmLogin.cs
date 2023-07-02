using PayrollSystem.Data;
using PayrollSystem.Forms;
using PayrollSystem.Forms.Employees;
using PayrollSystem.Logic;
using PayrollSystem.Tools;
using System.Data.SqlClient;

namespace PayrollSystem.Forms
{
    public partial class FrmLogin : Form
    {
        //Variables MouseMouve
        int x = 0;//Horizontal
        int y = 0;//Vertical

        public string? NameEmployee { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Role { get; set; }

        public FrmLogin()
        {
            InitializeComponent();
        }

        #region Methods Login
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


        private void Login()
        {
            if (this.txtUserLogin.Text == string.Empty || this.txtPasswordLogin.Text == string.Empty)
            {
                MessageBox.Show("Enter the username and password please");
            }
            else
            {
                var user = txtUserLogin.Text;
                var pass = Encrypt.GetSHA256(txtPasswordLogin.Text);
                var reponse = LUser.Login(user, pass);

                if (reponse.Rows.Count!=0)
                {
                    this.Hide();
                    FrmPrincipal launch = new();
                    FrmHome frmHome = new FrmHome();


                    frmHome.LblRole.Text = reponse.Rows[0][7].ToString();
                    frmHome.LblName.Text = reponse.Rows[0][4].ToString();
                    frmHome.LblLastName.Text = reponse.Rows[0][5].ToString();
                    frmHome.LblEmail.Text = reponse.Rows[0][6].ToString();
                    
                    launch.Role = reponse.Rows[0][7].ToString();
                    launch.NameEmployee = reponse.Rows[0][4].ToString();
                    launch.LastName = reponse.Rows[0][5].ToString();
                    launch.Email = reponse.Rows[0][6].ToString();

                    //byte[] imageBuffer = (byte[])(reponse.Rows[0][8].ToString());
                    //MemoryStream stream = new MemoryStream(imageBuffer);

                    //frmHome.PtxImage.Image = Image.FromStream(stream);
                    //frmHome.PtxImage.SizeMode = PictureBoxSizeMode.StretchImage;

                    launch.GetForm(frmHome);
                    launch.Show();

                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
        }

        #endregion

        #region Events Login

        #region MouseMove

        //MouseMove Login
        private void FrmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoves(e);
        }

        //MouseMove PanelButton
        private void PanelButtonLogin_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoves(e);
        }

        //MouseMove PanelLogin
        private void PanelLogin_MouseMove(object sender, MouseEventArgs e)
        {
            MouseMoves(e);
        }

        #endregion

        #region Click


        private void BtnCloseLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizeLogin_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }

        #endregion

        #endregion

    }
}
