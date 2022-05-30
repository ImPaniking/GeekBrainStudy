//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int b1 = 2;
int k1 = 5;
int b2 = 4;
int k2 = 9;

float y=0;
float x=0;

if (b1 > b2 && k1 > k2)
    x = (float)(b1 - b2)/(k1 - k2);
if (b1 < b2 && k1 < k2)
    x = (float)(b2 - b1)/(k2 - k1);
if (b1 > b2 && k1 < k2)
    x = (float)(b1 - b2)/(k2 - k1);
if (b1 < b2 && k1 > k2)
    x = (float)(b2 - b1)/(k1 - k2);

Console.Write($"{x:N2}");

if ( k1 > k2)
    y = k2 * x + b2;
else
    y = k1 * x + b1;