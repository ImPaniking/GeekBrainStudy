from aiogram.types import InlineKeyboardButton,InlineKeyboardMarkup

bank_kb = InlineKeyboardMarkup(row_width=1)
from curs_md import bank_list
button_dict = bank_list()
new_list = []
for i in button_dict:
    new_list.append(InlineKeyboardButton(text = i, callback_data = f'Bank_{i}'))
bank_kb.add(*new_list)

def abr_kb_creationn(bank):
    abr_kb = InlineKeyboardMarkup(row_width=4)
    from curs_md import abr_list
    button_dict = abr_list(bank)
    new_list = []
    for i in button_dict:
        new_list.append(InlineKeyboardButton(text = i, callback_data = f'Abr_{i}'))
    return abr_kb.add(*new_list)

def type_kb_creationn(bank,abr):
    type_kb = InlineKeyboardMarkup(row_width=4)
    from curs_md import type_list
    button_dict = type_list(bank,abr)
    new_list = []
    for i in button_dict:
        new_list.append(InlineKeyboardButton(text = i, callback_data = f'Type_{i}'))
    return type_kb.add(*new_list)

BS_kb = InlineKeyboardMarkup(row_width=2)
Buy_b = InlineKeyboardButton(text = 'MDL to Valuta', callback_data = 'BS_Buy')
Sell_b = InlineKeyboardButton(text = 'Valuta to MDL', callback_data = 'BS_Sell')
BS_kb.add(Buy_b,Sell_b)