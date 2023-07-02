using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Roles
{
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
        }
        #region Methods FrmRoles

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if(DataList.Rows.Count > 0 )
                this.DataList.Columns[1].Visible = false;
        }

        #endregion

        #region Method ShowRoles DataGridView DataList
        private void ShowRoles()
        {
            this.DataList.DataSource = LRole.ShowRoles();
            this.HideColumns();
            LabelTotalRoles.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchName Role
        private void SearchNameRole()
        {
            this.DataList.DataSource = LRole.SearchName(TxtSearch.Text);
            this.HideColumns();
            LabelTotalRoles.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }
        #endregion

        #endregion

        #region Events FrmRoles

        #region FrmRoles Load Event
        private void FrmRoles_Load(object sender, EventArgs e)
        {
            this.ShowRoles();
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
            this.SearchNameRole();
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
            FrmNewRole newRole = new();
            newRole.TxtIdRole.Text = Convert.ToString(DataList.CurrentRow.Cells["IdRole"].Value);
            newRole.TxtNameRole.Text = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value);
            newRole.TxtDescriptionRole.Text = Convert.ToString(DataList.CurrentRow.Cells["Description"].Value);
            newRole.CbxStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["Status"].Value);

            newRole.BtnSave.Visible = false;
            newRole.BtnEdit.Visible = true;
            newRole.ShowDialog();
            this.ShowRoles();
        }

        #endregion

        #region NewRole Button Click Event
        private void BtnNewRole_Click(object sender, EventArgs e)
        {
            FrmNewRole newRole = new();
            newRole.BtnSave.Visible = true;
            newRole.BtnEdit.Visible = false;
            newRole.ShowDialog();
            this.ShowRoles();
        }

        #endregion

        #region DeleteRoles Button Click Event 
        private void BtnDeleteRoles_Click(object sender, EventArgs e)

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
                                message = LRole.Delete(Convert.ToInt32(id));

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
                        this.ShowRoles();
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
