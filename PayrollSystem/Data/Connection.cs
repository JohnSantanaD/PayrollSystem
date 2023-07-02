using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayrollSystem.Data
{
    internal class Connection
    {
        //public static readonly string connection = ConfigurationManager.ConnectionStrings["PayrollSystemDB"].ConnectionString;
        //public static readonly string connection = "Data Source=DESKTOP-HP;Initial Catalog=PayrollSystem;Integrated Security=True";
        public static readonly string connection = Properties.Settings.Default.ConnectionString;
    }
}
