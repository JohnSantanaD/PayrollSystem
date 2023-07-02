using PayrollSystem.Models;
using System.Data.SqlClient;
using System.Data;

namespace PayrollSystem.Data
{
    public class DPayroll
    {

        #region Method Insert Payroll
        public string Insert(Payroll payroll)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"INSERT INTO Payroll (IdEmployee,ExtraHours,PriceOvertime,OvertimePayments,Bonuses,FamilyHealthInsurance,PensionFundAdministrator,IncomeTax,SalaryAdvance,NetSalary,IdStatus)
                     VALUES (@IdEmployee,@ExtraHours,@PriceOvertime,@OvertimePayments,@Bonuses,@FamilyHealthInsurance,@PensionFundAdministrator,@IncomeTax,@SalaryAdvance,@NetSalary,@IdStatus)";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdEmployee", payroll.IdEmployee);
                sqlCommand.Parameters.AddWithValue("@ExtraHours", payroll.ExtraHours);
                sqlCommand.Parameters.AddWithValue("@PriceOvertime", payroll.PriceOvertime);
                sqlCommand.Parameters.AddWithValue("@OvertimePayments ", payroll.OvertimePayments);
                sqlCommand.Parameters.AddWithValue("@Bonuses", payroll.Bonuses);
                sqlCommand.Parameters.AddWithValue("@FamilyHealthInsurance", payroll.FamilyHealthInsurance);
                sqlCommand.Parameters.AddWithValue("@PensionFundAdministrator", payroll.PensionFundAdministrator);
                sqlCommand.Parameters.AddWithValue("@IncomeTax", payroll.IncomeTax);
                sqlCommand.Parameters.AddWithValue("@SalaryAdvance", payroll.SalaryAdvance);
                sqlCommand.Parameters.AddWithValue("@NetSalary", payroll.NetSalary);
                sqlCommand.Parameters.AddWithValue("@IdStatus", 1);

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

        #region Method Edit Payroll
        public string Edit(Payroll payroll)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"UPDATE Payroll SET IdEmployee=@IdEmployee, ExtraHours=@ExtraHours, PriceOvertime=@PriceOvertime,
                    OvertimePayments=@OvertimePayments, Bonuses=@Bonuses, FamilyHealthInsurance=@FamilyHealthInsurance, 
                    PensionFundAdministrator=@PensionFundAdministrator, IncomeTax=@IncomeTax, 
                    SalaryAdvance=@SalaryAdvance, NetSalary=@NetSalary WHERE IdPayroll=@IdPayroll";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdPayroll", payroll.IdPayroll);
                sqlCommand.Parameters.AddWithValue("@IdEmployee", payroll.IdEmployee);
                sqlCommand.Parameters.AddWithValue("@ExtraHours", payroll.ExtraHours);
                sqlCommand.Parameters.AddWithValue("@PriceOvertime", payroll.PriceOvertime);
                sqlCommand.Parameters.AddWithValue("@OvertimePayments ", payroll.OvertimePayments);
                sqlCommand.Parameters.AddWithValue("@Bonuses", payroll.Bonuses);
                sqlCommand.Parameters.AddWithValue("@FamilyHealthInsurance", payroll.FamilyHealthInsurance);
                sqlCommand.Parameters.AddWithValue("@PensionFundAdministrator", payroll.PensionFundAdministrator);
                sqlCommand.Parameters.AddWithValue("@IncomeTax", payroll.IncomeTax);
                sqlCommand.Parameters.AddWithValue("@SalaryAdvance", payroll.SalaryAdvance);
                sqlCommand.Parameters.AddWithValue("@NetSalary", payroll.NetSalary);

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

        #region Method Delete Payroll
        public string Delete(Payroll Payroll)
        {
            string message = "";
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                //string query = "UPDATE Payroll IdStatus='2' WHERE IdPayroll=@IdPayroll";
                string query = "DELETE FROM Payroll WHERE IdPayroll=@IdPayroll";
                SqlCommand sqlCommand = new(query, sqlConnection);

                sqlCommand.Parameters.AddWithValue("@IdPayroll", Payroll.IdPayroll);

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

        #region Method ShowPayrolls
        public DataTable ShowPayrolls()
        {
            DataTable? dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @"SELECT TOP 40
	                            p.IdPayroll,
								e.IdEmployee,
								e.NumberDocument,
	                            e.Name,
	                            e.LastName,
	                            r.name as Role,
								e.Salary,
								p.ExtraHours,
								p.PriceOvertime,
								p.OvertimePayments,
								p.Bonuses,
								p.FamilyHealthInsurance as SFS,
								p.PensionFundAdministrator as AFP,
								p.IncomeTax as ISR,
								p.SalaryAdvance,
								p.NetSalary,
                                p.RegistrationDate
	                            
	                            FROM Payroll p INNER JOIN Employees e on p.IdEmployee=e.IdEmployee
	                            INNER JOIN Roles r on e.IdRole = r.IdRole
	                            ORDER BY IdPayroll DESC";

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

        #region Method SearchPayrollDate Payroll
        public DataTable SearchPayrollDate(string desde, string hasta)
        {
            DataTable? dataTable = new();
            SqlConnection sqlConnection = new();
            try
            {
                sqlConnection.ConnectionString = Connection.connection;
                sqlConnection.Open();

                string query = @$"SELECT 
	                            p.IdPayroll,
								e.IdEmployee,
								e.NumberDocument,
	                            e.Name,
	                            e.LastName,
	                            r.name as Role,
								e.Salary,
								p.ExtraHours,
								p.PriceOvertime,
								p.OvertimePayments,
								p.Bonuses,
								p.FamilyHealthInsurance as SFS,
								p.PensionFundAdministrator as AFP,
								p.IncomeTax as ISR,
								p.SalaryAdvance,
								p.NetSalary,
                                p.RegistrationDate
	                            
	                            FROM Payroll p INNER JOIN Employees e on p.IdEmployee=e.IdEmployee
	                            INNER JOIN Roles r on e.IdRole = r.IdRole
	                            WHERE p.RegistrationDate>={desde} AND p.RegistrationDate<={hasta}";
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

        //#region Method SearchNumberDocument Payroll
        //public DataTable SearchNumberDocument(Payroll Payroll)
        //{
        //    DataTable? dataTable = new();
        //    SqlConnection sqlConnection = new();
        //    try
        //    {
        //        sqlConnection.ConnectionString = Connection.connection;
        //        sqlConnection.Open();

        //        string query = @"SELECT
	       //                     e.IdPayroll,
	       //                     e.Name,
	       //                     e.LastName,
	       //                     e.Sex,
	       //                     e.DateBirth,
	       //                     e.NumberDocument,
	       //                     e.Address,
	       //                     e.Phone,
	       //                     e.Email,
	       //                     e.DateAdmission,
	       //                     e.Salary,
	       //                     r.name as Role,
	       //                     d.Name as Department, 
	       //                     s.Name as Status,
        //                        e.RegistrationDate,
	       //                     e.Image
	                            
	       //                     FROM Payrolls e INNER JOIN Roles r on e.IdRole=r.IdRole
	       //                     INNER JOIN Departments d on e.IdDepartment = d.IdDepartment
	       //                     INNER JOIN Status s  on e.IdStatus = s.IdStatus WHERE e.NumberDocument LIKE @TextSearch + '%'";
        //        SqlCommand sqlCommand = new(query, sqlConnection);

        //        sqlCommand.Parameters.AddWithValue("@TextSearch", 1);

        //        SqlDataAdapter adapter = new(sqlCommand);
        //        adapter.Fill(dataTable);
        //    }
        //    catch (Exception)
        //    {
        //        dataTable = null;
        //    }
        //    finally
        //    {
        //        if (sqlConnection.State == ConnectionState.Open) sqlConnection.Close();
        //    }

        //    return dataTable;
        //}

        //#endregion

    }
}
