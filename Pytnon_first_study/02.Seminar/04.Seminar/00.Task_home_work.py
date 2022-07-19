numbers = [1.1, 1.2, 3.1, 5.567, 10.03]
 
def null_counter(num:float):
    '''
    Переносит точку в числе и считает, сколько знаков после точки
    param: num - вещественное число
    return: counter - количество символов после точки, num = int
    '''
    counter = 0
    while num != int(num):
        num*=10
        counter+=1
    return counter, num
def change_list(nums: list):
    '''
    Изменяет список чисел: переносит точки вправо у всех чисел.
    Первый цикл: делает описанное выше и узнает наибольшее количество символов после точки
    Второй цикл: подгоняет остальные цифры к max_counter
    
    Пример
    Вход:1.1 и 1.234.
    max_counter = 3
    Выход:1100 и 1234
    param: nums - список вещественных чисел
    return: counter - количество символов после точки, num = int
    '''
    max_counter = 0
    counters_list = []
    for i in range(len(nums)):
        counter,num = null_counter(nums[i])
        counters_list.append(counter)
        nums[i] = num
        if counter > max_counter:
            max_counter = counter
    for i in range(len(counters_list)):
        counter = max_counter - counters_list[i]
        if counter:
            nums[i] *= 10**counter
    return nums, max_counter
 
def difference_max_min(nums):
    '''
    Оставляет в числах списка только вещественную часть, 
    находит разницу между макс. и мин. числами
    params: nums - список целых чисел
    return: (float, float) разницы, где 1 - целая, 2 - вещественная
    '''
    nums, max_counter = change_list(nums)
    print(nums, max_counter)
    max_num, min_num = 0,nums[0]
    for num in nums:
        float_part=num % 10**max_counter
        print(float_part)
        if float_part > max_num:
            max_num = float_part
        if float_part < min_num:
            min_num = float_part
    print(f'{max_num=},{min_num=}')
    return max_num - min_num, (max_num - min_num)/10**max_counter
 
 
 
print(difference_max_min(numbers))