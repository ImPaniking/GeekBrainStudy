# 1 - Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

# *Пример:*

# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

import All_functions_for_home_work as AF

list_of_numbers = AF.array_creation(10,1,10) 
sum = AF.sum_of_not_numbers_in_array(list_of_numbers)
print_elements = AF.what_is_on_not_in_list(list_of_numbers)
print(f"{list_of_numbers} -> на нечётных позициях элементы {print_elements}, ответ:{sum}")