# Пользователь вводит 3 числа
# Нужно найти минимальное, максимальное и сумму 

numbers =[]

for i in range (3):
    number = int(input(" Введите число : "))
    numbers.append(number)

print(" Маинимальное число {} , максимальное число {} и их сумма = {}".format(min(numbers),max(numbers),sum(numbers)))

def filter(numbers , function):
    result = []
    for number in numbers:
        if function(number):
            result.append(number)
    return result

numbers = [1 , 2 , 3 , 4 , 5 , 6 , 7 , 10 , 15 , ]

def is_even(number):
    return number % 2 == 0

def is_noteven(number):
    return number % 2 != 0

def is_more(number):
    return number > 4

print(filter(numbers , is_even))
print(filter(numbers , is_noteven))
print(filter(numbers , is_more))

#Практическое задание
#1: Создайте функцию, принимающую на вход имя, возраст и город проживания человека. Функция должна возвращать строку вида «Василий, 21 год(а), проживает в городе Москва

#1.1 Easy variant
def function_write(name , age , city):
    print("{}, {} год(а), проживает в городе {}".format(name,age,city))

name = input(" Введите имя : ")
age = input(" Введите возраст : ")
city = input(" Введите город проживания : ")

function_write(name , age , city)

##1.2 Две функции
def function_write(name , age , city):
    print("{}, {} год(а), проживает в городе {}".format(name,age,city))

def enter():
    return input("Введите : ")

function_write(enter() , enter() , enter())

#1.3 Пример решения по уроку

def person_info(name , age , city):
    result = f'{name} , {age} год(а), проживает в городе {city}'
    return result

print(person_info("Василий" , 21 , "Москва"))

# 2: Создайте функцию, принимающую на вход 3 числа и возвращающую наибольшее из них.

#2.1 Лёгкий вариант

def maximum(numbers):
    print(max(numbers))

numbers = [10,2,3]

maximum(numbers)

#2.2 Вариант с функцией ввода

numbers = []

def enter():
    for i in range(3):
        number = int(input (" Введите число: "))
        numbers.append(number)
    return numbers

def maximum(numbers):
    print("Максимальное число - {} ".format(max(numbers)))

maximum(enter())

#2.3 Улучшение - не важно сколько цифр вводим 

numbers = []

def enter(number_count):
    for i in range(number_count):
        number = int(input (" Введите число: "))
        numbers.append(number)
    return numbers

def maximum(numbers):
    print("Максимальное число - {} ".format(max(numbers)))

number_count = int(input(" Кол-во цифр : "))
maximum(enter(number_count))

#2.4 Пример решения с лекции

def get_max(a,b,c):
    result=max[(a,b,c)]
    return result

print(get_max(10,5,4))

#3: Давайте опишем пару сущностей player и enemy через словарь, который будет иметь ключи и значения:
#name - строка полученная от пользователя,
#health = 100,
#damage = 50. 
# Поэкспериментируйте с значениями урона и жизней по желанию. 
# Теперь надо создать функцию attack(person1, person2). 
# Примечание: имена аргументов можете указать свои. 
# Функция в качестве аргумента будет принимать атакующего и атакуемого.
# В теле функция должна получить параметр damage атакующего и отнять это количество от health атакуемого.
# Функция должна сама работать со словарями и изменять их значения.

#3.1 - Вариант 1

player = {
    "name":input(" Player name : ") , 
    "health":1000, 
    "damage":50
    }

enemy = {
    "name":input(" Enemy name : ") , 
    "health":5000, 
    "damage":10
    }

def attac(attaker , attaked):
    attaked['health'] = attaked['health'] - attaker['damage']

while enemy['health'] >0 and player['health']>0:
    attac(player,enemy)
    if enemy['health']<=0 :
        break
    attac(enemy,player)

print(player)
print(enemy)

if player['health'] > enemy['health']:
    print("{} is the winner ".format(player['name']))
else:
    print("{} is the winner ".format(enemy['name']))

    #3.2 Пример решения с лекции
player_name=input("Enter player name : ")

player = {
    "name":player_name , 
    "health":1000, 
    "damage":50
    }
enemy_name=input("Enter player name : ")

enemy = {
    "name":enemy_name , 
    "health":5000, 
    "damage":10
    }

def attack(attaker , attaked):
    attaked["health"] -= attaker["damage"]

attack(player , enemy)

#4. Давайте усложним предыдущее задание. Измените сущности, добавив новый параметр - armor = 1.2 (величина брони персонажа)
player = {
    "name":input(" Player name : ") , 
    "health":1000, 
    "damage":50,
    "armor": 1.2
    }

enemy = {
    "name":input(" Enemy name : ") , 
    "health":5000, 
    "damage":10,
    "armor": 1.2
    }

def attac(attaker , attaked): 
    def damage_funct(attaker , attaked):
        damage = round(attaker['damage']/attaked['armor'],0)
        return damage
    attaked['health'] = attaked['health'] - damage_funct(attaker,attaked)
    #print("{} атаковал {} на {} урона".format(attaker['name'],attaked['name'],damage_funct(attaker,attaked)))

while enemy['health'] >0 and player['health']>0:
    attac(player,enemy)
    if enemy['health']<=0 :
        break
    attac(enemy,player)

print(player)
print(enemy)

if player['health'] > enemy['health']:
    print("{} is the winner ".format(player['name']))
else:
    print("{} is the winner ".format(enemy['name']))

#4.2 Пример решения с лекции

player_name=input("Enter player name : ")

player = {
    "name":player_name , 
    "health":1000, 
    "damage":50,
    "armor" :1.2
    }
enemy_name=input("Enter player name : ")

enemy = {
    "name":enemy_name , 
    "health":5000, 
    "damage":10,
    "armor" :1.2
    }

def damage_call(damage , armor):
    return damage/armor

def attack(attaker , attaked):
    damage = damage_call(attaker["damage"] , attaked["armor"])
    attaked["health"] -= damage

attack(player , enemy)
