public class User
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Username: {Username}");
    }

    public bool Login(string username, string password)
    {
        return (username == Username && password == Password);
    }
}