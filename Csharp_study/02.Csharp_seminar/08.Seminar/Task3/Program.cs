//Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

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

void StringArrayPrint(string[,] array)
{
    Console.Write("\n");
    for ( int i = 0 ; i < array.GetLength(0) ; i ++)
    {
        for ( int j = 0 ; j < array.GetLength(1) ; j ++)
            Console.Write($"\t{array[i,j]}"); 
        Console.Write("\n");
    }
}

string[,] DictionaryCreation(int[,] array)
{
    string[,] dictionary = new string[10,4];
    for (int i = 0 ; i < 10 ; i ++)
        dictionary[i,0] = $"{i}";
    for (int i = 0 ; i < 10 ; i ++)
        dictionary[i,1] = "встречается";
    for (int i = 0 ; i < 10 ; i ++)
        dictionary[i,2] = "0";
    for (int i = 0 ; i < 10 ; i ++)
        dictionary[i,3] = "раз";

    for ( int i = 0 ; i < array.GetLength(0) ; i++)
        for ( int j = 0 ; j < array.GetLength(1); j++)
            for ( int n = 0 ; n < 10 ; n++)
                if (Convert.ToString(array[i,j]) == dictionary[n,0]) dictionary[n,2] = Convert.ToString(int.Parse(dictionary[n,2]) + 1);
    
    return dictionary;
}

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");

int[,] array= RandomArrayCreation( rows:rows,
                                    colums:colums,
                                    minRandom:0,
                                    maxRandom:9);
Console.Write("\n Изначальный массив:");
ArrayPrint(array);

string[,] dictionary = DictionaryCreation(array);
Console.Write("\n Новый массив:");
StringArrayPrint(dictionary);


