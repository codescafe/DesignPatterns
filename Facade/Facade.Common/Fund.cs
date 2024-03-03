namespace Facade.Common
{
    public class Fund
    {
        Stock1 stock1;
        Stock2 stock2;

        public Fund()
        {
            stock1 = new Stock1();
            stock2 = new Stock2();
        }

        public void Buy()
        {
            stock1.Buy();
            stock2.Buy();
        }

        public void Sell()
        {
            stock1.Sell();
            stock2.Sell();
        }
    }
}
