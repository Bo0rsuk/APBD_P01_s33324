using DataModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Student : Person
    {
        public decimal AverageMark { get; set; }
        public string Major { get; set; } = string.Empty;

        public Student() { }

        public Student(int id, string firstName, string lastName, decimal averageMark, string major)
            : base(id, firstName, lastName)
        {
            this.AverageMark = averageMark;
            this.Major = major;
        }

        public override string getDisplayInfo()
        {
            return $"{base.getDisplayInfo()} | {AverageMark} {Major}";
        }
    }
}
