# Вычислить число pi c заданной точностью d Пример:
# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

import Penschii_A_Functions as PF
import math

# Вариант 1:

# digits_dictionary ={} # создаю словарь выборов округления

# for i in range(1,11):
#     digits_dictionary[i] = 10**-i


# print(f"Choost from 1 - 10 ammount of digits in Pi:\n")
# PF.print_dictionary_in_lines(digits_dictionary)
# digits_d = PF.input_number_examination(text_in_input="\nEnter d : ",case_def=3,min_num=1,max_num=10)

# pi_number = round(math.pi,digits_d)

# print(f"\nPi with {digits_dictionary[digits_d]} digits = {pi_number}")

# Вариант 2:

truple_of_digits = [(i,f"10^{-i}",10**-i) for i in range(1,11)]


print(f"Choost from 1 - 10 ammount of digits in Pi:\n") # что бы вывод был в строчку 
for i in truple_of_digits:
    print(i)

digits_d = PF.input_number_examination(text_in_input="\nEnter d : ",case_def=3,min_num=1,max_num=10)

# π = 3 + 4/(2*3*4) - 4/(4*5*6) + 4/(6*7*8) - 4/(8*9*10) + 4/(10*11*12) - (4/(12*13*14)

def pi_colculation(ammoint_of_iterations : int) -> float:
    """Calculation of Pi with row of Nilakant

    Args:
        ammoint_of_iterations (int): ammount of it iterations, higher ammout - more acurate 

    Returns:
        float: returns Pi
    """
    res = 3
    index = 2
    for i in range(1,ammoint_of_iterations): # Скажу честно - делаю это усталым. Понимаю что как-то не красиво, но пока что ничего поделать не могу =)
        list_of_nums = list(map(int,[i for i in range(index,index+3)]))
        result_of_list = list_of_nums[0] * list_of_nums[1] * list_of_nums[2]
        index += 2
        if i%2!=0:
            res += 4/(result_of_list)
        else:
            res -= 4/(result_of_list)
    return res

print(f"Pi with {truple_of_digits[digits_d-1][1]} digits is : {round(pi_colculation(ammoint_of_iterations = 1000),digits_d)} -- ряд Нилаканта")
print(f"Pi with {truple_of_digits[digits_d-1][1]} digits is : {round(math.pi,digits_d)} -- math.pi")
    