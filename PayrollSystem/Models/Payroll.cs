using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class Payroll
    {
        public int IdPayroll { get; set; }
        public int IdEmployee { get; set; }
        public Decimal ExtraHours { get; set; }
        public Decimal PriceOvertime { get; set; }
        public Decimal OvertimePayments { get; set; }
        public Decimal Bonuses { get; set; }
        public Decimal FamilyHealthInsurance { get; set; }
        public Decimal PensionFundAdministrator { get; set; }
        public Decimal IncomeTax { get; set; }
        public Decimal SalaryAdvance { get; set; }
        public Decimal NetSalary { get; set; }
        public int IdStatus { get; set; }
        public DateTime RegistrationDate { get; set; }

    }
}
