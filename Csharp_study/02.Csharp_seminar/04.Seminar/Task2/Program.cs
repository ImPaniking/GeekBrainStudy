Console.Clear();
string EnterNumberTest(){
    bool readlineFromStrToInt = true;
    string number = String.Empty;
    while (readlineFromStrToInt){
        Console.Write("Enter N : ");
        number = Console.ReadLine();
        if (int.TryParse(number, out int numberInt) ) readlineFromStrToInt = false;
        else Console.WriteLine("Введите положительное число");}

return number;}

string number = EnterNumberTest();
int count =0;
Console.WriteLine($"Number {number} and has {number.Length}");
foreach (char n in number) count++;
Console.WriteLine($"Number {number} and has {count}");

double num = 1235;
count =0;

while (num >1){
    num = num / 10;
    count++;}
Console.WriteLine($"Number {number} and has {count}");
