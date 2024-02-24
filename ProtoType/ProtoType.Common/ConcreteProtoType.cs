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
