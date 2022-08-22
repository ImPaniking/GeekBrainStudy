from aiogram.types import InlineKeyboardButton,InlineKeyboardMarkup
from curs_md import curs_BNM,curs_curs

curskb = InlineKeyboardMarkup(row_width=3)
button_dict = curs_BNM()
new_list = []
for key,value in button_dict.items():
    new_list.append(InlineKeyboardButton(text = f"{key}:{value:.2f}lei" , callback_data = f"BNM_curs={key}:{value}"))
curskb.add(*new_list)

curs_curskb = InlineKeyboardMarkup(row_width=1)
button_dict = curs_curs()
new_list = []
for key,value in button_dict.items():
    new_list.append(InlineKeyboardButton(text = f"{key} : {value:.2f} MDL" , callback_data = f"BNM_curs={key}:{value}"))
curs_curskb.add(*new_list)