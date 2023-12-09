import requests
from bs4 import BeautifulSoup
import re

with open("input.txt", "r") as f:
    lines = [line.strip() for line in f]
print(lines[61])

def string_to_digit(string):
    switcher = {
        "one": "1",
        "two": "2",
        "three": "3",
        "four": "4",
        "five": "5",
        "six": "6",
        "seven": "7",
        "eight": "8",
        "nine": "9"
    }
    return switcher.get(string)

def digiter(string):
    x = re.findall("one|two|three|four|five|six|seven|eight|nine", string)
    for i in range(len(x)):
        string = string.replace(x[i], string_to_digit(x[i]))
    return string

def count_num(text):
    arr = []
    for line in text:
        string = ""
        line = digiter(line)
        length = len(line)
        for i in range(length):
            if line[i].isdigit():
                string += line[i]
        arr.append(string)
    return arr

print(count_num(f))

def count_nums(text):
    arr = []
    for line in text:
        string = ""
        length = len(line)
        for i in range(length):
            if line[i].isdigit():
               string += line[i]
            for index, value in enumerate(['zero', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine']):
                if line[i:].startswith(value):
                    string += str(index)
        arr.append(string)
    return arr
    
arrone = count_nums(f)
arrtwo = count_num(f)