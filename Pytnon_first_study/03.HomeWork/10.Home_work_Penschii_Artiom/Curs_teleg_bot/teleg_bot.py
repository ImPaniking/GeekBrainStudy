from aiogram.utils import executor
from bot_create import dp

# from data_base import sqlite_db

async def on_startup(__):
    print("Бот на связи")
    global bank,abr,type1,Buy_Sell
    bank = None
    abr = None
    type1 = None
    Buy_Sell = None

from handlers import client,other,curs,convert

client.register_hendlers_clietn(dp)
curs.register_hendlers_curs(dp)
convert.register_hendlers_convert(dp)
other.register_hendlers_other(dp)


executor.start_polling(dp , skip_updates=True, on_startup=on_startup) # Исполнитель - конструкция которая запускает самого бота