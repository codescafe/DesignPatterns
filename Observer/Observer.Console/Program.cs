using Observer.Common;

Boss boss = new Boss();

StockObserver stockObserver1 = new StockObserver("Adam", boss);
NbaObserver nbaObserver1 = new NbaObserver("Ellen", boss);

boss.Update += stockObserver1.CloseStockMarket;
boss.Update += nbaObserver1.CloseNbaDirectSeeding;

boss.SubjectState = "Boss is back";

boss.Notify();