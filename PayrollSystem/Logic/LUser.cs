using System.Data;
using PayrollSystem.Models;
using PayrollSystem.Data;
using PayrollSystem.Tools;

namespace PayrollSystem.Logic
{
    public class LUser
    {
        #region Method Insert User Class LUser
        public static string Insert(string user, string password, int idemployee, int idstatus)
        {
            Users users = new();
            users.User = user;
            users.Password = Encrypt.GetSHA256(password);
            users.IdEmployee = idemployee;
            users.IdStatus = idstatus;

            DUsers dUser = new();
            return dUser.Insert(users);
        }

        #endregion

        #region Method Edit User Class LUser
        public static string Edit(int iduser, string user, string password, int idemployee,int idstatus)
        {
            Users users = new();
            users.IdUser = iduser;
            users.User = user;
            users.Password = Encrypt.GetSHA256(password);
            users.IdEmployee = idemployee;
            users.IdStatus = idstatus;

            DUsers dUser = new();
            return dUser.Edit(users);
        }

        #endregion

        #region Method Delete User Class LUser
        public static string Delete(int iduser)
        {
            Users users = new();
            users.IdUser = iduser;

            DUsers dUser = new();
            return dUser.Delete(users);
        }

        #endregion

        #region Method ShowUsers Class LUser
        public static DataTable ShowUsers()
        {
            return new DUsers().ShowUsers();
        }

        #endregion

        #region Method SearchName User Class LUser
        public static DataTable SearchName(string textsearch)
        {
            Users users = new();
            users.TextSearch = textsearch;

            DUsers dUser = new();
            return dUser.SearchName(users);
        }

        #endregion

        #region Method Login User Class LUser
        public static DataTable Login(string user, string password)
        {
            Users users = new() { User = user, Password = password };
            DUsers dUser = new();
            return dUser.Login(users);
        }

        #endregion
    }
}
