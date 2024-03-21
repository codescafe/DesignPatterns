namespace Observer.Common
{
    public interface INotifier
    {
        public delegate void EventHandler();
        void Notify();
        string SubjectState { get; set; }
    }
}
