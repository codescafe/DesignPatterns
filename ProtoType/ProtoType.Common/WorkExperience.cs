using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Common
{
    public class WorkExperience : ICloneable
    {
        public string Company { get; set; }
        public string WorkDate { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
