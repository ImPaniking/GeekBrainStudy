import random
start = 1
end = 100
start_enter = input("Игра - компьютер угадывает число! Цель - загадайте число от 1 до 100, когда готовы, нажмите Enter")
print(' И Мы начинаем! Компьютер будет угадывать число, а вы подсказывать чере :')
print('+ // загаданное число больше того что предложил компьютер')
print('- // загаданное число меньше того что предложил компьютер')
print('= // компьютер угадал! Просьба не жульничать ...')
number = random.randint(start, end+1)
simbol = None
count = 0
while simbol != "=":
    count +=1
    simbol = input("Компьютер закадал {} , оно больше - // меньше + // равно = // вашему числу ? ".format(number))
    if simbol == "=":
        print('Победа! Компьютер угадал число {} , за {} хода'.format(number,count))
    elif simbol == "+":
        start = number+1
    elif simbol == "-":
        end = number-1
    number = random.randint(start, end)