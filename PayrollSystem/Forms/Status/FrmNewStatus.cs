using PayrollSystem.Logic;
using PayrollSystem.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollSystem.Forms.Status
{
    public partial class FrmNewStatus : Form
    {
        public FrmNewStatus()
        {
            InitializeComponent();
        }
        #region Methods FrmNewDepartment

        #region Methods Clear TextBox
        private void ClearTextbox()
        {
            this.TxtIdStatus.Text = string.Empty;
            this.TxtNameStatus.Text = string.Empty;
            this.TxtDescriptionStatus.Text = string.Empty;
        }

        #endregion


        #endregion

        #region Events FrmNewDepartment

        #region NameStatus Textbox KeyPress Event
        private void TxtNameStatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region DescriptionStatus Textbox KeyPress Event
        private void TxtDescriptionStatusKeyPress(object sender, KeyPressEventArgs e)
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
                if (this.TxtNameStatus.Text == string.Empty)
                {
                    MessageBox.Show("Enter the Status");
                }
                else
                {
                    string message = LStatus.Insert(TxtNameStatus.Text.Trim().ToUpper(), this.TxtDescriptionStatus.Text.Trim());
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
                if (this.TxtNameStatus.Text == string.Empty)
                {
                    MessageBox.Show("Enter the Status");
                }
                else
                {
                    string message = LStatus.Edit(Convert.ToInt32(TxtIdStatus.Text), TxtNameStatus.Text.Trim().ToUpper(), this.TxtDescriptionStatus.Text.Trim());
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
