//Программа проверяет пятизначное число на палиндромом.
Console.WriteLine("number");
int number= int.Parse(Console.ReadLine());
int a = 0;
int b = 0;
int c = 0;
int d= 0;
int e = 0;
int x = 0;
a = number / 10000;
b = number / 1000;
b = b % 10;
c = number / 100;
c = c % 10;
d = number / 10;
d = d % 10;;
e= number % 10;
x= e*10000 + d*1000 + c*100 +b*10 +a;

if (number == x)
{
    Console.WriteLine("palindrom");
}
else if ( number != x)
{
    Console.WriteLine("no");
}
