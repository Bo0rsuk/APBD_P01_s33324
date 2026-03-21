using System;
using System.Collections.Generic;
using System.Text;

namespace DataModels
{
    public class Camera : Equipment
    {
        public string ModelName { get; set; } = string.Empty;
        public int MegaPixels { get; set; }
        public int MemorySize { get; set; }

        public Camera() { }

        public Camera(int id, decimal weight, string modelName, int megaPixels, int memorySize)
            : base(id, weight)
        {
            this.ModelName = modelName;
            this.MegaPixels = megaPixels;
            this.MemorySize = memorySize;
        }

        public override string getDisplayInfo()
        {
            return $"{base.getDisplayInfo()} | {ModelName} {MegaPixels} {MemorySize}";
        }
    }
}
