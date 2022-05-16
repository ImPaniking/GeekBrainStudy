Console.Clear();

Console.WriteLine("Задача 19:\n Напишите программу, которая принимает на вход пятизначное число\n и проверяет, является ли оно палиндромом.");

/* Изначально программа была корое, но в итоге решил сделать максимум функций*/

/* Цикл проверки введённой переменной */
string EnterNumberTest(){
    bool readlineFromStrToInt = true;
    string numberSTR = "";
    while (readlineFromStrToInt){
        Console.Write("Enter 9999 < number < 100000 : ");
        numberSTR = Console.ReadLine();
        
        if (int.TryParse(numberSTR, out int numberInt) ){
            if (numberSTR.Length != 5 || numberSTR[0] == '-') Console.WriteLine("Entered rong number , try again");
            else readlineFromStrToInt = false;
        }  
    }
    return numberSTR;
}
/* Функция Формированичя результата */
string polindromeResult(int sum, string number){
    string reuslt = (sum == 2 )? $"Yes {number} is polindrome" : $"No {number} is not a polindrome";
return reuslt;
}
/* Функцмя проверки на полимер и вывод результата */
string polindromeTest(string number){
    int sum =0;
    string result = "";
    for (int i = 0; i < 2; i++){
        if (number[i] == number[number.Length-i-1]) sum++;
    }
    result = polindromeResult(sum,number);
return result;
}

/* Сама программа */ 
string number = EnterNumberTest();

Console.WriteLine(polindromeTest(number));

Console.ReadLine();