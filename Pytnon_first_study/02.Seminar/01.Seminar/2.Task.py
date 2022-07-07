# Пользователь вводит количество дней, указывает процент скидки и вводит сумму. Рассчитать прибыль, если за каждый день сумма увеличивается на 3 $  и затем применяется скидка, то есть итоговая сумма еще увеличивается на данное число процентов.

days = int(input("Enter day's ammount : "))
disount = float(input("Enter discount : "))
if disount > 1 :
    disount /= 100
sum_of_money = float(input("Enter sum of monet : "))

index = 0

while index < days:
    sum_of_money += 3
    index+=1

sum_of_money *= (1+disount)

print(f"Final money ammount = {sum_of_money:.2f} $ ")

# Дано значение температуры в градусах Цельсия. Вывести температуру  в градусах Фаренгейта.

celcius = int(input("Enter celcius : "))

print(f"{celcius} °C = {(celcius*9/5) + 32:.2f} °F")

# Пользователь вводит время в минутах и расстояние в километрах. Найдите скорость в м/c.

minutes = int(input("Enter time in minutes : "))
kilometers = int(input("Enter distance in km : "))

print(f"Speed = ")