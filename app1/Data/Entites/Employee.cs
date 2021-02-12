using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace app1.Data.Entites
{
    public class Employee
    {
        public long EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public DateTime? JoiningDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Designation { get; set; }
        public decimal? Salary { get; set; }
    }
}
