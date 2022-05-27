Console.WriteLine("Введите число которое будет возведено в степень: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень в которе будет возведено число: ");

int st = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} в степени {st} = " + Math.Pow(a,st));