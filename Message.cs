using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaTask
{
    internal class Message
    {
        public int Sender { get; set; }

        public string MessageContent { get; set; }

        public Message(int senderId, string messageContent)
        {
            Sender = senderId;
            MessageContent = messageContent;
        }

        public void ShowMessage()
        {
            Console.WriteLine($"{Sender}:  {MessageContent} ");
        }
    }
}
