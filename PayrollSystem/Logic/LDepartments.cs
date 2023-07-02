using PayrollSystem.Models;
using PayrollSystem.Data;
using System.Data;

namespace PayrollSystem.Logic
{
    public class LDepartments
    {
        #region Method Insert Departments Class LDepartments
        public static string Insert(string name, string description, int idstatus)
        {
            Departments departments = new();
            departments.Name = name;
            departments.Description = description;
            departments.IdStatus = idstatus;

            DDepartments dDepartments = new();
            return dDepartments.Insert(departments);
        }

        #endregion

        #region Method Edit Departments Class Departments
        public static string Edit(int iddepartment, string name, string description, int idstatus)
        {
            Departments departments = new();
            departments.IdDepartment = iddepartment;
            departments.Name = name;
            departments.Description = description;
            departments.IdStatus = idstatus;

            DDepartments dDepartments = new();
            return dDepartments.Edit(departments);
        }

        #endregion

        #region Method Delete Departments Class LDepartments
        public static string Delete(int iddepartment)
        {
            Departments departments = new();
            departments.IdDepartment = iddepartment;

            DDepartments dDepartments = new();
            return dDepartments.Delete(departments);
        }

        #endregion

        #region Method ShowDepartments Class LDepartments
        public static DataTable ShowDepartments()
        {
            return new DDepartments().ShowDepartments();
        }

        #endregion

        #region Method SearchName Departments Class LDepartments
        public static DataTable SearchName(string textsearch)
        {
            Departments departments = new();
            departments.TextSearch = textsearch;

            DDepartments dDepartments = new();
            return dDepartments.SearchName(departments);
        }

        #endregion
    }
}
