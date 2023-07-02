using System.Data;
using System.Data.SqlClient;
using PayrollSystem.Models;

namespace PayrollSystem.Data
{
    public class DRoles
    {

        #region Method Insert Role
        public string Insert(Roles role)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "INSERT INTO Roles (Name,Description,IdStatus) VALUES (@Name,@Description,@IdStatus)";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Name", role.Name);
                sqlCommand.Parameters.AddWithValue("@Description", role.Description);
                sqlCommand.Parameters.AddWithValue("@IdStatus", role.IdStatus);

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

        #region Method Edit Role
        public string Edit(Roles role)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "UPDATE Roles SET Name=@Name,Description=@Description,IdStatus=@IdStatus WHERE IdRole=@IdRole";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdRole", role.IdRole);
                sqlCommand.Parameters.AddWithValue("@Name", role.Name);
                sqlCommand.Parameters.AddWithValue("@Description", role.Description);
                sqlCommand.Parameters.AddWithValue("@IdStatus", role.IdStatus);

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

        #region Method Delete Role
        public string Delete(Roles role)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "DELETE FROM Roles WHERE IdRole=@IdRole";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdRole", role.IdRole);

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

        #region Method ShowRoles
        public DataTable ShowRoles()
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 100
                                    r.IdRole,
                                    r.Name,
                                    r.Description,
                                    s.Name as Status,
                                    r.RegistrationDate
                                    FROM Roles r INNER JOIN Status s ON r.IdStatus=s.IdStatus ORDER BY IdRole DESC";
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

        #region Method SearchName Role
        public DataTable SearchName(Roles role)
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 100
                                    r.IdRole,
                                    r.Name,
                                    r.Description,
                                    s.Name as Status,
                                    r.RegistrationDate
                                    FROM Roles r INNER JOIN Status s ON r.IdStatus=s.IdStatus WHERE r.Name LIKE @TextSearch + '%'";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TextSearch", role.TextSearch);

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

    }
}
