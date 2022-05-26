//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

/*int[] GetArray(int length)
{
    Random rnd = new Random();
    int[] array = new int[length];
    for (int i = 0 ; i < length ; i ++)
        array[i] = rnd.Next(0,15);
return array;
}*/

int[] MakeArray()
{
    int[] array= new int[3];
    for ( int i = 0 ; i < array.Length ; i ++)
    {
        Console.WriteLine($"Введите сторону {i+1} :");
        array[i] = int.Parse(Console.ReadLine());
    }
return array;
}

void PrintArray(int[] array)
{
    foreach(int num in array)
        Console.Write($"{num} ");
}

void TiangleTest(int[] array)
{
    int sum = 0;
    int test = 0;
    for ( int i = 0 ; i < array.Length ; i ++)
    {
        sum = 0;
        for (int j = 0; j < array.Length ; j++)
        {
            if (j != i) 
                sum += array[j];
        }
        if ( array[i] < sum) 
            test++;
    }
    if (test == 3)
        Console.Write(" - > Да");
    else 
        Console.Write(" - > Нет");
}

int [] array = MakeArray();

PrintArray(array);
TiangleTest(array);