/* Задача - принять текст и заменить символы*/

string symbolsChange(string text,char oldSymb,char newSymb){ // Метод замены символов в тексте
    string newText = String.Empty;
    for (int i = 0 ; i < text.Length ; i++){
        if (text[i] == oldSymb) newText = newText + newSymb;
        else newText = newText + text[i];
    }
return newText;
}

char lengthControl(){ // Метод проверки кол-ва введёных символов для недопущения ошибки при вводе символов
    string symb =String.Empty;
    while (symb.Length !=1){
        symb = Console.ReadLine();
        if (symb.Length != 1){
            Console.WriteLine("Ввели слишком много символов");
            Console.Write("\tВведите 1 символ : ");
        }
    }
return Convert.ToChar(symb);
}

do { // тело программы с возможностью повтора

    Console.Clear();

    Console.Write("Введите любой текст.\n Когда закончите нажмите Enter\n ТЕКСТ : ");
    string text = Console.ReadLine();
    char symbToChange = '.';
    char symbNew = '.';
    do{ // повторный ввод если смволы одинаковые
        Console.Write("1.Введите символ, КОТОРЫЙ хоите заменить, Внимание! влияет буква заглавная или нет : ");
        symbToChange = lengthControl();
        Console.Write("2.Введите символ, НА КОТОРЫЙ хоите заменить, Внимание! влияет буква заглавная или нет : ");
        symbNew = lengthControl();
        if (symbNew == symbToChange) Console.WriteLine("Символы одинаковые, используйте разные символы.\n Повтор ввода обоих символов :");
    }
    while( symbNew == symbToChange);


    Console.Clear();
    Console.WriteLine($"В тексте {text}\nЗаменили {symbToChange} на {symbNew} и получили:\n{symbolsChange(text,symbToChange,symbNew)}");

    Console.WriteLine("\tДля выхода нажмите ESC,\n для повторна, нажмите любую клавишу к примеру ENTER");
}
while (Console.ReadKey().Key != ConsoleKey.Escape);