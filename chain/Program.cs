using chain;

BaseHendler Bill200 = new Hendel200();
BaseHendler Bill100 = new Hendel100();
BaseHendler Bill50 = new Hendel50();
BaseHendler Bill20 = new Hendel20();

Bill200.SetNext(Bill100);
Bill100.SetNext(Bill50);
Bill50.SetNext(Bill20);

Bill200.HandelRequest(770);

Console.WriteLine("-------------------------- Request : 100 ---------------");

Bill200.HandelRequest(100);


