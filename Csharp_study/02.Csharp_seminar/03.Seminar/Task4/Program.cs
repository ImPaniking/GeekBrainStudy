Console.Clear();

Console.WriteLine("Задача 1:\n Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Enter N : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            if (number < 0) Console.WriteLine("Введите положительное число");
            else if ( number == 0) Console.WriteLine("Введите пожалуйста не 0");
            else
                readlineFromStrToInt = false;
        }  
    }
    return number;
}

int n = EnterNumberTest();

for (int i=1 ; i <= n ; i ++) Console.Write($" {Math.Pow(i , 2)} ");