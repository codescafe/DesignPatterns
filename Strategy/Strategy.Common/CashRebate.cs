namespace Strategy.Common
{
    public class CashRebate : CashSuper
    {
        private double moneyRebate = 1d;
        public CashRebate(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        public override double AcceptCash(double money)
        {
            return money * moneyRebate;
        }
    }
}