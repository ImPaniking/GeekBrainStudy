# 3 - Задайте список из вещественных чисел. Напишите программу, которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

# *Пример:*

# - [1.1, 1.2, 3.1, 5.561, 10.01] => 0.56 или 56

import All_functions_for_home_work as AF

def min_max_of_drob_in_list(list_of_numbers : list) -> int:
    """look up min and max value of fraction part in float numbers in array

    Args:
        list_of_numbers (list): array of float numbers

    Returns:
        int: min and max valuses
    """
    # проходит по спуску дробных чисел - оставляет только дробную часть и проверят - оно минимальное и проверяет оно максимальное
    max = list_of_numbers[0] - int(list_of_numbers[0])
    min = list_of_numbers[0] - int(list_of_numbers[0]) 
    for i in list_of_numbers:
        num = i - int(i)
        if num > max:
            max = num
        if num < min:
            min = num
    return min,max

list_of = AF.array_creation_float(10)

min,max = min_max_of_drob_in_list(list_of)
dif = max - min
print(f"{list_of} => max({max:.3f}) - min({min:.3f}) = {dif:.3f}")