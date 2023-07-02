
namespace PayrollSystem.Models
{
    public class Employees
    {
        public int IdEmployee { get; set; }
        public string? Name { get; set; }
        public string? LastName { get; set; }
        public string? Sex { get; set; }
        public DateTime DateBirth { get; set; }
        public string? NumberDocument { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public byte[]? Image { get; set; }
        public DateTime DateAdmission { get; set;} 
        public Decimal Salary { get; set; }
        public int IdDepartment { get; set; }
        public int IdStatus { get; set; }
        public int IdRole { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? TextSearch { get; set; }
    }
}
