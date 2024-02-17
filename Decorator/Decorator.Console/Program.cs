using Decorator.Common;

Person person = new Person("小菜");

Console.WriteLine("第一种装扮：");

BigTrouser bigTrouser = new BigTrouser();
TShirts tShirts = new TShirts();

bigTrouser.Decorate(person);
tShirts.Decorate(bigTrouser);
tShirts.Show();