from aiogram import Bot , types
from aiogram.dispatcher import Dispatcher 
from aiogram.contrib.fsm_storage.memory import MemoryStorage

import os

storage = MemoryStorage()

bot = Bot(token = os.getenv('TOKEN'),parse_mode=types.ParseMode.HTML) # Создание бота и присвоение ему токена. В данном случае - используется bat файл для передачи Токена
dp = Dispatcher(bot , storage=storage)