Console.Clear();
Console.Write("Enter number1 : ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Enter number2 : ");
int number2 = int.Parse(Console.ReadLine());

if (number1*number1 == number2 || number2*number2 == number1) Console.WriteLine($"{number1} , {number2} -> Yes");
else Console.WriteLine($"{number1} , {number2} -> No");
    


