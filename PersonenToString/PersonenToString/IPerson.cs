using System;
using System.Security.Cryptography.X509Certificates;

namespace PersonenToString
{
	public interface IPerson
	{
		string Vorname { get; }

		string Nachname { get; }
	}
}

