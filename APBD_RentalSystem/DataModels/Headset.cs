using DataModels.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Headset : Equipment
    {
        public bool IsWireless { get; set; }
        public bool HasMicrophone { get; set; }

        public Headset() { }

        public Headset(int id, string modelName, decimal weight, bool isWireless, bool hasMicrophone)
            : base(id, modelName, weight)
        {
            IsWireless = isWireless;
            HasMicrophone = hasMicrophone;
        }

        public override string getDisplayInfo()
        {
            return $"{base.getDisplayInfo()} | {IsWireless} {HasMicrophone}";
        }
    }
}
