Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "гарри")//чтобы не было проблем с регистром, ToLower
{
  Console.WriteLine("Ура, это же ГАРРИ!!!");
}
else
{
  Console.Write("Привет, ");
  Console.WriteLine(username);
}
