# 4-Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

coords = {
    1:"x>0 and y>0",
    2:"x>0 and y<0",
    3:"x<0 and y<0",
    4:"x<0 and y>0"
    }

int_test = True

while int_test:
    coord_number = input("Enter coord zone from 1 to 4 : ")
    if coord_number.isdigit():
        coord_number = int(coord_number)
        if coord_number >= 1 and coord_number <= 4:
            int_test = False
        else :
            print("There no such coord")
    else :
        print("Not a number , try again")

print(f"{coord_number} coordinate zone - > {coords[coord_number]}")