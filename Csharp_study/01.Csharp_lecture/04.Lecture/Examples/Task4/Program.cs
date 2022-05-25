System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int factorial(int n)
{
    int result = 0;
    if (n == 1) result = 1;
    else result = n * factorial(n-1);
return result;
}
int fibonaci(int n)
{
    int result = 0;
    if (n == 1 || n == 2) result = 1;
    else result = fibonaci(n-1) + fibonaci(n-2);
return result;
}

int n = 10;

for (int i = 1; i <=n ; i++)
    Console.WriteLine($"{i}! = {factorial(i)}");

for (int i = 1; i <=n ; i++)
    Console.WriteLine($"{i} = {fibonaci(i)}");