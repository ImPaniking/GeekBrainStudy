# 4 - Напишите программу, которая будет преобразовывать десятичное число в двоичное.

# *Пример:*

# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10
# 5 - Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

import All_functions_for_home_work as AF

number = AF.input_number_test_biger_then_zero("Enter number > 0 : ")
result = AF.in_byte_transfer(number)
print(f" - {number} -> {result}")