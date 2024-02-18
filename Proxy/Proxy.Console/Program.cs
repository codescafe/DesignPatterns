using Proxy.Common;

SchoolGirl jiaojiao = new SchoolGirl();
jiaojiao.Name = "李娇娇";

Proxy.Common.Proxy daili = new Proxy.Common.Proxy(jiaojiao);

daili.GiveDolls();
daili.GiveFlowers();
daili.GiveChocolate();