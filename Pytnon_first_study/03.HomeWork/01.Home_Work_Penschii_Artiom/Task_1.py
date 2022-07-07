# 1- Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

# *Пример:*

# - 6 -> да
# - 7 -> да
# - 1 -> нет

week_days = {1:"Пн",2:"Вт",3:"Ср",4:"Чт",5:"Пт",6:"Сб",7:"Вс"}

int_test = True

while int_test:
    week_day_number = input("Enter day of week : ")
    if week_day_number.isdigit():
        week_day_number = int(week_day_number)
        if week_day_number >= 1 and week_day_number <= 7:
            int_test = False
        else :
            print("There no such day of week< try again")
    else :
        print("Not a number , try again")

if week_day_number == 6 or week_day_number == 7:
    print(f"{week_day_number} {week_days[week_day_number]}- > Yes ")
else :
    print(f"{week_day_number} {week_days[week_day_number]}- > No ")