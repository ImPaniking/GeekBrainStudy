# 2 - Напишите программу, которая найдёт произведение пар чисел списка. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

# *Пример:*

# - [2, 3, 4, 5, 6] => [12, 15, 16];
# - [2, 3, 5, 6] => [12, 15]

import All_functions_for_home_work as AF

def mult_of_par_in_list(list_of_numbers : list) -> list:
    """multiplication of pair in list (0,-1 / 1,-2 , etc)

    Args:
        list_of_numbers (list): array in wich multiplication will ocure

    Returns:
        list: list of multiplied pairs
    """
    # цикл проходит до середины массива - перемножает 1 и последний эллемент и добавляет результат в новый список
    list_fo_mult_pars = []
    for i in range (0,int(len(list_of_numbers)/2)):
        list_fo_mult_pars.append(list_of_numbers[i] * list_of_numbers[-(i+1)])
    # если кол-во эллементов не чётное - средний эллемент возводит в квадрат
    if len(list_of_numbers) % 2 != 0:
        list_fo_mult_pars.append(list_of_numbers[len(list_of_numbers) % 2+1] ** 2)
    return list_fo_mult_pars


list_of_numbers = AF.array_creation(6,1,10)
list_of_results = mult_of_par_in_list(list_of_numbers)

print(f"{list_of_numbers} => {list_of_results}")