using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Abstracts
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        protected Person() { }

        protected Person(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual string getDisplayInfo() 
        {
            return $"{Id}: {FirstName} {LastName}";
        }
    }
}
