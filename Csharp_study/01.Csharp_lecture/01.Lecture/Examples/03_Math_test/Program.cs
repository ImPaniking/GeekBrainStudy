int a = 5;
int b = 6;
int c = 7 , d = 8;
int sum = a + b;
double del = (double)d / (double)a; // важно перевести переменные
Console.WriteLine($"int throu sum - {a} + {b} = {sum}");
Console.WriteLine($"count in print - {a} + {c} = {a+c}");
Console.WriteLine($"del throu del - {d} / {a} = {del}");
Console.WriteLine($"del in print {- a} / {b} = {(double)a/b}");
Console.WriteLine($"Umnozenit - {a} * {c} = {a*c}");
Console.WriteLine($"using % - {c} % {a} = {c % a}");
Console.WriteLine($"using %2 - {b} % {2} = {b % 2}");
Console.WriteLine($"using %2 - {c} % {2} = {c % 2}");