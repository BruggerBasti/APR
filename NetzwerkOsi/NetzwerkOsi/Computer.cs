using System;
namespace NetzwerkOsi
{
	public class Computer
	{
		public void Send(string msg)
		{
			IInternetProtocol ip = new IPv6();
			ip.SendMessage(msg);
		}
	}
}

