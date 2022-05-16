Console.Clear();

Console.WriteLine("Задача 1:\n Напишите программу, которая принимает на вход число (N)\n и выдаёт таблицу кубов чисел от 1 до N.");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите N : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            if (number < 0) Console.WriteLine("Введите положительное число");
            else if ( number == 0) Console.WriteLine("Введите пожалуйста не 0");
            else
                readlineFromStrToInt = false;
        }
        else Console.WriteLine("Вы ввели текст");  
    }
    return number;
}

void printResult(int n){
    for (int i=1 ; i <= n ; i ++) {
        Console.Write($"{Math.Pow(i , 3)}");
        if (i<n) Console.Write(", ");
    }
}

printResult(EnterNumberTest());

Console.ReadLine();