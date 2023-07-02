using PayrollSystem.Forms.Departments;
using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Departments
{
    public partial class FrmDepartments : Form
    {
        public FrmDepartments()
        {
            InitializeComponent();
        }

        #region Methods FrmDepartments

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if (DataList.Rows.Count > 0)
                this.DataList.Columns[1].Visible = false;
        }

        #endregion

        #region Method ShowDepartments DataGridView DataList
        private void ShowDepartments()
        {
            this.DataList.DataSource = LDepartments.ShowDepartments();
            this.HideColumns();
            LabelTotalDepartment.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchName Department
        private void SearchNameDepartment()
        {
            this.DataList.DataSource = LDepartments.SearchName(TxtSearch.Text);
            this.HideColumns();
            LabelTotalDepartment.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }
        #endregion

        #endregion

        #region Events FrmDepartments

        #region FrmDepartments Load Event
        private void FrmDepartments_Load(object sender, EventArgs e)
        {
            this.ShowDepartments();
        }

        #endregion

        #region Search Textbox KeyPress Event
        private void TxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.OnlyLetters(e);
        }

        #endregion

        #region Search Textbox TextChanged Event
        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            this.SearchNameDepartment();
        }

        #endregion

        #region Delete Checkbox CheckChanged Event
        private void ChkDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (ChkDelete.Checked)
            {
                this.DataList.Columns[0].Visible = true;
            }
            else
            {
                this.DataList.Columns[0].Visible = false;
            }
        }

        #endregion

        #region Datalist DataGridView CellContentClick Event
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
            FrmNewDepartment newDepartment = new();
            newDepartment.TxtIdDepartment.Text = Convert.ToString(DataList.CurrentRow.Cells["IdDepartment"].Value);
            newDepartment.TxtNameDepartment.Text = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value);
            newDepartment.TxtDescriptionDepartment.Text = Convert.ToString(DataList.CurrentRow.Cells["Description"].Value);
            newDepartment.CbxStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["Status"].Value);

            newDepartment.BtnSave.Visible = false;
            newDepartment.BtnEdit.Visible = true;
            newDepartment.ShowDialog();
            this.ShowDepartments();
        }

        #endregion

        #region NewDepartment Button Click Event
        private void BtnNewDepartments_Click(object sender, EventArgs e)
        {
            FrmNewDepartment newDepartment = new();
            newDepartment.BtnSave.Visible = true;
            newDepartment.BtnEdit.Visible = false;
            newDepartment.ShowDialog();
            this.ShowDepartments();
        }

        #endregion

        #region DeleteDepartments Button Click Event 
        private void BtnDeleteDepartments_Click(object sender, EventArgs e)

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
                                message = LDepartments.Delete(Convert.ToInt32(id));

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
                        this.ShowDepartments();
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

        #endregion

    }
}
