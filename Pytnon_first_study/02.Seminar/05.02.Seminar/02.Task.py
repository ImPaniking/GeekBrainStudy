# 1. Если закончите обсуждение и нечем будет заняться, то вот вам задача посложнее:
# Дан список чисел. Создать список в который попадают числа, описывающие возрастающую последовательность и содержащие максимальное количество элементов. 

    
#     *Пример:* 
    
#     Пример: [1, 5, 2, 3, 4, 6, 1, 7] => [1, 2, 3, 4, 6, 7]
#     [5, 2, 3, 4, 6, 1, 7] => [2, 3, 4, 6, 7]

    

list_input = [1, 5, 2, 3, 4, 6, 1, 7]

second_list_dic = {}

def max_in_list(list_of_numbers):
    max = list_of_numbers[0]
    for i in list_of_numbers:
        if i > max:
            max = i
    return max

new_list_dic = {}


index = 0

for n in range(1,len(list_input)):
    for i,item in enumerate(list_input[:-n]):
        new_list = [list_input[i]]
        for j,item_2 in enumerate(list_input[i+n:]):
            if item_2 > max_in_list(new_list):
                new_list.append(item_2)
       
        if new_list not in new_list_dic.values():
            new_list_dic[index] = new_list
            index += 1

# for i in new_list_dic:
#     print(f"{i} : \t{new_list_dic[i]}")

max_list_index = -1
max_list = 0
for i in range(0,len(new_list_dic)):
    if len(new_list_dic[i]) > max_list:
        max_list = len(new_list_dic[i])
        max_list_index = i

print(f"{list_input} => {new_list_dic[max_list_index]}")


