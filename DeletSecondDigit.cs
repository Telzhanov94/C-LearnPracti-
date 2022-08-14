Console.WriteLine ("Введите трёхзнвчное число");
int digit= int.Parse (Console.ReadLine ());
Console.WriteLine ("Получаемое число без второй цифры: "+digit/100+""+digit%10 );