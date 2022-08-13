from cgitb import reset
from email.policy import default
from fileinput import close
from telegram import Update, Bot
from telegram.ext import Updater, CommandHandler, Filters, MessageHandler
from config import TOKEN
import random

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

ammount = 100
max_candy = 28
player = [1,2]

def game_start(update, context):
    global ammount
    global player
    global max_candy
    ammount = 100
    player = random.choice([[1,2],[2,1]])

def message(update, context):
    global ammount
    global player
    text = update.message.text
    if text.lower() == 'привет':
        context.bot.send_message(update.effective_chat.id, 'И тебе привет..')
    elif text.lower().isdigit():
        text = int(text)
        if text > max_candy and text <= 0 and ammount > 0:
            context.bot.send_message(update.effective_chat.id, "Если вы пытались забрать конфет, то выбрали не то количество ")
        elif text <= max_candy and text > 0 and ammount > 0:
            ammount -= int(text)
            if ammount <= 0 :
                context.bot.send_message(update.effective_chat.id, f'Игрок {player[0]} выйграл')
            if ammount > 0:
                context.bot.send_message(update.effective_chat.id, f'Походил игрок {player[0]} и взял {text} конфет , на столе осталось {ammount}')
            player[0],player[1] = player[1],player[0]
        elif ammount <= 0:
            context.bot.send_message(update.effective_chat.id, "Нет конфет на столе, напишите /game что бы добавить конфет на стол =) ")
    else:
        context.bot.send_message(update.effective_chat.id, 'я тебя не понимаю')

def unknown(update, context):
    context.bot.send_message(update.effective_chat.id, f'Шо сказал, не пойму')

start_handler = CommandHandler('start', start)#/start фразочка
info_handler = CommandHandler('info', info)
game_handler = CommandHandler('game', game_start)#/info
message_handler = MessageHandler(Filters.text, message)
unknown_handler = MessageHandler(Filters.command, unknown) #/game

dispatcher.add_handler(start_handler)
dispatcher.add_handler(info_handler)
dispatcher.add_handler(game_handler)
dispatcher.add_handler(unknown_handler)
dispatcher.add_handler(message_handler)

print('server started')
updater.start_polling()
updater.idle()