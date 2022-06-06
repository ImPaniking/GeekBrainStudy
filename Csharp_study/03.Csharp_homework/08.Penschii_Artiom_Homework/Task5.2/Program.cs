//Заполните спирально массив 4 на 4.

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

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
//Метод создаёт массив из заданного количества строк / столбцов и заполняет его по спирали 
//Спираль идёт вправо , вниз , влево, вверх. 

(int,int,int) RigthFilling(int[,] array , int row , int colum , int number)
{
    if ( array[row,colum] != 0 ) colum++;
    while ( array[row,colum] == 0 )
    {
        array[row,colum] = number;
        number++;
        if ( colum + 1 == array.GetLength(1))
            break;
        else if (array[row,colum+1] == 0)
            colum++;
    }
    return (row,colum,number);
}
(int,int,int) LeftFilling(int[,] array , int row , int colum , int number)
{
    if ( array[row,colum] != 0 ) colum--;
    while ( array[row,colum] == 0 )
    {
        array[row,colum] = number;
        number++;
        if ( colum - 1 < 0 )
            break;
        else if (array[row,colum-1] == 0)
            colum--;
    }
    return (row,colum,number);
}
(int,int,int) DownFilling(int[,] array , int row , int colum , int number)
{
    if ( array[row,colum] != 0 ) row++;
    while ( array[row,colum] == 0 )
    {
        array[row,colum] = number;
        number++;
        if ( row + 1 == array.GetLength(0))
            break;
        else if (array[row+1,colum] == 0)
            row++;
    }
    return (row,colum,number);
}
(int,int,int) UpFilling(int[,] array , int row , int colum , int number)
{
    if ( array[row,colum] != 0 ) row--;
    while ( array[row,colum] == 0 )
    {
        array[row,colum] = number;
        number++;
        if ( row - 1 < 0 )
            break;
        else if (array[row-1,colum] == 0)
            row--;
    }
    return (row,colum,number);
}

void SpiralFillArray(int[,] array)
{
    int direction = 1;
    int row = 0;
    int colum = 0;
    int number = 1;
    do
    {
        if (direction == 1) 
        {
            (row,colum,number) = RigthFilling(array,row,colum,number);
            direction = 2;
        }
        else if (direction == 2) 
        {
            (row,colum,number) = DownFilling(array,row,colum,number);
            direction = 3;
        }
        else if (direction == 3) 
        {
            (row,colum,number) = LeftFilling(array,row,colum,number);
            direction = 4;
        }
        else
        {
            (row,colum,number) = UpFilling(array,row,colum,number);
            direction = 1;
        }
    } while ( number <= array.GetLength(0)*array.GetLength(1));
}

Console.Write("Задача 60:"+
"Заполните спирально массив 4 на 4.\n\n");

int rows = NumberInput("кол-во строк");
int colums = NumberInput("кол-во столбцов");
int[,] array = new int[rows,colums];
Console.WriteLine($"Массив {rows} на {colums} заполенные по спирали");
SpiralFillArray(array); 
ArrayPrint(array);