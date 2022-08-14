Console.WriteLine ("Введите первое число ");
int FirstNumber = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите первое число ");
int SecondNumber = int.Parse (Console.ReadLine());
Console.WriteLine ("Введите первое число ");
int ThirdNumber = int.Parse (Console.ReadLine());
int number=FirstNumber;
if (SecondNumber>number)
{
   number=SecondNumber;
    }
if (ThirdNumber>number)
{
   number=ThirdNumber;
    }
Console.WriteLine ("Максимальное число: "+ number);