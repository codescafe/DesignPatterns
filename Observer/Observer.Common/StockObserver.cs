namespace Observer.Common
{
    public class StockObserver
    {
        private string name;
        private INotifier sub;
        public StockObserver(string name, INotifier sub)
        {
            this.name = name;
            this.sub = sub;
        }

        public void CloseStockMarket()
        {
            Console.WriteLine($"{sub.SubjectState}, {name}, close the stock market and continue working");
        }
    }
}