using PayrollSystem.Models;
using PayrollSystem.Data;
using System.Data;

namespace PayrollSystem.Logic
{
    public class LRole
    {
        #region Method Insert Role Class LRole
        public static string Insert(string name, string description, int idstatus)
        {
            Roles role = new();
            role.Name = name;
            role.Description = description;
            role.IdStatus = idstatus;

            DRoles dRole = new();
            return dRole.Insert(role);
        }

        #endregion

        #region Method Edit Role Class LRole
        public static string Edit(int idrole, string name, string description, int idstatus)
        {
            Roles role = new();
            role.IdRole = idrole;
            role.Name = name;
            role.Description = description;
            role.IdStatus = idstatus;

            DRoles dRole = new();
            return dRole.Edit(role);
        }

        #endregion

        #region Method Delete Role Class LRole
        public static string Delete(int idrole)
        {
            Roles role = new();
            role.IdRole = idrole;

            DRoles dRole = new();
            return dRole.Delete(role);
        }

        #endregion

        #region Method ShowRoles Class LRole
        public static DataTable ShowRoles()
        {
            return new DRoles().ShowRoles();
        }

        #endregion

        #region Method SearchName Role Class LRole
        public static DataTable SearchName(string textsearch)
        {
            Roles role = new();
            role.TextSearch = textsearch;

            DRoles dRole = new();
            return dRole.SearchName(role);
        }

        #endregion
    }
}
