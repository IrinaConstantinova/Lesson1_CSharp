Console.Write("Enter user name, please ");
string username = Console.ReadLine();

if (username.ToLower() == "masha")
{
    Console.WriteLine("Welcome, Masha!");
}
else 
{
    Console.Write("Hallo, ");
    Console.WriteLine(username);
}