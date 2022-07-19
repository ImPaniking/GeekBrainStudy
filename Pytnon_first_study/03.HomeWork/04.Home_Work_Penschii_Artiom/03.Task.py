# 3- Задайте натуральное число N. Напишите программу, которая составит список простых множителей числа N.
# Пример: при N = 12 -> [2, 3]

import Penschii_A_Functions as PF

number_N = PF.input_number_examination(text_in_input="Enter N : ",case_def=1) # личная гордость проверки ввода на число , по нескольким уровням =) 

def simpl_nums_of_number(number : int ) ->list:
    list_of_simple_numbers =[]
    number_to_work = number_N
    # Мне рекурсия не зашла и так как в задании нет указания что нужно сделать через неё - сделал без неё =) 
    for j in range(2,number_N+1):
        for i in range(2,number_N+1):
            if number_to_work % i == 0:
                list_of_simple_numbers.append(i)
                number_to_work = number_to_work / i
                break
    return list_of_simple_numbers

ls_of_simpl_mult = simpl_nums_of_number(number_N)

print(f"In number {number_N} list of siple multipliers are -> {ls_of_simpl_mult} -> {set(ls_of_simpl_mult)}")