Console.Write(" Enter Name : ");
string name = Console.ReadLine();

if (name.ToLower() == "max" )
{
    Console.WriteLine(" Damn! Its MAX! ");
}
else if (name.ToLower() == "kenoby")
{
    Console.WriteLine("Well Hello there");
    Console.WriteLine("General Kenoby");
}
else
{
    Console.WriteLine($"Hello , {name}");
}

int a = 1 , b = 8, c = 4 , d = 5 , e = 6;
int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;
if (d > max) max = d;
if (e > max) max = e;
Console.WriteLine("Max number is {0}",max);