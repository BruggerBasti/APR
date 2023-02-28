using System;
namespace NetzwerkOsi
{
	public interface IInternetProtocol
	{
        void SendMessage(string message);

        string ReceiveMessage();
    }
}

