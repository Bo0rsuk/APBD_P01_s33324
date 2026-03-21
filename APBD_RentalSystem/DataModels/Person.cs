using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;


        public virtual string getDisplayInfo() 
        {
            return $"{Id}: {FirstName} {LastName}";
        }
    }
}
