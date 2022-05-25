//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

/*
1. Создать массив случайных 3х значных цифр.
    1.1 Размер массива утсановлю на 10
    1.2 Случайнче числы от 100 до 1000
2. Создать метод подсчёта чётных чисел.
3. Создать метод вывода массива.
4. Метод Ввода длины массива и проверки на число >0
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode; 
Console.Clear(); 

int [] arrayCreation(int length){
    Random rnd= new Random ();
    int[] array = new int[length];
    for (int i = 0; i< array.Length; i++)
        array[i] = rnd.Next(100,1000);
return array;
}

int evenCountInArray(int[] array){ 
    int count = 0;
    foreach (int item in array){
        if (item % 2 == 0)
            count++;
    }
return count;
}

void pritnArrayColored(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        if (array[i] % 2 ==0){
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

int numberInput(string TextToWriteBeforeInput){
    bool examIfStrIsInt = true;
    int number = 0;
    do{
        Console.Write($"{TextToWriteBeforeInput}");
        string numberStr = Console.ReadLine();
        if (int.TryParse(numberStr, out int numberInt)){
            if (numberInt < 0)
                Console.WriteLine("Длина массива не мождет быть меньше 1, повторите попытку");
            else{
                number = numberInt;
                examIfStrIsInt = false;
            }
        }
        else Console.WriteLine("Ввели не число, повторие попытку");
    } while (examIfStrIsInt);
return number;    
}

Console.WriteLine("Задача 34:\n"+
"Задайте массив заполненный случайными положительными трёхзначными числами.\n"+
"Напишите программу, которая покажет количество чётных чисел в массиве.\n");

int arrayLength = numberInput("Введите длину массива : ");

int[] array = arrayCreation(arrayLength);
pritnArrayColored(array);
Console.WriteLine($" - > {evenCountInArray(array)}");

Console.ReadLine();
