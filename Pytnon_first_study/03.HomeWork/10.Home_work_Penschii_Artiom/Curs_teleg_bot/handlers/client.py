from aiogram import types , Dispatcher
from bot_create import dp,bot
from keyboards.client_kb import kb_client


# @dp.message_handler(commands=["start","help","старт"])
async def command_start(message : types.Message):
        await bot.send_message(message.from_user.id , "Здрастуй пользователь!\n я ImPanikig и я кое что могу:" , reply_markup=kb_client) # вызывает клавиатуру
        await message.delete()
# @dp.message_handler(commands=['info'])
async def info_command(message : types.Message):
    await message.answer("Тут могла быть ваша реклама...\n\n"+
                        'Ну а если серьёзно , я кое что умею ...\n'+
                        '/info - ты сейчас тут\n'+
                        '/joke - шутка =) но на Английском, лень парсить русские сайты =)\n'+
                        '/BNM - весе валюты представленные в Национальном Банке Молдовы\n'+
                        '/cyrs - только общепринятые валюты\n'+
                        '/Конвертор - я точно ошибся в этом слове но это как калькулятор валют\n'+
                        'З.Ы. если что, я пока без логов и прочей ереси =)\n'+
                        '/start - начать всё заново\n'+
                        'P.S.S тут мог быть HTML - но я хочу быстрее закончить')


def register_hendlers_clietn(dp : Dispatcher):
    dp.register_message_handler(command_start , commands=["start","help","старт"])
    dp.register_message_handler(info_command , commands=["info","инфо","помоги"])


