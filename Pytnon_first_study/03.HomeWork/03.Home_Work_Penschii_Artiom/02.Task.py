# 2 - Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# *Пример:*

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

import All_functions_for_home_work as AF

list_of_numbers = AF.array_creation(6,1,10)
list_of_results = AF.mult_of_par_in_list(list_of_numbers)

print(f"{list_of_numbers} => {list_of_results}")