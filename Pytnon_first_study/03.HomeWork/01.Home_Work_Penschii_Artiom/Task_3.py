# 3- Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).

# *Пример:*

# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3

int_test = True
is_minus = False

while int_test:
    x = input("Enter X : ")
    if x[0] == "-": #вот это пришлось добавить - так как минусовые числа он не воспренимал как числа. Сваял что придумал
        is_minus = True
        x = x.replace("-","")#убирает минус
    if x.isdigit():
        x = int(x)
        if is_minus:#возврат минуса если есть
            x *= -1
        if x != 0:
            int_test = False
        else :
            print("Enter not a 0 ")
    else :
        print("Not a number , try again")

int_test = True
is_minus = False
while int_test:
    y = input("Enter Y : ")
    if y[0] == "-":
        is_minus = True
        y = y.replace("-","")
    if y.isdigit():
        y = int(y)
        if is_minus:
            y *= -1
        if y != 0:
            int_test = False
        else :
            print("Enter not a 0 ")
    else :
        print("Not a number , try again")


# Пока без методов ( или функций )
if x > 0 and y > 0:
    print(f"x={x}; y={y} -> 1")
if x > 0 and y < 0:
    print(f"x={x}; y={y} -> 2")
if x < 0 and y < 0:
    print(f"x={x}; y={y} -> 3")
if x < 0 and y > 0:
    print(f"x={x}; y={y} -> 4")