using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Payrolls
{
    public partial class FrmPayroll : Form
    {
        public FrmPayroll()
        {
            InitializeComponent();
            this.DtpDesde.Value = DateTime.Now.AddDays(-30);

        }

        #region Methods FrmPayrolls

        #region Method Hide Columns DataGridView DataList
        private void HideColumns()
        {
            this.DataList.Columns[0].Visible = false;
            if (DataList.Rows.Count > 0)
            {
                this.DataList.Columns[1].Visible = false;
                this.DataList.Columns[2].Visible = false;
            }
        }

        #endregion

        #region Method ShowPayrolls DataGridView DataList
        private void ShowPayrolls()
        {
            this.DataList.DataSource = LPayroll.ShowPayrolls();
            this.HideColumns();
            LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
        }

        #endregion

        #region Method SearchPayrollDate DataGridView DataList
        private void SearchPayrollDate()
        {
            if (DtpDesde.Value <= DtpHasta.Value)
            {
                this.DataList.DataSource = LPayroll.SearchPayrollDate(this.DtpDesde.Value.ToString("dd/MM/yyyy"), this.DtpHasta.Value.ToString("dd/MM/yyyy"));
                this.HideColumns();
                LabelTotal.Text = "Total Records: " + Convert.ToString(DataList.Rows.Count);
                if (DataList.Rows.Count < 1)
                    ShowPayrolls();
            }
            else
            {
                MessageBox.Show("You must enter an acceptable range of dates");
                ShowPayrolls();
            }
        }

        #endregion

        #endregion

        #region Events FrmPayrolls

        #region FrmPayrolls Load Event
        private void FrmPayrolls_Load(object sender, EventArgs e)
        {
            this.ShowPayrolls();
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
                                message = LPayroll.Delete(Convert.ToInt32(id));

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
                        this.ShowPayrolls();
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
            FrmNewPayroll newPayroll = new();
            newPayroll.BtnEdit.Visible = false;
            newPayroll.BtnSave.Visible = true;
            newPayroll.ShowDialog();
            this.ShowPayrolls();
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
            //FrmNewPayroll newPayroll = new();
            //newPayroll.TxtIdPayroll.Text = Convert.ToString(DataList.CurrentRow.Cells["IdPayroll"].Value);
            //newPayroll.LblIdEmployee.Text = Convert.ToString(DataList.CurrentRow.Cells["IdEmployee"].Value);
            //newPayroll.TxtEmployee.Text = Convert.ToString(DataList.CurrentRow.Cells["NumberDocument"].Value);
            //newPayroll.TxtNameEmployee.Text = Convert.ToString(DataList.CurrentRow.Cells["Name"].Value);
            //newPayroll.TxtLastName.Text = Convert.ToString(DataList.CurrentRow.Cells["LastName"].Value);
            //newPayroll.TxtRole.Text = Convert.ToString(DataList.CurrentRow.Cells["Role"].Value);
            //newPayroll.TxtSalary.Text = Convert.ToString( DataList.CurrentRow.Cells["Salary"].Value);
            //newPayroll.TxtExtraHours.Text = Convert.ToString(DataList.CurrentRow.Cells["ExtraHours"].Value);
            //newPayroll.TxtPriceOvertime.Text = Convert.ToString( DataList.CurrentRow.Cells["PriceOvertime"].Value);
            //newPayroll.TxtOvertimePayment.Text = Convert.ToString( DataList.CurrentRow.Cells["OvertimePayments"].Value);
            //newPayroll.TxtBonuses.Text = Convert.ToString( DataList.CurrentRow.Cells["Bonuses"].Value);
            //newPayroll.TxtSFS.Text = Convert.ToString( DataList.CurrentRow.Cells["SFS"].Value);
            //newPayroll.TxtAFP.Text = Convert.ToString( DataList.CurrentRow.Cells["AFP"].Value);
            //newPayroll.TxtISR.Text = Convert.ToString( DataList.CurrentRow.Cells["ISR"].Value);
            //newPayroll.TxtSalaryAdvance.Text = Convert.ToString( DataList.CurrentRow.Cells["SalaryAdvance"].Value);
            //newPayroll.TxtNetSalary.Text = Convert.ToString( DataList.CurrentRow.Cells["NetSalary"].Value);

            //newPayroll.BtnEdit.Visible = true;
            //newPayroll.BtnSave.Visible = false;
            //newPayroll.ShowDialog();
            //this.ShowPayrolls();
        }

        #endregion

        #endregion

        private void BtnSearchPayroll_Click(object sender, EventArgs e)
        {
            SearchPayrollDate();
        }

    }
}
