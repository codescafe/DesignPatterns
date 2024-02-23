using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtoType.Common
{
    public class ConcreteProtoType : ProtoType
    {
        public ConcreteProtoType(string id) : base(id)
        {
        }

        public override ProtoType Clone()
        {
            return (ProtoType)this.MemberwiseClone();
        }
    }
}
