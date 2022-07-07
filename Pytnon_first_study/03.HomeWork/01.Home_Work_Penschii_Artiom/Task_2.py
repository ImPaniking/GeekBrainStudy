# 2- Напишите программу для. проверки истинности утверждения ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат.

# X = True
# Y = True
# Z = True
# result = bool(not(X and Y and Z) == -X or -Y or -Y)
# print(result)

# for x in range(0,2):
#     for y in range(0,2):
#         for z in range(0,2):
#             print(f"{x}/{y}/{z} {bool(not(x and y and z) == -x or -y or -z)}")

# я скажу честно - никогда не любил такие штуки
# и пока не помгу придумать как это с 1 и 0 сделать , что бы работало крректно 

print(f"x/y/z - x and y - and z -  not() - not x or not y - or not z- > not (x and y and z) == (not x or not y or not z)")
for x in range(0,2):
    x = bool(x == 1)
    for y in range(0,2):
        y = bool(y == 1)
        for z in range(0,2):
            z = bool(z == 1)
            print(f"{x}/{y}/{z} - {x and y} - {(x and y) and z} -  {not((x and y) and z)} - {not x or not y} - {(not x or not y) or not z}- >{ not (x and y and z) == (not x or not y or not z)}")