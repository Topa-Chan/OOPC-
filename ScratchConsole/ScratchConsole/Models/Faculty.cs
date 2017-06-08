using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class Faculty : Person
    {

        public int EmployeeID { get; set; }
        public DateTime DateOfHire { get; set; }
        public bool IsEmployed { get; set; }
        public float AnnualSalary { get; set; }

        public Faculty(string name, bool isEmployed) : base(name)
        {
            IsEmployed = isEmployed;
        }

        public override string ToString()
        {
            return $"ID: {EmployeeID} - {base.ToString()}\nHire Date: {DateOfHire.ToShortDateString()}\tActive Employee: {IsEmployed.ToYesNo(), 3}\t Salary: {AnnualSalary:c2}";
        }

    }
}
