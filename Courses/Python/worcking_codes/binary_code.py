number = int(input("Введите число для перевода в двоичную систему : "))
system = int(input("Введите разрадность системы : "))
cod_number=[]
# блок рассчёта двоичного кода
while number>=system:
    cod_number.append(number-number//system*system)
    number = number//system
cod_number.append(number)
# блок проверки нужного бита - нужен цикл проверки введённого бита
if len(cod_number)%2!=0:
    length = len(cod_number)+1
else:
    length = len(cod_number)
bit = 0
while bit<length:
    bit = input("В скольки битах вывести число : ")
    if bit=="":
        print("Бит не указан, за значение принято {}".format(length))
        bit=length
        break
    elif bit.isdigit()==False:
        print("Не верный символ ")
        bit=0
    else :
        bit = int(bit)
        if bit<length:
            print("Длина кода уже превышает указанный бит, минимальный бит - {}".format(length))
        elif bit>length:
            if bit%2!=0:
                bit +=1
# блок добавления 0 до нужного разряда
index = len(cod_number)
while index<bit:
    cod_number.append(0)
    index +=1
# блок сортировки кода для правильной записи
temp_cod=0
index = 0
while index<(len(cod_number)-1)/2:
    temp_cod=cod_number[index]
    cod_number[index]=cod_number[len(cod_number)-1-index]
    cod_number[len(cod_number) - 1 - index]=temp_cod
    index +=1
print(cod_number)
