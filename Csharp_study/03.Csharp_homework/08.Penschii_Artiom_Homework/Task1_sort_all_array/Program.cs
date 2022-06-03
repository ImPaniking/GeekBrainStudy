//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            Console.Write($"\t{array[i,j],3}"); 
        Console.Write("\n");
    }
}

/*void SortArray(int[,] array)//Попытка фильтровать весь массив целиком - но где-то что-то пропускается и я 2 часа не могу понять где, пошёл другим способом
{
    int max;
    int maxRow;
    int maxColum;
    for ( int n = 0 ; n < array.GetLength(0) ; n++)
    {
        for ( int m = 0 ; m < array.GetLength(1) ; m ++)
        {
            max = array[n,m];
            maxRow = n;
            maxColum = m;
            for ( int i = n ; i < array.GetLength(0) ; i ++)
            {
                for ( int j = m ; j < array.GetLength(1) ; j ++)
                {
                    if (max < array[i,j] )
                    {
                        max = array[i,j];
                        maxRow = i;
                        maxColum = j;
                    }
                }
            }
            array[maxRow,maxColum] = array[n,m];
            array[n,m] = max;
        }
    }
}*/

void SortArray(int[,] array)//Если вкратце - перевожу двумерный массив в линейный - линейный сортирую - перезаписываю оригинальный массив из линейного ( думаю это "грязый" способ - но рабочий)
{
    int[] lineArray = new int[array.GetLength(0)*array.GetLength(1)];
    int index = 0;
    for (int i = 0 ; i < array.GetLength(0) ; i ++)
        for ( int j = 0 ; j < array.GetLength(1) ; j++)
        {
            lineArray[index] = array[i,j];
            index++;
        }
    int temp;

    for ( int i = 0 ; i < lineArray.Length-1 ; i++)
        for ( int j = 0 ; j < lineArray.Length-1-i ; j++)
            if (lineArray[j] < lineArray[j+1])
            {
                temp = lineArray[j+1];
                lineArray[j+1] = lineArray[j];
                lineArray[j] = temp;
            }      
    index = 0;
    for (int i = 0 ; i < array.GetLength(0) ; i ++)
        for ( int j = 0 ; j < array.GetLength(1) ; j++)
        {
            array[i,j] = lineArray[index];
            index++;
        }
}


Console.Write("Задача 54:"+
"\nЗадайте двумерный массив."+
"\nНапишите программу, которая упорядочит по убыванию элементы"+
"\nкаждой строки двумерного массива.\n\n");

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");

int[,] array= RandomArrayCreation( rows:rows,
                                    colums:colums,
                                    minRandom:0,
                                    maxRandom:9);
Console.Write("\nИзначальный массив : \n");
ArrayPrint(array);
SortArray(array);
Console.Write("\nОтсортированный массив : \n");
ArrayPrint(array);
