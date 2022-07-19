# Задана натуральная степень k. Сформировать случайным образом список коэффициентов (значения от 0 до 100) многочлена и записать в файл многочлен степени k.

# Пример:

# - k=2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 или 10*x² = 0

from Penschii_A_Functions import input_number_examination

list_of_koef = []

k = input_number_examination(text_in_input="Enter k :" , case_def=1)

for i in range(0,100):
    if (2*i)**k + (4*i)+5 == 0 or (i**k)+5 == 0 or (10*i)**k == 0:
        list_of_koef.append(i)

print(list_of_koef)