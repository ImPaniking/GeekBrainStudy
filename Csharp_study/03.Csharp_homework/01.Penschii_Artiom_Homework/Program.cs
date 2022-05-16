//Задача2. Напищите программу, которая на вход принимает 2 числа и выдаёт какое число большее, а какое меньшее

Console.Clear();
Console.WriteLine("Task.2");
Console.Write(" Endter number a : ");
int a = int.Parse(Console.ReadLine());
Console.Write(" Endter number b : ");
int b = int.Parse(Console.ReadLine());

Console.WriteLine(a > b ? $" max ={a} and min = {b}" : $"max = {b} and min = {a}");

//Задача4. Напищите программу, которая на вход принимает 3 числа и выдаёт максимальное из этих числе
//Я бы хотел сделать список, но мы пока что не проходили
Console.WriteLine("Task.4");
Console.Write(" Endter number 1 : ");
int c = int.Parse(Console.ReadLine());
Console.Write(" Endter number 2 : ");
int d = int.Parse(Console.ReadLine());
Console.Write(" Endter number 3 : ");
int e = int.Parse(Console.ReadLine());

int Max = c;

if (c > Max) Max = c;
if (d > Max) Max = d;
if (e > Max) Max = e;

Console.WriteLine($"Max number -> {Max}");

//Задача6. Напищите программу, которая на вход принимает чило и выдаёт является ли оно чётным
Console.WriteLine("Task.6");
Console.Write(" Endter number 1 : ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine(number % 2 == 0 ? $"Number {number} is even" : $"Number {number} is NOT even");

//Задача8. Напищите программу, которая на вход принимает чило N и выводит всё чётные числа в диапазоне от 1 до N
Console.WriteLine("Task.8");
Console.Write(" Endter number 1 : ");
int num = int.Parse(Console.ReadLine());
int i = 1;
if (num <= i) Console.WriteLine("Нужно число больше 1");
while (i <= num)
{
    if (i % 2 == 0) Console.Write($" {i} ");
    i++;
}

Console.ReadKey();