
def input_number_examination(text_in_input = "Enter number :" , case_def = 0, min_num = 0,max_num=10,bool_is_not_decimal = True):
    """Testing if input is a number

    Args:
        text_in_input (str, optional): Text for input. Defaults to "Enter number :".  \n
        case_def (int, optional):   # 0 : "Is it a number",
                                    # 1 : "Enter integer number ",
                                    # 2 : "Enter number > 0",
                                    # 3 : "Enter number between X > number < Y"
                                    Defaults to 0.\n
        min_num (int, optional): If needed test >= . Defaults to 0.\n
        max_num (int, optional): If needed test <=. Defaults to 10.\n
        bool_is_not_decimal (bool, optional): For between min and max shood it be decimal or not  \n
                                            True - number should not be decimal  \n
                                            False - number could be decimal. Defaults to True.\n

    Returns:
        int,float: output could be int or float
    """

    bool_is_number = True

    while bool_is_number:

        bool_si_minus = False
        bool_is_decimal = False

        number = input(f"{text_in_input}")

        if number[0] == "-":
            bool_si_minus = True
            number = number.replace("-","")

        for i in number:
            if i == ".":
                bool_is_decimal = True
                break
        
        if bool_is_decimal:
                whole_part = ""
                digit_part = ""
                for i in number:
                    if i != ".":
                        whole_part += str(i)
                    else:
                        break
                if whole_part.isdigit():
                    for i in number[len(whole_part)+1:]:
                        digit_part += str(i)
                    if digit_part.isdigit():
                        number = whole_part + "." + digit_part
                    number = float(number)
                    bool_is_number = False
        else:
            if number.isdigit():
                number = int(number)
                bool_is_number = False

        if bool_is_number:
            print("Not a number , try again")
            continue

        if bool_si_minus:
            number *= -1
        
        bool_is_number = input_number_params(number,case_def, min_num,max_num,bool_is_not_decimal)

    return number

def input_number_params(number , case_def, min_num ,max_num,bool_is_not_decimal):
    """Chak variants of input input_number_examination

    Args:
        number (_type_): number to chek
        case_def (_type_):  # 0 : "Is it a number",
                            # 1 : "Enter integer number ",
                            # 2 : "Enter number > 0",
                            # 3 : "Enter number between X > number < Y",
        min_num (_type_): number >=
        max_num (_type_): number <=
        bool_is_not_decimal (_type_):   True - dont allow decimals
                                        False - allow decimals
    """

            # 0 : "Is it a number",
            # 1 : "Enter integer number ",
            # 2 : "Enter number > 0",
            # 3 : "Enter number between X > number < Y",

    float_bool = True

    if case_def < 0 or case_def > 4:
        print("Wrong argument for test. Need from 0 to 3")
        return True

    match case_def:
        case 0:
            try:
                float(number)
                return False
            except ValueError:
                return True
        case 1:
            for i in str(number):
                    if i == ".":
                        print("Not an integer")
                        float_bool = False
            if float_bool:
                    return False
            else:
                    return True
        case 2:
            if number >= 0:
                return False
            else:
                print("Not >= 0")
                return True
        case 3:
            if bool_is_not_decimal:
                for i in str(number):
                    if i == ".":
                        print("Not an integer")
                        float_bool = False
                if float_bool:
                    if min_num > max_num:
                        min_num,max_num = max_num,min_num
                    if number >= min_num and number <= max_num:
                        return False
                    else:
                        print(f"not >={min_num} or =<{max_num} ")
                        return True
                else:
                    print("Enter not decimal")
                    return True
            else:
                if min_num > max_num:
                    min_num,max_num = max_num,min_num
                if number >= min_num and number <= max_num:
                    return False
                else:
                    print(f"not >={min_num} or =<{max_num} ")
                    return True
