//Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
/*
    m = 3, n = 4.
    0 1 2 3
    1 2 3 4
    2 3 4 5
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

int[,] ArrayCreation(int rows, int colums)
{
    int[,] array = new int[rows,colums];
    for ( int i = 0 ; i < rows ; i++ )
        for ( int j = 0 ; j < colums ; j++)
            array[i,j] = i+j;
    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int colums = array.GetLength(1);
    for ( int i = 0 ; i < rows ; i++ )
    {
        for ( int j = 0 ; j < colums ; j++)
            Console.Write($"{array[i,j],2}");
        Console.Write("\n");
    }
}

Console.Write(
    "Задача 48:"+
    "\nЗадайте двумерный массив размера m на n"+
    "\nкаждый элемент в массиве находится по формуле: Aₘₙ = m+n"+
    "\nВыведите полученный массив на экран\n\n");

int rows = NumberInput("количество строк");
int colums = NumberInput("количество столбцов");

int[,] array = ArrayCreation(rows,colums);
Console.Write($"\n m = {rows}, n = {colums}\n");
PrintArray(array);