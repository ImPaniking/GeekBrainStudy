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

string printArray(int[] array){
    System.Text.StringBuilder result = new System.Text.StringBuilder();
    for (int i = 0; i < array.Length; i++){
        if ((i == 0) && (array.Length > 1) )
            result.Append("[").Append($"{array[i],3}").Append(", ");
        else if ((i == 0) && (array.Length == 1) ) 
            result.Append("[").Append($"{array[i],3}").Append("]");
        else if ( i < array.Length -1 )
            result.Append($"{array[i],3}").Append(", ");
        else 
            result.Append($"{array[i],3}").Append("]");
    }
return result.ToString();
}

string printArrayIndex(int[] array){// Печать индексов, чисто для удобства сверки
    System.Text.StringBuilder result = new System.Text.StringBuilder();
    for (int i = 0; i < array.Length; i++){
        if ((i == 0) && (array.Length > 1) )
            result.Append("[").Append($"{i,3}").Append(", ");
        else if ((i == 0) && (array.Length == 1) ) 
            result.Append("[").Append($"{i,3}").Append("]");
        else if ( i < array.Length -1 )
            result.Append($"{i,3}").Append(", ");
        else 
            result.Append($"{i,3}").Append("]");
    }
return result.ToString();
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

/*int numberLength(int number){ // Хотел использовать это для динамических отсупов при печати массива и индексов, что бы индекс находился над числом
    int length = Convert.ToString(number).Length;
return length;
}*/

Console.WriteLine("Задача 35:\n"+
"Задайте одномерный массив, заполненный случайными числами.\n"+
"Найдите сумму элементов, стоящих на нечётных позициях.\n");

Console.WriteLine("* Для читабильности , на каждое значение резервиутеся 3 знака, так что диапазон чисел лучше иметь от -99 до 999 \n"+
"Для читабельности - размер массива зависит от размера экрана. Для простоты предлагаю использовать меньше 10\n");

int arrayLength = numberInput("Введите длину массива : ");
int minNumberRandom = numberInputForRandom("Введите минимальное значение для случайного числа : ");
int maxNumberRandom = numberInputForRandom("Введите максимальное значение для случайного числа : ")+1;

int[] array = arrayCreation(arrayLength,minNumberRandom,maxNumberRandom);
Console.WriteLine($"\n{printArrayIndex(array)}" + " index");//Не смог придумать, как сделать динамический отступ по этому предуставноил на 3 символа
/* в теорри, для того что бы вывод был красивый, мне придётся создать метод, который сравнивал бы длину значения и добавлял недостоющую длину индексу при печати.
Сделать можно, но не вижу смысла так сильно усложнять. Мог бы просто массив пропечатать как таблицу с шапкой Индекс, Значение  */
Console.WriteLine($"{printArray(array)} - > {unEvenPositionInArraySum(array)} sum");
Console.ReadLine();
