import pandas as pd
import csv
import datetime as dt
import os

dict_of_rows = \
    {
        0: "User_ID",
        1: "User_Name",
        2: "User_Password",
        3: "User_email",
        4: "User_sex",
        5: "User_Type",
        6: "User_date_creation"
    }
dict_of_sex = \
    {
        0: "n/a",
        1: "male",
        2: "female",
        3: "other"
    }

def csv_creation(list_of_rows,path_to_create):
    data = [list_of_rows]

    with open(path_to_create, 'w') as f:
        writer = csv.writer(f,delimiter = ",", lineterminator="\r")
        for row in data:
            writer.writerow(row)

def csv_append(path_to_create,row):
    with open(path_to_create, 'a', newline='') as f_object:  
        # Pass the CSV  file object to the writer() function
        writer_object = csv.writer(f_object, delimiter = ",", lineterminator="\r")
        # Result - a writer object
        # Pass the data in the list as an argument into the writerow() function
        writer_object.writerow(row)  
        # Close the file object
    f_object.close()

def row_creation():
    row = [dict_of_row_functions[i] for i in dict_of_rows.values()]
    return(row)

def max_user_id():
    with open('user_base.csv') as f:
        reader = csv.reader(f)
    max = -1
    try:
        for row in reader:
            print(row)
            if row[0] > max:
                max = row[0]
    except:
        max = -1
    return max+1

def input_fun(text):
    return input(text)

def sex_coose() -> int:
    print("Choose sex from : ")
    for key,item in dict_of_sex.items():
        print(f"{key} : {item}")
    return int(input("Enter our chose : "))

dict_of_row_functions = \
    {
        "User_ID": max_user_id(),
        "User_Name": input_fun("Enter name : ") ,
        "User_Password": input_fun("Enter password : ") ,
        "User_email": input_fun("Enter email : ") ,
        "User_sex": dict_of_sex[sex_coose()],
        "User_Type": None,
        "User_date_creation": dt.datetime.now()
    }

path = 'user_base.csv'
list_of_rows = [i for i in dict_of_rows.values()]
# os.mkdir(path)
# csv_creation(list_of_rows,path)
new_list = row_creation()
print(new_list)
csv_append(path,new_list)
