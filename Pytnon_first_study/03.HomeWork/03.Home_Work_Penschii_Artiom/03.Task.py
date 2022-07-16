# 3 - Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

# *Пример:*

# - [1.1, 1.2, 3.1, 5.561, 10.01] => 0.56 или 56

import All_functions_for_home_work as AF

list_of = AF.array_creation_float(10)

min,max = AF.min_max_of_drob_in_list(list_of)
dif = max - min
print(f"{list_of} => max({max:.3f}) - min({min:.3f}) = {dif:.3f}")