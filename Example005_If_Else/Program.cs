Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "avia")
{
    Console.WriteLine("Ура, это же Avia!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}