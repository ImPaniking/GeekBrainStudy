Console.Clear();

Console.WriteLine("Задача 1:\n Напишите программу, которая принимает навход трёхзначное число\n и на выходе показывает вторуюцифру этого числа.");


int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Enter number : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) && (numberSTR.Length == 3)){
            number = numberInt;
            readlineFromStrToInt = false;
        }
        else if (int.TryParse(numberSTR, out numberInt) &&(numberSTR.Length != 3))
             Console.WriteLine("Нужно ввести 3х значное число , к примеру 145 ");
        else Console.WriteLine("Ввели не число, повторите попытку");
    }
    return number;   
}
int number = EnterNumberTest();
int secondCharNumber = (number%100)/10;
Console.WriteLine($"{number} -> {secondCharNumber}");

Console.ReadLine();