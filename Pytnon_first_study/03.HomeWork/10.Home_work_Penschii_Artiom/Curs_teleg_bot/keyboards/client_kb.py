from aiogram.types import ReplyKeyboardMarkup,KeyboardButton#,ReplyKeyboardRemove

# b1 = KeyboardButton('/start')
but_info = KeyboardButton('/info')
but_joke = KeyboardButton('/joke')
but_curs_BNM = KeyboardButton('/BNM')
but_curs_OTP = KeyboardButton('/curs')
but_convert = KeyboardButton('/Конвертор')

# resize_keyboard - подгоняет кнопки по размеру
# one_time_keyboard - после нажатия - скрывает клавиатуру
kb_client = ReplyKeyboardMarkup(resize_keyboard=True , one_time_keyboard=True)

# add - добавляет кнопку вниз
# insert - добавляет кнопку с права
# row(b1,b2,b3) - делает ряд
kb_client.row(but_info,but_joke).row(but_curs_BNM,but_curs_OTP,but_convert)