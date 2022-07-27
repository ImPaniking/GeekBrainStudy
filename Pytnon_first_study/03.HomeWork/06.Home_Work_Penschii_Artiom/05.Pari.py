# 5- Найти произведение пар чисел в списке. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

def pari_chisel(list_num):
    new_list = []
    for i in range((int(len(list_num)//2)+int(len(list_num)%2))):
        new_list.append(list_num[i]*list_num[-1-i])
    return new_list

list_num = [1,2,3,4,5,6]

print(f"{list_num} - > {pari_chisel(list_num)}")