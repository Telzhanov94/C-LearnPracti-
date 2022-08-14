Console.WriteLine ("Введите трёхзнвчное число");
int digit= int.Parse (Console.ReadLine ());
digit=digit/10;
Console.WriteLine ("Вторая цифра числа " + digit%10);