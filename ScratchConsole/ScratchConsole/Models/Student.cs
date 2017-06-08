using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchConsole.Models
{

    public static class Extension
    {
        public static string ToYesNo(this bool b)
        {
            return b ? "Yes" : "No";
        }
    }

    public class Student : Person
    {

        public int StudentID { get; set; }
        public bool IsEnrolled { get; set; }
        public float CummulativeGPA { get; set; }

        public Student(string name) : base(name)
        {

        }

        public override string ToString()
        {
            return $"ID: {StudentID} - {base.ToString()}\nEnrolled: {IsEnrolled.ToYesNo(), 3}\tGPA: {CummulativeGPA:n2}";
        }

    }
}
