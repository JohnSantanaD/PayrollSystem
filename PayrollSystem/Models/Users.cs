using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class Users
    {

        public int IdUser { get; set; }
        public string? User { get; set; }
        public string? Password { get; set; }
        public int IdEmployee { get; set; }
        public int IdStatus { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? TextSearch { get; set; }
    }
}
