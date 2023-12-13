using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaTask
{
    internal class FaceChat
    {

        public List <Message> Messages { get; set; }

        public FaceChat(List<Message> messages)
        {
            Messages = messages;
        }


        public void GetUserName(User UserName)
        {
            Console.WriteLine($"{UserName}");
        }

        public void ShowChat()
        {
            Console.Clear();
            foreach (var m in Messages)
            {
                m.ShowMessage();
            }

            Console.ReadLine();
        }
    }
}
