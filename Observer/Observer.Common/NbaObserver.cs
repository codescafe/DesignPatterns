namespace Observer.Common
{
    public class NbaObserver : Observer
    {
        public NbaObserver(string name, INotifier sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState}, {name}, close the NBA and continue working");
        }
    }
}
