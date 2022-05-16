/* Использование массива для нахождения максимального значения */
Console.Clear();
/* Метод поиска максимального значения в массиве */
double MaxLookUP(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++) if (numbers[i] > max) max = numbers[i];
    return max;
}
/* Метод создания массива */
double[] MassivCreate()
{
    List<string> lis = new List<string>();
    Console.WriteLine("Enter numbers for massiv, They can be int or double-you can wtite them like 7/8 , 7.8 , 7,8), when done press enter");
    /* ВАЖНО! Сначало создаём список , так как массив должен иметь ограниченный размер */
    while (true)
    {
        Console.Write("Enter number : ");
        string enter = Console.ReadLine();
        /* Замена символов . и / на запятую , что бы был возможен переврд в double */
        if (enter.Contains('.') == true) enter = enter.Replace('.', ',');
        if (enter.Contains('/') == true) enter = enter.Replace('/', ',');
        if (enter == "") break;
        else lis.Add(enter);
    }
    /* ВАЖНО! Переводим списко в массив, благодаря тому что у нас есть длина списка */
    int size = lis.Count;
    double[] mass = new double[size];
    for (int i = 0; i < size; i++)
    {
        mass[i] = double.Parse(lis[i]);
    }
    return mass;
}
/* Метод вывода маасива - так как нельзя просто в Write закинуть массив и ожидать печать =( */
void PrintMass(double[] massiv)
{
    for (int i = 0; i < massiv.Length - 1; i++) Console.Write($"{massiv[i]} , ");
    Console.Write($"{massiv[massiv.Length - 1]}");
}

double[] massiv = { 11, 21, 13, 14, 51, 61, 17, 18, 19 };

/* И тут печалька - нельзя загрузить Метод в печать и ожидать что это сработает */
Console.Write("Max number in : ");
PrintMass(massiv);
Console.WriteLine($" is {MaxLookUP(massiv)}");

double[] mass = MassivCreate();

Console.Write("Max number in : ");
PrintMass(mass);
Console.WriteLine($" is {MaxLookUP(mass)}");
