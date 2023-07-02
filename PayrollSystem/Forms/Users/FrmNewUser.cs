using FontAwesome.Sharp;
using PayrollSystem.Forms.Users;
using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace SystemSale.Forms.Users
{
    public partial class FrmNewUser : Form
    {

        public FrmNewUser()
        {
            InitializeComponent();
            FillStatus();
        }
        #region Methods FrmNewRole

        #region Methods Clear TextBox
        private void ClearTextbox()
        {
            this.TxtIdUser.Text = string.Empty;
            this.TxtUser.Text = string.Empty;
            this.TxtEmployee.Text = string.Empty;
            this.TxtPassword.Text = string.Empty;
            this.TxtConfirm.Text = string.Empty;
            this.LblIdEmployee.Text = string.Empty;
        }

        #endregion

        #region Method FillStatus ComboBox Status
        private void FillStatus()
        {
            CbxStatus.DataSource = LStatus.ShowStatus();
            CbxStatus.ValueMember = "IdStatus";
            CbxStatus.DisplayMember = "Name";
        }

        #endregion

        #endregion

        #region Events FrmNewUser

        #region UserName Textbox KeyPress Event
        private void TxtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region Cancel Button Click Event
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.ClearTextbox();
            this.Close();
        }


        #endregion

        #region Save Button Click Event
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.TxtUser.Text == string.Empty || this.TxtPassword.Text == string.Empty || this.TxtConfirm.Text == string.Empty ||
                    TxtEmployee.Text == string.Empty || LblIdEmployee.Text == string.Empty || CbxStatus.Text == string.Empty)
                {
                    MessageBox.Show("You must fill in the fields");
                }
                else
                {
                    if (TxtPassword.Text != string.Empty && TxtPassword.TextLength > 7
                        && TxtConfirm.Text != string.Empty && TxtConfirm.TextLength > 7
                        && TxtPassword.Text == TxtConfirm.Text)
                    {
                        string message = LUser.Insert(TxtUser.Text.Trim().ToUpper(), this.TxtPassword.Text.Trim(), Convert.ToInt32(LblIdEmployee.Text), Convert.ToInt32(CbxStatus.SelectedValue));
                        if (message.Equals("OK"))
                        {
                            MessageBox.Show("Entered Correctly");
                            this.Close();
                            ClearTextbox();
                        }
                        else
                        {
                            MessageBox.Show(message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password must have a minimum of 8 characters and the same");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        #region Edit Button Click Event
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.TxtUser.Text == string.Empty || this.TxtPassword.Text == string.Empty || this.TxtConfirm.Text == string.Empty ||
                    TxtEmployee.Text == string.Empty || LblIdEmployee.Text == string.Empty || CbxStatus.Text == string.Empty)
                {
                    MessageBox.Show("You must fill in the fields");
                }
                else
                {
                    if (TxtPassword.Text != string.Empty && TxtPassword.TextLength > 7
                        && TxtConfirm.Text != string.Empty && TxtConfirm.TextLength > 7
                        && TxtPassword.Text == TxtConfirm.Text)
                    {
                        string message = LUser.Edit(Convert.ToInt32(TxtIdUser.Text), TxtUser.Text.Trim().ToUpper(), this.TxtPassword.Text.Trim(), Convert.ToInt32(LblIdEmployee.Text), Convert.ToInt32(CbxStatus.SelectedValue));
                        if (message.Equals("OK"))
                        {
                            MessageBox.Show("Entered Correctly");
                            this.Close();
                            ClearTextbox();
                        }
                        else
                        {
                            MessageBox.Show(message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The password must have a minimum of 8 characters and the same");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        #endregion



        private void BtnShowPassword_Click(object sender, EventArgs e)
        {
            if (TxtPassword.PasswordChar == '*')
            {
                BtnShowPassword.IconChar = IconChar.EyeSlash;
                TxtPassword.PasswordChar = '\0';
            }
            else
            {
                BtnShowPassword.IconChar = IconChar.Eye;
                TxtPassword.PasswordChar = '*';
            }
        }

        private void BtnShowConfirm_Click(object sender, EventArgs e)
        {
            if (TxtConfirm.PasswordChar == '*')
            {
                BtnShowConfirm.IconChar = IconChar.EyeSlash;
                TxtConfirm.PasswordChar = '\0';
            }
            else
            {
                BtnShowConfirm.IconChar = IconChar.Eye;
                TxtConfirm.PasswordChar = '*';
            }
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            FrmViewEmployees employees = new();
            employees.ShowDialog();
            LblIdEmployee.Text = employees.IdEmployee;
            TxtEmployee.Text = $"{employees.NameEmployee} {employees.LastName}";

        }
    }
}
