using Godot;
using AccountModel;

public static class AccountCreator
{
    public static long Create(string username)
    {
        if (string.IsNullOrWhiteSpace(username)) return -1;

        username = username.Trim();

        long id = Database.CreateAccount(new Account
        {
            Username = username
        }
        );

        GD.Print($"{username} id {id}"); //когда будем тестить

        return id;
    }
}