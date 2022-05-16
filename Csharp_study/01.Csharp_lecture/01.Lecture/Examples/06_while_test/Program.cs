Console.Clear();
int x1 = 40, y1 = 1,
    x2 = 1, y2 = 30,
    x3 = 80, y3 = 30;
int x=x1 , y=x2;
int count =0; 

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");
Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");
Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

while (count <= 100000)
{
    int what = new Random().Next(0,3);
    if (what == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }
    if (what == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }
    if (what == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x , y);
    Console.WriteLine("+");
    count++;
}
