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

namespace PayrollSystem.Forms.Departments
{
    public partial class FrmNewDepartment : Form
    {
        public FrmNewDepartment()
        {
            InitializeComponent();
            FillStatus();
        }
        #region Methods FrmNewDepartment

        #region Methods Clear TextBox
        private void ClearTextbox()
        {
            this.TxtIdDepartment.Text = string.Empty;
            this.TxtNameDepartment.Text = string.Empty;
            this.TxtDescriptionDepartment.Text = string.Empty;
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

        #region Events FrmNewDepartment

        #region NameDepartment Textbox KeyPress Event
        private void TxtNameDepartment_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region DescriptionDepartment Textbox KeyPress Event
        private void TxtDescriptionDepartment_KeyPress(object sender, KeyPressEventArgs e)
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
                if (this.TxtNameDepartment.Text == string.Empty || this.CbxStatus.Text == string.Empty)
                {
                    MessageBox.Show("Enter the Department Name or Status");
                }
                else
                {
                    string message = LDepartments.Insert(TxtNameDepartment.Text.Trim().ToUpper(), this.TxtDescriptionDepartment.Text.Trim(), Convert.ToInt32(CbxStatus.SelectedValue));
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
                if (this.TxtNameDepartment.Text == string.Empty || this.CbxStatus.Text == string.Empty)
                {
                    MessageBox.Show("Enter the Department Name or Status");
                }
                else
                {
                    string message = LDepartments.Edit(Convert.ToInt32(TxtIdDepartment.Text), TxtNameDepartment.Text.Trim().ToUpper(), this.TxtDescriptionDepartment.Text.Trim(), Convert.ToInt32(CbxStatus.SelectedValue));
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
