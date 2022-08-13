from cgitb import reset
from email.policy import default
from telegram import Update, Bot
from telegram.ext import Updater, CommandHandler, Filters, MessageHandler
from config import TOKEN
from test_api import curs_md
import locale
import babel.numbers


bot = Bot(token=TOKEN)
updater = Updater(token=TOKEN)
dispatcher = updater.dispatcher



def start(update, context):
    arg = context.args
    if not arg:
        context.bot.send_message(update.effective_chat.id, "Привет")
    else:
        context.bot.send_message(update.effective_chat.id, f"{' '.join(arg)}")


def info(update, context):
    context.bot.send_message(update.effective_chat.id, "I'm Batman")

def curs(update, context):
    usd,euro,rub,uah,ron = curs_md()
    context.bot.send_message(update.effective_chat.id, f"USD : {usd}\nEUR : {euro}\nRUB : {rub}\nUAH: {uah}\nRON: {ron}\n")

# def cont(update, context):
#     number_1 = update.message.text
    
#         context.bot.send_message(update.effective_chat.id, f"try to write something like 1+2(3*4)**6")

# # def count(update, context):
# #     arg = context.args
# #     context.bot.send_message(update.effective_chat.id, f"{arg} = {eval(eval(arg))}")

def message(update, context):
    text = update.message.text
    try : 
        eval(text)
        context.bot.send_message(update.effective_chat.id, f"{text} = {eval(text)}")
    except:
        if text.lower() == 'привет':
            context.bot.send_message(update.effective_chat.id, 'И тебе привет..')
        elif "MDL = " in text:
            ammount = float(text.split()[-1])
            usd,euro,rub,uah,ron = curs_md()
            print_usd = babel.numbers.format_currency(ammount/usd, "USD", locale='fr_FR')
            print_eur = babel.numbers.format_currency(ammount/euro, "EUR", locale='fr_FR')
            print_rub = babel.numbers.format_currency(ammount/rub, "RUB", locale='fr_FR')
            print_uah = babel.numbers.format_currency(ammount/uah, "UAH", locale='fr_FR')
            print_ron = babel.numbers.format_currency(ammount/ron, "RON", locale='fr_FR')
            context.bot.send_message(update.effective_chat.id, f"USD : {print_usd}\nEUR : {print_eur}\nRUB : {print_rub}\nUAH: {print_uah}\nRON: {print_ron}\n")
        else:
            context.bot.send_message(update.effective_chat.id, 'я тебя не понимаю')

# print(locale.currency(12345.67, grouping=True)
# babel.numbers.format_currency(number_string, "USD", locale='en_US')

def unknown(update, context):
    context.bot.send_message(update.effective_chat.id, f'Шо сказал, не пойму')


start_handler = CommandHandler('start', start)#/start фразочка
info_handler = CommandHandler('info', info)#/info
curs_handler = CommandHandler('curs', curs)#/info
# count_handler = CommandHandler('count', count)#/info
message_handler = MessageHandler(Filters.text, message)
unknown_handler = MessageHandler(Filters.command, unknown) #/game
# count_handler = MessageHandler(Filters.text, cont)#/info

dispatcher.add_handler(start_handler)
dispatcher.add_handler(info_handler)
dispatcher.add_handler(curs_handler)
# dispatcher.add_handler(count_handler)
dispatcher.add_handler(unknown_handler)
dispatcher.add_handler(message_handler)

print('server started')
updater.start_polling()
updater.idle()