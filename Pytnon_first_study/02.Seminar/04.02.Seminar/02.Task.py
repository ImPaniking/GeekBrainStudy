with open ('test.txt' , 'r' , encoding='utf-8') as file:
    read_file = file.read()
    list_of_rows = read_file.split()
    print(read_file)