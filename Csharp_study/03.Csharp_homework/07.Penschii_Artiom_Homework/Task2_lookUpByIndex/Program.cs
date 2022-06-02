//Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

/*  
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    17 -> такого числа в массиве нет
*/


System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();
//есть 2 варианта решения задачи: 1 - поиск идёт по строка/столбец , 2 - идёт накопительная нумерация ( как в подъезде только сверху вниз)
//это вариент по индексу

(int[,],int) RandomArrayCreation(int rows , int colums , int minRandom , int maxRandom)//вставил на всякий случай возможность изменения рандомности чисел
{
    Random rnd = new Random();
    int[,] array = new int[rows,colums];
    int arrayIndex = 0;
    for ( int i = 0 ; i < rows ; i ++)
        for ( int j = 0 ; j < colums ; j ++)
        {
            array[i,j] = rnd.Next(minRandom,maxRandom+1);
            arrayIndex++;
        }
return (array,arrayIndex);
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
            Console.Write($"\t{array[i,j]} "); 
        Console.Write("\n");
    }
}

void LookUpValueByIndexInArray(int index, int[,] array)//Метод вывода значения по индексу
{
    int lookUpIndex = NumberInput("индекс для поиска");
    if (lookUpIndex > index) Console.Write($"{lookUpIndex} - > в массиве меньше элементов");//Надеюсь это более оптимально - что бы не пробегать по всему циклу, сначала проверяю введённое значение
    else 
    {
        int arrayIndex = 0;
        for ( int i = 0 ; i < array.GetLength(0) ; i ++)
            for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            {
                arrayIndex++;
                if (arrayIndex == lookUpIndex)
                {
                    Console.Write($"на позиции {lookUpIndex} - > значение ( {array[i,j]} )");
                    break;
                } 
            }
    }
}

Console.Write("Задача 50:"+
"\nНапишите программу, которая на вход принимает позиции элемента в двумерном массиве"+
"\nи возвращает значение этого элемента или же указание, что такого элемента нет.\n\n");

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");

(int[,] array ,int arrayIndex )= RandomArrayCreation( rows:rows,
                                    colums:colums,
                                    minRandom:0,
                                    maxRandom:9);
ArrayPrint(array);
Console.Write("\n");
LookUpValueByIndexInArray(arrayIndex,array);