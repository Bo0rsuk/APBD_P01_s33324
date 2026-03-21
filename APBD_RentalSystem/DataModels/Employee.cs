using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Employee : Person
    {
        public string Position { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        public Employee() { }

        public Employee(int id, string firstName, string lastName, string position, decimal salary)
            : base(id, firstName, lastName)
        {
            this.Position = position;
            this.Salary = salary;
        }

        public override string getDisplayInfo()
        {
            return $"{base.getDisplayInfo()} | {Position} {Salary}";
        }
    }
}
