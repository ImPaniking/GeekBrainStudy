import pandas as pd
import datetime as dt
import csv
import wget
import babel
# from google_currency import convert



def curs_md():
    tables = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")

    result_1 = pd.concat([tables[0],tables[1]], ignore_index=True, sort=False)
    usd = result_1["Cursul"][list(result_1["Abr"]).index('USD')]
    euro = result_1["Cursul"][list(result_1["Abr"]).index('EUR')]
    rub = result_1["Cursul"][list(result_1["Abr"]).index('RUB')]
    uah = result_1["Cursul"][list(result_1["Abr"]).index('UAH')]
    ron = result_1["Cursul"][list(result_1["Abr"]).index('RON')]
    return usd,euro,rub,uah,ron

tables = pd.read_html("https://www.mobiasbanca.md/ru/exchange")
# tables[0] = pd.DataFrame(columns = ["Abr","Buy_B" ,"Sell_B"], data=tables[0] )
# print(tables[0])
# tables[1] = pd.DataFrame(columns = ["Abr","Buy_C" ,"Sell_C"], data=tables[1] )
# print(tables[1])
result = pd.concat([tables[0],tables[1][1],tables[1][2]], axis=1, join="inner")
# result = pd.concat([tables[0],tables[1]], ignore_index=True, sort=False)
print(result)
# df.rename(columns = {'Name' : 'First Name', 'age' : 'Age'}, inplace = True) 


# avail_loc = babel.localedata.locale_identifiers()
# print(avail_loc)
# tables = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")

# result_1 = pd.concat([tables[0],tables[1]], ignore_index=True, sort=False)
# print(list(result_1["Cursul"][result_1["Abr"] == 'USD'])[0])
    

# df_full = pd.DataFrame()
# for index,element in enumerate(tables):
#     # df_full.append(element)
#     # print(df_full)
#     if index == 0:
#         df = pd.DataFrame(element)
#         usd = df["Cursul"][list(df["Abr"]).index('USD')]
#         print(usd)
        # euro = df["Cursul"][list(df["Abr"]).index('EUR')]
        # rub = df["Cursul"][list(df["Abr"]).index('RUB')]
        # uah = df["Cursul"][list(df["Abr"]).index('UAH')]
        # ron = df["Cursul"][list(df["Abr"]).index('RON')]
# result_2 = pd.concat([tables[2],tables[3]], ignore_index=True, sort=False)
# esult = pd.concat([result_1, result_2['Cursul']], axis=1, join="inner")
# print(esult)

# print(tables)
# print(usd,euro,rub,uah,ron)

# print(convert("USD" , "MDL" , 1))
# data_frame_full = pd.DataFrame(columns = ["Валюта","Код","Абр","Рейт","Курс"])
# for index,element in enumerate(tables):
#         # df = pd.DataFrame(element)
#         for i,e in enumerate(element):
#             print(i,e)
#             data_frame_full.append(e)

# print(data_frame_full)


# calls_df, = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb", header=0, parse_dates=["Valuta"])

# print(calls_df)
# date_to_dat = dt.datetime.now().strftime("%d.%m.%Y")
# path = "https://www.bnm.md/ro/export-official-exchange-rates?date=" + date_to_dat
# wget.download(path, "test_form_bank.csv")
# tables = pd.read_html(path)

# print(tables)

# "https://www.bnm.md/ro/export-official-exchange-rates?date=08.08.2022"
# "https://www.mobiasbanca.md/ru/exchange"