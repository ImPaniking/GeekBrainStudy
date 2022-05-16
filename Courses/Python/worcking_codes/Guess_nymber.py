#Создание случайного числа
import random

# Внесение случайного числа в переменную, где 1 - начало, 100 , конец
number = random.randint(1, 100)
print('Компьютер загадал число от 1 до 100 - попробуйте отгдадать число! ')
user_number = 0
count = 0

# Создание уровня сложности
# Словарь уровней сложности - можно рассширить
difficulty_levels = {1: 10, 2: 5, 3: 3}
level = int(input(
    'Выберите уровень сложности из {},где уровень:попытки :'.format(difficulty_levels)))
print(" Вы выбрали уровень c {} попытками".format(difficulty_levels[level]))
max_count = difficulty_levels[level]

# Цикл ввода числе
while number != user_number:
    count += 1
    if count > max_count:  # прерыватель цикла при заканчивании попыток
        print('Вы исчерпали свои попытки =( ')
        break
    user_number = int(input('Попытка № {} ,введите число : '.format(count)))
    if number > user_number:
        print('Введённое число меньше загаданного, осталось {} попыток'.format(
            max_count-count))
    elif number < user_number:
        print('Введённое число больше загаданного, осталось {} попыток'.format(
            max_count-count))
else:  # так как есть Break - этот else НУЖЕН - что бы при выходе из цикла не писало победа
    count = str(count)
    last_simb_count = int(count[-1])
    if last_simb_count == 1:
        print('Поздравляем! вы угадали число за {} ход'.format(count))
    elif last_simb_count <= 4:
        print('Поздравляем! вы угадали число за {} хода'.format(count))
    else:
        print('Поздравляем! вы угадали число за {} ходов'.format(count))
