System.Console.OutputEncoding = System.Text.Encoding.Unicode;
string useOldTextOrNewText(){// метод вывода кнопки кнопки из 2х вариантов
    ConsoleKeyInfo cki;
    Console.WriteLine("Повторить ? Используя старый текст, нажминет ENTER"+ 
    "\nПовторить? Используя новый текст, нажмите N"+
    "\n ВНИМАНИЕ! обязательно на английской расскладке"+
    "\nЧто бы выйти, нажмите ESCAPE");
    do{
        cki = Console.ReadKey(true);
    }while (cki.Key != ConsoleKey.Enter && cki.Key != ConsoleKey.N && cki.Key != ConsoleKey.Escape );
return Convert.ToString(cki.Key);}

char symbolInput(string text){ // Метод проверки кол-ва введёных символов для недопущения ошибки при вводе символов
    string symb =String.Empty;
    while (symb.Length !=1 ){
        Console.Write($"Введите символ {text} нужно поменять :");
        symb = Console.ReadLine();
        if (symb.Length == 0 ) Console.Write("Ввели пустое значение - ");
        else if (symb.Length != 1 ) Console.Write("Ввели слишком много символов - ");}
return Convert.ToChar(symb);}

char numberInput(int num, string text){//метод проверки числа
    bool readlineFromStrToInt = true;
    int number =0;
    while (readlineFromStrToInt){
        Console.Write($"Введите код символа, к примеру '{num}' {text} заменить : ");
        string numberSTR = Console.ReadLine();        
        if (int.TryParse(numberSTR, out int numberInt) ){
            number = numberInt;
            readlineFromStrToInt = false;}
        else Console.Write("Вы ввели не число - ");}
return (char)number;}

string wordInput(string text,string textToWrite){
    string word =" ";
    while (word.Length >= text.Length || word.Length != 0){
        Console.WriteLine($"Введите слово {textToWrite} нужно поменять : ");
        word = Console.ReadLine();
        if (word.Length > text.Length) Console.Write($"Введённое слово больше текста - ");
        else if (word.Length == 0) Console.Write($"Ввели пустое значение - ");}    
return word;}

string useSymbOrChar(){// метод вывода кнопки кнопки из 2х вариантов
    ConsoleKeyInfo cki;
    Console.WriteLine(
    "Нажмите S - чтобы вводить символ, к примеру 'A' \n"+
    "Нажмите C - чтобы вводить char, к примеру 20\n"+
    "Нажмите W - чтобы вводить слово целиком, к примеру 20\n"+
    "ВНИМАНИЕ! обязательно на английской расскладке");
    do{
        cki = Console.ReadKey(true);
    }while (cki.Key != ConsoleKey.S && cki.Key != ConsoleKey.C && cki.Key != ConsoleKey.W );
return Convert.ToString(cki.Key);}

string replaceSymbolsInText(string text,char symMinus,char SymPlus){
    string textNew = text.Replace(symMinus,SymPlus);
return textNew;}

bool lookUpSymb(string text,char symb){
    bool findChange = false;
    for (int i = 0;i<text.Length;i++){
        if (text[i]==symb) findChange = true;}
return findChange;}

bool lookUpWord(string text,string word){
    bool findChange = false;
    for (int i = 0;i <= text.Length-word.Length;i++){
        for (int j=0;j<word.Length;j++){
            if (text[i+j] == word[j]) findChange = true;
        }
    }
return findChange;
}

string text = String.Empty;
string textNew = String.Empty;
string wordToChange = " ";
string wordNew = " ";
char symbolToChange = '\0';
char symbolWithWhatToChange = '\0';
string newTextOrOld = (string)"N";
string symbOrChar = String.Empty;
string textInfo = String.Empty;

do { // тело программы с возможностью повтора
    Console.Clear();
    if (newTextOrOld != "N") text = textNew;
    else{ 
        Console.WriteLine("Введите любой текс, не успользуя ENTER.\n ENTER - подтверждение ввода");
        text = Console.ReadLine();
    } 
    Console.Clear();

    symbOrChar = useSymbOrChar();
    switch (symbOrChar){
        case "S":
            do{
                do{ 
                    symbolToChange = symbolInput("которой");
                    if (lookUpSymb(text,symbolToChange) == false) Console.WriteLine("Нет такого символа в тексте - повторный ввод");
                }while (lookUpSymb(text,symbolToChange) == false);
            symbolWithWhatToChange = symbolInput("на которой");
            if (symbolToChange == symbolWithWhatToChange) Console.WriteLine("Символы равны, повторый ввод");
            } while (symbolToChange == symbolWithWhatToChange || lookUpSymb(text,symbolToChange) == false);
            break;
        case "C":
            do{
                do{ 
                    symbolToChange = numberInput(20,"котрый");
                    if (lookUpSymb(text,symbolToChange) == false) Console.WriteLine("Нет такого символа в тексте - повторный ввод");
                }while (lookUpSymb(text,symbolToChange) == false);
            symbolWithWhatToChange = numberInput(3,"на которой");
            if (symbolToChange == symbolWithWhatToChange) Console.WriteLine("Символы равны, повторый ввод");
            } while (symbolToChange == symbolWithWhatToChange || lookUpSymb(text,symbolToChange) == false);
            break;
        case "W":
            do{
                do{ 
                    wordToChange = wordInput(text , "которое");
                    if (lookUpWord(text,wordToChange) == false) Console.WriteLine("Нет такого символа в тексте - повторный ввод");
                }while (lookUpWord(text,wordToChange) == false);
            wordNew = wordInput(text , "на которое");
            if (wordToChange == wordNew) Console.WriteLine("Символы равны, повторый ввод");
            } while (wordToChange == wordNew || lookUpWord(text,wordToChange) == false);
            break;
    }
    Console.Clear();
    textNew = replaceSymbolsInText(text,symbolToChange,symbolWithWhatToChange);
    Console.WriteLine($"Меняем '{symbolToChange}' на '{symbolWithWhatToChange}' в тексте : {text} и получилось :\n\t\t{textNew}");
    
    newTextOrOld = useOldTextOrNewText();
}while (newTextOrOld != "Escape");