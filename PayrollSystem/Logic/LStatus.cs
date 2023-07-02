using PayrollSystem.Models;
using PayrollSystem.Data;
using System.Data;

namespace PayrollSystem.Logic
{
    public class LStatus
    {
        #region Method Insert Status Class LStatus
        public static string Insert(string name, string description)
        {
            Status status = new();
            status.Name = name;
            status.Description = description;

            DStatus dStatus = new();
            return dStatus.Insert(status);
        }

        #endregion

        #region Method Edit Status Class LStatus
        public static string Edit(int idstatus, string name, string description)
        {
            Status status = new();
            status.IdStatus = idstatus;
            status.Name = name;
            status.Description = description;

            DStatus dStatus = new();
            return dStatus.Edit(status);
        }

        #endregion

        #region Method Delete Status Class LStatus
        public static string Delete(int idstatus)
        {
            Status status = new();
            status.IdStatus = idstatus;

            DStatus dStatus = new();
            return dStatus.Delete(status);
        }

        #endregion

        #region Method ShowStatus Class LStatus
        public static DataTable ShowStatus()
        {
            return new DStatus().ShowStatus();
        }

        #endregion

        #region Method SearchName Status Class LStatus
        public static DataTable SearchName(string textsearch)
        {
            Status status = new();
            status.TextSearch = textsearch;

            DStatus dStatus = new();
            return dStatus.SearchName(status);
        }

        #endregion
    }
}
