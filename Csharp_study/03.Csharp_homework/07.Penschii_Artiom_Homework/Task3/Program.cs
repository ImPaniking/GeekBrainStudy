//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*  
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int[,] RandomArrayCreation(int rows , int colums , int minRandom , int maxRandom)//вставил на всякий случай возможность изменения рандомности чисел
{
    Random rnd = new Random();
    int[,] array = new int[rows,colums];
    for ( int i = 0 ; i < rows ; i ++)
        for ( int j = 0 ; j < colums ; j ++)
            array[i,j] = rnd.Next(minRandom,maxRandom+1);
return array;
}

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputInt = true;
    int number =0;
    while (isInputInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            if (numberInt <= 0) Console.WriteLine("Введите число больше нуля");
            else
            {
                number = numberInt;
                isInputInt = false;
            } 
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

void ArrayPrint(int[,] array)
{
    Console.Write("\n");
    for ( int i = 0 ; i < array.GetLength(0) ; i ++)
    {
        Console.Write($"Строка {i+1}");
        for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            Console.Write($"\t{array[i,j],3}"); 
        Console.Write("\n");
    }
}

void ColumAverageCount(int[,] array)//Вариант печати ниже столбца
{
    int columSum;
    Console.Write($"Ср.Арифм");
    for ( int j = 0 ; j < array.GetLength(1) ; j++)
    {
        columSum = 0;
        for ( int i = 0 ; i < array.GetLength(0) ; i++)
        {
            columSum += array[i,j];
        }
        Console.Write($"\t{(double)columSum/array.GetLength(0),3:N1}");
    }
}

string ColumAverageCountSecondAsText(int[,] array)//Вариант вывода текста
{
    int columSum;
    string result = String.Empty;
    for ( int j = 0 ; j < array.GetLength(1) ; j++)
    {
        columSum = 0;
        for ( int i = 0 ; i < array.GetLength(0) ; i++)
        {
            columSum += array[i,j];
        }
        result += $"{(double)columSum/array.GetLength(0):N1}";
        if (j < array.GetLength(1) -1) result += "; ";
        else result += ".";
    }
return result;
}

Console.Write("Задача 52:"+
"\nЗадайте двумерный массив из целых чисел"+
"\nНайдите среднее арифметическое элементов в каждом столбце.\n\n");

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");

int[,] array= RandomArrayCreation( rows:rows,
                                    colums:colums,
                                    minRandom:0,
                                    maxRandom:9);
ArrayPrint(array);
ColumAverageCount(array);
Console.Write("\n");
Console.Write($"\nСреднее арифметическое каждого столбца: {ColumAverageCountSecondAsText(array)}");