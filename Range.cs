Console.WriteLine ("Введите число для обозначения диапазона");
int RangeNumber = int.Parse (Console.ReadLine());
int Count=-RangeNumber;
while (Count<RangeNumber+1)
{
    Console.Write (Count +" ");
    Count++;
}