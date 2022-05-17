Console.WriteLine("Введите три числа -> ");
int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write( a );
Console.Write(", ");
Console.Write( b );
Console.Write(", ");
Console.Write( c );
Console.Write(" -> ");
Console.Write(max);