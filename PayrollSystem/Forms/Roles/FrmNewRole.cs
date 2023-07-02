using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Roles
{
    public partial class FrmNewRole : Form
    {
        public FrmNewRole()
        {
            InitializeComponent();
            FillStatus();
        }
        #region Methods FrmNewRole

        #region Methods Clear TextBox
        private void ClearTextbox()
        {
            this.TxtIdRole.Text = string.Empty;
            this.TxtNameRole.Text = string.Empty;
            this.TxtDescriptionRole.Text = string.Empty;
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

        #region Events FrmNewRole

        #region NameRole Textbox KeyPress Event
        private void TxtNameRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region DescriptionRole Textbox KeyPress Event
        private void TxtDescriptionRole_KeyPress(object sender, KeyPressEventArgs e)
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
                if (this.TxtNameRole.Text == string.Empty || CbxStatus.Text == string.Empty)
                {
                    MessageBox.Show("Enter the Role Name or Status");
                }
                else
                {
                    string message = LRole.Insert(TxtNameRole.Text.Trim().ToUpper(), this.TxtDescriptionRole.Text.Trim(), Convert.ToInt32(CbxStatus.SelectedValue));
                    if (message.Equals("OK"))
                    {
                        MessageBox.Show("Entered Correctly");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
                ClearTextbox();
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
                if (this.TxtNameRole.Text == string.Empty || CbxStatus.Text == string.Empty)
                {
                    MessageBox.Show("Enter the Role Name or Status");
                }
                else
                {
                    string message = LRole.Edit(Convert.ToInt32(TxtIdRole.Text), TxtNameRole.Text.Trim().ToUpper(), this.TxtDescriptionRole.Text.Trim(), Convert.ToInt32(CbxStatus.SelectedValue));
                    if (message.Equals("OK"))
                    {
                        MessageBox.Show("Updated successfully");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(message);
                    }
                }
                ClearTextbox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        #endregion

        #endregion

    }
}
