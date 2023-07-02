using System.Data;
using System.Data.SqlClient;
using PayrollSystem.Models;

namespace PayrollSystem.Data
{
    public class DDepartments
    {

        #region Method Insert Departments
        public string Insert(Departments department)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "INSERT INTO Departments (Name,Description,IdStatus) VALUES (@Name,@Description,@IdStatus)";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Name", department.Name);
                sqlCommand.Parameters.AddWithValue("@Description", department.Description);
                sqlCommand.Parameters.AddWithValue("@IdStatus", department.IdStatus);

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

        #region Method Edit Departments
        public string Edit(Departments departments)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "UPDATE Departments SET Name=@Name,Description=@Description,IdStatus=@IdStatus WHERE IdDepartment=@IdDepartment";
                SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdDepartment", departments.IdDepartment);
                sqlCommand.Parameters.AddWithValue("@Name", departments.Name);
                sqlCommand.Parameters.AddWithValue("@Description", departments.Description);
                sqlCommand.Parameters.AddWithValue("@IdStatus", departments.IdStatus);

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

        #region Method Delete Departments
        public string Delete(Departments departments)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "DELETE FROM Departments WHERE IdDepartment=@IdDepartment";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdDepartment", departments.IdDepartment);

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

        #region Method ShowDepartments
        public DataTable ShowDepartments()
        {
            DataTable? dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 100
									d.IdDepartment,
                                    d.Name,
                                    d.Description,
                                    s.Name as Status,
                                    d.RegistrationDate
                                    FROM Departments d INNER JOIN Status s ON d.IdStatus=s.IdStatus ORDER BY IdDepartment DESC";
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

        #region Method SearchName Departments
        public DataTable SearchName(Departments departments)
        {
            DataTable dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 100
									d.IdDepartment,
                                    d.Name,
                                    d.Description,
                                    s.Name as Status,
                                    d.RegistrationDate
                                    FROM Departments d INNER JOIN Status s ON d.IdStatus=s.IdStatus WHERE d.Name LIKE @TextSearch + '%'";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TextSearch", departments.TextSearch);

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
