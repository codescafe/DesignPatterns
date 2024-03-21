namespace Observer.Common
{
    public class NbaObserver
    {
        private string name;
        private INotifier sub;
        public NbaObserver(string name, INotifier sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseNbaDirectSeeding()
        {
            Console.WriteLine($"{sub.SubjectState}, {name}, close the NBA direct seeding and continue working");
        }
    }
}
