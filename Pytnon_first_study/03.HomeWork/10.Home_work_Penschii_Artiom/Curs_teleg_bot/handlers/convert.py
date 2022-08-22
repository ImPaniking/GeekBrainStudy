from email.message import Message
from bot_create import dp,bot
from aiogram import types , Dispatcher
from aiogram.dispatcher.filters import Text
from keyboards.convert_kb import bank_kb

import asyncio
import logging

logging.basicConfig(level=logging.INFO)

global bank,abr,type1,Buy_Sell
bank = None
abr = None
type1 = None
Buy_Sell = None

# @dp.message_handler(commands=['/Конвертор','/конв','/conv'])
async def curs_command(message : types.Message):
    global bank,abr,type1,Buy_Sell
    bank = None
    abr = None
    type1 = None
    Buy_Sell = None
    await message.answer(f"Выбор банка : " , reply_markup=bank_kb)

@dp.callback_query_handler(Text(startswith='Bank_'))
async def abr_bot(callback : types.CallbackQuery):
    global bank
    bank = callback.data.split('_')[1]
    from keyboards.convert_kb import abr_kb_creationn
    await bot.edit_message_text(f"Выбор Валюты : " ,callback.from_user.id, callback.message.message_id, reply_markup=abr_kb_creationn(bank))

@dp.callback_query_handler(Text(startswith='Abr_'))
async def typy_but(callback : types.CallbackQuery):
    global bank,abr
    abr = callback.data.split('_')[1]
    from keyboards.convert_kb import type_kb_creationn
    await bot.edit_message_text(f"Выбор Типа операции : " ,callback.from_user.id, callback.message.message_id, reply_markup=type_kb_creationn(bank,abr))

@dp.callback_query_handler(Text(startswith='Type_'))
async def BS_but(callback : types.CallbackQuery):
    global type1
    type1 = callback.data.split('_')[1]
    from keyboards.convert_kb import BS_kb
    await bot.edit_message_text(f"Выбор Купить Валюту или Продать Валюту : " ,callback.from_user.id, callback.message.message_id, reply_markup=BS_kb)

@dp.callback_query_handler()
async def BS_but(callback : types.CallbackQuery):
    global Buy_Sell
    Buy_Sell = callback.data.split('_')[1]
    await callback.answer('Напишите в чат цифру для перевода,\n начиная с = , \nпример : =5000.50:', show_alert=True)

# @dp.message_handler(Text(startswith='='))
async def curs_send(message : types.Message):
    global bank,abr,type1,Buy_Sell
    number = None
    try :
        number = float(message.text.split('=')[1])
    except:
        None
    if bank != None and abr != None and type1 != None and Buy_Sell != None:
        from curs_md import curs_Moldova
        data = curs_Moldova()
        curs = float(list(data[Buy_Sell][(data['Bank'] == bank)&(data['Abr'] == abr)&(data['Type'] == type1)])[0])
        if Buy_Sell == 'Sell':
            await message.reply(f"{number:.2f}{abr} = {number*curs:.2f}MDL")
        elif Buy_Sell == 'Buy':
            await message.reply(f"{number:.2f}MDL = {number/curs:.2f}{abr}")
    else:
        None


def register_hendlers_convert(dp : Dispatcher):
    dp.register_message_handler(curs_command , commands = ['Конвертор','конв','conv'])
    dp.register_message_handler(curs_send,Text(startswith='='))
    # dp.register_message_handler(curs_curs_command , commands=['curs','курс'])