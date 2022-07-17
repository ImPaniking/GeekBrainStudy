# Задайте список из N элементов, заполненных числами из промежутка [-N, N]. Найдите произведение элементов на указанных позициях. Позиции хранятся в файле file.txt в одной строке одно число.
import random

from functions import input_number_test

number_N = input_number_test("Enter N : ")
if number_N < 0:
    number_N *= -1
list_of_numbers = []

for i in range(-number_N,number_N+1):
    list_of_numbers.append(random.randint(0,10))

# file = open('file.txt' , "a")
# file.write("2\n3")
# file.close()

file = open('file.txt' , "r")
data = file.read()
list_of_rows = data.split()
file.close()
print(f"{list_of_rows}")

result = 1
for i in list_of_rows:
    result *= list_of_numbers[int(i)]

print(f"{list_of_numbers} -> {list_of_rows} -> {result}")