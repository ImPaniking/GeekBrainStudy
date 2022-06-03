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

Console.Write("Задача 60:"+
"Заполните спирально массив 4 на 4.\n\n");
int row = 4;
int col = 4;
int[,] array = new int[row,col];
int number = 1;
int n = 0;
int i = 0;
int j = 0;
for ( int k = 0 ; k < 2 ; k++)
{
    for ( j = n ; j < col-n ; j++)
    {
        array[i,j] = number;
        number++;
        Console.WriteLine(array[i,j]);
    }
    j--;
    number--;  
    for ( i = n ; i < row-n ; i++)
    {
        array[i,j] = number;
        number++;
        Console.WriteLine(array[i,j]);
    }
    i--;
    number--;   
    for ( j = col-1-n ; j > n ; j--)
    {
        array[i,j] = number;
        number++;
        Console.WriteLine(array[i,j]);
    }
    
    for ( i = row-1-n; i > n; i--)
    {
        array[i,j] = number;
        number++;
        Console.WriteLine(array[i,j]);
    }
    i++;
    n++;
}
ArrayPrint(array);