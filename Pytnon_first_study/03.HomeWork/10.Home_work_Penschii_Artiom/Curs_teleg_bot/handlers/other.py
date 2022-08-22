from aiogram import types , Dispatcher
from aiogram.dispatcher.filters import Text
import json,string
from bot_create import dp,bot
import pyjokes
from prettytable import PrettyTable
from curs_md import curs_OTP


# @dp.message_handler(commands=['joke'])
async def joke_command(message : types.Message):
    await message.answer(pyjokes.get_joke())

# @dp.message_handler(commands=['joke'])
async def table_command(message : types.Message):
    from curs_md import test_list_print
    await message.answer(test_list_print())

# @dp.message_handler()
async def echo_send(message : types.Message):
    # Фильтр введённого текста на мат - Вкратце:
    # Сплитит текст по проблеу
    # Переводит всё в нижний регистр
    # Заменяет символику из string.punctuation в пусто
    # потом использует функцию пересечения
    if {i.lower().translate(str.maketrans('' , '' , string.punctuation)) for i in message.text.split(' ')}\
        .intersection(set(json.load(open("Dicts/not_to_use_words.json")))) != set():
        await message.reply("Маты запрещены.")
        await message.delete()      


def register_hendlers_other(dp : Dispatcher):
    dp.register_message_handler(joke_command , commands=['joke'])
    dp.register_message_handler(table_command , commands=['table'])
    dp.register_message_handler(echo_send)