using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    internal class Helper
    {
        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            employees.Add(new Employee(123, "Joe", "Doe", new List<string> { "joe.doe@gmail.com" }, 21312));
            employees.Add(new Employee(111, "Alvin", "Park", new List<string> { "alv.par@gmail.com" }, 11312));
            employees.Add(new Employee(123, "King", "Tim", new List<string> { "kin.tim@gmail.com" }, 31312));
            return employees;
        }
    }
}
