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
