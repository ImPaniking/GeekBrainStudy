from curs_md import curs_OTP_row
from curs_md import abr_names
from bot_create import dp,bot
from aiogram import types , Dispatcher
from aiogram.dispatcher.filters import Text
from keyboards.curs_kb import curskb,curs_curskb
import datetime

# @dp.message_handler(commands=['BNM','НБМ'])
async def curs_command(message : types.Message):
    date = datetime.datetime.now().strftime("%m/%d/%Y")
    await message.answer(f"Курс на сегодня {date} : " , reply_markup=curskb)

# @dp.message_handler(commands=['crus','курс'])    
async def curs_curs_command(message : types.Message):
    date = datetime.datetime.now().strftime("%m/%d/%Y")
    await message.answer(f"Курс на сегодня {date} : " , reply_markup=curs_curskb)

@dp.callback_query_handler(Text(startswith='BNM_curs='))
async def curs_count(callback : types.CallbackQuery):
    try:
        text = curs_OTP_row(callback.data[9:12])
        await callback.answer(f"{callback.data[9:12]} -> MDL\nOTP Sell : {text[1]:.2f}lei\nOTP Buy : {text[2]:.2f}lei\nOTP Sell by card : {text[3]:.2f}lei\nOTP Buy by card : {text[4]:.2f}lei", show_alert=True)
    except:
        await callback.answer(f"OTP не обслуживает {callback.data[9:12]}/{abr_names()[callback.data[9:12]]}", show_alert=True)

def register_hendlers_curs(dp : Dispatcher):
    dp.register_message_handler(curs_command , commands=['BNM','НБМ'])
    dp.register_message_handler(curs_curs_command , commands=['curs','курс'])


