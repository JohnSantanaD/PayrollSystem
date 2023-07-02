using PayrollSystem.Forms.Status;
using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Status
{
    public partial class FrmStatus : Form
    {
        public FrmStatus()
        {
            InitializeComponent();
        }

        #region Methods FrmStatuss

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if (DataList.Rows.Count > 0)
                this.DataList.Columns[1].Visible = false;
        }

        #endregion

        #region Method ShowStatuss DataGridView DataList
        private void ShowStatuss()
        {
            this.DataList.DataSource = LStatus.ShowStatus();
            this.HideColumns();
            LabelTotalStatus.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchName Status
        private void SearchNameStatus()
        {
            this.DataList.DataSource = LStatus.SearchName(TxtSearch.Text);
            this.HideColumns();
            LabelTotalStatus.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }
        #endregion

        #endregion

        #region Events FrmStatuss

        #region FrmStatuss Load Event
        private void FrmStatus_Load(object sender, EventArgs e)
        {
            this.ShowStatuss();
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
            this.SearchNameStatus();
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
            FrmNewStatus newStatus = new();
            newStatus.TxtIdStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["IdStatus"].Value);
            newStatus.TxtNameStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value);
            newStatus.TxtDescriptionStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["Description"].Value);

            newStatus.BtnSave.Visible = false;
            newStatus.BtnEdit.Visible = true;
            newStatus.ShowDialog();
            this.ShowStatuss();
        }

        #endregion

        #region NewStatus Button Click Event
        private void BtnNewStatus_Click(object sender, EventArgs e)
        {
            FrmNewStatus newStatus = new();
            newStatus.BtnSave.Visible = true;
            newStatus.BtnEdit.Visible = false;
            newStatus.ShowDialog();
            this.ShowStatuss();
        }

        #endregion

        #region DeleteStatuss Button Click Event 
        private void BtnDeleteStatus_Click(object sender, EventArgs e)

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
                                message = LStatus.Delete(Convert.ToInt32(id));

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
                        this.ShowStatuss();
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
