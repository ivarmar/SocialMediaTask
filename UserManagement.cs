using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMediaTask
{
    internal class UserManagement
    {
        public List<User> AllUsers { get; set; }
        public User LoggedInUser { get; set; }

        public UserManagement()
        {
            AllUsers = InitUsers();
        }

        public void LogIn()
        {
            User user = null;
            string userName;
            string password;
            do
            {
                Console.WriteLine("Username:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter password:");
                password = Console.ReadLine() ?? String.Empty;
                user = AllUsers.FirstOrDefault(u => u.UserName == userName && u.Password == password);
            } while (user == null);

            Console.WriteLine("You have logged in.");
            LoggedInUser = user;
        }

        private List<User> InitUsers()
        {
            var userList = new List<User>()
            {
                new User("Taria", "gerwwt23", "Omahn", "Sirius", 25, "joius@hotmail.com", "gambling",1),
                new User("Johann", "gert23", "John", "Sirius", 19, "johnserius@hotmail.com", "Fishing", 2),
            };

            return userList;
        }

        public void ShowAllUsers()
        {
            foreach (var u in AllUsers)
            {
                u.ShowInfo();
            }
        }

        public void RegisterUser()
        {
            Console.WriteLine("Welcome! Please Register to use our features and get to know people from across the globe!");
            Console.WriteLine("Enter a new username:");
            string newUserName = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Create a password:");
            string newPassword = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("What is your First name?");
            string newFirstName = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("What is your Last Name?");
            string newLastName = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("What is your age?");
            int newAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your Email?");
            string newEmail = Console.ReadLine() ?? String.Empty;
            Console.WriteLine("Tell us what your hobby is.");
            string newHobby = Console.ReadLine() ?? String.Empty;

            var newUser = new User(newUserName, newPassword, newFirstName, newLastName, newAge, newEmail, newHobby, 5);
            AllUsers.Add(newUser);
            LoggedInUser = newUser;

            Console.WriteLine("Registration successful.");
        }
        /*
        Console.WriteLine($"**{userIDToAdd.FirstName} aka {userIDToAdd.UserName} has been added to your friend list.**");
        Console.WriteLine("Enter the username of the friend you want to add:");
        var friendToAdd = Console.ReadLine() ?? String.Empty;
        FriendFunction.AddFriend(User.UserList, friendToAdd);
        */
    }
}
