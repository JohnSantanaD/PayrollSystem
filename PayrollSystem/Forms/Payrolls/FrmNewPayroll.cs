using PayrollSystem.Forms.Users;
using PayrollSystem.Logic;
using PayrollSystem.Tools;

namespace PayrollSystem.Forms.Payrolls
{
    public partial class FrmNewPayroll : Form
    {
        FrmViewEmployees employees = new();

        //Porcientos que se descuentan
        public const Decimal DiscountSFS = (Decimal)3.04 / 100;
        public const Decimal DiscountAFP = (Decimal)2.87 / 100;

        public const Decimal DiscountISR_15 = (Decimal)15 / 100;
        public const Decimal DiscountISR_20 = (Decimal)20 / 100;
        public const Decimal DiscountISR_25 = (Decimal)25 / 100;

        //Excedentes 
        public const Decimal SecondSurplus = (Decimal)399923.01;
        public const Decimal ThirdSurplus = (Decimal)599884.01;
        public const Decimal FourthSurplus = (Decimal)833171.01;

        //Escalas 
        public const Decimal SecondScale = (Decimal)416220.01;
        public const Decimal ThirdScale = (Decimal)624329.01;
        public const Decimal FourthScale = (Decimal)867123.01;

        //Tasas
        public const Decimal SecondRate = (Decimal)31216;
        public const Decimal ThirdRate = (Decimal)79776;


        public FrmNewPayroll()
        {
            InitializeComponent();
        }


        #region Methods FrmNewEmployee

        private void ClearControls()
        {
            this.TxtIdPayroll.Text = string.Empty;
            this.TxtEmployee.Text = string.Empty;
            this.LblIdEmployee.Text = string.Empty;
            this.TxtNameEmployee.Text = string.Empty;
            this.TxtLastName.Text = string.Empty;
            this.TxtRole.Text = string.Empty;
            this.TxtSalary.Text = string.Empty;
            this.TxtExtraHours.Text = string.Empty;
            this.TxtPriceOvertime.Text = string.Empty;
            this.TxtOvertimePayment.Text = string.Empty;
            this.TxtBonuses.Text = string.Empty;
            this.TxtTotalAssignments.Text = string.Empty;
            this.TxtSFS.Text = string.Empty;
            this.TxtAFP.Text = string.Empty;
            this.TxtTSS.Text = string.Empty;
            this.TxtISR.Text = string.Empty;
            this.TxtSalaryAdvance.Text = string.Empty;
            this.TxtTotalDeductions.Text = string.Empty;
            this.TxtNetSalary.Text = string.Empty;
        }

        private Decimal OvertimePayment()
        {
            decimal total = 0;
            if (TxtPriceOvertime.Text != string.Empty && TxtExtraHours.Text != string.Empty)
            {
                total = Convert.ToDecimal(TxtPriceOvertime.Text) * Convert.ToDecimal(TxtExtraHours.Text);
            }
            else
            {
                total = 0;
            }


            return total;
        }

        private Decimal TotalAssignments()
        {
            decimal total = 0;
            if (TxtBonuses.Text != string.Empty)
            {
                total = OvertimePayment() + Convert.ToDecimal(TxtBonuses.Text);
            }
            else
            {
                total = OvertimePayment();
            }


            return total;
        }

        private Decimal SFS()
        {
            decimal total = 0;
            decimal bonuses = 0;

            if (TxtBonuses.Text != string.Empty)
                bonuses = Convert.ToDecimal(TxtBonuses.Text);

            if (TxtSalary.Text != string.Empty)
            {
                total = Math.Round((Convert.ToDecimal(employees.Salary) + bonuses) * DiscountSFS, 2);
            }
            else
            {
                total = 0;
            }


            return total;
        }

        private Decimal AFP()
        {
            decimal total = 0;
            decimal bonuses = 0;

            if (TxtBonuses.Text != string.Empty)
                bonuses = Convert.ToDecimal(TxtBonuses.Text);

            if (TxtSalary.Text != string.Empty)
            {
                total = Math.Round((Convert.ToDecimal(employees.Salary) + bonuses) * DiscountAFP, 2);
            }
            else
            {
                total = 0;
            }


            return total;
        }

        private Decimal TotalTSS()
        {
            decimal total = 0;
            if (TxtSalary.Text != string.Empty)
            {
                total = SFS() + AFP();
            }
            else
            {
                total = 0;
            }


            return total;
        }

        private Decimal ISR()
        {
            decimal total = 0;
            decimal monthlySalary = 0;
            decimal annualSalary = 0;
            decimal surplus = 0;
            decimal bonuses = 0;

            if (TxtBonuses.Text != string.Empty)
                bonuses = Convert.ToDecimal(TxtBonuses.Text);

            if (TxtSalary.Text != string.Empty)
            {
                monthlySalary = (Convert.ToDecimal(employees.Salary) + bonuses) - TotalTSS() + OvertimePayment();
                annualSalary = monthlySalary * 12;

                if (annualSalary >= SecondScale && annualSalary < (Decimal)ThirdScale)
                {
                    surplus = annualSalary - SecondScale;
                    total = (surplus * DiscountISR_15) / 12;
                }
                else if (annualSalary >= ThirdScale && annualSalary < (Decimal)FourthScale)
                {
                    surplus = annualSalary - ThirdScale;
                    total = ((surplus * DiscountISR_20) + SecondRate) / 12;
                }
                else if (annualSalary >= FourthScale)
                {
                    surplus = annualSalary - FourthScale;
                    total = ((surplus * DiscountISR_25) + ThirdRate) / 12;
                }
                else
                {
                    total = 0;
                }
            }
            else
            {
                total = 0;
            }


            return Math.Round(total, 2);
        }

        private Decimal TotalDeductions()
        {
            decimal total = 0;
            if (TxtSalaryAdvance.Text != string.Empty)
            {
                total = TotalTSS() + Convert.ToDecimal(TxtSalaryAdvance.Text) + ISR();
            }
            else
            {
                total = TotalTSS() + ISR(); ;
            }


            return total;
        }

        private Decimal NetSalary()
        {
            decimal total = 0;
            if (TxtSalary.Text != string.Empty)
            {
                total = TotalAssignments() + Convert.ToDecimal(employees.Salary) - TotalDeductions();
            }
            else
            {
                total = 0;
            }


            return total;
        }

        #endregion

        #region Events FrmNewEmployee

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.ClearControls();
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNameEmployee.Text == string.Empty)
                {
                    MessageBox.Show("You must fill in the fields");
                }
                else
                {

                    if (TxtPriceOvertime.Text.Length == 0)
                        TxtPriceOvertime.Text = "0";
                    if (TxtExtraHours.Text.Length == 0)
                        TxtExtraHours.Text = "0";
                    if (TxtBonuses.Text.Length == 0)
                        TxtBonuses.Text = "0";
                    if (TxtSalaryAdvance.Text.Length == 0)
                        TxtSalaryAdvance.Text = "0";

                    string message = LPayroll.Insert(Convert.ToInt32(LblIdEmployee.Text), Convert.ToDecimal(TxtExtraHours.Text), Convert.ToDecimal(TxtPriceOvertime.Text),
                        Convert.ToDecimal(TxtOvertimePayment.Text), Convert.ToDecimal(TxtBonuses.Text), Convert.ToDecimal(TxtSFS.Text), Convert.ToDecimal(TxtAFP.Text),
                        Convert.ToDecimal(TxtISR.Text), Convert.ToDecimal(TxtSalaryAdvance.Text), Convert.ToDecimal(TxtNetSalary.Text));
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

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            //    try
            //    {
            //        if (TxtNameEmployee.Text == string.Empty)
            //        {
            //            MessageBox.Show("You must fill in the fields");
            //        }
            //        else
            //        {

            //            if (TxtPriceOvertime.Text.Length == 0)
            //                TxtPriceOvertime.Text = "0";
            //            if (TxtExtraHours.Text.Length == 0)
            //                TxtExtraHours.Text = "0";
            //            if (TxtBonuses.Text.Length == 0)
            //                TxtBonuses.Text = "0";
            //            if (TxtSalaryAdvance.Text.Length == 0)
            //                TxtSalaryAdvance.Text = "0";

            //            string message = LPayroll.Edit(Convert.ToInt32(TxtIdPayroll.Text), Convert.ToInt32(LblIdEmployee.Text), Convert.ToDecimal(TxtExtraHours.Text), Convert.ToDecimal(TxtPriceOvertime.Text),
            //                Convert.ToDecimal(TxtOvertimePayment.Text), Convert.ToDecimal(TxtBonuses.Text), Convert.ToDecimal(TxtSFS.Text), Convert.ToDecimal(TxtAFP.Text),
            //                Convert.ToDecimal(TxtISR.Text), Convert.ToDecimal(TxtSalaryAdvance.Text), Convert.ToDecimal(TxtNetSalary.Text));
            //            if (message.Equals("OK"))
            //            {
            //                MessageBox.Show("Updated successfully");
            //                this.Close();
            //            }
            //            else
            //            {
            //                MessageBox.Show(message);
            //            }
            //        }
            //        ClearControls();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message + ex.StackTrace);
            //    }
        }

        private void BtnSearchEmployee_Click(object sender, EventArgs e)
        {
            employees.ShowDialog();
            LblIdEmployee.Text = employees.IdEmployee;
            TxtEmployee.Text = employees.NumberDocument;
            TxtNameEmployee.Text = employees.NameEmployee;
            TxtLastName.Text = employees.LastName;
            TxtRole.Text = employees.Role;
            TxtSalary.Text = Convert.ToString(Convert.ToDecimal(employees.Salary));
            TxtSFS.Text = Convert.ToString(SFS());
            TxtAFP.Text = Convert.ToString(AFP());
            TxtTSS.Text = Convert.ToString(TotalTSS());
            TxtISR.Text = Convert.ToString(ISR());
            TxtNetSalary.Text = Convert.ToString(NetSalary());
            TxtTotalDeductions.Text = Convert.ToString(TotalDeductions());
        }

        private void TxtExtraHours_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersDecimals(e);
        }

        private void TxtPriceOvertime_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersDecimals(e);
        }

        private void TxtTransportVouchers_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersDecimals(e);
        }

        private void TxtSalaryAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validation.NumbersDecimals(e);
        }

        private void TxtPriceOvertime_TextChanged(object sender, EventArgs e)
        {
            TxtOvertimePayment.Text = Convert.ToString(OvertimePayment());
            TxtTotalAssignments.Text = Convert.ToString(TotalAssignments());
            TxtNetSalary.Text = Convert.ToString(NetSalary());
            TxtISR.Text = Convert.ToString(ISR());
            TxtTotalDeductions.Text = Convert.ToString(TotalDeductions());
        }

        private void TxtExtraHours_TextChanged(object sender, EventArgs e)
        {
            TxtOvertimePayment.Text = Convert.ToString(OvertimePayment());
            TxtTotalAssignments.Text = Convert.ToString(TotalAssignments());
            TxtNetSalary.Text = Convert.ToString(NetSalary());
            TxtISR.Text = Convert.ToString(ISR());
            TxtTotalDeductions.Text = Convert.ToString(TotalDeductions());
        }

        private void TxtTransportVouchers_TextChanged(object sender, EventArgs e)
        {
            TxtTotalAssignments.Text = Convert.ToString(TotalAssignments());
            TxtNetSalary.Text = Convert.ToString(NetSalary());
            TxtTSS.Text = Convert.ToString(TotalTSS());
            TxtISR.Text = Convert.ToString(ISR());
            TxtSFS.Text = Convert.ToString(SFS());
            TxtAFP.Text = Convert.ToString(AFP());
            TxtTotalDeductions.Text = Convert.ToString(TotalDeductions());
        }

        private void TxtSalaryAdvance_TextChanged(object sender, EventArgs e)
        {
            TxtNetSalary.Text = Convert.ToString(NetSalary());
            TxtTotalDeductions.Text = Convert.ToString(TotalDeductions());
        }

        #endregion


    }
}
