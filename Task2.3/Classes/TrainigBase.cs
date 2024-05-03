using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._3.Classes
{
    public abstract class TrainigBase : ICloneable
    {
        public string? Description { get; set; }

        public abstract object Clone();
    }
}
