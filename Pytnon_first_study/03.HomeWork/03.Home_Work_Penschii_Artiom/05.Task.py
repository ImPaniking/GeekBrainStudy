# 5 - Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

# *Пример:*

# - для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21] [Негафибоначчи](https://clck.ru/sH87m)

import All_functions_for_home_work as AF

fib_range = AF.input_number_test_biger_then_zero("Enter fibonachi ragne : ")
fib_list = AF.fibonachi_from_minus_to_plus(fib_range)
print(f"for n = {fib_range} fibonachi list is : {fib_list}")