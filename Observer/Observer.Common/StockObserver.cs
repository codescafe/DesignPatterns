namespace Observer.Common
{
    public class StockObserver : Observer
    {
        public StockObserver(string name, INotifier sub) : base(name, sub)
        {
        }

        public override void Update()
        {
            Console.WriteLine($"{sub.SubjectState}, {name}, close the stock market quotes and continue working");
        }
    }
}