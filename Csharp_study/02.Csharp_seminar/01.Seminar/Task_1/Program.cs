Console.Clear();
Console.Write("Enter number : ");
int step = 2;
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Number {number}^{step} = {Math.Pow(number,step)}");
Console.ReadKey();