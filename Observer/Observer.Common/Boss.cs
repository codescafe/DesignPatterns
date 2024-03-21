namespace Observer.Common
{
    public class Boss : INotifier
    {
        public event INotifier.EventHandler Update;

        private string action;

        public void Notify()
        {
            Update();
        }

        public string SubjectState { get; set; }
    }
}
