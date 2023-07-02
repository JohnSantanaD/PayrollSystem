
using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Employees
{
    public partial class FrmEmployees : Form
    {
        public FrmEmployees()
        {
            InitializeComponent();
        }

        #region Methods FrmEmployees

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if(DataList.Rows.Count > 0 )
            {
                this.DataList.Columns[1].Visible = false;
                this.DataList.Columns[16].Visible = false;
            }
        }

        #endregion

        #region Method ShowEmployees DataGridView DataList
        private void ShowEmployees()
        {
            this.DataList.DataSource = LEmployee.ShowEmployees();
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchName DataGridView DataList
        private void SearchName()
        {
            this.DataList.DataSource = LEmployee.SearchName(TxtSearch.Text);
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchNNumberDocument DataGridView DataList
        private void SearchNNumberDocument()
        {
            this.DataList.DataSource = LEmployee.SearchNNumberDocument(Convert.ToString(TxtSearch.Text));
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #endregion

        #region Events FrmEmployees

        #region FrmEmployees Load Event
        private void FrmEmployees_Load(object sender, EventArgs e)
        {
            this.ShowEmployees();
        }

        #endregion

        #region Search Textbox TextChanged Event
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (CbxSearch.Text.Equals("Name"))
            {
                this.SearchName();
            }
            else if (CbxSearch.Text.Equals("Document"))
            {
                this.SearchNNumberDocument();
            }
        }

        #endregion

        #region Search Textbox KeyPress Event
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbxSearch.Text.Equals("Name"))
            {
                Validation.OnlyLetters(e);
            }
            else if (CbxSearch.Text.Equals("Document"))
            {
                Validation.OnlyNumbers(e);
            }
        }

        #endregion

        #region Delete Button Click Event
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (ChkDelete.Checked == true)
            {
                try
                {
                    DialogResult Option;
                    Option = MessageBox.Show("Do you really want to delete the records", "Payrollystem", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Option == DialogResult.OK)
                    {
                        string? id;
                        string message = "";

                        foreach (DataGridViewRow row in DataList.Rows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                id = Convert.ToString(row.Cells[1].Value);
                                message = LEmployee.Delete(Convert.ToInt32(id));

                                if (message.Equals("OK"))
                                {
                                    MessageBox.Show("The record was deleted Correctly");
                                    if (ChkDelete.Checked == true)
                                    {
                                        ChkDelete.Checked = false;

                                    }
                                }
                                else
                                {
                                    MessageBox.Show(message);
                                }
                            }
                        }
                        this.ShowEmployees();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("To delete an element you must first select it", "Payrollystem", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region New Button Click Event
        private void BtnNew_Click(object sender, EventArgs e)
        {
            FrmNewEmployee newEmployee = new();
            newEmployee.BtnEdit.Visible = false;
            newEmployee.BtnSave.Visible = true;
            newEmployee.ShowDialog();
            this.ShowEmployees();
        }

        #endregion

        #region Delete Checkbox CheckedChanged Event
        private void ChkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDelete.Checked == true)
            {
                this.DataList.Columns[0].Visible = true;
            }
            else
            {
                this.DataList.Columns[0].Visible = false;
            }
        }

        #endregion

        #region DataList DataGridView CellContentClick Event
        private void DataList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DataList.Columns["Delete"].Index)
            {
                DataGridViewCheckBoxCell chkDelete = (DataGridViewCheckBoxCell)DataList.Rows[e.RowIndex].Cells["Delete"];
                chkDelete.Value = !Convert.ToBoolean(chkDelete.Value);
            }
        }

        #endregion

        #region DataList DataGridView DoubleClick Event
        private void DataList_DoubleClick(object sender, EventArgs e)
        {
            FrmNewEmployee newEmployee = new();
            newEmployee.TxtIdEmployee.Text = Convert.ToString(DataList.CurrentRow.Cells["IdEmployee"].Value);
            newEmployee.TxtNameEmployee.Text = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value);
            newEmployee.TxtLastName.Text = Convert.ToString(DataList.CurrentRow.Cells["LastName"].Value);
            newEmployee.TxtNumberDocument.Text = Convert.ToString(DataList.CurrentRow.Cells["NumberDocument"].Value);
            newEmployee.TxtAdress.Text = Convert.ToString(DataList.CurrentRow.Cells["Address"].Value);
            newEmployee.TxtPhone.Text = Convert.ToString(DataList.CurrentRow.Cells["Phone"].Value);
            newEmployee.TxtEmail.Text = Convert.ToString(DataList.CurrentRow.Cells["Email"].Value);
            newEmployee.TxtSalary.Text = Convert.ToString(DataList.CurrentRow.Cells["Salary"].Value);
            newEmployee.CbxSex.Text = Convert.ToString(DataList.CurrentRow.Cells["Sex"].Value);
            newEmployee.CbxStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["Status"].Value);
            newEmployee.CbxRole.Text = Convert.ToString(DataList.CurrentRow.Cells["Role"].Value);
            newEmployee.CbxDepartments.Text = Convert.ToString(DataList.CurrentRow.Cells["Department"].Value);
            newEmployee.DtpDateBirth.Text = Convert.ToString(DataList.CurrentRow.Cells["DateBirth"].Value);
            newEmployee.DtpDateAdmission.Text = Convert.ToString(DataList.CurrentRow.Cells["DateAdmission"].Value);

            byte[] imageBuffer = (byte[])DataList.CurrentRow.Cells["Image"].Value;
            MemoryStream stream = new MemoryStream(imageBuffer);

            newEmployee.PbxImage.Image = Image.FromStream(stream);
            newEmployee.PbxImage.SizeMode = PictureBoxSizeMode.StretchImage;

            newEmployee.BtnEdit.Visible = true;
            newEmployee.BtnSave.Visible = false;
            newEmployee.ShowDialog();
            this.ShowEmployees();
        }

        #endregion

        #endregion

    }
}
