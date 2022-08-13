import pandas as pd
import datetime as dt
import wget

tables = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb")

for index,element in enumerate(tables):
    if index == 0:
        df = pd.DataFrame(element)
        print(df)
        print(dict(df["Abr"]))
        print(df["Cursul"][16])
        print(list(df["Abr"]).index('USD'))




# calls_df, = pd.read_html("https://www.bnm.md/ro/content/ratele-de-schimb", header=0, parse_dates=["Valuta"])

# print(calls_df)
# date_to_dat = dt.datetime.now().strftime("%d.%m.%Y")
# path = "https://www.bnm.md/ro/export-official-exchange-rates?date=" + date_to_dat
# wget.download(path, "test_form_bank.csv")
# tables = pd.read_html(path)

# print(tables)

# "https://www.bnm.md/ro/export-official-exchange-rates?date=08.08.2022"