//This is comment to my code

//rakendus küsib kasutajal sisestada oma nime
//rakendus tervitab kasutajat nimepidi


Console.WriteLine("Kirjuta oma nime");
//string - sõne - строка
string userName;

userName = Console.ReadLine ();

Console.WriteLine("Tere, " + userName + "!");
Console.WriteLine($"Tere, {userName}!");