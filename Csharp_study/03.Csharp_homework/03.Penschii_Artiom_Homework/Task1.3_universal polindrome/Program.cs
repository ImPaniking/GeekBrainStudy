Console.Clear();

Console.WriteLine("Задача 19:\n Напишите программу, которая принимает на вход пятизначное число\n и проверяет, является ли оно палиндромом.");

string wordOrNumberTest(string text){//метод проверки что было введено
    string result = int.TryParse(text, out int numberInt)? "Число" : "Текст";
    if (result == "Текст") result = wordOrText(text);
return result;}

int polindromeTest(string text){
    int countSovpad =0;
        for (int i = 0;i < (text.Length / 2 );i++){
            if (text[i] == text[text.Length - 1 - i]) countSovpad++;}
return countSovpad;}

void printResulPolindrome(string text){
        if (polindromeTest(text) == text.Length / 2) Console.WriteLine($"{wordOrNumberTest(text)} {text} - > полиндром");
        else Console.WriteLine($"{wordOrNumberTest(text)} {text} - > не полиндром");}

string wordOrText(string text){
    string result = "Слово";
    for (int i = 0 ; i < text.Length ; i ++){
        if (text[i] == (char)32) result = "Текст";}
return result;}


string whtToDoWithSpaces(){
    
    ConsoleKeyInfo cki;
    do{
        Console.WriteLine("Нажмите Y-учитывать пробел / N-не учитывать пробел");
        cki = Console.ReadKey(true);
    }while (cki.Key == ConsoleKey.Y && cki.Key == ConsoleKey.N );
    
return $"{cki.Key}";}

string spaceDel(string text){
    string newText = String.Empty;
    for (int i = 0; i < text.Length; i++){
        if (text[i] != (char)32) newText = newText + text[i];}
return newText;}    


do{
Console.Clear();
Console.Write("Введите что-то на проверку, полиндром ли это : ");
string text = Console.ReadLine();

switch (wordOrNumberTest(text)){
    case "Число":   
        printResulPolindrome(text);
        break;
    case "Слово":
        printResulPolindrome(text);
        break;
    case "Текст":
        printResulPolindrome(text);
        break;}



Console.WriteLine("\tДля выхода нажмите ESC,\n для повторна, нажмите любую клавишу к примеру ENTER");
}while (Console.ReadKey().Key != ConsoleKey.Escape);