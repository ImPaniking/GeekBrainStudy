Console.Clear();
Console.Write("Enter number 1 : ");
int c = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2 : ");
int d = Convert.ToInt32(Console.ReadLine());
if (Math.Pow(c, 2) == d) Console.WriteLine("Yes");
else Console.WriteLine("No");
Console.ReadKey();