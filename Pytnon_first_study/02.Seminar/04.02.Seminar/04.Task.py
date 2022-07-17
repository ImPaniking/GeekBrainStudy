# 3. Создать текстовый файл (не программно). Построчно записать фамилии сотрудников и величину их окладов (не менее 10 строк). Определить, кто из сотрудников имеет оклад менее 20 тысяч, вывести фамилии этих сотрудников. Выполнить подсчёт средней величины дохода сотрудников.
# Пример файла:

# Иванов 23543.12
# Петров 13749.32


file = open('Salary.txt' , "r",encoding='utf-8')
data = file.read()
list_of_rows = data.split('\n')
file.close()

salary_dic ={}

for i in list_of_rows:
    name,salary = i.split()
    salary_dic[name] = salary

# print(salary_dic)

list_of_names =[]

for i in salary_dic:
    if float(salary_dic[i]) < 20000:
        list_of_names.append(i)
print("people who has salary less then 20 000 \n")
for i in list_of_names:
    print(f"{i} : {salary_dic[i]}")

result = 0
count =0
for i in salary_dic:
    count += 1
    result += float(salary_dic[i])
result /= count

print(f"\naverage salary : {result:.2f}")
