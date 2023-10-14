// Console.Write("Введите имя пользователя: ");
// string username = Console.ReadLine();

// if(username == "Маша")
// {
//     Console.WriteLine("Ура, это же МАША!");
// }
// else
// {
//     Console.Write("Привет, ");
//     Console.WriteLine(username);
// }

// // в чем тут может скрываться проблема? Если Маша будет вводить свое имя например, так: мАша, то ее программа будет приветствовать как обычного пользлвателя
// // исправим это

Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "маша")// мы починили большую часть проблем
{
    Console.WriteLine("Ура, это же МАША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
