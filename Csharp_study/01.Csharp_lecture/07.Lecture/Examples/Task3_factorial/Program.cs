//Задача Вывести n факториал

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int FactorialFor(int n)
{
int result = 1;
for (int i = 1; i <= n; i++) result *= i;
return result;
}

int FactorialRec(int n)
{
if (n == 1) return 1;
else return n * FactorialRec(n - 1);
}
int n = 25;
Console.Write($"Обычный метод {n}!:\t");
Console.WriteLine(FactorialFor(n)); // 3628800
Console.Write($"Рекурсивный метод {n}!:\t");
Console.WriteLine(FactorialRec(n)); // 3628800