using System.Data;
using System.Data.SqlClient;
using PayrollSystem.Data;
using PayrollSystem.Models;

namespace PayrollSystem.Data
{
    public class DEmployees
    {
        #region Constructors Class DEmployee
        #endregion

        #region Method Insert Employee
        public string Insert(Employees employee)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"INSERT INTO Employees (Name,LastName,Sex,DateBirth,NumberDocument,Address,Phone,Email,Image,DateAdmission,Salary,IdDepartment,IdStatus,IdRole)
                     VALUES (@Name,@LastName,@Sex,@DateBirth,@NumberDocument,@Address,@Phone,@Email,@Image,@DateAdmission,@Salary,@IdDepartment,@IdStatus,@IdRole)";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
                sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                sqlCommand.Parameters.AddWithValue("@Sex", employee.Sex);
                sqlCommand.Parameters.AddWithValue("@DateBirth", employee.DateBirth);
                sqlCommand.Parameters.AddWithValue("@NumberDocument", employee.NumberDocument);
                sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
                sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                sqlCommand.Parameters.AddWithValue("@Image", employee.Image);
                sqlCommand.Parameters.AddWithValue("@DateAdmission", employee.DateAdmission);
                sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
                sqlCommand.Parameters.AddWithValue("@IdDepartment", employee.IdDepartment);
                sqlCommand.Parameters.AddWithValue("@IdStatus", employee.IdStatus);
                sqlCommand.Parameters.AddWithValue("@Idrole", employee.IdRole);

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

        #region Method Edit Employee
        public string Edit(Employees employee)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"UPDATE Employees SET Name=@Name, LastName=@LastName, Sex=@Sex, DateBirth=@DateBirth,
                    NumberDocument=@NumberDocument, Address=@Address, Phone=@Phone, Email=@Email, Image=@Image, 
                    DateAdmission=@DateAdmission, Salary=@Salary, IdDepartment=@IdDepartment, 
                    IdStatus=@IdStatus, IdRole=@IdRole  WHERE IdEmployee=@IdEmployee";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdEmployee", employee.IdEmployee);
                sqlCommand.Parameters.AddWithValue("@Name", employee.Name);
                sqlCommand.Parameters.AddWithValue("@LastName", employee.LastName);
                sqlCommand.Parameters.AddWithValue("@Sex", employee.Sex);
                sqlCommand.Parameters.AddWithValue("@DateBirth", employee.DateBirth);
                sqlCommand.Parameters.AddWithValue("@NumberDocument", employee.NumberDocument);
                sqlCommand.Parameters.AddWithValue("@Address", employee.Address);
                sqlCommand.Parameters.AddWithValue("@Phone", employee.Phone);
                sqlCommand.Parameters.AddWithValue("@Email", employee.Email);
                sqlCommand.Parameters.AddWithValue("@Image", employee.Image);
                sqlCommand.Parameters.AddWithValue("@DateAdmission", employee.DateAdmission);
                sqlCommand.Parameters.AddWithValue("@Salary", employee.Salary);
                sqlCommand.Parameters.AddWithValue("@IdDepartment", employee.IdDepartment);
                sqlCommand.Parameters.AddWithValue("@IdStatus", employee.IdStatus);
                sqlCommand.Parameters.AddWithValue("@Idrole", employee.IdRole);

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

        #region Method Delete Employee
        public string Delete(Employees employee)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = "DELETE FROM Employees WHERE IdEmployee=@IdEmployee";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdEmployee", employee.IdEmployee);

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

        #region Method ShowEmployees
        public DataTable ShowEmployees()
        {
            DataTable? dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 100
	                            e.IdEmployee,
	                            e.Name,
	                            e.LastName,
	                            e.Sex,
	                            e.DateBirth,
	                            e.NumberDocument,
	                            e.Address,
	                            e.Phone,
	                            e.Email,
	                            e.DateAdmission,
	                            e.Salary,
	                            r.name as Role,
	                            d.Name as Department, 
	                            s.Name as Status,
                                e.RegistrationDate,
	                            e.Image
	                            
	                            FROM Employees e INNER JOIN Roles r on e.IdRole=r.IdRole
	                            INNER JOIN Departments d on e.IdDepartment = d.IdDepartment
	                            INNER JOIN Status s  on e.IdStatus = s.IdStatus
	                            ORDER BY IdEmployee DESC";

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

        #region Method SearchName Employee
        public DataTable SearchName(Employees employee)
        {
            DataTable? dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT
	                            e.IdEmployee,
	                            e.Name,
	                            e.LastName,
	                            e.Sex,
	                            e.DateBirth,
	                            e.NumberDocument,
	                            e.Address,
	                            e.Phone,
	                            e.Email,
	                            e.DateAdmission,
	                            e.Salary,
	                            r.name as Role,
	                            d.Name as Department, 
	                            s.Name as Status,
                                e.RegistrationDate,
	                            e.Image
	                            
	                            FROM Employees e INNER JOIN Roles r on e.IdRole=r.IdRole
	                            INNER JOIN Departments d on e.IdDepartment = d.IdDepartment
	                            INNER JOIN Status s  on e.IdStatus = s.IdStatus  WHERE e.Name + e.LastName LIKE '%' + @TextSearch + '%'";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TextSearch", employee.TextSearch);

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

        #region Method SearchNumberDocument Employee
        public DataTable SearchNumberDocument(Employees employee)
        {
            DataTable? dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT
	                            e.IdEmployee,
	                            e.Name,
	                            e.LastName,
	                            e.Sex,
	                            e.DateBirth,
	                            e.NumberDocument,
	                            e.Address,
	                            e.Phone,
	                            e.Email,
	                            e.DateAdmission,
	                            e.Salary,
	                            r.name as Role,
	                            d.Name as Department, 
	                            s.Name as Status,
                                e.RegistrationDate,
	                            e.Image
	                            
	                            FROM Employees e INNER JOIN Roles r on e.IdRole=r.IdRole
	                            INNER JOIN Departments d on e.IdDepartment = d.IdDepartment
	                            INNER JOIN Status s  on e.IdStatus = s.IdStatus WHERE e.NumberDocument LIKE @TextSearch + '%'";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@TextSearch", employee.TextSearch);

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