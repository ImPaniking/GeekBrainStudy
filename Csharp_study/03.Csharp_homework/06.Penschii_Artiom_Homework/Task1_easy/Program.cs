//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int numbersInput(int numberCount)//Метод ввода цифр по очереди
{
    Console.WriteLine("Вводите числа через ENTER :");
    int count = 1;
    int countNegative = 0;
    int number = 0;
    while (count <= numberCount)
    {
        Console.Write($"({count}) : ");
        number = int.Parse(Console.ReadLine());
        count++;
        if ( number < 0)
            countNegative++;
    }
return countNegative;
}

int numbersRandom(int numberCount)//Метод случайного генерирования цифр ( ну что бы не парится с вводом )
{
    Random rnd = new Random();
    int count = 1;
    int countNegative = 0;
    int number = 0;
    while (count <= numberCount)
    {
        number = rnd.Next(-10,11);
        Console.Write($"{number} ");
        count++;
        if ( number < 0)
            countNegative++;
    }
return countNegative;
}


Console.Write("Введите количество чисел M :");
int M = int.Parse(Console.ReadLine());

/*Console.Write($" Отрицательных чисел - > {numbersInput(M)}");*/ // Тут при записи вводятся цифры и сразу выдаётся ответ 
int count = numbersRandom(M);
Console.Write($" - > {count}");