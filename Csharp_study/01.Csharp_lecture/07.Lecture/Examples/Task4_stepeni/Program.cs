//Задача Вывести a в стеени b

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int PowerFor(int a, int n)
{ int result = 1;
for (int i = 1; i <= n; i++) result *= a;
return result;
}
int PowerRec(int a, int n)
{ return n == 0 ? 1 : PowerRec(a, n - 1) * a;
if (n == 0) return 1;
else return PowerRec(a, n - 1) * a;
}
int PowerRecMath(int a, int n)
{
if (n == 0) return 1;
else if (n % 2 == 0) return PowerRecMath(a * a, n / 2);
else return PowerRecMath(a, n - 1) * a;
}

int a = 2;
int b = 25;
Console.Write($"Обычный метод {a} в степени {b}:\t");
Console.WriteLine(PowerFor(a, b)); // 1024
Console.Write($"Рекурсивный метод {a} в степени {b}:\t");
Console.WriteLine(PowerRec(a, b)); // 1024
Console.Write($"Рекурсивный метод улучшенный {a} в степени {b}:\t");
Console.WriteLine(PowerRecMath(a, b)); // 1024