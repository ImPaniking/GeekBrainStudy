# 1 - Задайте список из нескольких чисел. Напишите программу, которая найдёт сумму элементов списка, стоящих на нечётной позиции.

# *Пример:*

# - [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

import All_functions_for_home_work as AF

def sum_of_not_numbers_in_array(list_of_numbers:list) -> int:
    """Counts sum of ellements thet are on not even positions

    Args:
        list_of_numbers (list): array in wich sum of ellements shuld ocure 

    Returns:
        int: sum of elements
    """
    # если индекс не чётный - увеличивает сумму на значение под индексом
    sum = 0
    index = 0
    for i in list_of_numbers:
        # if list_of_numbers.index(i) % 2 == 0: # хотел по интересному сделать, но понял что штука не работает при двойных значениях =)
        if index % 2 != 0:
            sum += i
        index += 1

    return sum

def what_is_on_not_in_list(list_of_numbers:list) -> str:
    """Makes a text with elements on not even positions

    Args:
        list_of_numbers (list): array in wich non even positions will be looked up

    Returns:
        str: text fo elements
    """
    # пришлось сделать отдельную функцию для печати =) Первая итерация считает какое кол-во эллементов нужно быдует печатать
    result = ""
    count = 0
    index_main = 0
    for i in list_of_numbers:
        if index_main % 2 != 0:
            count += 1
        index_main += 1
    # вторая итеррация - пока счётсчик не дошёл до нужного кол-ва , в текст добавляет значений
    index = 0
    for i in list_of_numbers:
        if index_main % 2 != 0:
            index += 1
            result += str(i)
            if index < count: # вот где используется кол-во эллементов - пока эллемент не последний , добавляет " и "
                result += " и "
        index_main += 1
    return result


list_of_numbers = AF.array_creation(10,1,10) 
sum = sum_of_not_numbers_in_array(list_of_numbers)
print_elements = what_is_on_not_in_list(list_of_numbers)
print(f"{list_of_numbers} -> на нечётных позициях элементы {print_elements}, ответ:{sum}")