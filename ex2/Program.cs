// По двум заданным числам проверять является ли одно квадратом другого
Console.WriteLine("numberA");
int numberA= int.Parse(Console.ReadLine());
Console.WriteLine("numberB");
int numberB= int.Parse(Console.ReadLine());
int a = 0;
a = numberA*numberA;
if (a ==numberB)
{
    Console.WriteLine("yes");
}
else if ( a!= numberB)
{
    Console.WriteLine("no");
}