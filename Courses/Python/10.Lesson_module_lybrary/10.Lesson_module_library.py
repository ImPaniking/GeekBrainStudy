import math
import random
import os
import sys
#1. math примеры
##1.1.Найти длину окружности с определённым радиусом
def circle_len(rad):
    circlelen = 2 * rad * math.pi
    return circlelen

rad = int(input("Enter radius : "))

print(circle_len(rad))
##1.2. Найти площадь окружности
def circle_space(rad):
    circlelen = math.pow(rad , 2) * math.pi
    return circlelen

print(circle_space(rad))
##1.3. По координатам 2х точек вычеслить расстояние
x1 = 10
y1 = 10
x2 = 50
y2 = 100
l = math.sqrt(math.pow(x1-x2 , 2) + math.pow(y1-y2 , 2))
print("Расстояние {}".format(l))
l = math.sqrt((x1-x2)**2 + (y1-y2)**2)
print("Расстояние {}".format(l))
##1.4. Найти факториал 9
fac = 9
print(math.factorial(fac))
#2. random примеры
##2.1 Вывести случайное число от 0 до 100
print(random.randint(0 , 100))
##2.2 Выбрать случайного победителя из списка players
players = ["Max" , "Leo" , "Kate" , "Ion" , "Kristy" , "Andy" , "Sofia"]
print(random.choice(players))
##2.3 Выбрать 3х победителей из списка players
print(random.sample(players , 3))
##2.4 Перемешать карты в стопке
cards = ["6" , "7" , "8" , "9" , "10" , "В" , "Д" , "К" , "Т"]
random.shuffle(cards)
print(cards)

#Модуль OS

## Имя операцонной системы
print(os.name)
## Текущая рабочая дирректория
print(os.getcwd())
## Создаём новый путь - мягко говоря - создаёт путь, который можно использовать в перменной
new_path = os.path.join(os.getcwd() , 'new_f') # Где после запятой - можно указать даже несуществующие файлы
## Создаём папку
os.mkdir(new_path)

#Модуль SYS

# путь до инепретатора
print(sys.executable)
# информация о платформе
print(sys.platform)
# Выход из python
sys.exit

print("Код не успеет отработать")

# path - выводит пути в которых ищет модули
for p in sys.path:
    print(p)
# добавление пути к модулу, важно - путь указать до того как импортируем модуль
sys.path.append('D:')

#Test - создание папок =) 
name = sys.platform

for i in range (1 , 6):
    new_path =os.path.join(os.getcwd() , "{}_{}".format(name,i))
    os.mkdir(new_path)
