# with open('test.txt', 'w') as test:
#     for i in range ( 1 , 6):
#         test.write(f"{i} - Hello World\n")
# test.close()

test = open('test.txt','r')
list_of_lines =[]
for line in test:
    list_of_lines.append(line)


for i in range(0,len(list_of_lines)):
    print(list_of_lines[i])
test.close()