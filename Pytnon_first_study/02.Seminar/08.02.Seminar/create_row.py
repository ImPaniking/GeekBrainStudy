import dict as D
import json

def take_from_base(path = 'students.json'):
    with open(path, 'r') as infile:
        data = json.load(infile)
        infile.close()
    return data

def rewrite_base(dictionary,path = 'students.json'):
    with open(path, 'w') as outfile:
        json.dump(dictionary, outfile,indent=2)
        outfile.close()

def student_row_creation(
    Name = "",
    SirName = "",
    Sex = 1,
    BirthDay = "",
    Class = 0 ,
    Class_type = 1
):
    stud_dic = take_from_base()
    # stud_dic = {}
    Marcs_dict = {}
    LCP_dict = {}
    person = \
        {
        "Name" : Name,
        "SirName" : SirName,
        "Sex" : D.sex_dic[Sex],
        "Birth Day" : BirthDay,
        "Class" : Class,
        "Clss-type" : D.class_dict[Class_type],
        "Marcs Status"  : Marcs_dict,
        "LCP" : LCP_dict 
        }
    stud_dic[int(max(stud_dic.keys()))+1] = person
    return stud_dic

def pop_student(ID_student,data:dict):
    new_dict = data
    new_dict.pop(ID_student)
    return new_dict

def look_up_name(Name : str,data : dict):
    return dict(filter(lambda x : x[1]["Name"] == Name , data.items()))


# rewrite_base(pop_student('3',take_from_base()))

# rewrite_base(student_row_creation(
#     Name = "Ilia",
#     SirName = "A",
#     Sex = 1,
#     BirthDay = "31/03/1991",
#     Class = 11 ,
#     Class_type = 1
# ))
# print(look_up_name("Ilia",take_from_base()))
