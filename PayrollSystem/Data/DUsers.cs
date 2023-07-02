using System.Data;
using System.Data.SqlClient;
using System.Windows.Controls;
using PayrollSystem.Data;
using PayrollSystem.Logic;
using PayrollSystem.Models;

namespace PayrollSystem.Data
{
    public class DUsers
    {

        #region Method Insert User
        public string Insert(Users users)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"INSERT INTO Users (UserName,Password,IdEmployee,IdStatus) 
                    VALUES (@UserName,@Password,@IdEmployee,@IdStatus)";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@UserName", users.User);
                sqlCommand.Parameters.AddWithValue("@Password", users.Password);
                sqlCommand.Parameters.AddWithValue("@IdEmployee", users.IdEmployee);
                sqlCommand.Parameters.AddWithValue("@IdStatus", users.IdStatus);

                message = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "The Registry was not entered";

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return message;
        }

        #endregion

        #region Method Edit User
        public string Edit(Users users)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "UPDATE Users SET UserName=@UserName,Password=@Password,IdEmployee=@IdEmployee,IdStatus=@IdStatus WHERE IdUser=@IdUser";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdUser", users.IdUser);
                sqlCommand.Parameters.AddWithValue("@UserName", users.User);
                sqlCommand.Parameters.AddWithValue("@Password", users.Password);
                sqlCommand.Parameters.AddWithValue("@IdEmployee", users.IdEmployee);
                sqlCommand.Parameters.AddWithValue("@IdStatus", users.IdStatus);

                message = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "Registry not updated";

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return message;
        }

        #endregion

        #region Method Delete User
        public string Delete(Users users)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "DELETE FROM Users WHERE IdUser=@IdUser";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdUser", users.IdUser);

                message = sqlCommand.ExecuteNonQuery() == 1 ? "OK" : "The Registry was not delete";

            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return message;
        }

        #endregion

        #region Method ShowUsers
        public DataTable ShowUsers()
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 100
					                u.IdUser,
					                U.UserName,
					                u.Password,
					                e.IdEmployee,
					                e.Name +' '+ e.LastName as Employee,
					                r.Name as Role,
					                s.Name as Status,
					                u.RegistrationDate
					                FROM Users u INNER JOIN Employees e ON u.IdEmployee = e.IdEmployee
					                INNER JOIN Roles r ON e.IdRole = r.IdRole
					                INNER JOIN Status s ON u.IdStatus = s.IdStatus ORDER BY u.IdUser DESC";
                SqlDataAdapter adapter = new(query, sqlConnection);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                dataTable = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return dataTable;
        }

        #endregion

        #region Method SearchName User
        public DataTable SearchName(Users users)
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT
					                u.IdUser,
					                U.UserName,
					                u.Password,
					                e.IdEmployee,
					                e.Name +' '+ e.LastName as Employee,
					                r.Name as Role,
					                s.Name as Status,
					                u.RegistrationDate
					                FROM Users u INNER JOIN Employees e ON u.IdEmployee = e.IdEmployee
					                INNER JOIN Roles r ON e.IdRole = r.IdRole
					                INNER JOIN Status s ON u.IdStatus = s.IdStatus WHERE U.UserName LIKE @TextSearch + '%'";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TextSearch", users.TextSearch);

                SqlDataAdapter adapter = new(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                dataTable = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return dataTable;
        }

        #endregion


        #region Method Login User
        public DataTable Logins(Users users)
        {
            var reponse = false; 
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand(@$"SELECT UserName, Password
                                                        FROM Users WHERE UserName='{users.User}' AND Password='{users.Password}'", sqlConnection);
                //SqlDataReader dr = sqlCommand.ExecuteReader();
                //if (dr.Read())
                //    reponse = true;
                //else
                //    reponse = false;
                SqlDataAdapter adapter = new(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                dataTable = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return dataTable;
        }

        #endregion



        #region Method Login User
        public DataTable Login(Users users)
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @$"SELECT
					                u.IdUser,
					                U.UserName,
					                u.Password,
					                e.IdEmployee,
					                e.Name, 
                                    e.LastName,
                                    e.Email,
					                r.Name as Role,
                                    e.Image
					                FROM Users u INNER JOIN Employees e ON u.IdEmployee = e.IdEmployee
					                INNER JOIN Roles r ON e.IdRole = r.IdRole WHERE u.UserName='{users.User}' AND u.Password='{users.Password}'";
                SqlCommand sqlCommand = new(query, sqlConnection);
                SqlDataAdapter adapter = new(sqlCommand);
                adapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                dataTable = null;
            }
            finally
            {
                if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
            }

            return dataTable;
        }

        #endregion

    }
}
