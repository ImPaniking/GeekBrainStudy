Console.Clear();/* Чистит терминал */
/* Найти максимум из 9 числе */
/* Стихийный метод */
int a1 = 5;
int a2 = 10;
int a3 = 15;
int a4 = 51;
int a5 = 16;
int a6 = -1;
int a7 = 20;
int a8 = 35;
int a9 = 40;

int max = a1;

if (a2 > max) max = a2;
if (a3 > max) max = a3;
if (a4 > max) max = a4;
if (a5 > max) max = a5;
if (a6 > max) max = a6;
if (a7 > max) max = a7;
if (a8 > max) max = a8;
if (a9 > max) max = a9;

Console.WriteLine($"Max number is {max}");
/* Создание Метода */
int Max_f(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
/* Применение метода */
max = Max_f(
    Max_f(a1, a2, a3),
    Max_f(a4, a5, a6),
    Max_f(a7, a8, a9)
    );
Console.WriteLine($"Max number is {max}");

Console.ReadLine();/* Если запусать exe - ожидает ввода ENTER */