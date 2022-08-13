from pydoc import plain
from dict import sit_place_dic_creation as SPDC
# from create_row import look_up_name as LUN
# from create_row import take_from_base as TFB
from create_row import rewrite_base as RW

places = {}
places = SPDC()

def sit_place_dic_creation():
    sit_place = {}
    colum = {}
    place = {}
    for i in range (1,6):
        for y in range ( 1,4):
            for n in range(1,3):
                place[n] = "-"
            colum[y] = place
        sit_place[i] = colum
    return sit_place


def test(dic : dict):
    places_dict = {}
    sit_place = {}
    colum = {}
    place = {}
    for c,d in dic.items():
        for i,j in d.items():
            for y,x in j.items():
                for n in x.keys():
                    print(n,y,i,c)
                    if n == 1 and y == 2 and i == 4 and c == 101:
                        place[n] = 0
                    else:
                        place[n] = '-'
                colum[y] = place
            sit_place[i] = colum
        places_dict[c] = sit_place
    return places_dict


RW(test(places),"Class.json")

