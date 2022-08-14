Console.WriteLine ("Введите делимое число");
int FirstNumber = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите возможное кратное число");
int SecondNumber = int.Parse(Console.ReadLine());
if (FirstNumber%SecondNumber==0)
{
    Console.WriteLine ("Число ктратное");
}
else {Console.WriteLine  ("Число не кратно получаемый остаток равен: " + FirstNumber%SecondNumber );}