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

namespace PayrollSystem.Forms.Employees
{
    public partial class FrmNewEmployee : Form
    {
        public FrmNewEmployee()
        {
            InitializeComponent();
            FillRole();
            FillStatus();
            FillDepartments();
        }


        #region Methods FrmNewEmployee

        #region Method Clear Controls
        private void ClearControls()
        {
            this.TxtIdEmployee.Text = string.Empty;
            this.TxtNameEmployee.Text = string.Empty;
            this.TxtLastName.Text = string.Empty;
            this.TxtNumberDocument.Text = string.Empty;
            this.TxtAdress.Text = string.Empty;
            this.TxtPhone.Text = string.Empty;
            this.TxtEmail.Text = string.Empty;
            this.TxtSalary.Text = string.Empty;
            this.DtpDateBirth.Value = DateTime.Now;
            this.DtpDateAdmission.Value = DateTime.Now;
            this.CbxRole.Text = string.Empty;
            this.CbxSex.Text = "F";
            this.CbxStatus.Text = string.Empty;
            this.CbxDepartments.Text = string.Empty;
            this.PbxImage.Image = Properties.Resources.user;
        }

        #endregion

        #region Method FillRole ComboBox Role
        private void FillRole()
        {
            CbxRole.DataSource = LRole.ShowRoles();
            CbxRole.ValueMember = "IdRole";
            CbxRole.DisplayMember = "Name";
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

        #region Method FillDepartments ComboBox Departments
        private void FillDepartments()
        {
            CbxDepartments.DataSource = LDepartments.ShowDepartments();
            CbxDepartments.ValueMember = "IdDepartment";
            CbxDepartments.DisplayMember = "Name";
        }

        #endregion

        #endregion

        #region Events FrmNewEmployee

        #region Name Employee Textbox KeyPress Event
        private void TxtNameEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region LastName Employee Textbox KeyPress Event
        private void TxtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region Number Document Employee Textbox KeyPress Event
        private void TxtNumberDocument_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        #endregion

        #region Phone Employee Textbox KeyPress Event
        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        #endregion

        #region Email Employee Textbox KeyPress Event
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.Email(e);
        }

        #endregion

        private void TxtSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyNumbers(e);
        }

        #region Cancel Button Click Event
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.ClearControls();
            this.Close();
        }

        #endregion

        #region Save Button Click Event
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNameEmployee.Text == string.Empty || TxtLastName.Text == string.Empty || DtpDateBirth.Value == DateTime.Now ||
                        TxtNumberDocument.Text == string.Empty || TxtAdress.Text == string.Empty || TxtPhone.Text == string.Empty ||
                        TxtEmail.Text == string.Empty || CbxDepartments.Text == string.Empty || CbxStatus.Text == string.Empty ||
                        CbxRole.Text == string.Empty || TxtSalary.Text == string.Empty)
                {
                    MessageBox.Show("You must fill in the fields");
                }
                else
                {
                    MemoryStream stream = new();
                    PbxImage.Image.Save(stream, PbxImage.Image.RawFormat);
                    byte[] image = stream.GetBuffer();

                    string message = LEmployee.Insert(TxtNameEmployee.Text.Trim(), TxtLastName.Text.Trim(), CbxSex.Text, DtpDateBirth.Value,
                        TxtNumberDocument.Text.Trim(), TxtAdress.Text.Trim(), TxtPhone.Text.Trim(), TxtEmail.Text.Trim(),
                        image, DtpDateAdmission.Value, Convert.ToDecimal(TxtSalary.Text), Convert.ToInt32(CbxDepartments.SelectedValue), Convert.ToInt32(CbxStatus.SelectedValue), Convert.ToInt32(CbxRole.SelectedValue));
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
                ClearControls();
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
                if (TxtNameEmployee.Text == string.Empty || TxtLastName.Text == string.Empty || DtpDateBirth.Value == DateTime.Now ||
                        TxtNumberDocument.Text == string.Empty || TxtAdress.Text == string.Empty || TxtPhone.Text == string.Empty ||
                        TxtEmail.Text == string.Empty || CbxDepartments.Text == string.Empty || CbxStatus.Text == string.Empty ||
                        CbxRole.Text == string.Empty || TxtSalary.Text == string.Empty)
                {
                    MessageBox.Show("You must fill in the fields");
                }
                else
                {
                    MemoryStream stream = new();
                    PbxImage.Image.Save(stream, PbxImage.Image.RawFormat);
                    byte[] image = stream.GetBuffer();

                    string message = LEmployee.Edit(Convert.ToInt32(TxtIdEmployee.Text), TxtNameEmployee.Text.Trim(), TxtLastName.Text.Trim(), CbxSex.Text, DtpDateBirth.Value,
                        TxtNumberDocument.Text.Trim(), TxtAdress.Text.Trim(), TxtPhone.Text.Trim(), TxtEmail.Text.Trim(),
                        image, DtpDateAdmission.Value, Convert.ToDecimal(TxtSalary.Text), Convert.ToInt32(CbxDepartments.SelectedValue), Convert.ToInt32(CbxStatus.SelectedValue), Convert.ToInt32(CbxRole.SelectedValue));
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
                ClearControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        #endregion

        #region SearchImage Button Click Event
        private void BtnSearchImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new();

            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                PbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
                PbxImage.Image = Image.FromFile(dialog.FileName);
            }

        }

        #endregion

        #region CleanImage Button Click Event
        private void BtnCleanImage_Click(object sender, EventArgs e)
        {
            PbxImage.SizeMode = PictureBoxSizeMode.StretchImage;
            PbxImage.Image = Properties.Resources.user;
        }

        #endregion

        #endregion


    }
}
