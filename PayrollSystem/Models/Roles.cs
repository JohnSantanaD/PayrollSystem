using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Models
{
    public class Roles
    {
        public int IdRole { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int IdStatus { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string? TextSearch { get; set; }
    }
}
