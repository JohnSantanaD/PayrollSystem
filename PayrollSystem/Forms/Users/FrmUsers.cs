using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace SystemSale.Forms.Users
{
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        #region Methods FrmUsers

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if (DataList.Rows.Count > 0)
            {
                this.DataList.Columns[1].Visible = false;
                this.DataList.Columns[3].Visible = false;
                this.DataList.Columns[4].Visible = false;
            }
        }

        #endregion

        #region Method ShowUsers DataGridView DataList
        private void ShowUsers()
        {
            this.DataList.DataSource = LUser.ShowUsers();
            this.HideColumns();
            LabelTotalUsers.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchName User
        private void SearchNameUser()
        {
            this.DataList.DataSource = LUser.SearchName(TxtSearch.Text);
            this.HideColumns();
            LabelTotalUsers.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }
        #endregion

        #endregion

        #region Events FrmUsers

        #region FrmUsers Load Event
        private void FrmUsers_Load(object sender, EventArgs e)
        {
            this.ShowUsers();
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
            this.SearchNameUser();
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
            FrmNewUser newUser = new();
            newUser.TxtIdUser.Text = Convert.ToString(DataList.CurrentRow.Cells["IdUser"].Value);
            newUser.TxtUser.Text = Convert.ToString(DataList.CurrentRow.Cells["UserName"].Value);
            newUser.TxtEmployee.Text = Convert.ToString(DataList.CurrentRow.Cells["Employee"].Value);
            newUser.CbxStatus.Text = Convert.ToString(DataList.CurrentRow.Cells["Status"].Value);

            newUser.BtnSave.Visible = false;
            newUser.BtnEdit.Visible = true;
            newUser.ShowDialog();
            this.ShowUsers();
        }

        #endregion

        #region NewUser Button Click Event
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            FrmNewUser newUser = new();
            newUser.BtnSave.Visible = true;
            newUser.BtnEdit.Visible = false;
            newUser.ShowDialog();
            this.ShowUsers();
        }

        #endregion

        #region DeleteUsers Button Click Event 
        private void BtnDeleteUsers_Click(object sender, EventArgs e)

        {
            if (ChkDelete.Checked == true)
            {
                if(DataList.Rows.Count > 1)
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
                                    message = LUser.Delete(Convert.ToInt32(id));

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
                            this.ShowUsers();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                    }
                }
                else
                {
                    MessageBox.Show("You can NOT delete all users");
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
