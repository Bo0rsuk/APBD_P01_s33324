using DataModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Laptop : Equipment
    {
        
        public int RAM { get; set; }
        public int DiskSize { get; set; }

        public Laptop() { }

        public Laptop(int id, decimal weight, string modelName, int RAM, int diskSize)
            : base(id, modelName, weight)
        {
            this.RAM = RAM;
            this.DiskSize = diskSize;
        }

        public override string ToString()
        {
            return $"{base.ToString()} | {ModelName} {RAM} {DiskSize}";
        }
    }
}
