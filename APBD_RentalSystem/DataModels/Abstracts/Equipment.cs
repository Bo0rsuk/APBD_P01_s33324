using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels.Abstracts
{
    public abstract class Equipment
    {
        public int Id { get; set; }

        public string ModelName { get; set; } = string.Empty;
        public decimal Weight { get; set; }

        public bool IsAvailable { get; set; } = true;

        protected Equipment() { }
        protected Equipment(int id, string modelName, decimal weight)
        {
            this.Id = id;
            this.ModelName = modelName;
            this.Weight = weight;
        }

        public virtual string getDisplayInfo()
        {
            return $"{Id}: {Weight} {IsAvailable}";
        }
    }
}
