using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDev_Week1.Classes
{
    internal class Employee: BaseEmployee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Emails { get; set; }
        public int Salary { get; set; }

        public Employee(int iD, string firstName, string lastName, List<string> emails, int salary)
        {
            this.ID = iD;
            this.FirstName = firstName;
            this.LastName = lastName;
            Emails = emails;
            Salary = salary;
        }

        public string GetFullName()
        {
            return this.FirstName + " " + LastName;
        }

        public override int GetMonthlySalary()
        {
            throw new NotImplementedException();
        }
    }
}
