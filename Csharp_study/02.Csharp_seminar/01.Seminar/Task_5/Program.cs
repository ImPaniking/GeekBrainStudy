Console.Clear();
Console.Write("Enter number : ");
int number = int.Parse(Console.ReadLine());
int i = -number;

while (i <= number)
{
    Console.Write($" {i} ");
    i++;
}
Console.WriteLine("");
Console.Write("Enter number : ");
string numberA = Console.ReadLine();
string A = numberA.Substring(numberA.Length-1);

Console.Write($" Last number {numberA} - {A} ");