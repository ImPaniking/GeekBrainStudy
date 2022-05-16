Console.Clear();

Console.WriteLine("Задача 1:\n Напишите программу, которая по заданному номеру четверти,\n показывает диапазон возможных координат точек в этой четверти \n(x и y).");

int EnterNumberTest(){
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write("Введите число : ");
        string numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            if ((number < 0) && (number >4)) Console.WriteLine("Всего 4 квадрата");
            else readlineFromStrToInt = false;
        }
    }
    return number;
}

void Diapason(int number){
    switch (number){
        case 1 :
            Console.WriteLine("X > 0 & Y > 0");
            break;
        case 2 :
            Console.WriteLine("X > 0 & Y < 0");
            break;
        case 3 :
            Console.WriteLine("X < 0 & Y < 0");
            break;
        default:
            Console.WriteLine("X < 0 & Y > 0");
            break;
    }
}

Diapason(EnterNumberTest());