# Вычислить число pi c заданной точностью d Пример:
# - при $d = 0.001, π = 3.141.$    $10^{-1} ≤ d ≤10^{-10}$

import Penschii_A_Functions as PF
import math

digits_dictionary ={}

for i in range(1,11):
    digits_dictionary[i] = 10**-i

# PF.print_dictionary_in_lines(digits_dictionary)
print(f"Choost from 1 - 10 ammount of digits in Pi:\n")
PF.print_dictionary_in_lines(digits_dictionary)
digits_d = PF.input_number_examination(text_in_input="\nEnter d : ",case_def=3,min_num=1,max_num=10)

pi_number = round(math.pi,digits_d)

print(f"\nPi with {digits_dictionary[digits_d]} digits = {pi_number}")