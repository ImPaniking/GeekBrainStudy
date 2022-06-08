//Задача игра в пирамидку

System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();

void Towers(string with = "1", string on = "3", string some = "2", int count = 3)
{
if (count > 1) Towers(with, some, on, count - 1);
Console.WriteLine($"{with} >> {on}");
if (count > 1) Towers(some, on, with, count - 1);
}

Towers(count:5);