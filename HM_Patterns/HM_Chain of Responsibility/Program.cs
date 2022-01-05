using HM_Chain_of_Responsibility;

Car firstCH = new FirstCheckup();
Car SecondCH = new Car_Assemblies();
Car ThirdCH = new Electric_Checkup();
Car LastCH = new Diagnostic_Checkup();


firstCH.SetNext(SecondCH);
SecondCH.SetNext(ThirdCH);
ThirdCH.SetNext(LastCH);
LastCH.SetNext(null);

firstCH.Handle();