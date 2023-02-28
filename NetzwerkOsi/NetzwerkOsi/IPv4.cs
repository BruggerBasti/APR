using System;
namespace NetzwerkOsi
{
    public class IPv4 : IInternetProtocol
    {
        public string ReceiveMessage()
        {
            return string.Empty;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Send message (IPv4): {message}");
        }
    }
}