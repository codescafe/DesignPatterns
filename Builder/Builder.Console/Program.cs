using Builder.Common;

Director director = new Director();
Builder.Common.Builder b1 = new ConcretBuilder1();
Builder.Common.Builder b2 = new ConcretBuilder2();

director.Construct(b1);
Product p1 = b1.GetResult();
p1.Show();

director.Construct(b2);
Product p2 = b2.GetResult();
p2.Show();