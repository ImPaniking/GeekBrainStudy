# 2- Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности. Посмотрели, что такое множество? Вот здесь его не используйте.

from Penschii_A_Functions import fibonachi_from_minus_to_plus

list_of_fibonacci = fibonachi_from_minus_to_plus(8)

print(f"Fibbonaci : {list_of_fibonacci}")
# читерский вариант =)
# lots_of = set(list_of_fibonacci)

# print(f"Without repetitions : {lots_of}")

def list_without_duble(list_of_numbers : list) ->list:
    """Затягивает список - и выводит новый, с непвторяющимеся эллементами

    Args:
        list_of_numbers (list): Изначальный список, в котором происходит поиск эллементов

    Returns:
        list: Новый список без повторений
    """
    new_list =[list_of_numbers[0]] # я чувствую что можно на много проще даже эту мысль оформить - но нет вдохновения =) 
    for i in list_of_numbers:
        count = 1
        for j in new_list:
            if i == j:
                count +=1
        if count == 1:
            new_list.append(i)
    return new_list

# count
def list_with_no_(list_of_numbers : list) ->list:
    new_list = []
    for i in list_of_numbers:
        if list_of_numbers.count(i) == 1:
            new_list.append(i)
    return new_list

print(f"Without repetitions : {list_with_no_(list_of_fibonacci)}")
