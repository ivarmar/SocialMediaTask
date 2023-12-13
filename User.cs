using System;
using System.Reflection.Metadata.Ecma335;
using SocialMediaTask;

internal class User
{
    public List<int> FriendList { get; set; } = new List<int>();

    public string UserName { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string UserHobby { get; set; }

    public int UserID { get; set; }
    public object FaceChat { get; internal set; }

    public User(string userName, string password, string firstName, string lastName, int age, string email, string userHobby, int userID)
    {
        UserName = userName;
        Password = password;
        Email = email;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        UserHobby = userHobby;
        UserID = userID;
    }

    public void AddFriend(List<User> allUsers)
    {
        Console.WriteLine("Type the username of your friend:");
        var friendUserName = Console.ReadLine();

        var friendUser = allUsers.Find(user => user.UserName == friendUserName);

        if (friendUser != null)
        {
            FriendList.Add(friendUser.UserID);
            Console.WriteLine($"{friendUserName} added to your friend list.");
        }
        else
        {
            Console.WriteLine($"User with username {friendUserName} not found in the allUsers list.");
        }
    }

    public void RemoveFriend(List<User> allUsers)
    {
        Console.WriteLine("type username to remove from friendlist:");
        var friendUserName = Console.ReadLine();

        var friendUser = allUsers.Find(user => user.UserName == friendUserName);

        if (friendUser != null)
        {
            FriendList.Remove(friendUser.UserID);
            Console.WriteLine($"{friendUserName} added to your friend list.");
        }
        else
        {
            Console.WriteLine($"User with username {friendUserName} not found in the allUsers list.");
        }
    }


    public void ShowInfo()
    {
        Console.WriteLine("****************");
        Console.WriteLine($"Username: {UserName}, ID: {UserID}");
        Console.WriteLine($"Name: {FirstName + LastName}");
        Console.WriteLine($"Age: {Age}");
        Console.WriteLine($"Hobby: {UserHobby}");
        Console.WriteLine("****************");
    }

    public void ShowFriendList(List<User> allUsers)
    {
        Console.WriteLine($"Friend List of {UserName}:");

        List<User> friends = allUsers
                .Where(u => FriendList.Contains(u.UserID))
                .ToList();

        foreach (var f in friends)
        {
            f.ShowInfo();
        }
    }
}

