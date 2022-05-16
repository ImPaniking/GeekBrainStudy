Console.Clear();
double a;
double b;
double c;

b = 100;
c = b / Math.Cos(Math.PI*15/180);
a = Math.Sqrt(c*c - b*b);

Console.WriteLine($"Катет а {a}");
Console.WriteLine($"Катет b {b}");
Console.WriteLine($"Гипотенуза c {c}");
