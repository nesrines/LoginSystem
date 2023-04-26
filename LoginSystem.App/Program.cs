Console.WriteLine("/close app");
Console.WriteLine("/register");
Console.WriteLine("/login");
Console.Write("Enter a command: ");
string request = Console.ReadLine();

while (request != "/close app")
{
    switch (request)
    {
        case "/register":
            break;

        case "/login":
            break;

        default:
            Console.WriteLine("Enter a valid command:");
            break;
    }
    Console.WriteLine("/close app");
    Console.WriteLine("/register");
    Console.WriteLine("/login");
    Console.Write("Enter a command: ");
    request = Console.ReadLine();
}