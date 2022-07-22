# 4- В текстовом файле удалить все слова, которые содержат хотя бы одну цифру.
# В файле содержится, например:
# Мама сшила м0не штаны и7з бере9зовой кор45ы 893. -> Мама сшила штаны.

# file = open('Text.txt' , "w",encoding='utf-8')
# file.write("Мама сшила м0не , штаны и7з бере9зовой кор45ы 893 .")
# file.close()


path = 'Text.txt'

def del_word_witn_num(path: str) -> str:
    """Удаляет слова с цифрами в них 

    Args:
        path (str): путь к файлу

    Returns:
        str: Изначальная строка и результат после удаления 
    """
    file = open('Text.txt' , "r",encoding='utf-8')
    data = file.read()
    list_of_words = data.split()
    file.close()

    new_list = []
    for i in list_of_words:
        delete_bool = False
        for n in i:
            if n.isdigit():
                delete_bool = True
                break
        if delete_bool == False:
            new_list.append(i)

    # for i in range(0,len(new_list)):
    #     result += new_list[i]
    #     if i >= 0 and i < len(new_list):
    #         result += " "

    return  f"{list_of_words} -> " + " ".join(new_list) # как воспринять точку или знак препинания , не как часть слова - не могу придумать
    
print(del_word_witn_num(path))