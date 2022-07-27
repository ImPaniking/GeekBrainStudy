# 1- Определить, присутствует ли в заданном списке строк, некоторое число

def look_up_number(text_were_to_look : str,number_to_look_up : str):
    return len(list(filter(lambda a : a in number_to_look_up, text_were_to_look.split()))) > 0


text = "My name is artiom, im 31 year's old"
number = "25"
print(f"{number} in text : '{text}' - > is {look_up_number(text,number)}")