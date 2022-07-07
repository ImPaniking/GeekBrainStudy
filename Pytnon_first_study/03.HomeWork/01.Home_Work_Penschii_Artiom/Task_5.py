# 5- Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

# *Пример:*

# - A (3,6); B (2,1) -> 5,09
# - A (7,-5); B (1,-1) -> 7,21

import math  # Я честно не знаю как корень взять без этого =) 

def input_coords(text):

    int_test = True
    is_minus = False
    while int_test:
        coord = input(f"{text}")
        if coord[0] == "-":
            is_minus = True
            coord = coord.replace("-","")
        if coord.isdigit():
            coord = int(coord)
            if is_minus:
                coord *= -1
            int_test = False
        else :
            print("Not a number , try again")
    return coord

x1 = input_coords("Entre X1 : ")
y1 = input_coords("Entre Y1 : ")
x2 = input_coords("Entre X2 : ")
y2 = input_coords("Entre Y2 : ")

distance = math.sqrt((x2-x1)**2 + (y2-y1)**2)

print(f"Distance between ({x1},{y1}) and ({x2},{y2}) - > {distance:.3f}")