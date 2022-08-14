int digit = new Random().Next(10,99);
int digitdouble = digit;
Console.WriteLine ("Выпавшее число "+digit);
if (digit/10>digitdouble%10)
{
    Console.WriteLine ("Наибольшая Цифра числа "+digit+" является число " +digit/10);
}
else 
{
    Console.WriteLine ("Наибольшая цифра числа "+digit+" является число "+digitdouble%10);
}