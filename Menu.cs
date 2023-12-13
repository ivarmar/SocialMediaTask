using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace SocialMediaTask
{
    internal class Menu
    {
        
        public bool LogInMenu(UserManagement manager)
        {
            //manager.LoggedInUser = new User("ivar", "123", "Omahn", "Sirius", 25, "joius@hotmail.com", "gambling", 9);

            while (true)
            {


                Console.Clear();
                Console.WriteLine("1. Log In\n2. Register");
                var input = Console.ReadLine() ?? String.Empty;

                if (input is "1" or "2" or "3")
                    switch (input)
                    {
                        case "1":
                            manager.LogIn();
                            return true;
                        case "2":
                            manager.RegisterUser();
                            return true;
                        case "3":
                            return false;
                    }
            }
        }

        public void MainMenu(UserManagement manager, FaceChat chat)
        {
            Console.Clear();
            string mainMenu;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("***FriendFace***");
                Console.WriteLine("*Main Menu options:*");
                Console.WriteLine("1.See a List of all other Users");
                Console.WriteLine("2.Friend Options");
                Console.WriteLine("3.Show General Chat");
                mainMenu = Console.ReadLine() ?? String.Empty;
                switch (mainMenu)
                {

                    case "1":
                        manager.ShowAllUsers();
                        Console.WriteLine("Press Any key to advance");
                        Console.ReadLine();
                        break;
                    case "2":
                        FriendMenu(manager);
                        break;
                    case "3":
                        chat.ShowChat();
                        break;
                }

            }
        }

        public void FriendMenu(UserManagement manager)
        {
            Console.WriteLine("1. See Friend List");
            Console.WriteLine("2.Add a Friend");
            Console.WriteLine("3.Remove Friend");
            var friendMenu = Console.ReadLine() ?? String.Empty;
            switch (friendMenu)
            {
                case "1":
                    manager.LoggedInUser.ShowFriendList(manager.AllUsers);
                    Console.WriteLine("Press Any key to advance");
                    Console.ReadLine();
                    break;
                case "2":
                    manager.LoggedInUser.AddFriend(manager.AllUsers);
                    break;
                case "3":
                    manager.LoggedInUser.RemoveFriend(manager.AllUsers);
                    break;
            }
        }
    }
}

