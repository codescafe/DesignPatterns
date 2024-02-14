namespace Strategy.Common
{
    public class CashContext
    {
        private CashSuper cashSuper;

        public CashContext(string type)
        {
            cashSuper = type switch
            {
                "正常收费" => new CashNormal(),
                "满300返100" => new CashReturn(300, 100),
                "打8折" => new CashRebate(0.8)
            };
        }

        public double GetResult(double money)
        {
            return cashSuper.AcceptCash(money);
        }
    }
}
