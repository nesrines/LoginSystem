using LoginSystem.App.Services.Implementations;
using LoginSystem.App.Services.Interfaces;
Console.WriteLine("/close app");
Console.WriteLine("/register");
Console.WriteLine("/login");
Console.Write("Enter a command: ");
string request = Console.ReadLine();
IUserService userService = new UserService();

while (request != "/close app")
{
    Console.WriteLine();
    switch (request)
    {
        case "/register":
            userService.Register();
            break;

        case "/login":
            userService.Login();
            break;

        default:
            Console.WriteLine("Enter a valid command: ");
            break;
    }
    Console.WriteLine();
    Console.WriteLine("/close app");
    Console.WriteLine("/register");
    Console.WriteLine("/login");
    Console.Write("Enter a command: ");
    request = Console.ReadLine();
}