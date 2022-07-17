# 5 - Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

# *Пример:*

# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи](https://clck.ru/sH87m)

import All_functions_for_home_work as AF

def fibonachi_plus(fib_range : int) -> list:
    """makes array of fibonacci numbers > 0

    Args:
        fib_range (int): range of fibonacci numbers

    Returns:
        list: > 0 fibonacci array
    """
    flibonachi_list = [0,1]
    if fib_range > 1:
        for i in range(2,fib_range+1):
            # формула рассчёта фибоначи, для этог первые 2 числа записанны
            flibonachi_list.append(flibonachi_list[i-1]+flibonachi_list[i-2])
    return flibonachi_list

def fibonachi_minus(fib_range : int) -> list: # наверное можно было обойтись без этого и просто каждый второй эллемент обычного фибоначи умнодить на -1, но подумал - вдруг когда то потребуется только минуосовй фибоначи
    """makes fibonacci numbers < 0

    Args:
        fib_range (int): range of fibonacci numbers

    Returns:
        list: < 0 fibonacci array
    """
    flibonachi_list = [0,1]
    if fib_range > 1:
        for i in range(2,fib_range+1):
            # формула рассчёта фибоначи, для этог первые 2 числа записанны
            flibonachi_list.append(flibonachi_list[i-2]-flibonachi_list[i-1])
    return flibonachi_list

def fibonachi_from_minus_to_plus(fib_range : int) -> list:
    """compels two fibonacci arrays ( < 0 and > 0 ) in one fibonacci array

    Args:
        fib_range (int): range of fibonacci 

    Returns:
        list: list of fibonacci numbers
    """
    fib_plus = fibonachi_plus(fib_range) # создаёт положителный фибоначи
    flibonachi_list = fibonachi_minus(fib_range) # создаёт отрицательный фибоначи
    AF.sort_array(flibonachi_list) # разворачивает отрицательный фибоначи
    for i in range(1,fib_range+1): # к отрицательному добавляет положительный по каждому эллементу 
        flibonachi_list.append(fib_plus[i])
    return flibonachi_list
        

fib_range = AF.input_number_test_biger_then_zero("Enter fibonachi ragne : ")
fib_list = fibonachi_from_minus_to_plus(fib_range)
print(f"for n = {fib_range} fibonachi list is : {fib_list}")