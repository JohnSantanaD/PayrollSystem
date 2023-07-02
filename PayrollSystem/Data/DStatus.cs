using System.Data;
using System.Data.SqlClient;
using PayrollSystem.Models;

namespace PayrollSystem.Data
{
    public class DStatus 
    { 

        #region Method Insert Status
        public string Insert(Status status)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "INSERT INTO Status (Name,Description) VALUES (@Name,@Description)";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Name", status.Name);
                sqlCommand.Parameters.AddWithValue("@Description", status.Description);

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

        #region Method Edit Status
        public string Edit(Status status)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "UPDATE Status SET Name=@Name,Description=@Description WHERE IdStatus=@IdStatus";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdStatus", status.IdStatus);
                sqlCommand.Parameters.AddWithValue("@Name", status.Name);
                sqlCommand.Parameters.AddWithValue("@Description", status.Description);

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

        #region Method Delete Status
        public string Delete(Status status)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "DELETE FROM Status WHERE IdStatus=@IdStatus";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdStatus", status.IdStatus);

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

        #region Method ShowStatus
        public DataTable ShowStatus()
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "SELECT TOP 100 * FROM Status ORDER BY IdStatus DESC";
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

        #region Method SearchName Status
        public DataTable SearchName(Status status)
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "SELECT * FROM Status WHERE Name LIKE @TextSearch + '%'";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TextSearch", status.TextSearch);

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
