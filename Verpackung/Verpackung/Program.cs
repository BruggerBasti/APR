using Verpackung;

Person empfänger = new Person("Max", "Empfänger");

Paket w = new Paket(70, 50, 5, empfänger);
IPaket g = new Geburtstagspaket(50, 25, 30, 2, empfänger);

Person kim = new Person("Kim", "Huber");
g.Verpacken();
kim.Versenden(g);