// Дано число обозначающее день недели. Выяснить является номер дня недели выходным
Console.WriteLine ("number");
int number = int.Parse(Console.ReadLine());
string [] weekday = new string[7] { "mon", "tue", "wen", "thu", "fri", "sat", "sun"};;
int i= weekday.Length;
if (number < i && number < 6)
{
    Console.WriteLine("not day off");
}
else if ( number < i && number <= 7)
{
    Console.WriteLine("day off");
}

