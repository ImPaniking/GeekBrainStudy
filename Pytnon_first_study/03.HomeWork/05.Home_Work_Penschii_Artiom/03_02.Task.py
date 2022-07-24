# 3-Создайте два списка — один с названиями языков программирования, другой — с числами от 1 до длины первого.
# ['python', 'c#']
# [1,2]
# Вам нужно сделать две функции: первая из которых создаст список кортежей, состоящих из номера и языка, написанного большими буквами.
# [(1,'PYTHON'), (2,'C#')]
# Вторая — которая отфильтрует этот список следующим образом: если сумма очков слова имеет в делителях номер, с которым она в паре в кортеже, то кортеж остается, его номер заменяется на сумму очков.
# [сумма очков c# = 102, в делителях есть 2 с которым в паре. Значит список будет]
# [(1,'PYTHON'), (102,'C#')]

list_of_lenguages = ["Python","C#","Ruby","HTML","JAVA","JS"]
list_of_orded = [i for i in range(1,len(list_of_lenguages)+1)]

list_for_task = list(zip(list_of_orded,list_of_lenguages))

print(list_for_task)

new_list_for_task = []
for i,item in enumerate(list_for_task):
    sum_of_char_code = 0
    for j in item[1]:
        sum_of_char_code += ord(j)
    print(f"{list_for_task[i][1]} => {sum_of_char_code} % {list_for_task[i][0]} => {sum_of_char_code%list_for_task[i][0] == 0}")
    if sum_of_char_code%list_for_task[i][0] == 0:
        new_list_for_task.append((sum_of_char_code,item[1]))

print(new_list_for_task)