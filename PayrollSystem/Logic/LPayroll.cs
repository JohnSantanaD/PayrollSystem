using PayrollSystem.Data;
using PayrollSystem.Models;
using System.Data;

namespace PayrollSystem.Logic
{
    public class LPayroll
    {

        #region Method Insert Payroll Class LPayroll
        public static string Insert(int idemployee, Decimal extrahours, Decimal priceovertime, Decimal overtimepayments, Decimal Bonuses, 
            Decimal familyhealthinsurance, Decimal Pensionfundadministrator, Decimal incometax, Decimal salaryadvance, Decimal netsalary)
        {
            Payroll payroll = new();
            payroll.IdEmployee = idemployee;
            payroll.ExtraHours = extrahours;
            payroll.PriceOvertime = priceovertime;
            payroll.OvertimePayments = overtimepayments;
            payroll.Bonuses = Bonuses;
            payroll.FamilyHealthInsurance = familyhealthinsurance;
            payroll.PensionFundAdministrator = Pensionfundadministrator;
            payroll.IncomeTax = incometax;
            payroll.SalaryAdvance = salaryadvance;
            payroll.NetSalary = netsalary;

            DPayroll dPayroll = new();
            return dPayroll.Insert(payroll);
        }
        #endregion

        #region Method Edit Payroll Class LPayroll
        public static string Edit(int idpayroll, int idemployee, Decimal extrahours, Decimal priceovertime, Decimal overtimepayments, Decimal Bonuses,
            Decimal familyhealthinsurance, Decimal Pensionfundadministrator, Decimal incometax, Decimal salaryadvance, Decimal netsalary)
        {
            Payroll payroll = new();
            payroll.IdPayroll = idpayroll;
            payroll.IdEmployee = idemployee;
            payroll.ExtraHours = extrahours;
            payroll.PriceOvertime = priceovertime;
            payroll.OvertimePayments = overtimepayments;
            payroll.Bonuses = Bonuses;
            payroll.FamilyHealthInsurance = familyhealthinsurance;
            payroll.PensionFundAdministrator = Pensionfundadministrator;
            payroll.IncomeTax = incometax;
            payroll.SalaryAdvance = salaryadvance;
            payroll.NetSalary = netsalary;

            DPayroll dPayroll = new();
            return dPayroll.Edit(payroll);
        }
        #endregion

        #region Method Delete Payroll Class LPayroll
        public static string Delete(int idPayroll)
        {
            Payroll payroll = new();
            payroll.IdPayroll = idPayroll;

            DPayroll dPayroll = new();
            return dPayroll.Delete(payroll);
        }
        #endregion

        #region Method ShowPayrolls Class LPayroll
        public static DataTable ShowPayrolls()
        {
            return new DPayroll().ShowPayrolls();
        }

        #endregion

        #region Method SearchName Payroll Class LPayroll
        public static DataTable SearchPayrollDate(string textsearch, string textsearch2)
        {
            return new DPayroll().SearchPayrollDate(textsearch, textsearch2) ;
        }

        #endregion

        //#region Method SearchNumberDocument Payroll Class LPayroll
        //public static DataTable SearchNNumberDocument(string textsearch)
        //{
        //    Payrolls Payroll = new();
        //    Payroll.TextSearch = textsearch;

        //    DPayrolls dPayroll = new();
        //    return dPayroll.SearchNumberDocument(Payroll);
        //}

        //#endregion

    }
}
