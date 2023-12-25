f = open("input.txt", "r")

def count_num(array):
    global_sum = 0
    for name in array:
        sum = ""
        f_found = False
        l_found = False
        for i in range(len(name)):
            if name[i].isdigit() and not f_found:
                sum = sum + name[i]
                f_found=True
        for i in range(len(name)):
            if name[-1-i].isdigit() and not l_found:
                sum = sum + name[-1-i]
                l_found=True
        global_sum += int(sum)
    return global_sum

print(count_num(f))
