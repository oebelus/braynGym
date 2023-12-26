f = open("input.txt", "r")
demo = open("demo.txt", "r")

def count_num(text):
    ans = 0
    for line in text:
        digits = []
        length = len(line)
        for i in range(length):
            if line[i].isdigit():
                digits.append(line[i])
            for index, value in enumerate(['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine']):
                if line[i:].startswith(value):
                    digits.append(str(index))
        if digits: 
            score = int(digits[0] + digits[-1])
            ans += score
    print(ans)

count_num(f)
