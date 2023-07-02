using System.Data;
using PayrollSystem.Data;
using PayrollSystem.Models;

namespace PayrollSystem.Logic
{
    public class LEmployee
    {
        #region Method Insert Employee Class LEmployee
        public static string Insert(string name, string lastname, string sex, DateTime datebirth, string numberdocument,
            string adress, string phone, string email, byte[] image, DateTime dateadmission, Decimal salary, int Iddeparment, int status, int idrole)
        {
            Employees employee = new();
            employee.Name = name;
            employee.LastName = lastname;
            employee.Sex = sex;
            employee.DateBirth = datebirth;
            employee.NumberDocument = numberdocument;
            employee.Address = adress;
            employee.Phone = phone;
            employee.Email = email;
            employee.Image = image;
            employee.DateAdmission = dateadmission;
            employee.Salary = salary;
            employee.IdDepartment = Iddeparment;
            employee.IdStatus = status;
            employee.IdRole = idrole;

            DEmployees dEmployee = new();
            return dEmployee.Insert(employee);
        }
        #endregion

        #region Method Edit Employee Class LEmployee
        public static string Edit(int idemployee, string name, string lastname, string sex, DateTime datebirth, string numberdocument,
            string adress, string phone, string email, byte[] image, DateTime dateadmission, Decimal salary, int Iddeparment, int status, int idrole)
        {
            Employees employee = new();
            employee.IdEmployee = idemployee;
            employee.Name = name;
            employee.LastName = lastname;
            employee.Sex = sex;
            employee.DateBirth = datebirth;
            employee.NumberDocument = numberdocument;
            employee.Address = adress;
            employee.Phone = phone;
            employee.Email = email;
            employee.Image = image;
            employee.DateAdmission = dateadmission;
            employee.Salary = salary;
            employee.IdDepartment = Iddeparment;
            employee.IdStatus = status;
            employee.IdRole = idrole;

            DEmployees dEmployee = new();
            return dEmployee.Edit(employee);
        }
        #endregion

        #region Method Delete Employee Class LEmployee
        public static string Delete(int idemployee)
        {
            Employees employee = new();
            employee.IdEmployee = idemployee;

            DEmployees dEmployee = new();
            return dEmployee.Delete(employee);
        }
        #endregion

        #region Method ShowEmployees Class LEmployee
        public static DataTable ShowEmployees()
        {
            return new DEmployees().ShowEmployees();
        }

        #endregion

        #region Method SearchName Employee Class LEmployee
        public static DataTable SearchName(string textsearch)
        {
            Employees employee = new();
            employee.TextSearch = textsearch;

            DEmployees dEmployee = new();
            return dEmployee.SearchName(employee);
        }

        #endregion

        #region Method SearchNumberDocument Employee Class LEmployee
        public static DataTable SearchNNumberDocument(string textsearch)
        {
            Employees employee = new();
            employee.TextSearch = textsearch;

            DEmployees dEmployee = new();
            return dEmployee.SearchNumberDocument(employee);
        }

        #endregion
    }
}
