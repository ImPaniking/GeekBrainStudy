# 1. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
    
#     *Примеры:* 
    
#     - 5, 25 -> да
#     - 4, 16 -> да
#     - 25, 5 -> да
#     - 8,9 -> нет


# a = int(input("Enter number A : "))
# b = int(input("Enter number B : "))

# if a**2 == b:
#     print("number {} is sqr of {}".format(a,b))
# elif  b**2 == a:
#     print("number {} is sqr of {}".format(b,a))
# else:
#     print("no number is sqr of other number")


# 2. Напишите программу, которая на вход принимает 5 чисел и находит максимальное из них.
    
#     Примеры:
    
#     - 1, 4, 8, 7, 5 -> 8
#     - 78, 55, 36, 90, 2 -> 90
import random
number_ammount = int(input("Enter number's ammount : "))

i=0
list_numbers =[]

while i < number_ammount:
    number = int(input("Enter number : "))
    list_numbers.append(number)
    print(list_numbers[i])
    i+=1

max = list_numbers[0]

for num in list_numbers:
    if max<num:
        max = num

print("{} is max ".format(max))
