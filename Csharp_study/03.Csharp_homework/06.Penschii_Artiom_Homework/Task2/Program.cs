//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

//https://profmeter.com.ua/communication/learning/course/course19/lesson194/ - взял теорию отсюда
//k- угловой коефициент
//b - сводный член в уравнении прямой
// k1 - не должно ровнятся k2

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

int NumberInput(string text)//Метод ввода и проверки на число
{
    bool isInputStringInt = true;
    int number =0;
    while (isInputStringInt)
    {
        Console.Write($"Введите {text} :");
        string numberSTR = Console.ReadLine();
        if (int.TryParse(numberSTR, out int numberInt))
        {
            number = numberInt;
            isInputStringInt = false;
        }
        else 
            Console.WriteLine("Ввели не число");
    }
    return number;
}

(float,float) IntersectionPoint(int b1,int k1,int b2,int k2)//Метод расчёта точки пересечения
{
    float x=(float)(b2-b1)/(k1-k2);
    float y=(float)(k1*x+b1);
    return(x,y);
}


Console.Write(
    "Напишите программу, которая найдёт точку пересечения двух прямых,"+
    "\nзаданных уравнениями y = k1 * x + b1, y = k2 * x + b2;"+
    "\nзначения b1, k1, b2 и k2 задаются пользователем.\n");
Console.Write("\nПример: b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)\n\n");

/*
//Минимум переменных
(float x,float y) = IntersectionPoint
        (
        b1: NumberInput("b1"),
        k1: NumberInput("уголовой коэф. k1"),
        b2: NumberInput("b2"),
        k2: NumberInput("уголовой коэф. k2")
        );
Console.WriteLine($"({x}; {y})");
*/
//Более корректное оформление

int b1 = NumberInput("b1");
int k1 = NumberInput("уголовой коэф. k1");
int b2 = NumberInput("b2");
int k2 = NumberInput("уголовой коэф. k2");

if (k1 == k2)
    Console.WriteLine("Линии не пересекаются");
else 
{
    (float x, float y) = IntersectionPoint(b1,k1,b2,k2);
    Console.WriteLine($"\nb1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} - > ({x:N1}; {y:N1})");
}
