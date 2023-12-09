import requests
from bs4 import BeautifulSoup

session = requests.Session()
session.cookies['session'] = "53616c7465645f5f76ee6eb05724824f1171cfc6e3dbdd563af2228f1b0c405380ec3c14e79b53cf6adf6f98cc6d73b2b5b2dfef91de60ad19704f872fdcb24a"
website = session.get("https://adventofcode.com/2023/day/1/input")
output = BeautifulSoup(website.text, "html.parser")

words = output.text.split()

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

print(count_num(words))
