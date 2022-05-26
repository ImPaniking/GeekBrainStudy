//Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

Console.WriteLine("Введите число");
int Number =int.Parse(Console.ReadLine());
int numberOst = Number;
int ost = 0;
int index = 0;
List<int> code = new List<int>();

while (numberOst >1 )
{
    ost = numberOst % 2 ;
    numberOst = (numberOst-ost)/2;
    code.Add(ost);
    index++;
}
code.Add(numberOst);
code.Reverse();

void PrintList(List<int> list)
{
    for (int i = 0 ; i < list.Count ; i++)
        Console.Write(list[i]);
}

PrintList(code);

