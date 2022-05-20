System.Console.InputEncoding = System.Text.Encoding.Unicode;
System.Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.Clear();
Console.Write("Вставьте символ : ");
string symb = Console.ReadLine();
byte[] uni = System.Text.Encoding.Unicode.GetBytes(symb);
for (int i = 0; i< uni.Length;i++) Console.Write(uni[i]);
Console.WriteLine();
Console.WriteLine();
string ch = "\x0650";
Console.WriteLine(ch);
Console.WriteLine((char)11732);

/*string test = Convert.ToChar(92)+Convert.ToChar(48)+Convert.ToChar(48)+Convert.ToChar(48)+Convert.ToChar(49);
Console.WriteLine(test);*/