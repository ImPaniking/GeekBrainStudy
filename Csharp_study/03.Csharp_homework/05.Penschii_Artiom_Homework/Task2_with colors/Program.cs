//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
1. Создать массив случайных цифр.
    1.1 Размер массива утсановлю на 10
2. Создать метод подсчёта чисел на нечётных позициях.
3. Создать метод вывода массива.
4. Создать метод печати индексов
5. Метод Ввода длины массива и проверки на число >0
    5.1 Хотел метод сделать универсальным, но понял что Random не входит в верхнее условие
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int [] arrayCreation(int length,int minNumber,int maxNumber){
    Random rnd= new Random ();
    int[] array = new int[length];
    for (int i = 0; i< array.Length; i++){
        array[i] = rnd.Next(minNumber,maxNumber);
    }
return array;
}

int unEvenPositionInArraySum(int[] array){ // метод поиска не чётных индексов и суммирования значений по этим индексов
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0)
            sum += array[i];
    }
return sum;
}

void pritnArrayColored(int[] array)// Печать массива с отметкой каждого символа на не чётном индексе
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        if (i % 2 !=0){
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(array[i]);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        else {Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(array[i]);
            Console.BackgroundColor = ConsoleColor.Black;
        }
        if (i < array.Length -1 ) Console.Write(", ");
        else if (i == array.Length-1)Console.Write("]");
    }
}

void coutnAndPrintArray(int[] array)
{
    int sum = 0;
    Console.Write($"\n\nInd\tNum\tSum\n");
    for (int i = 0 ; i < array.Length ; i ++)
    {
        if ( i % 2 != 0)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            sum = sum + array[i];
            Console.Write($"{i,-3}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"\t{array[i],-3}\t{sum,-3}\n");
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write($"{i,-3}");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write($"\t{array[i],-3}\t{"",-3}\n");
        }
    }
    Console.Write($"\nTotal Sum : {sum,-3}\n");
}

int numberInput(string TextToWriteBeforeInput){
    bool examIfStrIsInt = true;
    int number = 0;
    do{
        Console.Write($"{TextToWriteBeforeInput}");
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out int numberInt)){
            if (numberInt <= 1)
                Console.WriteLine("Длина массива не мождет быть меньше или равна 1, повторите попытку");
            else{
                number = numberInt;
                examIfStrIsInt = false;
            }
        }
        else Console.WriteLine("Ввели не число, повторие попытку");
    } while (examIfStrIsInt);
return number;    
}
int numberInputForRandom(string TextToWriteBeforeInput){// В следующем задании объеденил 2 метода. Зрительно - тело программы читабильнее когда 2 разных метода. 
    bool examIfStrIsInt = true;
    int number = 0;
    do{
        Console.Write($"{TextToWriteBeforeInput}");
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out int numberInt)){
                number = numberInt;
                examIfStrIsInt = false;
        }
        else Console.WriteLine("Ввели не число, повторие попытку");
    } while (examIfStrIsInt);
return number;    
}


Console.WriteLine("Задача 35:\n"+
"Задайте одномерный массив, заполненный случайными числами.\n"+
"Найдите сумму элементов, стоящих на нечётных позициях.\n");

int arrayLength = numberInput("Введите длину массива : ");
int minNumberRandom = numberInputForRandom("Введите минимальное значение для случайного числа : ");
int maxNumberRandom = numberInputForRandom("Введите максимальное значение для случайного числа : ")+1;

int[] array = arrayCreation(arrayLength,minNumberRandom,maxNumberRandom);

pritnArrayColored(array);
Console.WriteLine($" - > {unEvenPositionInArraySum(array)} sum");
coutnAndPrintArray(array);

Console.ReadLine();
