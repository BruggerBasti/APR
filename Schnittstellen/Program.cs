using Schnittstellen;

Employee e = new Employee();
e.Firstname = "Hugo";
e.Surname = "Huber";

e.AddDataToOnBoardComputer("data to add to computer");

IPilot p = (IPilot)e;