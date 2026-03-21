using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Employee : Person
    {
        public string Position { get; set; } = string.Empty;
        public decimal Salary { get; set; }

        public override string getDisplayInfo()
        {
            return $"{base.getDisplayInfo()} | {Position} {Salary}";
        }
    }
}
