//Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
/*
    Например, изначально массив
    выглядел вот так:
    1 4 7 2
    5 9 2 3
    8 4 2 4

    Новый массив будет выглядеть 
    вот так:
    1 4 7 2
    5 81 2 9
    8 4 2 4

*/
System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

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

int[,] RandomArrayCreation(int rows, int colums)
{
    Random rnd = new Random();
    int[,] array = new int[rows,colums];
    for ( int i = 0 ; i < rows ; i++ )
        for ( int j = 0 ; j < colums ; j++)
            array[i,j] = rnd.Next(0,10);
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i = 0 ; i < rows ; i++ )
    {
        for ( int j = 0 ; j < colums ; j++)
            Console.Write($"\t{array[i,j]}");
        Console.Write("\n");
    }
}

int[,] ArrayChange(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    int[,] arrayNew = new int[rows,colums];
    for ( int i = 0 ; i < rows ; i++ )
        for ( int j = 0 ; j < colums ; j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0)) arrayNew[i,j] = (int)Math.Pow(array[i,j],2);
            else arrayNew[i,j] = array[i,j];
        }
    return arrayNew;
}

Console.Write(
    "Задача 49:"+
    "\nЗадайте двумерный массив"+
    "\nНайдите элементы, у которых оба индекса чётные,"+
    "\nи замените эти элементы на их квадраты.\n\n");

int rows = NumberInput("количество строк");
int colums = NumberInput("количество столбцов");

Console.Write("\nОрегинальный массив : \n");
int[,] array = RandomArrayCreation(rows,colums);
PrintArray(array);
Console.Write("\nИзменённый массив : \n");
int[,] arrayNew = ArrayChange(array);
PrintArray(arrayNew);

