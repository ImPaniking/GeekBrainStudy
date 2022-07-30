# Найти сумму чисел списка стоящих на нечетной позиции

list_of_nums = [i for i in range(1,10)]

print(f"{list_of_nums} -> {sum([elem[1] for elem in (filter(lambda x: x[0]%2 != 0, enumerate(list_of_nums)))])}")
