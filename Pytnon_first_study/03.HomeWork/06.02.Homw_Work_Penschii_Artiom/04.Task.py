# Для натурального n создать словарь индекс-значение, состоящий из элементов последовательности 3n + 1.
# Для n = 6: {1: 4, 2: 7, 3: 10, 4: 13, 5: 16, 6: 19}

number_N = 6
new_list= { a: 3*a+1 for a in range(1,number_N+1)}
print(new_list)