using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Student : Person
    {
        public string IndexNumber { get; set; } = string.Empty;
        public string Major { get; set; } = string.Empty;

        public Student() { }

        public Student(int id, string firstName, string lastName, string indexNumber, string major)
            : base(id, firstName, lastName)
        {
            IndexNumber = indexNumber;
            Major = major;
        }

        public override string getDisplayInfo()
        {
            return $"{base.getDisplayInfo()} | {IndexNumber} {Major}";
        }
    }
}
