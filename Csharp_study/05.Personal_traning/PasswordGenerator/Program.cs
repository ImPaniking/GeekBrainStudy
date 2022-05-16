Console.Clear();

Random rnd = new Random();

int randomSymb(){
    int rnSym = rnd.Next(0,3);
    return rnSym;
}

string randomChar(int type){
    int symNum =0;
    char sym = '#';
    if (type == 0) {
        symNum = rnd.Next(48,57);
        sym = Convert.ToChar(symNum);
    }
    if (type == 1) {
        symNum = rnd.Next(97,122);
        sym = Convert.ToChar(symNum);
    }
    if (type == 2) {
        symNum = rnd.Next(65,91);
        sym = Convert.ToChar(symNum);
    }
    string symbol = Convert.ToString(sym);
    return symbol;
}
string pass = "";

Console.Write("Укажите длину пароля : ");
int passLength =  int.Parse(Console.ReadLine());

for (int i =0;i<passLength;i++){
    pass = pass + randomChar(randomSymb());
}

Console.WriteLine(pass);
Console.ReadLine();