Console.Clear();

Console.WriteLine("Задача 19:\n Напишите программу, которая принимает на вход пятизначное число\n и проверяет, является ли оно палиндромом.");

/* Цикл проверки введённой переменной */
string EnterNumberTest(){
    bool readlineFromStrToInt = true;
    string numberSTR = "";
    while (readlineFromStrToInt){
        Console.Write("Enter 9 999 < number < 100 000 : ");
        numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            if (numberSTR.Length != 5 || numberSTR[0] == '-') Console.WriteLine("Entered rong number , try again");
            else readlineFromStrToInt = false;
        }  
    }
    return numberSTR;
}
void polindromeTest(string text){
    if (text[0] == text[4] && text[1]==text[3]) Console.WriteLine($"{text} -> Да");
    else Console.WriteLine($"{text} -> Нет");
}

/* Сама программа */ 
string number = EnterNumberTest();

polindromeTest(number);

Console.ReadLine();