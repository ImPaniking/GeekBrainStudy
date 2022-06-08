//Задача Вывести цифры от А до B

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

string NumbersFor(int a, int b)
{
 string result = String.Empty;
 for (int i = a; i <= b; i++)
 {
 result += $"{i} ";
 }
 return result;
}
string NumbersRec(int a, int b)
{
 if (a <= b) return $"{a} " + NumbersRec(a + 1, b);
 else return String.Empty;
}
int a = 1;
int b = 10;
Console.Write($"Обычный метод от {a} до {b}:\t");
Console.WriteLine(NumbersFor(a, b)); 
Console.Write($"Рекурсивный метод от {a} до {b}:\t");
Console.WriteLine(NumbersRec(a, b)); 
