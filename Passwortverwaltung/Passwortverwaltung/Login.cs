using System;
namespace Passwortverwaltung
{
	public class Login
	{
		public string Username { get; set; } = string.Empty;

		public string Password { get; set; } = string.Empty;

		public string Title { get; set; } = string.Empty;

		public override string ToString()
		{
			return String.Format("{0}: {1}", this.Title, this.Username);
		}
	}
}

