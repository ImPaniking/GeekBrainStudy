Console.Clear();
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
int sumFromOneToN(int n){
    int sum = 0;
    for ( int i =1; i <= n; i++) sum = sum+i;
return sum;
}


int a = EnterNumberTest();
int sum = sumFromOneToN(a);
Console.WriteLine($"Sum form 1 to {a} = {sum}");

