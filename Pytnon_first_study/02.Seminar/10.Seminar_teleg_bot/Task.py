# 2- Создайте программу для игры с конфетами человек против человека.

# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой. 
# За один ход можно забрать не более чем 28 конфет. 
# Все конфеты оппонента достаются сделавшему последний ход. 
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?

# a) Добавьте игру против бота

# b) Подумайте как наделить бота ""интеллектом""

import Penschii_A_Functions as PF
import random

def game_players(num_of_players=2,candy_ammount=2021,aloud_ammount_on_turn=28):
    """Игра - где каждый игрок по очереди берёт доступное кол-во конфет

    Args:
        num_of_players (int, optional): Кол-во игроков Defaults to 2.
        candy_ammount (int, optional): Всего конфет. Defaults to 2021.
        aloud_ammount_on_turn (int, optional):Можно брать за раз. Defaults to 28.
    """
    list_of_players = [i for i in range(1,num_of_players+1)]
    i = 0
    while candy_ammount > 0 :
        if aloud_ammount_on_turn > candy_ammount:
            aloud_ammount_on_turn = candy_ammount
        candy_take = PF.input_number_examination(text_in_input=f"Candy left : {candy_ammount} \tPlayer {list_of_players[i]} :",case_def=3,min_num=1,max_num=aloud_ammount_on_turn)
        candy_ammount -= candy_take
        if candy_ammount == 0:
            break
        else :
            if i == num_of_players-1:
                i = 0
            else :
                i += 1

    print(f"Player {list_of_players[i]} took last candy ! he WON! ")


def game_bot_easy(candy_ammount=2021,aloud_ammount_on_turn = 28):
    """Игра против бота, бот рандомно берёт кол-во конфет

    Args:
        candy_ammount (int, optional): Всего конфет. Defaults to 2021.
        aloud_ammount_on_turn (int, optional): Кол-во конфет за ход. Defaults to 28.
    """
    start = input("Press enter to start")
    tos_a_coin = random.randint(0,2)
    if tos_a_coin == 0:
        list_of_players = ["Player","Bot"]
        print("Player go first \n")
    else:
        list_of_players = ["Bot","Player"]
        print("Bot go first \n")
    i = 0
    while candy_ammount > 0 :
        if aloud_ammount_on_turn > candy_ammount:
            aloud_ammount_on_turn = candy_ammount
        if list_of_players[i] == "Player":
            candy_take = PF.input_number_examination(text_in_input=f"Candy left : {candy_ammount} \t{list_of_players[i]} :",case_def=3,min_num=1,max_num=aloud_ammount_on_turn)
        else:
            candy_take = random.randint(1,aloud_ammount_on_turn)
            print(f"Candy left : {candy_ammount} \t{list_of_players[i]} : {candy_take}")
        candy_ammount -= candy_take
        if candy_ammount == 0:
            break
        else :
            if i == 1:
                i = 0
            else :
                i = 0

    print(f"Player {list_of_players[i]} took last candy ! he WON! ")


def game_2_bots_easy(candy_ammount = 2021 ,aloud_ammount_on_turn = 28):
    """Игра 2 ботов , каждый из которых берёт рандомное кол-во конфет

    Args:
        candy_ammount (int, optional): Кол-во всего конфет. Defaults to 2021.
        aloud_ammount_on_turn (int, optional): Кол-во конфет за раз. Defaults to 28.
    """
    start = input("Press enter to start")
    tos_a_coin = random.randint(0,2)
    if tos_a_coin == 0:
        list_of_players = ["Player","Bot"]
        print("Player go first \n")
    else:
        list_of_players = ["Bot","Player"]
        print("Bot go first \n")
    i = 0
    while candy_ammount > 0 :
        if aloud_ammount_on_turn > candy_ammount:
            aloud_ammount_on_turn = candy_ammount
        
        if candy_ammount <= aloud_ammount_on_turn*2 and candy_ammount > 29:
            candy_take = candy_ammount - 29
        elif candy_ammount <= aloud_ammount_on_turn:
            candy_take = candy_ammount
        else:
            candy_take = random.randint(1,aloud_ammount_on_turn)

        print(f"Candy left : {candy_ammount} \t{list_of_players[i]} : {candy_take}")
        candy_ammount -= candy_take
        if candy_ammount == 0:
            break
        else :
            if i == num_of_players-1:
                i = 0
            else :
                i += 1

    print(f"Player {list_of_players[i]} took last candy ! he WON! ")


def game_bot_2_medium(candy_ammount=2021,aloud_ammount_on_turn = 28):
    """В этом варианте - бот по концеове старается выйграть , точнее если игрок не будет просчитывать ходы - бот точно выйграет

    Args:
        candy_ammount (int, optional): Кол-во конфет всего. Defaults to 2021.
        aloud_ammount_on_turn (int, optional): Кол-во конфет за ход. Defaults to 28.
    """
    start = input("Press enter to start")
    tos_a_coin = random.randint(0,2)
    if tos_a_coin == 0:
        list_of_players = ["Player","Bot"]
        print("Player go first \n")
    else:
        list_of_players = ["Bot","Player"]
        print("Bot go first \n")
    i = 0
    while candy_ammount > 0 :
        if aloud_ammount_on_turn > candy_ammount:
            aloud_ammount_on_turn = candy_ammount
        if list_of_players[i] == "Player":
            candy_take = PF.input_number_examination(text_in_input=f"Candy left : {candy_ammount} \t{list_of_players[i]} :",case_def=3,min_num=1,max_num=aloud_ammount_on_turn)
        else:
            if candy_ammount >= aloud_ammount_on_turn*2+1 and candy_ammount < aloud_ammount_on_turn*3:
                candy_take = candy_ammount - (aloud_ammount_on_turn*2) 
            elif candy_ammount <= aloud_ammount_on_turn*2 and candy_ammount > 29:
                candy_take = candy_ammount - 29
            elif candy_ammount <= aloud_ammount_on_turn:
                candy_take = candy_ammount
            else:
                if candy_ammount <= aloud_ammount_on_turn*2 and candy_ammount > 29:
                    candy_take = candy_ammount - 29
                elif candy_ammount <= aloud_ammount_on_turn:
                    candy_take = candy_ammount
                else:
                    candy_take = random.randint(1,aloud_ammount_on_turn)
            print(f"Candy left : {candy_ammount} \t{list_of_players[i]} : {candy_take}")
        candy_ammount -= candy_take
        if candy_ammount == 0:
            break
        else :
            if i == num_of_players-1:
                i = 0
            else :
                i += 1

    print(f"Player {list_of_players[i]} took last candy ! he WON! ")

candy_ammount = 2021
aloud_ammount_on_turn = 28

print(f"Игра - забери последнюю конфету !\nправила: есть {candy_ammount}\nза раз можно взять {candy_ammount}\nцель, забрать последнюю конфету !\n")
print("есть выбор :\n1 - игра с компанией, от 2 до 6 человек\n2 - посмотреть как играют 2 бота\n4 - игра против слабого бота\n3 - игра против среднего бота\n")
coise_case = PF.input_number_examination(text_in_input="Выш выбор : ", case_def= 3, min_num=1,max_num=4)
match coise_case:
    case 1:
        num_of_players = PF.input_number_examination(text_in_input="Кол-во игроков от 2х до 6и : ", case_def= 3, min_num=2,max_num=6)
        game_players(num_of_players,candy_ammount,aloud_ammount_on_turn)
    case 2:
        game_bot_easy(candy_ammount,aloud_ammount_on_turn)
    case 3:
        game_2_bots_easy(candy_ammount,aloud_ammount_on_turn)
    case 4:
        game_bot_2_medium(candy_ammount,aloud_ammount_on_turn)