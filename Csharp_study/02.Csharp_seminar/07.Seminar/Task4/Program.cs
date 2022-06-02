//Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
/*
    Например, задан массив:
    1 4 7 2
    5 9 2 3
    8 4 2 4
    Сумма элементов главной диагонали: 1+9+2 = 12
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

int[,] RandomArrayCreation(int demension)
{
    Random rnd = new Random();
    int[,] array = new int[demension,demension];
    for ( int i = 0 ; i < demension ; i++ )
        for ( int j = 0 ; j < demension ; j++)
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
            Console.Write($"\t{array[i,j]} ");
        Console.Write("\n");
    }
}

(string,int) SumNumOnMainDiagonal(int[,] array) // стринг тут чисто для вывода как по условию
{
    int sum = 0;
    string elements = String.Empty;
    for ( int i = 0 ; i < array.GetLength(0) ; i++ )
    {
        sum += array[i,i];
        elements += $"{array[i,i]}";
        if (i != array.GetLength(0)-1) elements += "+";
    } 
    return (elements,sum);
}

Console.Write(
    "Задача 51:"+
    "\nЗадайте двумерный массив. (Random от 0 до 10 )"+
    "\nНайдите сумму элементов, находящихся на главной диагонали ( массив будет квадратным )\n\n");

int demension = NumberInput("размер квадратного массива");

int[,] array = RandomArrayCreation(demension);
Console.Write("\n");
PrintArray(array);
(string elementsOfMainDiagonal , int sumOfElementsOfMainDiagonal) = SumNumOnMainDiagonal(array);
Console.Write($"\nСумма элементов главной диагонали: {elementsOfMainDiagonal} = {sumOfElementsOfMainDiagonal}");