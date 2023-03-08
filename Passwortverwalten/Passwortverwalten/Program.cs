using Passwortverwalten;
using System.Xml.Linq;

// roo-Element vom Dateisystem laden
XElement rootElement = XElement.Load("logins.xml");

//Element Auslesen
var logins = from login in rootElement.Descendants("login")
             select new Login()
             {
                 Title = (string)login.Attribute("title"),
                 Username = (string)login.Attribute("username"),
                 Password = (string)login.Attribute("password")
             };

/*
// falls abfrage
foreach (var item in logins)
{
    Console.WriteLine((string)item.Attribute("title"));
}
*/

// falls eine Liste gewünscht wird

List<Login> loginListe = logins.ToList<Login>();

foreach (var item in logins)
{
    Console.WriteLine(item.Title);
}

//Element Hinzufügen
var loginItem = new XElement("login");

var usernameAtrebut = new XAttribute("username", "ahuber");
// usernameAtrebut wird beim loginItem als Attrebut hinzugefügt
loginItem.Add(usernameAtrebut);

loginItem.Add(new XAttribute("password", "geheim"));
loginItem.Add(new XAttribute("title", "Schule"));
loginItem.Add(new XAttribute("id", Guid.NewGuid().ToString()));

// loginItem beim roo-Elemnt hinzufügen
rootElement.Add(loginItem);

var item2 = from login in rootElement.Descendants("login")
            where (string)login.Attribute("id") == "7a4d8f4f-702d-4b05-b506-64d172e041e3"
			select login;

item2.Remove();

// root-Elemnt speichern
rootElement.Save("login.xml");