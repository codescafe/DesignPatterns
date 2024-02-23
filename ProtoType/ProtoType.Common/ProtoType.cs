namespace ProtoType.Common
{
    /// <summary>
    /// Please use ICloneable instead of this class
    /// </summary>
    public abstract class ProtoType
    {
        private string id;
        public ProtoType(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract ProtoType Clone();
    }
}
