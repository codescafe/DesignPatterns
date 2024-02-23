using ProtoType.Common;

var p1 = new ConcreteProtoType("I");
var p2 = p1.Clone();
Console.WriteLine("Cloud: {0}", p1.Id);

var a = new Resume("Rio");
a.SetPersonalInfo("Male", "26");
a.SetWorkExperience("Microsoft", "2010-2014");

var b = (Resume)a.Clone();
b.SetWorkExperience("Google", "2014-2018");

var c = (Resume)a.Clone();
c.SetPersonalInfo("Female", "22");

a.Display();
b.Display();
c.Display();