using Observer.Common;

INotifier boss = new Boss();

var nbaObserver = new NbaObserver("Tom", boss);
var stockObserver = new StockObserver("Jerry", boss);

boss.Attach(nbaObserver);
boss.Attach(stockObserver);

boss.SubjectState = "I am back";
boss.Notify();

INotifier secretary = new Secretary();

var nbaObserver2 = new NbaObserver("Tom", secretary);
var stockObserver2 = new StockObserver("Jerry", secretary);

secretary.Attach(nbaObserver2);
secretary.Attach(stockObserver2);

secretary.SubjectState = "Boss is back";
secretary.Notify();
