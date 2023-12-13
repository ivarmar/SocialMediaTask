using System;
using System.Collections.Generic;

namespace SocialMediaTask
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var manager = new UserManagement();
            var menu = new Menu();
            var chat = new FaceChat(new List<Message>()
            {
                new Message(1, "finally open whoo!"),
                new Message(2, "yep, great...."),
            });

            menu.LogInMenu(manager);
            menu.MainMenu(manager, chat);
        }
    }
}
