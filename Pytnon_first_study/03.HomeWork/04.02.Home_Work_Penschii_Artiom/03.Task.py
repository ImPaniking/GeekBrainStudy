# Задайте последовательность чисел. Напишите программу, которая выведет список неповторяющихся элементов исходной последовательности

from Penschii_A_Functions import fibonachi_from_minus_to_plus

list_of_fibonacci = fibonachi_from_minus_to_plus(8)

print(f"Fibbonaci : {list_of_fibonacci}")

lots_of = set(list_of_fibonacci)

print(f"Without repetitions : {lots_of}")
