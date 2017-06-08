using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string SSN { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsMarried { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name} \nSSN: {SSN}\tDOB: {BirthDate.ToShortDateString()}\tMarried: {IsMarried.ToYesNo()}";
        }
    }
}
