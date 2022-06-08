//Задача Вывести сумму цифры от 1 до A

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int SumFor(int n)
{
int result = 0;
for (int i = 1; i <= n; i++) result += i;
return result;
}

int SumRec(int n)
{
if (n == 0) return 0;
else return n + SumRec(n - 1);
}
int a = 55;
Console.Write($"Обычный метод от {1} до {a}:\t");
Console.WriteLine(SumFor(a)); // 55
Console.Write($"Рекурсивный метод от {1} до {a}:\t");
Console.WriteLine(SumRec(a)); // 55