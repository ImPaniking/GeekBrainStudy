# 2) Задача: предложить улучшения кода для уже решённых задач с помощью использования **лямбд, filter, map, zip, enumerate, list comprehension

# Дана последовательность чисел. Получить список уникальных элементов заданной последовательности.
# Пример:

# [1, 2, 3, 5, 1, 5, 3, 10] => [2, 10]



list_of_nums = [1, 2, 3, 5, 1, 5, 3, 10]

list_new = list(filter(lambda a : list_of_nums.count(a) == 1, list_of_nums))

print(f"{list_of_nums} -> {list_new}")