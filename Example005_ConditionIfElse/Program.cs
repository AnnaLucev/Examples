// Приветствие пользователя - любимчика

Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();
if (username.ToLower() == "маша")               // переводит весь текст в нижний регистр
{
   Console.WriteLine("Ура! Это же МАША!"); 
}
else 
{
    Console.Write("Привет,  "); 
    Console.WriteLine(username); 
}

