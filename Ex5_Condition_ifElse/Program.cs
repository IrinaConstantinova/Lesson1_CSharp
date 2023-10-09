// Задание 5. Лекция 1 по CSharp
// Написать программу которая запрашивает имя 
// пользователя и, если оно masha, то приветстут фаворита - машу
// если это имя дрккгое, то ввыведится приветствие рядового пользователя

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