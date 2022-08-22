import pandas as pd

def curs_md():
    tables = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")

    result_1 = pd.concat([tables[0],tables[1]], ignore_index=True, sort=False)
    usd = result_1["Cursul"][list(result_1["Abr"]).index('USD')]
    euro = result_1["Cursul"][list(result_1["Abr"]).index('EUR')]
    rub = result_1["Cursul"][list(result_1["Abr"]).index('RUB')]
    uah = result_1["Cursul"][list(result_1["Abr"]).index('UAH')]
    ron = result_1["Cursul"][list(result_1["Abr"]).index('RON')]
    gbp = result_1["Cursul"][list(result_1["Abr"]).index('GBP')]
    return usd,euro,rub,uah,ron,gbp

def curs_OTP():
    tables = pd.read_html("https://www.mobiasbanca.md/ru/exchange")
    df_1 = pd.DataFrame(tables[0]).rename(columns = {0 : 'Abr', 1 : 'Buy', 2 : 'Sell'}, inplace = True)
    df_2 = pd.DataFrame(tables[1]).rename(columns = {0 : 'Abr', 1 : 'Buy_card', 2 : 'Sell_card'}, inplace = True)
    return tables[0].join(tables[1]['Buy_card']).join(tables[1]['Sell_card'])
def curs_OTP_Arb():
    tables = pd.read_html("https://www.mobiasbanca.md/ru/exchange")
    pd.DataFrame(tables[0]).rename(columns = {0 : 'Abr', 1 : 'Buy', 2 : 'Sell'}, inplace = True)
    pd.DataFrame(tables[1]).rename(columns = {0 : 'Abr', 1 : 'Buy_card', 2 : 'Sell_card'}, inplace = True)
    res = tables[0].join(tables[1]['Buy_card']).join(tables[1]['Sell_card'])
    return dict(zip(res['Abr'],tuple(zip(res['Buy'],res['Buy_card']))))

def curs_OTP_row(index):
    tables = pd.read_html("https://www.mobiasbanca.md/ru/exchange")
    df_1 = pd.DataFrame(tables[0]).rename(columns = {0 : 'Abr', 1 : 'Buy', 2 : 'Sell'}, inplace = True)
    df_2 = pd.DataFrame(tables[1]).rename(columns = {0 : 'Abr', 1 : 'Buy_card', 2 : 'Sell_card'}, inplace = True)
    result = tables[0].join(tables[1]['Buy_card']).join(tables[1]['Sell_card'])
    return result.loc[list(result["Abr"]).index(index)]    
    
def curs_BNM():
    df = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")
    df = pd.concat([df[0],df[1]], ignore_index=True, sort=False)
    df['Curs'] = df['Cursul'] / df['Rata']
    return dict(zip(df['Abr'],df['Curs']))

def curs_curs():
    df = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")
    df = pd.concat([df[0],df[1]], ignore_index=True, sort=False)
    df['Curs'] = df['Cursul'] / df['Rata']
    df = df[(df['Abr'] == 'EUR') | (df['Abr'] == 'USD') | (df['Abr'] == 'UAH') |\
        (df['Abr'] == 'RUB') | (df['Abr'] == 'RON') | (df['Abr'] == 'GBP') ]
    return dict(zip(df['Abr'],df['Curs']))

def abr_names():
    df = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")
    df = pd.concat([df[0],df[1]], ignore_index=True, sort=False)
    return dict(zip(df['Abr'],df['Valuta']))

def curs_pointmd():
    tables = pd.read_html("https://point.md/ru/curs/")
    df_bank = tables[0]['MDL'].rename(columns = {'Unnamed: 0_level_1' : 'Bank'})
    list_bank = []
    for i in tables[0]:
        df = None
        if i[0] != "MDL":
            if i[1] != 'покуп.':
                df = tables[0][i[0]].rename(columns = {'покуп.' : 'Buy' ,'прод.' : 'Sell'  })
                df['Abr'] = i[0]
                df['Type'] = 'Valuta'
                df = df.reindex(columns = ['Type','Abr','Buy','Sell'])
                df = df_bank.join(df)
                df.loc[df['Bank'] == 'Banca Nationala a Moldovei' ,'Type'] = 'NatBank'
                df = df.reindex(columns = ['Bank','Type','Abr','Buy','Sell'])
        list_bank.append(df)
    df = pd.concat(list_bank, ignore_index=True, sort=False)
    df.loc[df['Buy'] == '—' ,('Buy','Sell') ] = 0
    return df

def curs_Mobias():
    tables = pd.read_html("https://www.mobiasbanca.md/ru/exchange")
    for i,y in enumerate(tables):
        if i != 2:
            y.rename(columns = {0 : 'Abr', 1 : 'Buy', 2 : 'Sell'}, inplace = True)
            if i ==0:
                y['Type'] = 'Valuta'
            else:
                y['Type'] = 'Card'
            y['Bank'] = 'OTP Mobiasbanca'
    df = pd.concat([tables[0],tables[1]], ignore_index=True, sort=False).reindex(columns = ['Bank','Type','Abr','Buy','Sell'])
    return df

def curs_Nat_Bank():
    df = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")
    df = pd.concat([df[0],df[1]], ignore_index=True, sort=False)
    df['Curs'] = df['Cursul'] / df['Rata']
    df = df[(df['Abr'] != 'EUR') | (df['Abr'] != 'USD') | (df['Abr'] != 'UAH') |\
            (df['Abr'] != 'RUB') | (df['Abr'] != 'RON') | (df['Abr'] != 'GBP') ]
    df['Bank'] = 'Banca Nationala a Moldovei'
    df['Type'] = 'NatBank'
    df['Buy'] = df['Curs']
    df['Sell'] = df['Curs']
    df = df.drop(columns = ['Valuta', 'Cod','Rata','Cursul','Curs'], axis = 1) 
    df = df.reindex(columns = ['Bank','Type','Abr','Buy','Sell'])
    return df

def cursr_MAIB():
    tables = pd.read_html("https://www.maib.md/ru/curs-valutar")
    list_bank=[]
    for i,y in enumerate(tables):
        df = None
        df = y.rename(columns = {'Покупка' : 'Buy' ,'Продажа' : 'Sell','Валюта' : 'Abr'})
        match i:
            case 0:
                df['Type'] = 'Valuta'
            case 1:
                df['Type'] = 'Bancomat'
            case 2:
                df['Type'] = 'Bancomat/Customs'
            case 3:
                df['Type'] = 'Card'
            case 4:
                df['Type'] = 'Customs'
            case _:
                df['Type'] = 'Error'
        df['Bank'] = 'MAIB Moldova Agroindbank'
        df = df.reindex(columns = ['Bank','Type','Abr','Buy','Sell'])
        list_bank.append(df)
    df = pd.concat(list_bank, ignore_index=True, sort=False)
    return df

def curs_Moldova():
    return pd.concat([curs_pointmd(),curs_Mobias(),curs_Nat_Bank(),cursr_MAIB()], ignore_index=True, sort=False)

def test_list_print():
    curs_moldova = curs_Moldova()
    return list(pd.unique(curs_moldova['Abr'][curs_moldova['Bank'] != 'Banca Nationala a Moldovei']))

def bank_list():
    curs_moldova = curs_Moldova()
    return list(pd.unique(curs_moldova['Bank']))

def abr_list(bank : str):
    curs_moldova = curs_Moldova()
    return list(pd.unique(curs_moldova['Abr'][curs_moldova['Bank'] == f'{bank}']))

def type_list(bank : str,abr : str):
    curs_moldova = curs_Moldova()
    return list(pd.unique(curs_moldova['Type'][(curs_moldova['Bank'] == f'{bank}') & (curs_moldova['Abr'] == abr)& (curs_moldova['Buy'] != 0)]))


# def print_test():
#     curs_moldova = curs_Moldova()
#     df_buy = curs_moldova.drop(columns = 'Sell' , axis = 1)[curs_moldova['Bank'] != 'Banca Nationala a Moldovei']
#     import numpy as np
#     table = pd.pivot_table(df_buy, values='Buy', index=['Bank', 'Type'],
#                     columns=['Abr'], aggfunc=np.sum, fill_value=0)
#     text = None
#     return text




# "https://www.bnm.md/ro/export-official-exchange-rates?date=08.08.2022"
# "https://www.bnm.md/ro/content/ratele-de-schimb"
# "https://www.mobiasbanca.md/ru/exchange"
# "https://point.md/ru/curs/"
# "https://www.maib.md/ru/curs-valutar"
