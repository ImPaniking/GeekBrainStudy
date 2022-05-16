/* Найти индекс позиции из списка*/
Console.Clear();
/* Заполнение массива случайными числами от до*/
void FillArray(int[] collection,int minNumber,int maxNumber)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(minNumber,maxNumber);
        index++;
    }
}

/* Вывод массива*/

void PrintArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        Console.Write($" {collection[index]} ");
        index++;
    }
}

int IndOfNum(int[] array , int number)
{
    int index = -1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == number) 
        {
            index = i;
            break;
        }
    }
    return index;
}


int[] array = { 11, 21, 3, 41, 5, 6, 17, 18, 9 , 3};

int n = array.Length;
Console.Write("Enter number to find : ");
int find = int.Parse(Console.ReadLine());
int index = 0;

/* Вывод всех индексов по числу*/

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Index of number {find} : {index}");
    }
    index++;
}

/* Прерывание цикла на первом найденом варианте*/

index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Index of first number {find} : {index}");
        break;
    }
    index++;
}


Console.Write("Enter mass length : ");
int length = int.Parse(Console.ReadLine());
int[] array2 = new int[length];

FillArray(array2,1,10);
PrintArray(array2);
Console.WriteLine();
Console.Write("Enter number you look : ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"First index of {number} is {IndOfNum(array2 , number)}");
