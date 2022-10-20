// Задать номер четверти, показать диапазоны для возможных координат
Console.WriteLine("number");
int number= int.Parse(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("x= negative y= positive");
}
if (number == 2)
{
    Console.WriteLine("x= positive y= positive");
}
if (number == 3)
{
    Console.WriteLine("x= positive y= negative");
}
if (number == 4)
{
    Console.WriteLine("x= negative y= negative");
}