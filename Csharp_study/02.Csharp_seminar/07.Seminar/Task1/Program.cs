//Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
/*
    m = 3, n = 4.
    1 4 8 19
    5 -2 33 -2
    77 3 8 1
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
            array[i,j] = rnd.Next(0,100);
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i = 0 ; i < rows ; i++ )
    {
        for ( int j = 0 ; j < colums ; j++)
            Console.Write($"{array[i,j],3} ");
        Console.Write("\n");
    }
}

Console.Write(
    "Задача 46:"+
    "\nЗадайте двумерный массив размером m×n"+
    "\nзаполненный случайными целыми числами (Random выставил от 0 до 99)\n\n");

int rows = NumberInput("количество строк");
int colums = NumberInput("количество столбцов");

int[,] array = RandomArrayCreation(rows,colums);
Console.Write($"\n m = {rows}, n = {colums}\n");
PrintArray(array);