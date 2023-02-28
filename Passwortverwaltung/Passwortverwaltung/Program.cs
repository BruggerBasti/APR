using Passwortverwaltung;
using System.Xml.Linq;

// Root-Element vom Dateisystem laden
XElement rootElement = XElement.Load("logins.xml");

// Elemente auslesen
var logins = from login in rootElement.Descendants("login")
			 select new Login()
			 {
				 Title = (string)login.Attribute("title"),
				 Username = (string)login.Attribute("username"),
				 Password = (string)login.Attribute("password")
			 };

/* falls Abfrage:
 * from login in rootElement.Descendants("login")
   select login

foreach (var item in logins) {
	Console.WriteLine((string)item.Attribute("title"));
}
*/

List<Login> loginList = logins.ToList<Login>();

foreach (var item in logins) {
	Console.WriteLine(item);
}

// Element hinzufügen
var loginItem = new XElement("login");

var usernameAttribute = new XAttribute("username", "mhuber");

// usernameAttribute wird beim loginItem als Attribut hinzugefügt
loginItem.Add(usernameAttribute);

loginItem.Add(new XAttribute("password", "geheim"));
loginItem.Add(new XAttribute("title", "Schule"));

// loginItem beim Root-Element hinzufügen
rootElement.Add(loginItem);

// Root-Element speichern
rootElement.Save("logins.xml");

Random r = new Random();
int i = r.Next(0, 99);
string rndmPassword = String.Format("abc{0}", i);

Console.WriteLine(rndmPassword);