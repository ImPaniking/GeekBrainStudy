Console.Clear();

Console.WriteLine("Задача 1:\n Напишите программу, которая принимает на вход координаты точки (X и Y),\n причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,\n в которой находится эта точка.");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            if (number == 0 ) Console.WriteLine("Enter number not 0");
            else readlineFromStrToInt = false;
        }
    }
    return number;
}
void Test(int x, int y){
    if (x > 0 && y>0 ) Console.WriteLine("1 kvadrat");
    if (x > 0 && y<0 ) Console.WriteLine("2 kvadrat");
    if (x < 0 && y<0 ) Console.WriteLine("3 kvadrat");
    if (x < 0 && y>0 ) Console.WriteLine("4 kvadrat");
}

int x = EnterNumberTest();
int y = EnterNumberTest();

Test(x,y);

Console.ReadLine();