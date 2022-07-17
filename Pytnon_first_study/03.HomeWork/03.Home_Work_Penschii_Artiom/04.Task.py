# 4 - Напишите программу, которая будет преобразовывать десятичное число в двоичное.

# *Пример:*

# - 45 -> 101101
# - 3 -> 11
# - 2 -> 10
# 5 - Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

import All_functions_for_home_work as AF

def in_byte_transfer(number : int) -> list:
    """codes number in 2byte code

    Args:
        number (int): number that shoud be coded

    Returns:
        list: integer 2 byte code of number
    """
    ostatok = number 
    list_of_bites =[]
    # деление без остатка на 2 - это будущий остаток, Число - остаток = 1 или 0 для записпи в код
    # потом число меняет на остаток и повторяет процецц пока остаток больше 1
    while ostatok >= 1:
        ostatok = number // 2
        # print(number,ostatok,number-ostatok*2) # провкерка
        list_of_bites.append(number-ostatok*2)
        number = ostatok
    AF.sort_array(list_of_bites) # разворачивает список ( кстати - пример Void функции - если я правильно понмю , в C# списки и массивы были ссылочными типами, по этому любое изменение - меняет его везед)
    return AF.convert_list_in_int(list_of_bites) # переводит списко в число ( сделал что бы было как в примере )

number = AF.input_number_test_biger_then_zero("Enter number > 0 : ")
result = in_byte_transfer(number)
print(f" - {number} -> {result}")