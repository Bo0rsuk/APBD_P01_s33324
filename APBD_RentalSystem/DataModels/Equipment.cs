using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public abstract class Equipment
    {
        public int Id { get; set; }
        public decimal Weight { get; set; }

        public bool IsAvailable { get; set; } = true;

        protected Equipment() { }
        protected Equipment(int id, decimal weight)
        {
            this.Id = id;
            this.Weight = weight;
        }

        public virtual string getDisplayInfo()
        {
            return $"{Id}: {Weight} {IsAvailable}";
        }
    }
}
