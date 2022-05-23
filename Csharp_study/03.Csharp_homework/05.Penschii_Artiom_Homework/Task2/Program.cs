//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

/*
1. Создать массив случайных цифр.
    1.1 Размер массива утсановлю на 10
2. Создать метод подсчёта чисел на нечётных позициях.
3. Создать метод вывода массива.
*/

System.Console.OutputEncoding = System.Text.Encoding.Unicode; // Данная функция нужна мне для ноутбука что бы писались русские символы в консоли
Console.Clear(); // очистка консали - персональное предпочтение

int [] arrayCreation(int length,int minNumber,int maxNumber){
    Random rnd= new Random ();//подключаем рандом
    int[] array = new int[length];//создаём массив
    for (int i = 0; i< array.Length; i++){//создаём цикл прохода по всему массиву
        array[i] = rnd.Next(minNumber,maxNumber);//присвоение каждому эллементу массиву 
    }
return array;
}

int unEvenPositionInArraySum(int[] array){ // метод поиска чётных значений
    int sum = 0;
    for (int i = 0; i < array.Length; i++){
        if (i % 2 != 0)
            sum += array[i];
    }
return sum;
}

string printArray(int[] array){// метод печати массива - что бы он выглядел красиво оформленным 
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0 )
            result = "["+Convert.ToString(array[i])+", ";
        else if ( i < array.Length -1 )
            result = result +Convert.ToString(array[i])+", ";
        else 
            result = result +Convert.ToString(array[i]) +"]";
    }
return result;
}
string printArrayIndex(int[] array){// метод печати индексов массива, для лёгкой проверки
    string result = String.Empty;
    for (int i = 0; i < array.Length; i++){
        if (i == 0 )
            result = "["+Convert.ToString(i)+", ";
        else if ( i < array.Length -1 )
            result = result +Convert.ToString(i)+", ";
        else 
            result = result +Convert.ToString(i) +"]"; 
    }
return result;
}

Console.WriteLine("Задача 35:\n"+
"Задайте одномерный массив, заполненный случайными числами.\n"+
"Найдите сумму элементов, стоящих на нечётных позициях.\n");

int arrayLength = 10;// в залаче не сказанна длина массива. Указал 10. 
int minNumberRandom = 0;
int maxNumberRandom = 10;

int[] array = arrayCreation(arrayLength,minNumberRandom,maxNumberRandom);
Console.WriteLine(printArrayIndex(array) + " index");//Создал для облегчения проверки
Console.WriteLine($"{printArray(array)} - > {unEvenPositionInArraySum(array)} sum");
