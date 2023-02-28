using System;
namespace NetzwerkOsi
{
    public class IPv6 : IInternetProtocol
    {
        public string ReceiveMessage()
        {
            return string.Empty;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine($"Send message (IPv6):");

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message.Substring(i, 1));
            }
        }
    }
}

