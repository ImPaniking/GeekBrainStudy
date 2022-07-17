# Строка содержит набор чисел. Показать большее и меньшее число
# Символ-разделитель - пробел
# Найти корни квадратного уравнения Ax² + Bx + C = 0
# Математикой
# Используя дополнительные библиотеки*
# Найти НОК двух чисел

# 30*** , Подумать, что если точность вычисления до 1000 знаков после запятой

from Penschii_A_Functions import input_number_examination

number_N = input_number_examination(text_in_input="Enter number N : ",case_def=1)

with open ('test.txt' , 'w' , encoding='utf-8') as file:
    for i in range(0,number_N+1):
        file.write(f"{i}\n")
    file.close()

