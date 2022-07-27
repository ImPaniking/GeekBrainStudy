# 6-Сформировать список из  N членов последовательности.
# Для N = 5: 1, -3, 9, -27, 81 и т.д.

def posled(number_N):
    list_of_num = [1]
    for i in range(1,number_N):
        list_of_num.append(list_of_num[i-1]*-3)
    return list_of_num

number_N=5
print(f"For N = {number_N} -> {posled(number_N)}")
