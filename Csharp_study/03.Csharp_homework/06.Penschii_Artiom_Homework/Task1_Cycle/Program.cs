//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int NumberInput(string inputText)//Метод ввода и проверки на число
{
    bool isInputStringInt = true;
    int number =0;
    while (isInputStringInt)
    {
        Console.Write($"{inputText} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            number = numberInt;
            isInputStringInt = false;
        }
        else 
            Console.Write("Ввели не число ");
    }
    return number;
}

(int[] , int) NumberArrayInput(int arrayLength)//Метод задания массива из кол-ва чисел M, решил сразу вывести и количество негативных
{
    int[] array = new int[arrayLength];
    int negativeNumbersCount = 0;
    for (int i = 0 ; i < arrayLength ; i ++)
    {
        array[i] = NumberInput(inputText: $"{i+1}");
        if (array[i] < 0)
            negativeNumbersCount++;
    }    
    return (array,negativeNumbersCount);
}

void PrintArray(int[] array)//метод печати массива как в примере - чисто для красоты
{
    for ( int i = 0 ; i < array.Length ; i ++)
        {
            Console.Write(array[i]);
            if ( i < array.Length - 1)
                Console.Write(", ");
        }
}

Console.Write(
    "Пользователь вводит с клавиатуры M чисел."+
    "\nПосчитайте, сколько чисел больше 0 ввёл пользователь."+
    "\n\nПример : 0, 7, 8, -2, -2 -> 2");

int numbersAmmount = NumberInput("\n\nКоличество чисел M");//Вводится с клавиатуры какое-количество чисел будет
Console.WriteLine();
(int[] numbersArray , int negativeNumbersCount) = NumberArrayInput(numbersAmmount);//Создаётся массив чисел и даётся количество отрицательных
Console.WriteLine();
PrintArray(numbersArray);//Оформленрие результата
Console.Write($" - > {negativeNumbersCount}");