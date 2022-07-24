# Создайте программу для игры в ""Крестики-нолики"".

import Penschii_A_Functions as PF
import os

def print_game_board(game_list : list):
    """Печатает доску для игры

    Args:
        game_list (list): Принимает на вход доску для игры
    """
    os.system('cls')
    for i in game_list:
        result = ""
        for j in i:
            result += f"\t{j}"
        print(result)
        print("\n")

game_list = []
pos_dic ={}

# у меня очень сильное ощущение что я мог бы обойтись только словарём... 
# Если вкратце - у меня создаётся массив, в который записываются номера от 1 до 9. Что бы не играться с координатами 
# потом я делаю словарь с этими координатами.
# пока пишу явно понимаю что одно из этих дейсвтий лишнее , но работает и я боюсь это менять =) 

index = 1
for i in range(0,3):
    list_new = []
    for j in range(0,3):
        list_new.append(index)
        index +=1
    game_list.append(list_new)

print_game_board(game_list)

for i in range(0,3):
    for j in range(0,3):
        pos_dic[game_list[i][j]] = [i,j]

# Это проверка на выйгрышные позиции - из-за того что я использую и словарь и списко - пришлось напрячь голову что бы всё прописать.
# из-за того что в питоне работаем через список в списке а не в чистом массиве - я не смог придумать алгоритм проверки 
# Хотя пока пишу комментарий - понимаю что стоило сделать циклы - сначала пробегать по строкам, потом по столбцам, потом по диагоналям... не знаю если написани такого кода было бы быстрее =)

def win_chek(pos_dic : dict,game_list : list) -> bool:
    win_bool = False
    if game_list[pos_dic[1][0]][pos_dic[1][1]] == game_list[pos_dic[2][0]][pos_dic[2][1]] == game_list[pos_dic[3][0]][pos_dic[3][1]]:
        win_bool = True
    elif game_list[pos_dic[4][0]][pos_dic[4][1]] == game_list[pos_dic[5][0]][pos_dic[5][1]] == game_list[pos_dic[6][0]][pos_dic[6][1]]:
        win_bool = True
    elif game_list[pos_dic[7][0]][pos_dic[7][1]] == game_list[pos_dic[8][0]][pos_dic[8][1]] == game_list[pos_dic[9][0]][pos_dic[9][1]]:
        win_bool = True
    elif game_list[pos_dic[1][0]][pos_dic[1][1]] == game_list[pos_dic[4][0]][pos_dic[4][1]] == game_list[pos_dic[7][0]][pos_dic[7][1]]:
        win_bool = True
    elif game_list[pos_dic[2][0]][pos_dic[2][1]] == game_list[pos_dic[5][0]][pos_dic[5][1]] == game_list[pos_dic[8][0]][pos_dic[8][1]]:
        win_bool = True
    elif game_list[pos_dic[3][0]][pos_dic[3][1]] == game_list[pos_dic[6][0]][pos_dic[6][1]] == game_list[pos_dic[9][0]][pos_dic[9][1]]:
        win_bool = True
    elif game_list[pos_dic[1][0]][pos_dic[1][1]] == game_list[pos_dic[5][0]][pos_dic[5][1]] == game_list[pos_dic[9][0]][pos_dic[9][1]]:
        win_bool = True
    elif game_list[pos_dic[3][0]][pos_dic[3][1]] == game_list[pos_dic[5][0]][pos_dic[5][1]] == game_list[pos_dic[7][0]][pos_dic[7][1]]:
        win_bool = True
    return win_bool


player_turn = 2
turns_count = 0
# ну и тут сам код игры

while not win_chek(pos_dic,game_list) and turns_count != 9:

    if player_turn == 1:
        player_turn = 2
    else:
        player_turn = 1
    position_bool = True
    print("Введите номер ячеки куда поставить символ от 1 до 9 : ")
    while position_bool:
        possition_to_put = PF.input_number_examination(text_in_input=f"Игрок {player_turn} ",case_def=3,min_num=1,max_num=9) # ввод числа от 1 до 9
        if game_list[pos_dic[possition_to_put][0]][pos_dic[possition_to_put][1]] == possition_to_put : # проверка - если эта ячейка уже занята
            if player_turn == 1:
                game_list[pos_dic[possition_to_put][0]][pos_dic[possition_to_put][1]] = "X" # Х если игрок 1
                position_bool = False
            else :
                game_list[pos_dic[possition_to_put][0]][pos_dic[possition_to_put][1]] = "O" # О если игрок 2
                position_bool = False
        else:
            print("Ячейка занята, попробуйте другую")

    turns_count += 1 # Считает кол-во ходов, на 9 по идее доска заканчивается

    print_game_board(game_list) # после каждого хода перепечатывает доску для наглядности

if turns_count == 9 and not win_chek(pos_dic,game_list): # возникла идея что может последним ходом кто-то может выйграть , я не силён в этой игре =)
    print(f"Победила дружба !")
else:
    print(f"Игрок {player_turn} выйграл")




